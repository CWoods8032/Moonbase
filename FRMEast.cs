using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moonbase
{
    public partial class FRMEast : Form
    {
        private const string LogFilePath = "log.txt";
        // Constructor for the FRMEast form
        public FRMEast()
        {
            InitializeComponent();
        }
        // Main button click event
        private void BTNMain_Click(object sender, EventArgs e)
        {
            LogFormNavigation("Main");
            FRMMain frm = new FRMMain(); // Create an instance of FRMMain
            this.Hide(); // Hide current form (FRMEast)
            frm.Show(); // Show the FRMMain form
        }
        // West button click event
        private void BTNWest_Click(object sender, EventArgs e)
        {
            LogFormNavigation("West");
            FRMWest frm = new FRMWest(); // Create an instance of FRMWest
            this.Hide(); // Hide current form (FRMEast)
            frm.Show(); // Show the FRMWest form
        }
        // South button click event
        private void BTNSouth_Click(object sender, EventArgs e)
        {
            LogFormNavigation("South");
            FRMSouth frm = new FRMSouth(); // Create an instance of FRMSouth
            this.Hide(); // Hide current form (FRMEast)
            frm.Show(); // Show the FRMSouth form
        }
        // North button click event
        private void BTNNorth_Click(object sender, EventArgs e)
        {
            LogFormNavigation("North");
            FRMNorth frm = new FRMNorth(); // Create an instance of FRMNorth
            this.Hide(); // Hide current form (FRMEast)
            frm.Show(); // Show the FRMNorth form
        }
        private void LogFormNavigation(string formName)
        {
            using (StreamWriter writer = new StreamWriter(LogFilePath, true))
            {
                writer.WriteLine(formName);
            }
        }
    }
}
