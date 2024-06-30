namespace Moonbase
{
    partial class FRMEast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMEast));
            this.GBNav = new System.Windows.Forms.GroupBox();
            this.BTNWest = new System.Windows.Forms.Button();
            this.BTNEast = new System.Windows.Forms.Button();
            this.BTNSouth = new System.Windows.Forms.Button();
            this.GBInfoEast = new System.Windows.Forms.GroupBox();
            this.TBRoomDesEast = new System.Windows.Forms.TextBox();
            this.LABRoomDesEast = new System.Windows.Forms.Label();
            this.TBRoomInfoEast = new System.Windows.Forms.TextBox();
            this.LABRoomEast = new System.Windows.Forms.Label();
            this.BTNMain = new System.Windows.Forms.Button();
            this.BTNNorth = new System.Windows.Forms.Button();
            this.GBNav.SuspendLayout();
            this.GBInfoEast.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBNav
            // 
            this.GBNav.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GBNav.Controls.Add(this.BTNNorth);
            this.GBNav.Controls.Add(this.BTNWest);
            this.GBNav.Controls.Add(this.BTNEast);
            this.GBNav.Controls.Add(this.BTNSouth);
            this.GBNav.Location = new System.Drawing.Point(12, 62);
            this.GBNav.Name = "GBNav";
            this.GBNav.Size = new System.Drawing.Size(233, 199);
            this.GBNav.TabIndex = 2;
            this.GBNav.TabStop = false;
            this.GBNav.Text = "Personal Nav Device";
            // 
            // BTNWest
            // 
            this.BTNWest.Location = new System.Drawing.Point(27, 88);
            this.BTNWest.Name = "BTNWest";
            this.BTNWest.Size = new System.Drawing.Size(75, 34);
            this.BTNWest.TabIndex = 3;
            this.BTNWest.Text = "West";
            this.BTNWest.UseVisualStyleBackColor = true;
            this.BTNWest.Click += new System.EventHandler(this.BTNWest_Click);
            // 
            // BTNEast
            // 
            this.BTNEast.Enabled = false;
            this.BTNEast.Location = new System.Drawing.Point(127, 88);
            this.BTNEast.Name = "BTNEast";
            this.BTNEast.Size = new System.Drawing.Size(75, 34);
            this.BTNEast.TabIndex = 2;
            this.BTNEast.Text = "East";
            this.BTNEast.UseVisualStyleBackColor = true;
            // 
            // BTNSouth
            // 
            this.BTNSouth.Location = new System.Drawing.Point(74, 128);
            this.BTNSouth.Name = "BTNSouth";
            this.BTNSouth.Size = new System.Drawing.Size(75, 31);
            this.BTNSouth.TabIndex = 1;
            this.BTNSouth.Text = "South";
            this.BTNSouth.UseVisualStyleBackColor = true;
            this.BTNSouth.Click += new System.EventHandler(this.BTNSouth_Click);
            // 
            // GBInfoEast
            // 
            this.GBInfoEast.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GBInfoEast.Controls.Add(this.TBRoomDesEast);
            this.GBInfoEast.Controls.Add(this.LABRoomDesEast);
            this.GBInfoEast.Controls.Add(this.TBRoomInfoEast);
            this.GBInfoEast.Controls.Add(this.LABRoomEast);
            this.GBInfoEast.Location = new System.Drawing.Point(1474, 62);
            this.GBInfoEast.Name = "GBInfoEast";
            this.GBInfoEast.Size = new System.Drawing.Size(540, 548);
            this.GBInfoEast.TabIndex = 3;
            this.GBInfoEast.TabStop = false;
            this.GBInfoEast.Text = "Location Information";
            // 
            // TBRoomDesEast
            // 
            this.TBRoomDesEast.Location = new System.Drawing.Point(39, 143);
            this.TBRoomDesEast.Multiline = true;
            this.TBRoomDesEast.Name = "TBRoomDesEast";
            this.TBRoomDesEast.ReadOnly = true;
            this.TBRoomDesEast.Size = new System.Drawing.Size(472, 367);
            this.TBRoomDesEast.TabIndex = 3;
            this.TBRoomDesEast.Text = resources.GetString("TBRoomDesEast.Text");
            // 
            // LABRoomDesEast
            // 
            this.LABRoomDesEast.AutoSize = true;
            this.LABRoomDesEast.Location = new System.Drawing.Point(35, 120);
            this.LABRoomDesEast.Name = "LABRoomDesEast";
            this.LABRoomDesEast.Size = new System.Drawing.Size(136, 20);
            this.LABRoomDesEast.TabIndex = 2;
            this.LABRoomDesEast.Text = "Room Description";
            // 
            // TBRoomInfoEast
            // 
            this.TBRoomInfoEast.Location = new System.Drawing.Point(39, 63);
            this.TBRoomInfoEast.Name = "TBRoomInfoEast";
            this.TBRoomInfoEast.ReadOnly = true;
            this.TBRoomInfoEast.Size = new System.Drawing.Size(185, 26);
            this.TBRoomInfoEast.TabIndex = 1;
            this.TBRoomInfoEast.Text = "Kitchen";
            // 
            // LABRoomEast
            // 
            this.LABRoomEast.AutoSize = true;
            this.LABRoomEast.Location = new System.Drawing.Point(35, 40);
            this.LABRoomEast.Name = "LABRoomEast";
            this.LABRoomEast.Size = new System.Drawing.Size(98, 20);
            this.LABRoomEast.TabIndex = 0;
            this.LABRoomEast.Text = "Room Name";
            // 
            // BTNMain
            // 
            this.BTNMain.Location = new System.Drawing.Point(835, 62);
            this.BTNMain.Name = "BTNMain";
            this.BTNMain.Size = new System.Drawing.Size(88, 41);
            this.BTNMain.TabIndex = 4;
            this.BTNMain.Text = "Main";
            this.BTNMain.UseVisualStyleBackColor = true;
            this.BTNMain.Click += new System.EventHandler(this.BTNMain_Click);
            // 
            // BTNNorth
            // 
            this.BTNNorth.Location = new System.Drawing.Point(73, 51);
            this.BTNNorth.Name = "BTNNorth";
            this.BTNNorth.Size = new System.Drawing.Size(76, 31);
            this.BTNNorth.TabIndex = 4;
            this.BTNNorth.Text = "North";
            this.BTNNorth.UseVisualStyleBackColor = true;
            this.BTNNorth.Click += new System.EventHandler(this.BTNNorth_Click);
            // 
            // FRMEast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Moonbase.Properties.Resources.Kitchen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2026, 968);
            this.Controls.Add(this.BTNMain);
            this.Controls.Add(this.GBInfoEast);
            this.Controls.Add(this.GBNav);
            this.Name = "FRMEast";
            this.Text = "Moonbase Zero!";
            this.GBNav.ResumeLayout(false);
            this.GBInfoEast.ResumeLayout(false);
            this.GBInfoEast.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBNav;
        private System.Windows.Forms.Button BTNWest;
        private System.Windows.Forms.Button BTNEast;
        private System.Windows.Forms.Button BTNSouth;
        private System.Windows.Forms.GroupBox GBInfoEast;
        private System.Windows.Forms.TextBox TBRoomDesEast;
        private System.Windows.Forms.Label LABRoomDesEast;
        private System.Windows.Forms.TextBox TBRoomInfoEast;
        private System.Windows.Forms.Label LABRoomEast;
        private System.Windows.Forms.Button BTNMain;
        private System.Windows.Forms.Button BTNNorth;
    }
}