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
    public partial class FRMSouthEast : Form
    {
        // Created variable for log file
        private const string LogFilePath = "Log.txt";

        // Instance of seroomDetails to hold the main room details
        private seroomDetails seDetails;

        public FRMSouthEast()
        {
            InitializeComponent();
            // Initialize the seroomDetails object with the main room's information
            seDetails = new seroomDetails
                (
                "MaintenanceRoom.jpg",
                "Maintenance Room",
                "This room is filled with levels and readings of the moonbase. They make sure it stays in top shape. The most high tech tools and equipment is used to keep this place maintained."
                );
            // Load the room details into the form
            LoadNorthWestDetails();
        }
        // Method to load details into the form controls
        private void LoadNorthWestDetails()
        {
            GBInfoSE.Text = seDetails.BackgroundPath;
            TBRoomInfoSE.Text = seDetails.LocationName;
            TBRoomDesSE.Text = seDetails.LocationDescription;
        }

        private void LogFormNavigation(string direction)
        {
            using (StreamWriter writer = new StreamWriter(LogFilePath, true))
            {
                writer.WriteLine(direction);
            }
        }

        public class seroomDetails
        {
            // Properties to store room details
            public string BackgroundPath { get; private set; }
            public string LocationName { get; private set; }
            public string LocationDescription { get; private set; }

            // Constructor to initialize the room details
            public seroomDetails(string backgroundPath, string locationName, string locationDescription)
            {
                BackgroundPath = backgroundPath;
                LocationName = locationName;
                LocationDescription = locationDescription;
            }
        }

        private void BTNMain_Click_1(object sender, EventArgs e)
        {
            LogFormNavigation("Main");
            FRMMain frm = new FRMMain();
            this.Hide();
            frm.Show();
        }

        private void BTNNorthHallway_Click_1(object sender, EventArgs e)
        {
            LogFormNavigation("North Hallway");
            FRMNorthHallway frm = new FRMNorthHallway();
            this.Hide();
            frm.Show();
        }

        private void BTNNorth_Click_1(object sender, EventArgs e)
        {
            LogFormNavigation("North");
            FRMNorth frm = new FRMNorth();
            this.Hide();
            frm.Show();
        }

        private void BTNNorthEast_Click_1(object sender, EventArgs e)
        {
            LogFormNavigation("North East");
            FRMNorthEast frm = new FRMNorthEast();
            this.Hide();
            frm.Show();
        }

        private void BTNEast_Click_1(object sender, EventArgs e)
        {
            LogFormNavigation("East");
            FRMEast frm = new FRMEast();
            this.Hide();
            frm.Show();
        }

        private void BTNSouthWest_Click_1(object sender, EventArgs e)
        {
            LogFormNavigation("South East");
            FRMSouthWest frm = new FRMSouthWest();
            this.Hide();
            frm.Show();
        }

        private void BTNSouth_Click_1(object sender, EventArgs e)
        {
            LogFormNavigation("South");
            FRMSouth frm = new FRMSouth();
            this.Hide();
            frm.Show();
        }

        private void BTNSouthHallway_Click_1(object sender, EventArgs e)
        {
            LogFormNavigation("South Hallway");
            FRMSouthHallway frm = new FRMSouthHallway();
            this.Hide();
            frm.Show();
        }

        private void BTNSouthEast_Click_1(object sender, EventArgs e)
        {
            LogFormNavigation("South West");
            FRMSouthEast frm = new FRMSouthEast();
            this.Hide();
            frm.Show();
        }

        private void BTNWest_Click_1(object sender, EventArgs e)
        {
            LogFormNavigation("West");
            FRMWest frm = new FRMWest();
            this.Hide();
            frm.Show();
        }

        private void BTNNorthWest_Click_1(object sender, EventArgs e)
        {
            LogFormNavigation("North West");
            FRMNorthWest frm = new FRMNorthWest();
            this.Hide();
            frm.Show();
        }
    }
}
