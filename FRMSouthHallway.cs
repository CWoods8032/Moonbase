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
    public partial class FRMSouthHallway : Form
    {
        // Created variable for log file
        private const string LogFilePath = "Log.txt";
        // Instance of shroomDetails to hold the main room details
        private shroomDetails shDetails;

        public FRMSouthHallway()
        {
            InitializeComponent();
            // Initialize the shroomDetails object with the main room's information
            shDetails = new shroomDetails
                (
                "MoonbaseHallways.jpg",
                "South Hallway",
                "This hallway leads to multiple places. Those include the main entrance, maintenance room, and vehicle depot."
                );
            // Load the main room details into the form
            LoadNorthWestDetails();
        }

        // Method to load details into the form controls
        private void LoadNorthWestDetails()
        {
            GBInfoSH.Text = shDetails.BackgroundPath;
            TBRoomInfoSH.Text = shDetails.LocationName;
            TBRoomDesSH.Text = shDetails.LocationDescription;
        }
        private void LogFormNavigation(string direction)
        {
            using (StreamWriter writer = new StreamWriter(LogFilePath, true))
            {
                writer.WriteLine(direction);
            }
        }

        public class shroomDetails
        {
            // Properties to store room details
            public string BackgroundPath { get; private set; }
            public string LocationName { get; private set; }
            public string LocationDescription { get; private set; }

            // Constructor to initialize the room details
            public shroomDetails(string backgroundPath, string locationName, string locationDescription)
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
