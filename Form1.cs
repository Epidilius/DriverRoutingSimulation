using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverRoutingSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void button_TestMap_MainForm_Click(object sender, EventArgs e)
        {
            MainMapForm mainMapForm = new MainMapForm();
            mainMapForm.Show();
        }
    }
}
