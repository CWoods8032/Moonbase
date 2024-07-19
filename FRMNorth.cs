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
    public partial class FRMNorth : Form
    {
        // Created variable for log file
        private const string LogFilePath = "log.txt";

        // Instance of northroomDetails to hold the north room details
        private northroomDetails northDetails;
        // Constructor for the FRMNorth form
        public FRMNorth()
        {
            InitializeComponent();
            // Initialize the northroomdetails object with the north room's information
            northDetails = new northroomDetails(
            // Background path
            "Livingquarters.jpg",
            // Location name
            "Living Quarters",
            // Location Description
            "Arriving to the North part of the moonbase there are several living quarters. There is a ladder that leads up to a comfy bed. Plenty of storage for clothes and other personal items.\r\n\r\nComfortable lounging area to do all sorts of hobbies like reading. A rug in the middle that's comfortable to the touch. Seems like a very nice area to live.\r\n"
                );
            // Load the north room details into the form
            LoadNorthDetails();
        }

        // Method to load details into the form controls
        private void LoadNorthDetails()
        {
            GBInfoNorth.Text = northDetails.BackgroundPath;
            TBRoomInfoNorth.Text = northDetails.LocationName;
            TBRoomDesNorth.Text = northDetails.LocationDescription;
        }
        // West button click event
        private void BTNWest_Click(object sender, EventArgs e)
        {
            LogFormNavigation("West"); // Log the navigation action
            FRMWest frm = new FRMWest(); // Create an instance of FRMWest
            this.Hide(); // Hide the current form (FRMNorth)
            frm.Show(); // Show the FRMWest form
        }
        // East button click event
        private void BTNEast_Click(object sender, EventArgs e)
        {
            LogFormNavigation("East"); // Log the navigation action
            FRMEast frm = new FRMEast(); // Create an instance of FRMEast
            this.Hide(); // Hide the current form (FRMNorth)
            frm.Show(); // Show the FRMEast form
        }
        // South button click event
        private void BTNSouth_Click(object sender, EventArgs e)
        {
            LogFormNavigation("South"); // Log the navigation action
            FRMSouth frm = new FRMSouth(); // Create an instance of FRMSouth
            this.Hide(); // Hide the current form (FRMNorth)
            frm.Show(); // Show the FRMSouth form
        }
        // Main button click event
        private void BTNMain_Click(object sender, EventArgs e)
        {
            LogFormNavigation("Main"); // Log the navigation action
            FRMMain frm = new FRMMain(); // Create an instance of FRMMain
            this.Hide(); // Hide the current form (FRMNorth)
            frm.Show(); // Show the FRMMain form
        }
        // North button click event
        private void BTNNorth_Click(object sender, EventArgs e)
        {

        }
        // Method to log form navigation to a text file
    private void LogFormNavigation(string formName)
    {
        using (StreamWriter writer = new StreamWriter(LogFilePath, true))
        {
            writer.WriteLine(formName); // Write the form name to the log file
        }
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

        private void BTNSouthWest_Click(object sender, EventArgs e)
        {
            LogFormNavigation("South East");
            FRMSouthWest frm = new FRMSouthWest();
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
    }
    // Class to encapsulate the details of a room
    public class northroomDetails
    {
        // Properties to store room details
        public string BackgroundPath { get; private set; }
        public string LocationName { get; private set; }
        public string LocationDescription { get; private set; }

        // Constructor to initialize the room details
        public northroomDetails(string backgroundPath, string locationName, string locationDescription)
        {
            BackgroundPath = backgroundPath;
            LocationName = locationName;
            LocationDescription = locationDescription;
        }
    }
}
