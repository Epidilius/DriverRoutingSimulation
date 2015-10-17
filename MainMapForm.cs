using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET;

namespace DriverRoutingSimulation
{
    public partial class MainMapForm : Form
    {
        //Thread Stuff
        //My thread alive bools
        private bool mIsDriverThreadAlive = false;
        private bool mIsMapThreadAlive = false;
        private bool mIsStatsThreadAlive = false;
        //My Threads
        private Thread mDriverThread = null;
        private Thread mMapThread = null;
        private Thread mStatsThread = null;
        //Delegates
        private delegate void mUpdateDriversDel();
        private delegate void mUpdateMapDel(GMapRoute aRoute);
        private delegate void mUpdateStatsDel(string stat, TextBox textBox);
        //Locking Object
        private Object __LockObject = new Object();

        //DICTIONARY IDENTIFIERS
        private const string COMMAND_ID = "COM_";
        private const string DATA_ID = "DAT_";

        //Commands
        private static string mCommandAddDriver = "ADD";
        private static string mCommandRemoveDriver = "REMOVE";
        private static string mCommandDoNothing = "NOTHING";
        private static string mCommandAddItemPickupPoint = "ITEM PICKUP";
        private static string mCommandAddItemDropOffPoint = "ITEM DROP OFF";
        private static string mCommandNoOrder = "NO ORDER";
        
        //Overlays
        GMapOverlay mDriverMarkers;
        GMapOverlay mDeliveryMarkers;
        GMapOverlay mRoutes;
        GMapOverlay mAllRoutes;
        //List of drivers
        List<Driver> mDrivers;
        short mActiveDrivers;

        //List of items
        List<Order> mItems;
        List<Order> mDealtWithItems;

        Random mRandom;

        //Items to add orders
        Order mTempOrder;
        string mNoOrderString = "NO ORDER";
        int mColourToPick;

        string mWhatToDoOnClick;

        float mSimSpeed;
        float mDriverFee;
        float mDeliveryFee;
        float mDollarPerKM;
        float mAverageKMPerHour;
        float mMaximumKMPerHour;
        float mMaxPickupDistance;
        int mDriverMinReliability;
        int mDriverMaxReliability;

        //Lists of stat numbers to be used later
        //Thread stuff

        //TODO: Make a note that the "efficiency" stats are for the company. That is the dollar amount a company will make in an hour, from a single driver, for just the delivery costs. This does not include the item itself, and should be multiplied by the number of drivers available.
        //TODO: Add a text box to enter an address, and a text box for a drop off address. Use these to create an order.
        //TODO: Save all info to a spreadsheet or series of sheets.
        //TODO: Driver AI.
        //TODO: Give drivers a "reliability" stat. This is a RNG from 50 to 95. 
            //This determines the frequency of accepted pickups. 50 is 50% accepted, 95 is 95% accepted. 
            //This should also throw in some delays, of 5-30 minute lengths. This option can be turned off.
        //TODO: Have the route lines also colour coded to match the driver markers
        //TODO: Be able to turn the routes on and off
        //TODO: Toggle the center of the map cross
        //TODO: Allow the user to cancel placing a delivery
        //TODO: Find a list of Ottawa addresses. Use them for deliveries. Pull an address, use it as origin. Pull a second, make sure it's different, use it as destination.

        //Intersting Things
        //I can get a list of all the points on a route with List<PointLatLng> points = route.Points;
        //gRoute.Distance and route.Distance (in the AddRoute function) return distance in KM
        //I can get a reasonable time by dividing the distance by 40 (to represent an average of 40km per hour)

        public MainMapForm()
        {

            InitializeComponent();

            mDriverMarkers = new GMapOverlay("Drivers");
            mDeliveryMarkers = new GMapOverlay("Deliveries");
            mRoutes = new GMapOverlay("Routes");
            mAllRoutes = new GMapOverlay("All Routes");

            mDrivers = new List<Driver>();
            mActiveDrivers = 0;

            mItems = new List<Order>();
            mDealtWithItems = new List<Order>();

            mRandom = new Random();

            mTempOrder = new Order();
            mTempOrder.OrderName = mNoOrderString;
            mColourToPick = 0;

            mSimSpeed = 1;
            mDriverFee = 3;
            mDeliveryFee = 0;
            mDollarPerKM = 0.3f;
            mAverageKMPerHour = 40;
            mMaximumKMPerHour = 60;
            mMaxPickupDistance = 0;
            mDriverMinReliability = 80;
            mDriverMaxReliability = 95;

            mWhatToDoOnClick = mCommandDoNothing;
            
            LoadMap();

            StartThreads();
        }

