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
    public partial class FRMNorthWest : Form
    {
        // Created variable for log file
        private const string LogFilePath = "Log.txt";
        // Instance of nwroomDetails to hold the main room details
        private nwroomDetails nwDetails;

        public FRMNorthWest()
        {
            InitializeComponent();
            // Initialize the nwroomDetails object with the main room's information
            nwDetails = new nwroomDetails
                (
                "CommandCenter.jpg",
                "Command Center",
                "The command center let me in just to look around but not to ask questions. Everything is Top Secret. The room has several people working. I even noticed an arms room filled with high tech weaponery.\r\n\r\nThey wouldn't let me stay long but its filled with the most high tech communications equipment. So this is where all the big wigs of the moonbase meet up to talk strategy.\r\n"
                );
            // Load the room details into the form
            LoadNorthWestDetails();
        }
        // Method to load details into the form controls
        private void LoadNorthWestDetails()
        {
            GBInfoNW.Text = nwDetails.BackgroundPath;
            TBRoomInfoNW.Text = nwDetails.LocationName;
            TBRoomDesNW.Text = nwDetails.LocationDescription;
        }
        private void BTNMain_Click(object sender, EventArgs e)
        {
            LogFormNavigation("Main");
            FRMMain frm = new FRMMain();
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

        public class nwroomDetails
        {
            // Properties to store room details
            public string BackgroundPath { get; private set; }
            public string LocationName { get; private set; }
            public string LocationDescription { get; private set; }

            // Constructor to initialize the room details
            public nwroomDetails(string backgroundPath, string locationName, string locationDescription)
            {
                BackgroundPath = backgroundPath;
                LocationName = locationName;
                LocationDescription = locationDescription;
            }
        }

        private void BTNNorthHallway_Click(object sender, EventArgs e)
        {
            LogFormNavigation("North Hallway");
            FRMNorthHallway frm = new FRMNorthHallway();
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
            FRMSouthEast frm = new FRMSouthEast();
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

        private void BTNSouthHallway_Click(object sender, EventArgs e)
        {
            LogFormNavigation("South Hallway");
            FRMSouthHallway frm = new FRMSouthHallway();
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
    }
}

