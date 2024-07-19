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
    public partial class FRMNorthEast : Form
    {
        // Created variable for log file
        private const string logFilePath = "log.txt";
        // Instance of neroomDetails to hold the main room details
        private neroomDetails neDetails;
        public FRMNorthEast()
        {
            InitializeComponent();
            // Initialize the neroomDetails object with the main room's information
            neDetails = new neroomDetails(
                "Greenhouse.jpg",
                "Greenhouse",
                "There is a number of plants, fruits and vegetables growing here. It's also in zero gravity so plants are growing everywhere. This supplies the lab and kitchen."
                );
            // Load the main room details into the form
            LoadNorthEastDetails();
        }
        // Method to load details into the form controls
        private void LoadNorthEastDetails()
        {
            GBInfoNE.Text = neDetails.BackgroundPath;
            TBRoomInfoNE.Text = neDetails.LocationName;
            TBRoomDesNE.Text = neDetails.LocationDescription;
        }

        private void BTNMain_Click(object sender, EventArgs e)
        {
            LogFormNavigation("Main");
            FRMMain frm = new FRMMain();
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
            FRMSouth fRM = new FRMSouth();
            this.Hide();
            fRM.Show();
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

        private void LogFormNavigation(string direction)
        {
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine(direction);
            }
        }
    }
    // Class to encapsulate the details of a room
    public class neroomDetails
    {
        // Properties to store room details
        public string BackgroundPath { get; private set; }
        public string LocationName { get; private set; }
        public string LocationDescription { get; private set; }
        // Constructor to initialize the room details
        public neroomDetails(string backgroundPath, string locationName, string locationDescription)
        {
            BackgroundPath = backgroundPath;
            LocationName = locationName;
            LocationDescription = locationDescription;
        }
    }
}