        private void LoadMap()
        {
            // Initialize map:
            gMapControl_MainMap_MainMapForm.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl_MainMap_MainMapForm.SetPositionByKeywords("Ottawa, Canada");
            //gMapControl_MainMap_MainMapForm.ShowCenter = false;
        }

        private void AddDriverMarker(PointLatLng aPointToPlaceDriverMarker, Color aMarkerColour)
        {
            Driver driver = new Driver();
            Order order = new Order();

            order.OrderName = mCommandNoOrder;
            driver.OrderWorkingOn = order;

            driver.DriverReliability = mRandom.Next(mDriverMinReliability, mDriverMaxReliability);

            driver.Marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(aPointToPlaceDriverMarker, GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_dot);
            mDrivers.Add(driver);
            gMapControl_MainMap_MainMapForm.Overlays.Add(mDriverMarkers);
            mDriverMarkers.Markers.Add(driver.Marker);
        }

        private void AddDeliveryMarker(PointLatLng aPointToPlaceDriverMarker, Color aMarkerColour, int aOrderNumber)
        {
            GMap.NET.WindowsForms.Markers.GMarkerGoogle marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(aPointToPlaceDriverMarker, GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green);
            marker.ToolTipText = aOrderNumber.ToString();
            gMapControl_MainMap_MainMapForm.Overlays.Add(mDeliveryMarkers);
            mDeliveryMarkers.Markers.Add(marker);
        }
        
