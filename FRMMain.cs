﻿using System;
using System.CodeDom;
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
    public partial class FRMMain : Form
    {
        // Created variable for log file
        private const string LogFilePath = "log.txt";

        // Instance of mainroomDetails to hold the main room details
        private mainroomDetails mainDetails;

        public FRMMain()
        {
            InitializeComponent();
            // Initialize the mainroomDetails object with the main room's information
            mainDetails = new mainroomDetails(
               "Moonbase.jpg",
                "Entertainment Room",
                "Walking into this room you can see chairs, tables, and a bar. The bar consists of all types of drinks in bags. The seated areas with tables have games of cards and checkers.\r\n\r\nYou can also choose any other board games if you wish. It seems rather busy and a very socializing experience.\r\n"
            );
            // Load the main room details into the form
            LoadMainDetails();
        }

        

        // Method to load details into the form controls
        private void LoadMainDetails()
        {
            GBInfoMain.Text = mainDetails.BackgroundPath;
            TBRoomInfoMain.Text = mainDetails.LocationName;
            TBRoomDesMain.Text = mainDetails.LocationDescription;
        }

        private void BTNNorth_Click( object sender, EventArgs e )
        {
            LogFormNavigation("North");
            FRMNorth frm = new FRMNorth();
            this.Hide();
            frm.Show();
        }

        private void BTNWest_Click( object sender, EventArgs e )
        {
            LogFormNavigation("West");
            FRMWest frm = new FRMWest();
            this.Hide();
            frm.Show();
        }

        private void BTNEast_Click( object sender, EventArgs e )
        {
            LogFormNavigation("East");
            FRMEast frm = new FRMEast();
            this.Hide();
            frm.Show();
        }

        private void BTNSouth_Click( object sender, EventArgs e )
        {
            LogFormNavigation("South");
            FRMSouth frm = new FRMSouth();
            this.Hide();
            frm.Show();
        }

        private void LogFormNavigation(string direction)
        {
            using(StreamWriter writer = new StreamWriter(LogFilePath, true))
            {
                writer.WriteLine(direction);
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
    public class mainroomDetails
    {
        // Properties to store room details
        public string BackgroundPath { get; private set; }
        public string LocationName { get; private set; }
        public string LocationDescription { get; private set; }

        // Constructor to initialize the room details
        public mainroomDetails(string backgroundPath, string locationName, string locationDescription)
        {
            BackgroundPath = backgroundPath;
            LocationName = locationName;
            LocationDescription = locationDescription;
        }
        
        
    }
}


        
    



    
 
