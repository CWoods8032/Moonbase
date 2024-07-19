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
    public partial class FRMSouth : Form
    {
        // Created variable for log file
        private const string LogFilePath = "log.txt";

        // Instance of southroomDetails to hold the south room details
        private southroomDetails southDetails;

        // Constructor for the FRMSouth form
        public FRMSouth()
        {
            InitializeComponent();
            // Initialize the southroomDetails object with the south room's information
            southDetails = new southroomDetails
                (
            // Background path
            "Moonbaseentrance.jpg",
            // Location name
            "Main Entrance",
            // Location Description
            "To the South of main is the main entrance to the moonbase. It has spacesuits, first aid, bathrooms and so on. Researchers can go outside to investigate the moon or maybe just bounce around.\r\n\r\nIt also keeps the number of personnel that are currently in out at this moment. Keeping track of individuals is important. Especially when it comes to allowing people on the moons surface. The outside has vehicles waiting as a form of transportation.\r\n"
                );
                // Load the south room details into the form
                LoadSouthDetails();
        }

        // Method to load details into the form controls
        private void LoadSouthDetails()
        {
            GBInfoSouth.Text = southDetails.BackgroundPath;
            TBRoomInfoSouth.Text = southDetails.LocationName;
            TBRoomDesSouth.Text = southDetails.LocationDescription;
        }
        // Main button click event
        private void BTNMain_Click(object sender, EventArgs e)
        {
            LogFormNavigation("Main"); // Log the navigation action
            FRMMain frm = new FRMMain(); // Create an instance of FRMMain
            this.Hide(); // Hide the current form (FRMSouth)
            frm.Show(); // Show the FRMMain form
        }
        // North button click event
        private void BTNNorth_Click(object sender, EventArgs e)
        {
            LogFormNavigation("North"); // Log the navigation action
            FRMNorth frm = new FRMNorth(); // Create an instance of FRMNorth
            this.Hide(); // Hide the current form (FRMSouth)
            frm.Show(); // Show the FRMNorth form
        }
        // West button click event
        private void BTNWest_Click(object sender, EventArgs e)
        {
            LogFormNavigation("West"); // Log the navigation action
            FRMWest frm = new FRMWest(); // Create an instance of FRMWest
            this.Hide(); // Hide the current form (FRMSouth)
            frm.Show(); // Show the FRMWest form
        }
        // East button click event
        private void BTNEast_Click(object sender, EventArgs e)
        {
            LogFormNavigation("East"); // Log the navigation action
            FRMEast frm = new FRMEast(); // Create an instance FRMEast
            this.Hide(); // Hide the current form (FRMSouth)
            frm.Show(); // Show the FRMEast form
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

        private void BTNSouthWest_Click(object sender, EventArgs e)
        {
            LogFormNavigation("South East");
            FRMSouthWest frm = new FRMSouthWest();
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
    }

    // Class to encapsulate the details of a room
    public class southroomDetails
    {
        // Properties to store room details
        public string BackgroundPath { get; private set; }
        public string LocationName { get; private set; }
        public string LocationDescription { get; private set; }

        // Constructor to initialize the room details
        public southroomDetails(string backgroundPath, string locationName, string locationDescription)
        {
            BackgroundPath = backgroundPath;
            LocationName = locationName;
            LocationDescription = locationDescription;
        }
    }
}
