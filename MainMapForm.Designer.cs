namespace DriverRoutingSimulation
{
    partial class MainMapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gMapControl_MainMap_MainMapForm = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox_Controls_MainMapForm = new System.Windows.Forms.GroupBox();
            this.textBox_DeliveryFee_MainMapForm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_AddDeliveryComplete_MainMapForm = new System.Windows.Forms.Button();
            this.label_DestinationAddress_MainMapForm = new System.Windows.Forms.Label();
            this.label_OriginAddress_MainMapForm = new System.Windows.Forms.Label();
            this.textBox_DestinationAddress_MainMapForm = new System.Windows.Forms.TextBox();
            this.textBox_OriginAddress_MainMapForm = new System.Windows.Forms.TextBox();
            this.textBox_PricePerKilometer_MainMapForm = new System.Windows.Forms.TextBox();
            this.label_PricePerKilmoter_MainMapForm = new System.Windows.Forms.Label();
            this.button_AddDelivery_MainMapForm = new System.Windows.Forms.Button();
            this.button_DoNothingOnClick_MainMapForm = new System.Windows.Forms.Button();
            this.label_ActiveDriverCount_MainMapForm = new System.Windows.Forms.Label();
            this.button_RemoveDriver_MainMapForm = new System.Windows.Forms.Button();
            this.button_AddDriver_MainMapForm = new System.Windows.Forms.Button();
            this.textBox_SimulationSpeed_MainMapForm = new System.Windows.Forms.TextBox();
            this.label_SimulationSpeed_MainMapForm = new System.Windows.Forms.Label();
            this.textBox_MaxTravelDistance_MainMapForm = new System.Windows.Forms.TextBox();
            this.label_MaxTravelDistance_MainMapForm = new System.Windows.Forms.Label();
            this.textBox_DriverFee_MainMapForm = new System.Windows.Forms.TextBox();
            this.label_DriverFee_MainMapForm = new System.Windows.Forms.Label();
            this.label_DriversActive_MainMapForm = new System.Windows.Forms.Label();
            this.groupBox_Statistics_MainMapForm = new System.Windows.Forms.GroupBox();
            this.textBox_AverageCompanyProfit_MainMapForm = new System.Windows.Forms.TextBox();
            this.textBox_TotalCompanyProfit_MainMapForm = new System.Windows.Forms.TextBox();
            this.textBox_TotalDriverProfit_MainMapForm = new System.Windows.Forms.TextBox();
            this.textBox_AverageEfficiency_MainMapForm = new System.Windows.Forms.TextBox();
            this.textBox_MaximumEfficiency_MainMapForm = new System.Windows.Forms.TextBox();
            this.textBox_AverageCostPerDelivery_MainMapForm = new System.Windows.Forms.TextBox();
            this.textBox_AverageTravelDistance_MainMapForm = new System.Windows.Forms.TextBox();
            this.textBox_AverageDeliveryTime_MainMapForm = new System.Windows.Forms.TextBox();
            this.textBox_DebugBox_MainMapForm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Controls_MainMapForm.SuspendLayout();
            this.groupBox_Statistics_MainMapForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapControl_MainMap_MainMapForm
            // 
            this.gMapControl_MainMap_MainMapForm.Bearing = 0F;
            this.gMapControl_MainMap_MainMapForm.CanDragMap = true;
            this.gMapControl_MainMap_MainMapForm.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl_MainMap_MainMapForm.GrayScaleMode = false;
            this.gMapControl_MainMap_MainMapForm.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl_MainMap_MainMapForm.LevelsKeepInMemmory = 5;
            this.gMapControl_MainMap_MainMapForm.Location = new System.Drawing.Point(12, 12);
            this.gMapControl_MainMap_MainMapForm.MarkersEnabled = true;
            this.gMapControl_MainMap_MainMapForm.MaxZoom = 18;
            this.gMapControl_MainMap_MainMapForm.MinZoom = 0;
            this.gMapControl_MainMap_MainMapForm.MouseWheelZoomEnabled = true;
            this.gMapControl_MainMap_MainMapForm.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl_MainMap_MainMapForm.Name = "gMapControl_MainMap_MainMapForm";
            this.gMapControl_MainMap_MainMapForm.NegativeMode = false;
            this.gMapControl_MainMap_MainMapForm.PolygonsEnabled = true;
            this.gMapControl_MainMap_MainMapForm.RetryLoadTile = 0;
            this.gMapControl_MainMap_MainMapForm.RoutesEnabled = true;
            this.gMapControl_MainMap_MainMapForm.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl_MainMap_MainMapForm.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl_MainMap_MainMapForm.ShowTileGridLines = false;
            this.gMapControl_MainMap_MainMapForm.Size = new System.Drawing.Size(500, 500);
            this.gMapControl_MainMap_MainMapForm.TabIndex = 0;
            this.gMapControl_MainMap_MainMapForm.Zoom = 5D;
            this.gMapControl_MainMap_MainMapForm.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMapControl_MainMap_MainMapForm_OnMarkerClick);
            this.gMapControl_MainMap_MainMapForm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl_MainMap_MainMapForm_MouseClick);
            // 
            // groupBox_Controls_MainMapForm
            // 
            this.groupBox_Controls_MainMapForm.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_Controls_MainMapForm.Controls.Add(this.textBox_DeliveryFee_MainMapForm);
            this.groupBox_Controls_MainMapForm.Controls.Add(this.label9);
            this.groupBox_Controls_MainMapForm.Controls.Add(this.button_AddDeliveryComplete_MainMapForm);
            this.groupBox_Controls_MainMapForm.Controls.Add(this.label_DestinationAddress_MainMapForm);
            this.groupBox_Controls_MainMapForm.Controls.Add(this.label_OriginAddress_MainMapForm);
            this.groupBox_Controls_MainMapForm.Controls.Add(this.textBox_DestinationAddress_MainMapForm);
            this.groupBox_Controls_MainMapForm.Controls.Add(this.textBox_OriginAddress_MainMapForm);
            this.groupBox_Controls_MainMapForm.Controls.Add(this.textBox_PricePerKilometer_MainMapForm);
            this.groupBox_Controls_MainMapForm.Controls.Add(this.label_PricePerKilmoter_MainMapForm);
            this.groupBox_Controls_MainMapForm.Controls.Add(this.button_AddDelivery_MainMapForm);
            this.groupBox_Controls_MainMapForm.Controls.Add(this.button_DoNothingOnClick_MainMapForm);
            this.groupBox_Controls_MainMapForm.Controls.Add(this.label_ActiveDriverCount_MainMapForm);
            this.groupBox_Controls_MainMapForm.Controls.Add(this.button_RemoveDriver_MainMapForm);
            this.groupBox_Controls_MainMapForm.Controls.Add(this.button_AddDriver_MainMapForm);
            this.groupBox_Controls_MainMapForm.Controls.Add(this.textBox_SimulationSpeed_MainMapForm);
            this.groupBox_Controls_MainMapForm.Controls.Add(this.label_SimulationSpeed_MainMapForm);
            this.groupBox_Controls_MainMapForm.Controls.Add(this.textBox_MaxTravelDistance_MainMapForm);
            this.groupBox_Controls_MainMapForm.Controls.Add(this.label_MaxTravelDistance_MainMapForm);
            this.groupBox_Controls_MainMapForm.Controls.Add(this.textBox_DriverFee_MainMapForm);
            this.groupBox_Controls_MainMapForm.Controls.Add(this.label_DriverFee_MainMapForm);
            this.groupBox_Controls_MainMapForm.Controls.Add(this.label_DriversActive_MainMapForm);
            this.groupBox_Controls_MainMapForm.Location = new System.Drawing.Point(518, 12);
            this.groupBox_Controls_MainMapForm.Name = "groupBox_Controls_MainMapForm";
            this.groupBox_Controls_MainMapForm.Size = new System.Drawing.Size(637, 250);
            this.groupBox_Controls_MainMapForm.TabIndex = 2;
            this.groupBox_Controls_MainMapForm.TabStop = false;
            this.groupBox_Controls_MainMapForm.Text = "Controls";
            // 
            // textBox_DeliveryFee_MainMapForm
            // 
            this.textBox_DeliveryFee_MainMapForm.Location = new System.Drawing.Point(120, 108);
            this.textBox_DeliveryFee_MainMapForm.Name = "textBox_DeliveryFee_MainMapForm";
            this.textBox_DeliveryFee_MainMapForm.Size = new System.Drawing.Size(100, 20);
            this.textBox_DeliveryFee_MainMapForm.TabIndex = 20;
            this.textBox_DeliveryFee_MainMapForm.Text = "0";
            this.textBox_DeliveryFee_MainMapForm.TextChanged += new System.EventHandler(this.textBox_DeliveryFee_MainMapForm_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Delivery Fee";
            // 
            // button_AddDeliveryComplete_MainMapForm
            // 
            this.button_AddDeliveryComplete_MainMapForm.Location = new System.Drawing.Point(308, 169);
            this.button_AddDeliveryComplete_MainMapForm.Name = "button_AddDeliveryComplete_MainMapForm";
            this.button_AddDeliveryComplete_MainMapForm.Size = new System.Drawing.Size(256, 23);
            this.button_AddDeliveryComplete_MainMapForm.TabIndex = 18;
            this.button_AddDeliveryComplete_MainMapForm.Text = "Add Delivery";
            this.button_AddDeliveryComplete_MainMapForm.UseVisualStyleBackColor = true;
            this.button_AddDeliveryComplete_MainMapForm.Click += new System.EventHandler(this.button_AddDeliveryComplete_MainMapForm_Click);
            // 
            // label_DestinationAddress_MainMapForm
            // 
            this.label_DestinationAddress_MainMapForm.AutoSize = true;
            this.label_DestinationAddress_MainMapForm.Location = new System.Drawing.Point(239, 227);
            this.label_DestinationAddress_MainMapForm.Name = "label_DestinationAddress_MainMapForm";
            this.label_DestinationAddress_MainMapForm.Size = new System.Drawing.Size(63, 13);
            this.label_DestinationAddress_MainMapForm.TabIndex = 17;
            this.label_DestinationAddress_MainMapForm.Text = "Destination:";
            // 
            // label_OriginAddress_MainMapForm
            // 
            this.label_OriginAddress_MainMapForm.AutoSize = true;
            this.label_OriginAddress_MainMapForm.Location = new System.Drawing.Point(265, 201);
            this.label_OriginAddress_MainMapForm.Name = "label_OriginAddress_MainMapForm";
            this.label_OriginAddress_MainMapForm.Size = new System.Drawing.Size(37, 13);
            this.label_OriginAddress_MainMapForm.TabIndex = 16;
            this.label_OriginAddress_MainMapForm.Text = "Origin:";
            // 
            // textBox_DestinationAddress_MainMapForm
            // 
            this.textBox_DestinationAddress_MainMapForm.Location = new System.Drawing.Point(308, 224);
            this.textBox_DestinationAddress_MainMapForm.Name = "textBox_DestinationAddress_MainMapForm";
            this.textBox_DestinationAddress_MainMapForm.Size = new System.Drawing.Size(256, 20);
            this.textBox_DestinationAddress_MainMapForm.TabIndex = 15;
            // 
            // textBox_OriginAddress_MainMapForm
            // 
            this.textBox_OriginAddress_MainMapForm.Location = new System.Drawing.Point(308, 198);
            this.textBox_OriginAddress_MainMapForm.Name = "textBox_OriginAddress_MainMapForm";
            this.textBox_OriginAddress_MainMapForm.Size = new System.Drawing.Size(256, 20);
            this.textBox_OriginAddress_MainMapForm.TabIndex = 11;
            // 
            // textBox_PricePerKilometer_MainMapForm
            // 
            this.textBox_PricePerKilometer_MainMapForm.Location = new System.Drawing.Point(6, 227);
            this.textBox_PricePerKilometer_MainMapForm.Name = "textBox_PricePerKilometer_MainMapForm";
            this.textBox_PricePerKilometer_MainMapForm.Size = new System.Drawing.Size(100, 20);
            this.textBox_PricePerKilometer_MainMapForm.TabIndex = 14;
            this.textBox_PricePerKilometer_MainMapForm.Text = "0.3";
            this.textBox_PricePerKilometer_MainMapForm.TextChanged += new System.EventHandler(this.textBox_PricePerKilometer_MainMapForm_TextChanged);
            // 
            // label_PricePerKilmoter_MainMapForm
            // 
            this.label_PricePerKilmoter_MainMapForm.AutoSize = true;
            this.label_PricePerKilmoter_MainMapForm.Location = new System.Drawing.Point(6, 211);
            this.label_PricePerKilmoter_MainMapForm.Name = "label_PricePerKilmoter_MainMapForm";
            this.label_PricePerKilmoter_MainMapForm.Size = new System.Drawing.Size(99, 13);
            this.label_PricePerKilmoter_MainMapForm.TabIndex = 13;
            this.label_PricePerKilmoter_MainMapForm.Text = "Price Per Kilometer:";
            // 
            // button_AddDelivery_MainMapForm
            // 
            this.button_AddDelivery_MainMapForm.Location = new System.Drawing.Point(6, 65);
            this.button_AddDelivery_MainMapForm.Name = "button_AddDelivery_MainMapForm";
            this.button_AddDelivery_MainMapForm.Size = new System.Drawing.Size(108, 23);
            this.button_AddDelivery_MainMapForm.TabIndex = 12;
            this.button_AddDelivery_MainMapForm.Text = "Add Delivery";
            this.button_AddDelivery_MainMapForm.UseVisualStyleBackColor = true;
            this.button_AddDelivery_MainMapForm.Click += new System.EventHandler(this.button_AddDelivery_MainMapForm_Click);
            // 
            // button_DoNothingOnClick_MainMapForm
            // 
            this.button_DoNothingOnClick_MainMapForm.Location = new System.Drawing.Point(120, 65);
            this.button_DoNothingOnClick_MainMapForm.Name = "button_DoNothingOnClick_MainMapForm";
            this.button_DoNothingOnClick_MainMapForm.Size = new System.Drawing.Size(108, 23);
            this.button_DoNothingOnClick_MainMapForm.TabIndex = 11;
            this.button_DoNothingOnClick_MainMapForm.Text = "Do Nothing";
            this.button_DoNothingOnClick_MainMapForm.UseVisualStyleBackColor = true;
            this.button_DoNothingOnClick_MainMapForm.Click += new System.EventHandler(this.button_DoNothing_MainMapForm_Click);
            // 
            // label_ActiveDriverCount_MainMapForm
            // 
            this.label_ActiveDriverCount_MainMapForm.AutoSize = true;
            this.label_ActiveDriverCount_MainMapForm.Location = new System.Drawing.Point(89, 20);
            this.label_ActiveDriverCount_MainMapForm.Name = "label_ActiveDriverCount_MainMapForm";
            this.label_ActiveDriverCount_MainMapForm.Size = new System.Drawing.Size(13, 13);
            this.label_ActiveDriverCount_MainMapForm.TabIndex = 10;
            this.label_ActiveDriverCount_MainMapForm.Text = "0";
            // 
            // button_RemoveDriver_MainMapForm
            // 
            this.button_RemoveDriver_MainMapForm.Location = new System.Drawing.Point(120, 36);
            this.button_RemoveDriver_MainMapForm.Name = "button_RemoveDriver_MainMapForm";
            this.button_RemoveDriver_MainMapForm.Size = new System.Drawing.Size(108, 23);
            this.button_RemoveDriver_MainMapForm.TabIndex = 9;
            this.button_RemoveDriver_MainMapForm.Text = "Remove Driver";
            this.button_RemoveDriver_MainMapForm.UseVisualStyleBackColor = true;
            this.button_RemoveDriver_MainMapForm.Click += new System.EventHandler(this.button_RemoveDriver_MainMapForm_Click);
            // 
            // button_AddDriver_MainMapForm
            // 
            this.button_AddDriver_MainMapForm.Location = new System.Drawing.Point(6, 36);
            this.button_AddDriver_MainMapForm.Name = "button_AddDriver_MainMapForm";
            this.button_AddDriver_MainMapForm.Size = new System.Drawing.Size(108, 23);
            this.button_AddDriver_MainMapForm.TabIndex = 8;
            this.button_AddDriver_MainMapForm.Text = "Add Driver";
            this.button_AddDriver_MainMapForm.UseVisualStyleBackColor = true;
            this.button_AddDriver_MainMapForm.Click += new System.EventHandler(this.button_AddDriver_MainMapForm_Click);
            // 
            // textBox_SimulationSpeed_MainMapForm
            // 
            this.textBox_SimulationSpeed_MainMapForm.Location = new System.Drawing.Point(6, 188);
            this.textBox_SimulationSpeed_MainMapForm.Name = "textBox_SimulationSpeed_MainMapForm";
            this.textBox_SimulationSpeed_MainMapForm.Size = new System.Drawing.Size(100, 20);
            this.textBox_SimulationSpeed_MainMapForm.TabIndex = 7;
            this.textBox_SimulationSpeed_MainMapForm.Text = "1";
            this.textBox_SimulationSpeed_MainMapForm.TextChanged += new System.EventHandler(this.textBox_SimulationSpeed_MainMapForm_TextChanged);
            // 
            // label_SimulationSpeed_MainMapForm
            // 
            this.label_SimulationSpeed_MainMapForm.AutoSize = true;
            this.label_SimulationSpeed_MainMapForm.Location = new System.Drawing.Point(3, 171);
            this.label_SimulationSpeed_MainMapForm.Name = "label_SimulationSpeed_MainMapForm";
            this.label_SimulationSpeed_MainMapForm.Size = new System.Drawing.Size(175, 13);
            this.label_SimulationSpeed_MainMapForm.TabIndex = 6;
            this.label_SimulationSpeed_MainMapForm.Text = "Simulation Speed: Not Implemented";
            // 
            // textBox_MaxTravelDistance_MainMapForm
            // 
            this.textBox_MaxTravelDistance_MainMapForm.Location = new System.Drawing.Point(5, 148);
            this.textBox_MaxTravelDistance_MainMapForm.Name = "textBox_MaxTravelDistance_MainMapForm";
            this.textBox_MaxTravelDistance_MainMapForm.Size = new System.Drawing.Size(100, 20);
            this.textBox_MaxTravelDistance_MainMapForm.TabIndex = 5;
            this.textBox_MaxTravelDistance_MainMapForm.Text = "0";
            this.textBox_MaxTravelDistance_MainMapForm.TextChanged += new System.EventHandler(this.textBox_MaxTravelDistance_MainMapForm_TextChanged);
            // 
            // label_MaxTravelDistance_MainMapForm
            // 
            this.label_MaxTravelDistance_MainMapForm.AutoSize = true;
            this.label_MaxTravelDistance_MainMapForm.Location = new System.Drawing.Point(2, 131);
            this.label_MaxTravelDistance_MainMapForm.Name = "label_MaxTravelDistance_MainMapForm";
            this.label_MaxTravelDistance_MainMapForm.Size = new System.Drawing.Size(162, 13);
            this.label_MaxTravelDistance_MainMapForm.TabIndex = 4;
            this.label_MaxTravelDistance_MainMapForm.Text = "Max Travel Distance For Pickup:";
            // 
            // textBox_DriverFee_MainMapForm
            // 
            this.textBox_DriverFee_MainMapForm.Location = new System.Drawing.Point(6, 108);
            this.textBox_DriverFee_MainMapForm.Name = "textBox_DriverFee_MainMapForm";
            this.textBox_DriverFee_MainMapForm.Size = new System.Drawing.Size(100, 20);
            this.textBox_DriverFee_MainMapForm.TabIndex = 3;
            this.textBox_DriverFee_MainMapForm.Text = "3";
            this.textBox_DriverFee_MainMapForm.TextChanged += new System.EventHandler(this.textBox_DriverFee_MainMapForm_TextChanged);
            // 
            // label_DriverFee_MainMapForm
            // 
            this.label_DriverFee_MainMapForm.AutoSize = true;
            this.label_DriverFee_MainMapForm.Location = new System.Drawing.Point(6, 91);
            this.label_DriverFee_MainMapForm.Name = "label_DriverFee_MainMapForm";
            this.label_DriverFee_MainMapForm.Size = new System.Drawing.Size(56, 13);
            this.label_DriverFee_MainMapForm.TabIndex = 2;
            this.label_DriverFee_MainMapForm.Text = "Driver Fee";
            // 
            // label_DriversActive_MainMapForm
            // 
            this.label_DriversActive_MainMapForm.AutoSize = true;
            this.label_DriversActive_MainMapForm.Location = new System.Drawing.Point(7, 20);
            this.label_DriversActive_MainMapForm.Name = "label_DriversActive_MainMapForm";
            this.label_DriversActive_MainMapForm.Size = new System.Drawing.Size(76, 13);
            this.label_DriversActive_MainMapForm.TabIndex = 0;
            this.label_DriversActive_MainMapForm.Text = "Drivers Active:";
            // 
            // groupBox_Statistics_MainMapForm
            // 
            this.groupBox_Statistics_MainMapForm.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_Statistics_MainMapForm.Controls.Add(this.textBox_AverageCompanyProfit_MainMapForm);
            this.groupBox_Statistics_MainMapForm.Controls.Add(this.textBox_TotalCompanyProfit_MainMapForm);
            this.groupBox_Statistics_MainMapForm.Controls.Add(this.textBox_TotalDriverProfit_MainMapForm);
            this.groupBox_Statistics_MainMapForm.Controls.Add(this.textBox_AverageEfficiency_MainMapForm);
            this.groupBox_Statistics_MainMapForm.Controls.Add(this.textBox_MaximumEfficiency_MainMapForm);
            this.groupBox_Statistics_MainMapForm.Controls.Add(this.textBox_AverageCostPerDelivery_MainMapForm);
            this.groupBox_Statistics_MainMapForm.Controls.Add(this.textBox_AverageTravelDistance_MainMapForm);
            this.groupBox_Statistics_MainMapForm.Controls.Add(this.textBox_AverageDeliveryTime_MainMapForm);
            this.groupBox_Statistics_MainMapForm.Controls.Add(this.textBox_DebugBox_MainMapForm);
            this.groupBox_Statistics_MainMapForm.Controls.Add(this.label8);
            this.groupBox_Statistics_MainMapForm.Controls.Add(this.label7);
            this.groupBox_Statistics_MainMapForm.Controls.Add(this.label6);
            this.groupBox_Statistics_MainMapForm.Controls.Add(this.label5);
            this.groupBox_Statistics_MainMapForm.Controls.Add(this.label4);
            this.groupBox_Statistics_MainMapForm.Controls.Add(this.label3);
            this.groupBox_Statistics_MainMapForm.Controls.Add(this.label2);
            this.groupBox_Statistics_MainMapForm.Controls.Add(this.label1);
            this.groupBox_Statistics_MainMapForm.Location = new System.Drawing.Point(518, 268);
            this.groupBox_Statistics_MainMapForm.Name = "groupBox_Statistics_MainMapForm";
            this.groupBox_Statistics_MainMapForm.Size = new System.Drawing.Size(637, 250);
            this.groupBox_Statistics_MainMapForm.TabIndex = 3;
            this.groupBox_Statistics_MainMapForm.TabStop = false;
            this.groupBox_Statistics_MainMapForm.Text = "Statistics";
            // 
            // textBox_AverageCompanyProfit_MainMapForm
            // 
            this.textBox_AverageCompanyProfit_MainMapForm.Enabled = false;
            this.textBox_AverageCompanyProfit_MainMapForm.Location = new System.Drawing.Point(251, 204);
            this.textBox_AverageCompanyProfit_MainMapForm.Name = "textBox_AverageCompanyProfit_MainMapForm";
            this.textBox_AverageCompanyProfit_MainMapForm.Size = new System.Drawing.Size(100, 20);
            this.textBox_AverageCompanyProfit_MainMapForm.TabIndex = 18;
            // 
            // textBox_TotalCompanyProfit_MainMapForm
            // 
            this.textBox_TotalCompanyProfit_MainMapForm.Enabled = false;
            this.textBox_TotalCompanyProfit_MainMapForm.Location = new System.Drawing.Point(251, 178);
            this.textBox_TotalCompanyProfit_MainMapForm.Name = "textBox_TotalCompanyProfit_MainMapForm";
            this.textBox_TotalCompanyProfit_MainMapForm.Size = new System.Drawing.Size(100, 20);
            this.textBox_TotalCompanyProfit_MainMapForm.TabIndex = 17;
            // 
            // textBox_TotalDriverProfit_MainMapForm
            // 
            this.textBox_TotalDriverProfit_MainMapForm.Enabled = false;
            this.textBox_TotalDriverProfit_MainMapForm.Location = new System.Drawing.Point(251, 152);
            this.textBox_TotalDriverProfit_MainMapForm.Name = "textBox_TotalDriverProfit_MainMapForm";
            this.textBox_TotalDriverProfit_MainMapForm.Size = new System.Drawing.Size(100, 20);
            this.textBox_TotalDriverProfit_MainMapForm.TabIndex = 15;
            // 
            // textBox_AverageEfficiency_MainMapForm
            // 
            this.textBox_AverageEfficiency_MainMapForm.Enabled = false;
            this.textBox_AverageEfficiency_MainMapForm.Location = new System.Drawing.Point(251, 100);
            this.textBox_AverageEfficiency_MainMapForm.Name = "textBox_AverageEfficiency_MainMapForm";
            this.textBox_AverageEfficiency_MainMapForm.Size = new System.Drawing.Size(100, 20);
            this.textBox_AverageEfficiency_MainMapForm.TabIndex = 14;
            // 
            // textBox_MaximumEfficiency_MainMapForm
            // 
            this.textBox_MaximumEfficiency_MainMapForm.Enabled = false;
            this.textBox_MaximumEfficiency_MainMapForm.Location = new System.Drawing.Point(251, 74);
            this.textBox_MaximumEfficiency_MainMapForm.Name = "textBox_MaximumEfficiency_MainMapForm";
            this.textBox_MaximumEfficiency_MainMapForm.Size = new System.Drawing.Size(100, 20);
            this.textBox_MaximumEfficiency_MainMapForm.TabIndex = 13;
            // 
            // textBox_AverageCostPerDelivery_MainMapForm
            // 
            this.textBox_AverageCostPerDelivery_MainMapForm.Enabled = false;
            this.textBox_AverageCostPerDelivery_MainMapForm.Location = new System.Drawing.Point(251, 48);
            this.textBox_AverageCostPerDelivery_MainMapForm.Name = "textBox_AverageCostPerDelivery_MainMapForm";
            this.textBox_AverageCostPerDelivery_MainMapForm.Size = new System.Drawing.Size(100, 20);
            this.textBox_AverageCostPerDelivery_MainMapForm.TabIndex = 12;
            // 
            // textBox_AverageTravelDistance_MainMapForm
            // 
            this.textBox_AverageTravelDistance_MainMapForm.Enabled = false;
            this.textBox_AverageTravelDistance_MainMapForm.Location = new System.Drawing.Point(251, 126);
            this.textBox_AverageTravelDistance_MainMapForm.Name = "textBox_AverageTravelDistance_MainMapForm";
            this.textBox_AverageTravelDistance_MainMapForm.Size = new System.Drawing.Size(100, 20);
            this.textBox_AverageTravelDistance_MainMapForm.TabIndex = 11;
            // 
            // textBox_AverageDeliveryTime_MainMapForm
            // 
            this.textBox_AverageDeliveryTime_MainMapForm.Enabled = false;
            this.textBox_AverageDeliveryTime_MainMapForm.Location = new System.Drawing.Point(251, 22);
            this.textBox_AverageDeliveryTime_MainMapForm.Name = "textBox_AverageDeliveryTime_MainMapForm";
            this.textBox_AverageDeliveryTime_MainMapForm.Size = new System.Drawing.Size(100, 20);
            this.textBox_AverageDeliveryTime_MainMapForm.TabIndex = 10;
            // 
            // textBox_DebugBox_MainMapForm
            // 
            this.textBox_DebugBox_MainMapForm.Location = new System.Drawing.Point(357, 22);
            this.textBox_DebugBox_MainMapForm.Name = "textBox_DebugBox_MainMapForm";
            this.textBox_DebugBox_MainMapForm.Size = new System.Drawing.Size(274, 20);
            this.textBox_DebugBox_MainMapForm.TabIndex = 9;
            this.textBox_DebugBox_MainMapForm.Text = "DEBUG BOX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Profit Made By Driver (Total):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Profit Made By Companies (Average):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Profit Made By Companies (Total):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Average Distance Traveled Per Delivery (KM):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average Efficiency ($/Hour):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maximum Efficiency ($/Hour):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Average Cost Per Delivery:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Average Time Per Delivery(Mins):";
            // 
            // MainMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 532);
            this.Controls.Add(this.groupBox_Statistics_MainMapForm);
            this.Controls.Add(this.groupBox_Controls_MainMapForm);
            this.Controls.Add(this.gMapControl_MainMap_MainMapForm);
            this.Name = "MainMapForm";
            this.Text = "MainMapForm";
            this.groupBox_Controls_MainMapForm.ResumeLayout(false);
            this.groupBox_Controls_MainMapForm.PerformLayout();
            this.groupBox_Statistics_MainMapForm.ResumeLayout(false);
            this.groupBox_Statistics_MainMapForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl_MainMap_MainMapForm;
        private System.Windows.Forms.GroupBox groupBox_Controls_MainMapForm;
        private System.Windows.Forms.GroupBox groupBox_Statistics_MainMapForm;
        private System.Windows.Forms.Label label_DriversActive_MainMapForm;
        private System.Windows.Forms.TextBox textBox_DriverFee_MainMapForm;
        private System.Windows.Forms.Label label_DriverFee_MainMapForm;
        private System.Windows.Forms.TextBox textBox_MaxTravelDistance_MainMapForm;
        private System.Windows.Forms.Label label_MaxTravelDistance_MainMapForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_SimulationSpeed_MainMapForm;
        private System.Windows.Forms.Label label_SimulationSpeed_MainMapForm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_ActiveDriverCount_MainMapForm;
        private System.Windows.Forms.Button button_RemoveDriver_MainMapForm;
        private System.Windows.Forms.Button button_AddDriver_MainMapForm;
        private System.Windows.Forms.Button button_DoNothingOnClick_MainMapForm;
        private System.Windows.Forms.TextBox textBox_DebugBox_MainMapForm;
        private System.Windows.Forms.Button button_AddDelivery_MainMapForm;
        private System.Windows.Forms.TextBox textBox_PricePerKilometer_MainMapForm;
        private System.Windows.Forms.Label label_PricePerKilmoter_MainMapForm;
        private System.Windows.Forms.TextBox textBox_AverageDeliveryTime_MainMapForm;
        private System.Windows.Forms.Label label_DestinationAddress_MainMapForm;
        private System.Windows.Forms.Label label_OriginAddress_MainMapForm;
        private System.Windows.Forms.TextBox textBox_DestinationAddress_MainMapForm;
        private System.Windows.Forms.TextBox textBox_OriginAddress_MainMapForm;
        private System.Windows.Forms.Button button_AddDeliveryComplete_MainMapForm;
        private System.Windows.Forms.TextBox textBox_AverageTravelDistance_MainMapForm;
        private System.Windows.Forms.TextBox textBox_AverageCostPerDelivery_MainMapForm;
        private System.Windows.Forms.TextBox textBox_AverageCompanyProfit_MainMapForm;
        private System.Windows.Forms.TextBox textBox_TotalCompanyProfit_MainMapForm;
        private System.Windows.Forms.TextBox textBox_TotalDriverProfit_MainMapForm;
        private System.Windows.Forms.TextBox textBox_AverageEfficiency_MainMapForm;
        private System.Windows.Forms.TextBox textBox_MaximumEfficiency_MainMapForm;
        private System.Windows.Forms.TextBox textBox_DeliveryFee_MainMapForm;
        private System.Windows.Forms.Label label9;
    }
}