        private void AddPolygon()
        {
            GMapOverlay polyOverlay = new GMapOverlay("polygons");

            GMap.NET.PointLatLng centerPos = new GMap.NET.PointLatLng(gMapControl_MainMap_MainMapForm.Position.Lat, gMapControl_MainMap_MainMapForm.Position.Lng);

            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(centerPos.Lat, centerPos.Lng - 1.0f));
            points.Add(new PointLatLng(centerPos.Lat - 1.0f, centerPos.Lng));
            points.Add(new PointLatLng(centerPos.Lat, centerPos.Lng + 1.0f));
            points.Add(new PointLatLng(centerPos.Lat + 1.0f, centerPos.Lng));
            GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 1);
            polyOverlay.Polygons.Add(polygon);
            gMapControl_MainMap_MainMapForm.Overlays.Add(polyOverlay);
        }

        private GMapRoute AddRoute(PointLatLng aOrigin, PointLatLng aDestination)
        {
            MapRoute route = GMap.NET.MapProviders.OpenStreetMapProvider.Instance.GetRoute(aOrigin, aDestination, false, false, 15);

            if (route == null)
            {
                UpdateMap(null);
                return null;
            }

            GMapRoute gRoute = new GMapRoute(route.Points, "Test Route");
            double temp = gRoute.Distance;
            double tempTwo = route.Distance;
            double tempTime = temp / 40;

            UpdateMap(gRoute);

            return gRoute;
        }

        private void textBox_DriverFee_MainMapForm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mDriverFee = float.Parse(textBox_DriverFee_MainMapForm.Text);
            }
            catch
            {

            }
        }

        private void textBox_DeliveryFee_MainMapForm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mDeliveryFee = float.Parse(textBox_DeliveryFee_MainMapForm.Text);
            }
            catch
            {

            }
        }

        private void textBox_MaxTravelDistance_MainMapForm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mMaxPickupDistance = float.Parse(textBox_MaxTravelDistance_MainMapForm.Text);
            }
            catch
            {

            }
        }

        private void textBox_SimulationSpeed_MainMapForm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mSimSpeed = float.Parse(textBox_SimulationSpeed_MainMapForm.Text);
            }
            catch
            {

            }
        }

        private void textBox_PricePerKilometer_MainMapForm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mDollarPerKM = float.Parse(textBox_PricePerKilometer_MainMapForm.Text);
            }
            catch
            {

            }
        }

        private void button_AddDriver_MainMapForm_Click(object sender, EventArgs e)
        {
            mWhatToDoOnClick = mCommandAddDriver;
        }

        private void button_RemoveDriver_MainMapForm_Click(object sender, EventArgs e)
        {
            mWhatToDoOnClick = mCommandRemoveDriver;
        }

        private void button_AddDelivery_MainMapForm_Click(object sender, EventArgs e)
        {
            mWhatToDoOnClick = mCommandAddItemPickupPoint;
        }

        private void button_DoNothing_MainMapForm_Click(object sender, EventArgs e)
        {
            mWhatToDoOnClick = mCommandDoNothing;
        }

        private void gMapControl_MainMap_MainMapForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                double lat = gMapControl_MainMap_MainMapForm.FromLocalToLatLng(e.X, e.Y).Lat;
                double lng = gMapControl_MainMap_MainMapForm.FromLocalToLatLng(e.X, e.Y).Lng;

                List<Placemark> plc = null;
                PointLatLng clickPoint = (gMapControl_MainMap_MainMapForm.FromLocalToLatLng(e.X, e.Y));

                if (mWhatToDoOnClick == mCommandAddDriver)
                {
                    AddDriverMarker(clickPoint, Color.Green);
                    mActiveDrivers++;
                }

                else if(mWhatToDoOnClick == mCommandAddItemPickupPoint)
                {
                    if (mTempOrder.OrderName == mNoOrderString)
                    {
                        mTempOrder = new Order();
                        mTempOrder.OrderName = "ORDER";
                        mTempOrder.PickupPoint = clickPoint;

                        mWhatToDoOnClick = mCommandAddItemDropOffPoint;
                    }
                }

                else if(mWhatToDoOnClick == mCommandAddItemDropOffPoint)
                {
                    mTempOrder.DropoOffPoint = clickPoint;
                    int count = 0;

                    KnownColor[] values = (KnownColor[])Enum.GetValues(typeof(KnownColor));
                    foreach (KnownColor kc in values)
                    {
                        Color realColor = Color.FromKnownColor(kc);

                        if(count == mColourToPick)
                        {
                            mTempOrder.OrderColour = realColor;
                            GMapRoute wasRouteCreated = AddRoute(mTempOrder.PickupPoint, mTempOrder.DropoOffPoint);

                            if (wasRouteCreated == null)
                                break;

                            AddDeliveryMarker(mTempOrder.PickupPoint, realColor, mColourToPick);
                            AddDeliveryMarker(mTempOrder.DropoOffPoint, realColor, mColourToPick);
                            mTempOrder.TimeOrderWasCreated = DateTime.Now;

                            mColourToPick++;
                            mWhatToDoOnClick = mCommandAddItemPickupPoint;
                            mItems.Add(mTempOrder);
                            mTempOrder.OrderName = mNoOrderString;

                            break;
                        }

                        count++;
                    } 
                }

                //Debug Stuff
                /*var st = GMap.NET.MapProviders.GoogleMapProvider.Instance.GetPlacemarks(clickPoint, out plc);
                if (st == GeoCoderStatusCode.G_GEO_SUCCESS && plc != null)
                {
                    foreach (var pl in plc)
                    {
                        if (!string.IsNullOrEmpty(pl.PostalCodeNumber))
                        {
                            textBox_DebugBox_MainMapForm.Text = "Accuracy: " + pl.Accuracy + ", " + pl.Address + ", PostalCodeNumber: " + pl.PostalCodeNumber;
                        }
                    }
                }*/
            }
        }
        
        private void gMapControl_MainMap_MainMapForm_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (mWhatToDoOnClick == mCommandRemoveDriver)
                {
                    int index = -1;

                    for(int i = 0; i < mDriverMarkers.Markers.Count; i++)
                    {
                        if(mDriverMarkers.Markers[i] == item)
                        {
                            index = i;
                            i = mDriverMarkers.Markers.Count;
                        }
                    }

                    if (index == -1)
                        return;

                    //See which of these gets the world coordinates properly. This will be used to determine who gets the item, route planning (made when the item is placed, the driver is assigned right away), and maybe other things
                    Point temp = mDrivers[index].Marker.LocalPosition;
                    PointLatLng tempFour = mDrivers[index].Marker.Position;
                    Point tempTwo = mDriverMarkers.Markers.ElementAt(index).LocalPosition;
                    PointLatLng tempThree = mDriverMarkers.Markers.ElementAt(index).Position;

                    mDriverMarkers.Markers.RemoveAt(index);
                    mDrivers.RemoveAt(index);
                    mActiveDrivers--;
                }
            }
        }

        //THREAD FUNCTIONS
        private void StartThreads()
        {
            //TODO: Add a sleep after each start so they are all offset. Then have the refresh rate in each thread be the same
            //=====START THE THREADS
            //Start The Driver Thread
            if (mIsDriverThreadAlive == false)
            {
                mDriverThread = new Thread(new ThreadStart(DriverThread));
                mIsDriverThreadAlive = true;
                mDriverThread.Start();
            }
            //Start The Map Thread
            if (mIsMapThreadAlive == false)
            {
                mMapThread = new Thread(new ThreadStart(MapThread));
                mIsMapThreadAlive = true;
                mMapThread.Start();
            }
            //Start The Stats Thread
            if (mIsStatsThreadAlive == false)
            {
                mStatsThread = new Thread(new ThreadStart(StatsThread));
                mIsStatsThreadAlive = true;
                mStatsThread.Start();
            }
        }
        private void StopThreads()
        {
            //=====STOP THE THREADS
            //Stop The Driver Thread
            if (mIsDriverThreadAlive == true)
            {
                mDriverThread.Abort();
                mIsDriverThreadAlive = false;
            }
            //Stop The Map Thread
            if (mIsMapThreadAlive == true)
            {
                mMapThread.Abort();
                mIsMapThreadAlive = false;
            }
            //Stop The Stats Thread
            if (mIsStatsThreadAlive == true)
            {
                mStatsThread.Abort();
                mIsStatsThreadAlive = false;
            }
        }
        //Driver Thread
        private void DriverThread()
        {
            Driver tempDriver;

            while (mIsDriverThreadAlive == true)
            {
                //TODO: Driver stuff
                //TODO: For all threads, have a label for each one, saying if it is alive or not
                Thread.Sleep(5000);

                for(int i = 0; i < mDrivers.Count; i++)
                {
                    for(int j = 0; j < mItems.Count; j++)
                    {
                        if(mDrivers[i].Marker.Position.Lat - mItems[j].PickupPoint.Lat <= mMaxPickupDistance ||
                            mDrivers[i].Marker.Position.Lng - mItems[j].PickupPoint.Lng <= mMaxPickupDistance)  //TODO: Absolute value?
                        {
                            int doIPickUp = mRandom.Next(0, 100);
                            if(doIPickUp < mDrivers[i].DriverReliability && mDrivers[i].OrderWorkingOn.OrderName == mCommandNoOrder)
                            {
                                tempDriver = mDrivers[i];
                                tempDriver.MapRoute = AddRoute(mDrivers[i].Marker.Position, mItems[j].PickupPoint);
                                tempDriver.OrderWorkingOn = mItems[j];
                                mDrivers[i] = tempDriver;
                                
                                mDealtWithItems.Add(mItems[j]);
                                mItems.RemoveAt(j);
                            }
                        }
                    }

                    if (mDrivers[i].MapRoute == null)
                        continue;

                    float numOfPoints = mDrivers[i].MapRoute.Points.Count;
                    double distanceToTravelPerTick = mDrivers[i].MapRoute.Distance / mAverageKMPerHour;
                    //float pointsToMove = ((numOfPoints / 60.0f) / 60.0f) * mSimSpeed;

                    int tempasf = -1;

                    //distance / 40 / 60 (or * 60?) should get me the distance it needs to move every second. Multiply that by the rest time to get distance per tick

                    //Increment which point the driver is at based on the 40km/h average multiplied by mSimSpeed.
                    //Use the average speed to determine how long the trip will take. Then, move the marker an appropriate amount
                    //mDrivers[i].TripTime = mDrivers[i].MapRoute.Distance / mAverageKMPerHour;
                    //mDrivers[i].MapRoute.Points
                    //Move the marker with this:
                    //mDrivers[i].Marker.Position = newLatLngPos;
                    //TODO: When a driver drops off the order, change the order name to mCommandNoOrder
                }
            }
        }
        //Map Thread
        private void MapThread()
        {
            //while (mIsMapThreadAlive == true)
            {
                //TODO: Map stuff
                //Thread.Sleep(1000);
            }
        }
        //Stats Thread
        private void StatsThread()
        {
            while (mIsStatsThreadAlive == true)
            {
                //TODO: Stats stuff
                Thread.Sleep(5000);

                //Efficiency Stats
                float maxEfficiency = mDollarPerKM * mMaximumKMPerHour;
                string maxEfficiencyString = maxEfficiency.ToString("0.00");
                UpdateStats(maxEfficiencyString, textBox_MaximumEfficiency_MainMapForm);

                float averageEfficiency = mDollarPerKM * mAverageKMPerHour;
                string averageEfficiencyString = averageEfficiency.ToString("0.00");
                UpdateStats(averageEfficiencyString, textBox_AverageEfficiency_MainMapForm);

                double totalDistance = 0;
                double extraTime = 0;

                for(int i = 0; i < mAllRoutes.Routes.Count; i++)
                {
                    totalDistance += mAllRoutes.Routes[i].Distance;
                    //extraTime += (mItems[i].TimeOrderWasPickedUp - mItems[i].TimeOrderWasCreated).TotalSeconds / 60.0f;
                }

                if (totalDistance == 0)
                    continue;
                
                //Time Stats
                double averageTime = (((totalDistance / mAverageKMPerHour) * 60) + extraTime) / mAllRoutes.Routes.Count;
                string averageTimeString = averageTime.ToString("0.00");
                UpdateStats(averageTimeString, textBox_AverageDeliveryTime_MainMapForm);

                //Distance Stats
                double averageDistance = (totalDistance / mAllRoutes.Routes.Count);
                string averageDistanceString = averageDistance.ToString("0.00");
                UpdateStats(averageDistanceString, textBox_AverageTravelDistance_MainMapForm);

                //Cost Stats
                double averageCost = ((totalDistance * mDollarPerKM) + (mDriverFee * mAllRoutes.Routes.Count)) / mAllRoutes.Routes.Count;
                string averageCostString = averageCost.ToString("0.00");
                UpdateStats(averageCostString, textBox_AverageCostPerDelivery_MainMapForm);

                double totalProfitMadeByDrivers = mDriverFee * mAllRoutes.Routes.Count;
                string totalProfitMadeByDriversString = totalProfitMadeByDrivers.ToString("0.00");
                UpdateStats(totalProfitMadeByDriversString, textBox_TotalDriverProfit_MainMapForm);

                double totalProfitMadeByCompanies = (mDollarPerKM * totalDistance) + (mDeliveryFee * mAllRoutes.Routes.Count);
                string totalProfitMadeByCompaniesString = totalProfitMadeByCompanies.ToString("0.00");
                UpdateStats(totalProfitMadeByCompaniesString, textBox_TotalCompanyProfit_MainMapForm);

                double averageProfitMadeByCompanies = totalProfitMadeByCompanies / mAllRoutes.Routes.Count;
                string averageProfitMadeByCompaniesString = averageProfitMadeByCompanies.ToString("0.00");
                UpdateStats(averageProfitMadeByCompaniesString, textBox_AverageCompanyProfit_MainMapForm);
            }
        }

        //DELEGATE FUNCTIONS
        private void UpdateStats(string aStat, TextBox aTextBoxToUpdate) //Make one for each, or have it take in the textbox it's updating
        {
            if (this.InvokeRequired)
            {
                mUpdateStatsDel UpdateDel = new mUpdateStatsDel(UpdateStats);
                this.Invoke(UpdateDel, new object[] { aStat, aTextBoxToUpdate });
            }
            else
            {
                aTextBoxToUpdate.Text = aStat;
            }
        }
        private void UpdateMap(GMapRoute aRoute) //Make one for each, or have it take in the textbox it's updating
        {
            if (this.InvokeRequired)
            {
                mUpdateMapDel UpdateDel = new mUpdateMapDel(UpdateMap);
                this.Invoke(UpdateDel, new object[] { aRoute });
            }
            else
            {
                if (aRoute == null)
                {
                    textBox_DebugBox_MainMapForm.Text = "ROUTE IS NULL";
                    return;
                }
                mRoutes.Routes.Add(aRoute);
                mAllRoutes.Routes.Add(aRoute);
                //gRoute.Stroke.Width = 2;
                //gRoute.Stroke.Color = Color.SeaGreen;
                gMapControl_MainMap_MainMapForm.Overlays.Add(mRoutes);
            }
        }
        
        private void button_AddDeliveryComplete_MainMapForm_Click(object sender, EventArgs e)
        {
            if(textBox_OriginAddress_MainMapForm.Text != string.Empty &&
                textBox_DestinationAddress_MainMapForm.Text != string.Empty)
            {
                //TODO: Clear boxes
                Order order = new Order();
                order.OrderName = "ORDER";
                int count = 0;

                string originAddress = textBox_OriginAddress_MainMapForm.Text;
                string destinationAddress = textBox_DestinationAddress_MainMapForm.Text;
                textBox_OriginAddress_MainMapForm.Text = string.Empty;
                textBox_DestinationAddress_MainMapForm.Text = string.Empty;

                GeoCoderStatusCode status;

                PointLatLng? originPoint = GMap.NET.MapProviders.GoogleMapProvider.Instance.GetPoint(originAddress, out status);
                if (status == GeoCoderStatusCode.G_GEO_SUCCESS && originPoint != null)
                {
                    order.PickupPoint = (PointLatLng)originPoint;
                }

                PointLatLng? destinationPoint = GMap.NET.MapProviders.GoogleMapProvider.Instance.GetPoint(destinationAddress, out status);
                if (status == GeoCoderStatusCode.G_GEO_SUCCESS && originPoint != null)
                {
                    order.DropoOffPoint = (PointLatLng)destinationPoint;
                }

                KnownColor[] values = (KnownColor[])Enum.GetValues(typeof(KnownColor));
                foreach (KnownColor kc in values)
                {
                    Color realColor = Color.FromKnownColor(kc);

                    if (count == mColourToPick)
                    {
                        order.OrderColour = realColor;
                        GMapRoute wasRouteCreated = AddRoute(order.PickupPoint, order.DropoOffPoint);

                        if (wasRouteCreated == null)
                            break;

                        AddDeliveryMarker(order.PickupPoint, realColor, mColourToPick);
                        AddDeliveryMarker(order.DropoOffPoint, realColor, mColourToPick);
                        order.TimeOrderWasCreated = DateTime.Now;

                        mColourToPick++;
                        mWhatToDoOnClick = mCommandAddItemPickupPoint;
                        mItems.Add(order);

                        break;
                    }

                    count++;
                }
            }
        }
    }

    //Conveniance Structs
    struct Order
    {
        string orderName;
        DateTime timeOrderWasCreated;
        DateTime timeOrderWasPickedUp;
        DateTime timeOrderWasDroppedOff;
        PointLatLng pickupPoint;
        PointLatLng dropoOffPoint;
        Color orderColour;

        public string OrderName
        {
            get { return orderName; }
            set { orderName = value; }
        }

        public DateTime TimeOrderWasCreated
        {
            get { return timeOrderWasCreated; }
            set { timeOrderWasCreated = value; }
        }

        public DateTime TimeOrderWasPickedUp
        {
            get { return timeOrderWasPickedUp; }
            set { timeOrderWasPickedUp = value; }
        }

        public DateTime TimeOrderWasDroppedOff
        {
            get { return timeOrderWasDroppedOff; }
            set { timeOrderWasDroppedOff = value; }
        }
        
        public PointLatLng PickupPoint
        {
            get { return pickupPoint; }
            set { pickupPoint = value; }
        }

        public PointLatLng DropoOffPoint
        {
            get { return dropoOffPoint; }
            set { dropoOffPoint = value; }
        }

        public Color OrderColour
        {
            get { return orderColour; }
            set { orderColour = value; }
        }

        //Time calculations

        public float TotalTimeSincePickup
        {
            get
            {
                //TODO: Get current time, get difference between it and pickup time
                return -1;
            }
        }

        public float TotalTimeSinceOrderCreated
        {
            get
            {
                //TODO: Get current time, get difference between it and creation time
                return -1;
            }
        }

        public float TimeTakenToDeliver
        {
            get
            {
                //TODO: Get difference between pickup time and drop off time
                return -1;
            }
        }
    }
    struct Driver
    {
        float kmDriven;
        float moneyMade;
        float timeWorked;
        double tripTime;
        int driverReliability;
        GMapRoute mapRoute;
        //GMapRoute gMapRoute;
        Order orderWorkingOn;
        GMap.NET.WindowsForms.Markers.GMarkerGoogle marker;

        public float KMDriven
        {
            get { return kmDriven; }
            set { kmDriven = value; }
        }
        
        public float MoneyMade
        {
            get { return moneyMade; }
            set { moneyMade = value; }
        }

        public float TimeWorked
        {
            get { return timeWorked; }
            set { timeWorked = value; }
        }

        public double TripTime
        {
            get { return tripTime; }
            set { tripTime = value; }
        }
        
        public int DriverReliability
        {
            get { return driverReliability; }
            set { driverReliability = value; }
        }

        public GMapRoute MapRoute
        {
            get { return mapRoute; }
            set { mapRoute = value; }
        }

        public Order OrderWorkingOn
        {
            get { return orderWorkingOn; }
            set { orderWorkingOn = value; }
        }

        public GMap.NET.WindowsForms.Markers.GMarkerGoogle Marker
        {
            get { return marker; }
            set { marker = value; }
        }
    }
}
