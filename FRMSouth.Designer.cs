namespace Moonbase
{
    partial class FRMSouth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMSouth));
            this.GBNav = new System.Windows.Forms.GroupBox();
            this.BTNWest = new System.Windows.Forms.Button();
            this.BTNEast = new System.Windows.Forms.Button();
            this.BTNSouth = new System.Windows.Forms.Button();
            this.BTNNorth = new System.Windows.Forms.Button();
            this.GBInfoSouth = new System.Windows.Forms.GroupBox();
            this.TBRoomDesSouth = new System.Windows.Forms.TextBox();
            this.LABRoomDesSouth = new System.Windows.Forms.Label();
            this.TBRoomInfoSouth = new System.Windows.Forms.TextBox();
            this.LABRoomSouth = new System.Windows.Forms.Label();
            this.BTNMain = new System.Windows.Forms.Button();
            this.GBNav.SuspendLayout();
            this.GBInfoSouth.SuspendLayout();
            this.SuspendLayout();
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
            this.GBNav.Size = new System.Drawing.Size(260, 199);
            this.GBNav.TabIndex = 3;
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
            this.BTNSouth.Enabled = false;
            this.BTNSouth.Location = new System.Drawing.Point(92, 143);
            this.BTNSouth.Name = "BTNSouth";
            this.BTNSouth.Size = new System.Drawing.Size(75, 31);
            this.BTNSouth.TabIndex = 1;
            this.BTNSouth.Text = "South";
            this.BTNSouth.UseVisualStyleBackColor = true;
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
            // GBInfoSouth
            // 
            this.GBInfoSouth.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GBInfoSouth.Controls.Add(this.TBRoomDesSouth);
            this.GBInfoSouth.Controls.Add(this.LABRoomDesSouth);
            this.GBInfoSouth.Controls.Add(this.TBRoomInfoSouth);
            this.GBInfoSouth.Controls.Add(this.LABRoomSouth);
            this.GBInfoSouth.Location = new System.Drawing.Point(1474, 62);
            this.GBInfoSouth.Name = "GBInfoSouth";
            this.GBInfoSouth.Size = new System.Drawing.Size(540, 548);
            this.GBInfoSouth.TabIndex = 4;
            this.GBInfoSouth.TabStop = false;
            this.GBInfoSouth.Text = "Location Information";
            // 
            // TBRoomDesSouth
            // 
            this.TBRoomDesSouth.Location = new System.Drawing.Point(39, 143);
            this.TBRoomDesSouth.Multiline = true;
            this.TBRoomDesSouth.Name = "TBRoomDesSouth";
            this.TBRoomDesSouth.ReadOnly = true;
            this.TBRoomDesSouth.Size = new System.Drawing.Size(472, 367);
            this.TBRoomDesSouth.TabIndex = 3;
            this.TBRoomDesSouth.Text = resources.GetString("TBRoomDesSouth.Text");
            // 
            // LABRoomDesSouth
            // 
            this.LABRoomDesSouth.AutoSize = true;
            this.LABRoomDesSouth.Location = new System.Drawing.Point(35, 120);
            this.LABRoomDesSouth.Name = "LABRoomDesSouth";
            this.LABRoomDesSouth.Size = new System.Drawing.Size(136, 20);
            this.LABRoomDesSouth.TabIndex = 2;
            this.LABRoomDesSouth.Text = "Room Description";
            // 
            // TBRoomInfoSouth
            // 
            this.TBRoomInfoSouth.Location = new System.Drawing.Point(39, 63);
            this.TBRoomInfoSouth.Name = "TBRoomInfoSouth";
            this.TBRoomInfoSouth.ReadOnly = true;
            this.TBRoomInfoSouth.Size = new System.Drawing.Size(185, 26);
            this.TBRoomInfoSouth.TabIndex = 1;
            this.TBRoomInfoSouth.Text = "Main Entrance";
            // 
            // LABRoomSouth
            // 
            this.LABRoomSouth.AutoSize = true;
            this.LABRoomSouth.Location = new System.Drawing.Point(35, 40);
            this.LABRoomSouth.Name = "LABRoomSouth";
            this.LABRoomSouth.Size = new System.Drawing.Size(98, 20);
            this.LABRoomSouth.TabIndex = 0;
            this.LABRoomSouth.Text = "Room Name";
            // 
            // BTNMain
            // 
            this.BTNMain.Location = new System.Drawing.Point(91, 88);
            this.BTNMain.Name = "BTNMain";
            this.BTNMain.Size = new System.Drawing.Size(75, 34);
            this.BTNMain.TabIndex = 5;
            this.BTNMain.Text = "Main";
            this.BTNMain.UseVisualStyleBackColor = true;
            this.BTNMain.Click += new System.EventHandler(this.BTNMain_Click);
            // 
            // FRMSouth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Moonbase.Properties.Resources.Moonbaseentrance;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2026, 968);
            this.Controls.Add(this.GBInfoSouth);
            this.Controls.Add(this.GBNav);
            this.Name = "FRMSouth";
            this.Text = "Moonbase Zero!";
            this.GBNav.ResumeLayout(false);
            this.GBInfoSouth.ResumeLayout(false);
            this.GBInfoSouth.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBNav;
        private System.Windows.Forms.Button BTNWest;
        private System.Windows.Forms.Button BTNEast;
        private System.Windows.Forms.Button BTNSouth;
        private System.Windows.Forms.Button BTNNorth;
        private System.Windows.Forms.GroupBox GBInfoSouth;
        private System.Windows.Forms.TextBox TBRoomDesSouth;
        private System.Windows.Forms.Label LABRoomDesSouth;
        private System.Windows.Forms.TextBox TBRoomInfoSouth;
        private System.Windows.Forms.Label LABRoomSouth;
        private System.Windows.Forms.Button BTNMain;
    }
}