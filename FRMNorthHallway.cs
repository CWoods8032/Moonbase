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
    public partial class FRMNorthHallway : Form
    {   // Created variable for log file
        private const string LogFilePath = "Log.txt";
        // Instance of mainroomDetails to hold the main room details
        private nhroomDetails nhDetails;

        public FRMNorthHallway()
        {
            InitializeComponent();
            // Initialize the nhroomDetails object with the main room's information
            nhDetails = new nhroomDetails
                (
                "MoonbaseHallways.jpg",
                "North Hallway",
                "This hallway leads to multiple places. Those include the living quarters, greenhouse, and the command center."
                );
            // Load the North Hallway room details into the form
            LoadNorthHallDetails();
        }
        // Method to load details into the form controls
        private void LoadNorthHallDetails()
        {
            GBInfoNH.Text = nhDetails.BackgroundPath;
            TBRoomInfoNH.Text = nhDetails.LocationName;
            TBRoomDesNH.Text = nhDetails.LocationDescription;
        }

        private void LogFormNavigation(string direction)
        {
            using (StreamWriter writer = new StreamWriter(LogFilePath, true))
            {
                writer.WriteLine(direction);
            }
        }
        // Class to encapsulate the details of a room
        public class nhroomDetails
        {
            // Properties to store room details
            public string BackgroundPath { get; private set; }
            public string LocationName { get; private set; }
            public string LocationDescription { get; private set; }

            // Constructor to initialize the room details
            public nhroomDetails(string backgroundPath, string locationName, string locationDescription)
            {
                BackgroundPath = backgroundPath;
                LocationName = locationName;
                LocationDescription = locationDescription;
            }
        }

        private void BTNNorth_Click(object sender, EventArgs e)
        {
            LogFormNavigation("North");
            FRMNorth frm = new FRMNorth();
            this.Hide();
            frm.Show();
        }

        private void BTNNorthEast_Click(object sender, EventArgs e)
        {
            LogFormNavigation("North East");
            FRMNorthEast frm = new FRMNorthEast();
            this.Hide();
            frm.Show();
        }

        private void BTNEast_Click(object sender, EventArgs e)
        {
            LogFormNavigation("East");
            FRMEast frm = new FRMEast();
            this.Hide();
            frm.Show();
        }

        private void BTNSouthWest_Click(object sender, EventArgs e)
        {
            LogFormNavigation("South East");
            FRMSouthWest frm = new FRMSouthWest();
            this.Hide();
            frm.Show();
        }

        private void BTNSouth_Click(object sender, EventArgs e)
        {
            LogFormNavigation("South");
            FRMSouth frm = new FRMSouth();
            this.Hide();
            frm.Show();
        }

        private void BTNSouthEast_Click(object sender, EventArgs e)
        {
            LogFormNavigation("South West");
            FRMSouthEast frm = new FRMSouthEast();
            this.Hide();
            frm.Show();
        }

        private void BTNWest_Click(object sender, EventArgs e)
        {
            LogFormNavigation("West");
            FRMWest frm = new FRMWest();
            this.Hide();
            frm.Show();
        }

        private void BTNNorthWest_Click(object sender, EventArgs e)
        {
            LogFormNavigation("North West");
            FRMNorthWest frm = new FRMNorthWest();
            this.Hide();
            frm.Show();
        }

        private void BTNNorthHallway_Click(object sender, EventArgs e)
        {
            LogFormNavigation("North Hallway");
            FRMNorthHallway frm = new FRMNorthHallway();
            this.Hide();
            frm.Show();
        }

        private void BTNSouthHallway_Click(object sender, EventArgs e)
        {
            LogFormNavigation("South Hallway");
            FRMSouthHallway frm =new FRMSouthHallway();
            this.Hide();
            frm.Show();
        }

        private void BTNMain_Click(object sender, EventArgs e)
        {
            LogFormNavigation("Main");
            FRMMain frm =new FRMMain();
            this.Hide();
            frm.Show();
        }
    }
}
