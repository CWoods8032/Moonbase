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
        // Created variable for log file
        private const string LogFilePath = "log.txt";

        // Instance of eastroomDetails to hold the east room details
        private eastroomDetails eastDetails;
        // Constructor for the FRMEast form
        public FRMEast()
        {
            InitializeComponent();
            // Initialize the eastroomDetails object with the main room's information
            eastDetails = new eastroomDetails( 
             // Background path
            "Kitchen.jpg",
            // Location name
            "Kitchen",
            // Location description
            "The East side of the base has the most updated kitchen I have ever saw. It's controlled by an artificial intelligence that can help you make food. Has several stoves and ovens. A refrigerator that is filled with all sorts of goodies.\r\n\r\nThe AI also helps keep this place clean so we don't have to worry about clean up. Everything is properly disposed of so it doesn't litter the moons surface. I love that it supports staying green.\r\n"
                );
            // Load the east room details into the form
            LoadEastDetails();
        }

        // Method to load details into the form controls
        private void LoadEastDetails()
        {
            GBInfoEast.Text = eastDetails.BackgroundPath;
            TBRoomInfoEast.Text = eastDetails.LocationName;
            TBRoomDesEast.Text = eastDetails.LocationDescription;
        }
        // Main button click event
        private void BTNMain_Click(object sender, EventArgs e)
        {
            LogFormNavigation("Main"); // Log the navigation action
            FRMMain frm = new FRMMain(); // Create an instance of FRMMain
            this.Hide(); // Hide current form (FRMEast)
            frm.Show(); // Show the FRMMain form
        }
        // West button click event
        private void BTNWest_Click(object sender, EventArgs e)
        {
            LogFormNavigation("West"); // Log the navigation action
            FRMWest frm = new FRMWest(); // Create an instance of FRMWest
            this.Hide(); // Hide current form (FRMEast)
            frm.Show(); // Show the FRMWest form
        }
        // South button click event
        private void BTNSouth_Click(object sender, EventArgs e)
        {
            LogFormNavigation("South"); // Log the navigation action
            FRMSouth frm = new FRMSouth(); // Create an instance of FRMSouth
            this.Hide(); // Hide current form (FRMEast)
            frm.Show(); // Show the FRMSouth form
        }
        // North button click event
        private void BTNNorth_Click(object sender, EventArgs e)
        {
            LogFormNavigation("North"); // Log the navigation action
            FRMNorth frm = new FRMNorth(); // Create an instance of FRMNorth
            this.Hide(); // Hide current form (FRMEast)
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
    public class eastroomDetails
    {
        // Properties to store room details
        public string BackgroundPath { get; private set; }
        public string LocationName { get; private set; }
        public string LocationDescription { get; private set; }

        // Constructor to initialize the room details
        public eastroomDetails(string backgroundPath, string locationName, string locationDescription)
        {
            BackgroundPath = backgroundPath;
            LocationName = locationName;
            LocationDescription = locationDescription;
        }
    }
}
