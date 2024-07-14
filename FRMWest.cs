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
    // Constructor for the FRMWest form
    public partial class FRMWest : Form
    {
        // Created variable for log file
        private const string LogFilePath = "log.txt";
        // Instance of westroomDetails to hold the west room details
        private westroomDetails westDetails;
        public FRMWest()
        {
            InitializeComponent();
            // Initialize the westroomDetails object with the west room's information 
            westDetails = new westroomDetails(
            // Background path
            "Lab.jpg",
            // Location name
            "Labratory",
            // Location Description
            "Arriving on the west side has a full blown lab with all the bells and whistles. This is where all the magic happens. It seems to be quite busy as people are walking in and out constantly.\r\n\r\nIt has several high tech computers, vials, tubes, virtual screens and so on. It seems like everyone is happy with their work and believe they are making a difference. Not sure exactly what's being worked on and everyone says its top secret.\r\n"
                );
            // Load the west room details into the form
            LoadWestDetails();
        }

        // Method to load details into the form controls
        private void LoadWestDetails()
        {
            GBInfoWest.Text = westDetails.BackgroundPath; // Set background image path
            TBRoomInfoWest.Text = westDetails.LocationName; // Set location name
            TBRoomDesWest.Text = westDetails.LocationDescription; // Set location description
        }
        // Main button click event
        private void BTNMain_Click(object sender, EventArgs e)
        {
            LogFormNavigation("Main"); // Log the navigation action
            FRMMain frm = new FRMMain(); // Create an instance of FRMMain
            this.Hide(); // Hide the current form (FRMWest)
            frm.Show(); // Show the FRMMain form
        }
        // East button click event
        private void BTNEast_Click(object sender, EventArgs e)
        {
            LogFormNavigation("East"); // Log the navigation action
            FRMEast frm = new FRMEast(); // Create an instance of FRMEast
            this.Hide(); // Hide the current form (FRMWest)
            frm.Show(); // Show the FRMEast form
        }
        // South button click event
        private void BTNSouth_Click(object sender, EventArgs e)
        {
            LogFormNavigation("South"); // Log the navigation action
            FRMSouth frm = new FRMSouth(); // Create an instance of FRMSouth
            this.Hide(); // Hide the current form (FRMWest)
            frm.Show(); // Show the FRMSouth form
        }
        // North button click event
        private void BTNNorth_Click(object sender, EventArgs e)
        {
            LogFormNavigation("North"); // Log the navigation action
            FRMNorth frm = new FRMNorth(); // Create an instance of FRMNorth
            this.Hide(); // Hide the current form (FRMWest)
            frm.Show(); // Show the FRMNorth form
        }
        // Method to log form navigation to a text file
        private void LogFormNavigation(string formName)
        {
            using (StreamWriter writer = new StreamWriter(LogFilePath, true))
            {
                writer.WriteLine(formName); // Write the form name to the log file
            }
        }
    }

    // Class to encapusulate the details of a room
    public class westroomDetails
    {
        // Properties to store room details
        public string BackgroundPath { get; private set; }
        public string LocationName { get; private set; }
        public string LocationDescription { get; private set; }

        // Constructor to initialize the room details
        public westroomDetails(string backgroundPath, string locationName, string locationDescription)
        {
            BackgroundPath = backgroundPath;
            LocationName = locationName;
            LocationDescription = locationDescription;
        }
    }
}
