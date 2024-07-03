namespace Moonbase
{
    partial class FRMMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMMain));
            this.GBInfoMain = new System.Windows.Forms.GroupBox();
            this.LABRoomDesMain = new System.Windows.Forms.Label();
            this.TBRoomDesMain = new System.Windows.Forms.TextBox();
            this.TBRoomInfoMain = new System.Windows.Forms.TextBox();
            this.LABRoomMain = new System.Windows.Forms.Label();
            this.GBNav = new System.Windows.Forms.GroupBox();
            this.BTNWest = new System.Windows.Forms.Button();
            this.BTNEast = new System.Windows.Forms.Button();
            this.BTNSouth = new System.Windows.Forms.Button();
            this.BTNNorth = new System.Windows.Forms.Button();
            this.BTNMain = new System.Windows.Forms.Button();
            this.GBInfoMain.SuspendLayout();
            this.GBNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBInfoMain
            // 
            this.GBInfoMain.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GBInfoMain.Controls.Add(this.LABRoomDesMain);
            this.GBInfoMain.Controls.Add(this.TBRoomDesMain);
            this.GBInfoMain.Controls.Add(this.TBRoomInfoMain);
            this.GBInfoMain.Controls.Add(this.LABRoomMain);
            this.GBInfoMain.Location = new System.Drawing.Point(1474, 62);
            this.GBInfoMain.Name = "GBInfoMain";
            this.GBInfoMain.Size = new System.Drawing.Size(540, 548);
            this.GBInfoMain.TabIndex = 0;
            this.GBInfoMain.TabStop = false;
            this.GBInfoMain.Text = "Location Information";
            // 
            // LABRoomDesMain
            // 
            this.LABRoomDesMain.AutoSize = true;
            this.LABRoomDesMain.Location = new System.Drawing.Point(34, 120);
            this.LABRoomDesMain.Name = "LABRoomDesMain";
            this.LABRoomDesMain.Size = new System.Drawing.Size(136, 20);
            this.LABRoomDesMain.TabIndex = 3;
            this.LABRoomDesMain.Text = "Room Description";
            // 
            // TBRoomDesMain
            // 
            this.TBRoomDesMain.Location = new System.Drawing.Point(36, 146);
            this.TBRoomDesMain.Multiline = true;
            this.TBRoomDesMain.Name = "TBRoomDesMain";
            this.TBRoomDesMain.ReadOnly = true;
            this.TBRoomDesMain.Size = new System.Drawing.Size(472, 367);
            this.TBRoomDesMain.TabIndex = 2;
            this.TBRoomDesMain.Text = resources.GetString("TBRoomDesMain.Text");
            // 
            // TBRoomInfoMain
            // 
            this.TBRoomInfoMain.Location = new System.Drawing.Point(36, 63);
            this.TBRoomInfoMain.Name = "TBRoomInfoMain";
            this.TBRoomInfoMain.ReadOnly = true;
            this.TBRoomInfoMain.Size = new System.Drawing.Size(185, 26);
            this.TBRoomInfoMain.TabIndex = 1;
            this.TBRoomInfoMain.Text = "Entertainment Room";
            // 
            // LABRoomMain
            // 
            this.LABRoomMain.AutoSize = true;
            this.LABRoomMain.Location = new System.Drawing.Point(32, 39);
            this.LABRoomMain.Name = "LABRoomMain";
            this.LABRoomMain.Size = new System.Drawing.Size(98, 20);
            this.LABRoomMain.TabIndex = 0;
            this.LABRoomMain.Text = "Room Name";
            // 
            // GBNav
            // 
            this.GBNav.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GBNav.Controls.Add(this.BTNMain);
            this.GBNav.Controls.Add(this.BTNWest);
            this.GBNav.Controls.Add(this.BTNEast);
            this.GBNav.Controls.Add(this.BTNSouth);
            this.GBNav.Controls.Add(this.BTNNorth);
            this.GBNav.Location = new System.Drawing.Point(12, 62);
            this.GBNav.Name = "GBNav";
            this.GBNav.Size = new System.Drawing.Size(260, 198);
            this.GBNav.TabIndex = 1;
            this.GBNav.TabStop = false;
            this.GBNav.Text = "Personal Nav Device";
            // 
            // BTNWest
            // 
            this.BTNWest.Location = new System.Drawing.Point(6, 88);
            this.BTNWest.Name = "BTNWest";
            this.BTNWest.Size = new System.Drawing.Size(75, 34);
            this.BTNWest.TabIndex = 3;
            this.BTNWest.Text = "West";
            this.BTNWest.UseVisualStyleBackColor = true;
            this.BTNWest.Click += new System.EventHandler(this.BTNWest_Click);
            // 
            // BTNEast
            // 
            this.BTNEast.Location = new System.Drawing.Point(179, 88);
            this.BTNEast.Name = "BTNEast";
            this.BTNEast.Size = new System.Drawing.Size(75, 34);
            this.BTNEast.TabIndex = 2;
            this.BTNEast.Text = "East";
            this.BTNEast.UseVisualStyleBackColor = true;
            this.BTNEast.Click += new System.EventHandler(this.BTNEast_Click);
            // 
            // BTNSouth
            // 
            this.BTNSouth.Location = new System.Drawing.Point(92, 143);
            this.BTNSouth.Name = "BTNSouth";
            this.BTNSouth.Size = new System.Drawing.Size(75, 31);
            this.BTNSouth.TabIndex = 1;
            this.BTNSouth.Text = "South";
            this.BTNSouth.UseVisualStyleBackColor = true;
            this.BTNSouth.Click += new System.EventHandler(this.BTNSouth_Click);
            // 
            // BTNNorth
            // 
            this.BTNNorth.Location = new System.Drawing.Point(92, 34);
            this.BTNNorth.Name = "BTNNorth";
            this.BTNNorth.Size = new System.Drawing.Size(75, 33);
            this.BTNNorth.TabIndex = 0;
            this.BTNNorth.Text = "North";
            this.BTNNorth.UseVisualStyleBackColor = true;
            this.BTNNorth.Click += new System.EventHandler(this.BTNNorth_Click);
            // 
            // BTNMain
            // 
            this.BTNMain.Enabled = false;
            this.BTNMain.Location = new System.Drawing.Point(91, 88);
            this.BTNMain.Name = "BTNMain";
            this.BTNMain.Size = new System.Drawing.Size(76, 34);
            this.BTNMain.TabIndex = 4;
            this.BTNMain.Text = "Main";
            this.BTNMain.UseVisualStyleBackColor = true;
            // 
            // FRMMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Moonbase.Properties.Resources.Moonbase;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2026, 968);
            this.Controls.Add(this.GBNav);
            this.Controls.Add(this.GBInfoMain);
            this.Name = "FRMMain";
            this.Text = "Moonbase Zero!";
            this.GBInfoMain.ResumeLayout(false);
            this.GBInfoMain.PerformLayout();
            this.GBNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBInfoMain;
        private System.Windows.Forms.TextBox TBRoomInfoMain;
        private System.Windows.Forms.Label LABRoomMain;
        private System.Windows.Forms.Label LABRoomDesMain;
        private System.Windows.Forms.TextBox TBRoomDesMain;
        private System.Windows.Forms.GroupBox GBNav;
        private System.Windows.Forms.Button BTNWest;
        private System.Windows.Forms.Button BTNEast;
        private System.Windows.Forms.Button BTNSouth;
        private System.Windows.Forms.Button BTNNorth;
        private System.Windows.Forms.Button BTNMain;
    }
}

