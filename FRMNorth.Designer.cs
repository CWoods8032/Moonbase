namespace Moonbase
{
    partial class FRMNorth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMNorth));
            this.GBInfoNorth = new System.Windows.Forms.GroupBox();
            this.TBRoomDesNorth = new System.Windows.Forms.TextBox();
            this.LABRoomDesNorth = new System.Windows.Forms.Label();
            this.TBRoomInfoNorth = new System.Windows.Forms.TextBox();
            this.LABRoomNorth = new System.Windows.Forms.Label();
            this.GBNav = new System.Windows.Forms.GroupBox();
            this.BTNWest = new System.Windows.Forms.Button();
            this.BTNEast = new System.Windows.Forms.Button();
            this.BTNSouth = new System.Windows.Forms.Button();
            this.BTNMain = new System.Windows.Forms.Button();
            this.BTNNorth = new System.Windows.Forms.Button();
            this.GBInfoNorth.SuspendLayout();
            this.GBNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBInfoNorth
            // 
            this.GBInfoNorth.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GBInfoNorth.Controls.Add(this.TBRoomDesNorth);
            this.GBInfoNorth.Controls.Add(this.LABRoomDesNorth);
            this.GBInfoNorth.Controls.Add(this.TBRoomInfoNorth);
            this.GBInfoNorth.Controls.Add(this.LABRoomNorth);
            this.GBInfoNorth.Location = new System.Drawing.Point(1474, 62);
            this.GBInfoNorth.Name = "GBInfoNorth";
            this.GBInfoNorth.Size = new System.Drawing.Size(540, 548);
            this.GBInfoNorth.TabIndex = 0;
            this.GBInfoNorth.TabStop = false;
            this.GBInfoNorth.Text = "Location Information";
            // 
            // TBRoomDesNorth
            // 
            this.TBRoomDesNorth.Location = new System.Drawing.Point(39, 143);
            this.TBRoomDesNorth.Multiline = true;
            this.TBRoomDesNorth.Name = "TBRoomDesNorth";
            this.TBRoomDesNorth.ReadOnly = true;
            this.TBRoomDesNorth.Size = new System.Drawing.Size(472, 367);
            this.TBRoomDesNorth.TabIndex = 3;
            this.TBRoomDesNorth.Text = resources.GetString("TBRoomDesNorth.Text");
            // 
            // LABRoomDesNorth
            // 
            this.LABRoomDesNorth.AutoSize = true;
            this.LABRoomDesNorth.Location = new System.Drawing.Point(35, 120);
            this.LABRoomDesNorth.Name = "LABRoomDesNorth";
            this.LABRoomDesNorth.Size = new System.Drawing.Size(136, 20);
            this.LABRoomDesNorth.TabIndex = 2;
            this.LABRoomDesNorth.Text = "Room Description";
            // 
            // TBRoomInfoNorth
            // 
            this.TBRoomInfoNorth.Location = new System.Drawing.Point(39, 63);
            this.TBRoomInfoNorth.Name = "TBRoomInfoNorth";
            this.TBRoomInfoNorth.ReadOnly = true;
            this.TBRoomInfoNorth.Size = new System.Drawing.Size(185, 26);
            this.TBRoomInfoNorth.TabIndex = 1;
            this.TBRoomInfoNorth.Text = "Living Quarters";
            // 
            // LABRoomNorth
            // 
            this.LABRoomNorth.AutoSize = true;
            this.LABRoomNorth.Location = new System.Drawing.Point(35, 40);
            this.LABRoomNorth.Name = "LABRoomNorth";
            this.LABRoomNorth.Size = new System.Drawing.Size(98, 20);
            this.LABRoomNorth.TabIndex = 0;
            this.LABRoomNorth.Text = "Room Name";
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
            this.BTNEast.Location = new System.Drawing.Point(127, 88);
            this.BTNEast.Name = "BTNEast";
            this.BTNEast.Size = new System.Drawing.Size(75, 34);
            this.BTNEast.TabIndex = 2;
            this.BTNEast.Text = "East";
            this.BTNEast.UseVisualStyleBackColor = true;
            this.BTNEast.Click += new System.EventHandler(this.BTNEast_Click);
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
            // BTNMain
            // 
            this.BTNMain.Location = new System.Drawing.Point(835, 62);
            this.BTNMain.Name = "BTNMain";
            this.BTNMain.Size = new System.Drawing.Size(88, 41);
            this.BTNMain.TabIndex = 3;
            this.BTNMain.Text = "Main";
            this.BTNMain.UseVisualStyleBackColor = true;
            this.BTNMain.Click += new System.EventHandler(this.BTNMain_Click);
            // 
            // BTNNorth
            // 
            this.BTNNorth.Enabled = false;
            this.BTNNorth.Location = new System.Drawing.Point(74, 49);
            this.BTNNorth.Name = "BTNNorth";
            this.BTNNorth.Size = new System.Drawing.Size(75, 33);
            this.BTNNorth.TabIndex = 4;
            this.BTNNorth.Text = "North";
            this.BTNNorth.UseVisualStyleBackColor = true;
            // 
            // FRMNorth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Moonbase.Properties.Resources.livingquarters;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2026, 968);
            this.Controls.Add(this.BTNMain);
            this.Controls.Add(this.GBNav);
            this.Controls.Add(this.GBInfoNorth);
            this.Name = "FRMNorth";
            this.Text = "Moonbase Zero!";
            this.GBInfoNorth.ResumeLayout(false);
            this.GBInfoNorth.PerformLayout();
            this.GBNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBInfoNorth;
        private System.Windows.Forms.TextBox TBRoomInfoNorth;
        private System.Windows.Forms.Label LABRoomNorth;
        private System.Windows.Forms.TextBox TBRoomDesNorth;
        private System.Windows.Forms.Label LABRoomDesNorth;
        private System.Windows.Forms.GroupBox GBNav;
        private System.Windows.Forms.Button BTNWest;
        private System.Windows.Forms.Button BTNEast;
        private System.Windows.Forms.Button BTNSouth;
        private System.Windows.Forms.Button BTNMain;
        private System.Windows.Forms.Button BTNNorth;
    }
}