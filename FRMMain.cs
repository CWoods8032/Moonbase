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
    public partial class FRMMain : Form
    {
        // Created variable for log file
        private const string LogFilePath = "log.txt";

        String[] mainDetails = new string[3]
        {// Background path
            "Moonbase.jpg", 
            // Location name
            "Entertainment Room", 
            // Location Description
            "Walking into this room you can see chairs, tables, and a bar. The bar consists of all types of drinks in bags. The seated areas with tables have games of cards and checkers. \r\n\r\nYou can also choose any other board games if you wish. It seems rather busy and a very socializing experience.\r\n", 
        };
        // Constructor for the FRMMain form
        public FRMMain()
        {
            InitializeComponent();
            LoadMainDetails();
        }

        // Method to load details
        private void LoadMainDetails()
        {
            GBInfoMain.Text = mainDetails[0].ToString(); // Assign first element of Array
            TBRoomInfoMain.Text = mainDetails[1].ToString(); // Assign second element of Array
            TBRoomDesMain.Text = mainDetails[2].ToString(); // Assign third element of Array
        }
        // North button click event
        private void BTNNorth_Click(object sender, EventArgs e)
        {
            LogFormNavigation("North"); // Log the navigation action
            FRMNorth frm = new FRMNorth(); // Create an instance of FRMNorth
            this.Hide(); // Hide the current form (FRMMain)
            frm.Show(); // Show the FRMNorth form
        }
        // West button click event
        private void BTNWest_Click(object sender, EventArgs e)
        {
            LogFormNavigation("West"); // Log the navigation action
            FRMWest frm = new FRMWest(); // Create an instance of FRMWest
            this.Hide(); // Hide the current form (FRMMain)
            frm.Show(); // Show the FRMWest form
        }
        // East button click event
        private void BTNEast_Click(object sender, EventArgs e)
        {
            LogFormNavigation("East"); // Log the navigation action
            FRMEast frm = new FRMEast(); // Create an instance of FRMEast
            this.Hide(); // Hide the current form (FRMMain)
            frm.Show(); // Show the FRMEast form
        }
        // South button click event
        private void BTNSouth_Click(object sender, EventArgs e)
        {
            LogFormNavigation("South"); // Log the navigation action
            FRMSouth frm = new FRMSouth(); // Create an instance of FRMSouth
            this.Hide(); // Hide the current form (FRMMain)
            frm.Show(); // Show the FRMSouth form
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
    
 
