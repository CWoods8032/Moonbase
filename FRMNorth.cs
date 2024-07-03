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

        String[] northDetails = new string[3]
        {   // Background path
            "Livingquarters.jpg", 
             // Location name
            "Living Quarters",
            // Location Description
            "Arriving to the North part of the moonbase there are several living quarters. There is a ladder that leads up to a comfy bed. Plenty of storage for clothes and other personal items.\r\n\r\nComfortable lounging area to do all sorts of hobbies like reading. A rug in the middle that's comfortable to the touch. Seems like a very nice area to live.\r\n", 
        };
        // Constructor for the FRMNorth form
        public FRMNorth()
        {
            InitializeComponent();
            LoadNorthDetails();
        }

        // Method to Load Details
        private void LoadNorthDetails()
        {
            GBInfoNorth.Text = northDetails[0].ToString(); // Assign first element of Array
            TBRoomInfoNorth.Text = northDetails[1].ToString(); // Assign second element of Array
            TBRoomDesNorth.Text = northDetails[2].ToString(); // Assign third element of Array
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
}
}
