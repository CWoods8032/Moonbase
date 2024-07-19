using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moonbase
{
    public partial class FRMSouthWest : Form
    {
        // Created variable for log file
        private const string LogFilePath = "log.txt";

        // Instance of swroomDetails to hold the room details
        private swroomDetails swDetails;

        public FRMSouthWest()
        {
            InitializeComponent();
            // Initialize the swroomDetails object with the main room's information
            swDetails = new swroomDetails(
                "vehicleDepot.jpg",
                "Vehicle Depot",
                "This has a number of vehicles and maintainers inside. Tires and tools to help fix just about any vehicle they have. On the other side they have all sorts of parts if needed as well."
                );
            // Load the room details into the form
            LoadSWDetails();
        }
        // Method to load details into the form controls
        private void LoadSWDetails()
        {
            GBInfoSW.Text = swDetails.BackgroundPath;
            TBRoomInfoSW.Text = swDetails.LocationName;
            TBRoomDesSW.Text = swDetails.LocationDescription;
        }

        private void BTNMain_Click(object sender, EventArgs e)
        {
            LogFormNavigation("Main");
            FRMMain frm = new FRMMain();
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

        private void BTNWest_Click(object sender, EventArgs e)
        {
            LogFormNavigation("West");
            FRMWest frm = new FRMWest();
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

        private void BTNNorth_Click(object sender, EventArgs e)
        {
            LogFormNavigation("North");
            FRMNorth frm = new FRMNorth();
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

        private void BTNNorthEast_Click(object sender, EventArgs e)
        {
            LogFormNavigation("North East");
            FRMNorthEast frm = new FRMNorthEast();
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
            FRMSouthHallway frm = new FRMSouthHallway();
            this.Hide();
            frm.Show();
        }

        private void LogFormNavigation(string direction)
        {
            using (StreamWriter writer = new StreamWriter(LogFilePath, true))
            {
                writer.WriteLine(direction);
            }
        }

        private void BTNSouthWest_Click(object sender, EventArgs e)
        {
            LogFormNavigation("South East");
            FRMSouthWest frm = new FRMSouthWest();
            this.Hide();
            frm.Show();
        }
    }
    // Class to encapsulate the details of a room
    public class swroomDetails
    {
        // Properties to store room details
        public string BackgroundPath { get; private set; }
        public string LocationName { get; private set; }
        public string LocationDescription { get; private set; }

        // Constructor to initialize the room details
        public swroomDetails(string backgroundPath, string locationName, string locationDescription)
        {
            BackgroundPath = backgroundPath;
            LocationName = locationName;
            LocationDescription = locationDescription;
        }
    }
}
