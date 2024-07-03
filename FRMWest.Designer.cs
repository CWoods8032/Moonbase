namespace Moonbase
{
    partial class FRMWest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMWest));
            this.GBNav = new System.Windows.Forms.GroupBox();
            this.BTNNorth = new System.Windows.Forms.Button();
            this.BTNWest = new System.Windows.Forms.Button();
            this.BTNEast = new System.Windows.Forms.Button();
            this.BTNSouth = new System.Windows.Forms.Button();
            this.GBInfoWest = new System.Windows.Forms.GroupBox();
            this.TBRoomDesWest = new System.Windows.Forms.TextBox();
            this.LABRoomDesWest = new System.Windows.Forms.Label();
            this.TBRoomInfoWest = new System.Windows.Forms.TextBox();
            this.LABRoomWest = new System.Windows.Forms.Label();
            this.BTNMain = new System.Windows.Forms.Button();
            this.GBNav.SuspendLayout();
            this.GBInfoWest.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBNav
            // 
            this.GBNav.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GBNav.Controls.Add(this.BTNMain);
            this.GBNav.Controls.Add(this.BTNNorth);
            this.GBNav.Controls.Add(this.BTNWest);
            this.GBNav.Controls.Add(this.BTNEast);
            this.GBNav.Controls.Add(this.BTNSouth);
            this.GBNav.Location = new System.Drawing.Point(12, 62);
            this.GBNav.Name = "GBNav";
            this.GBNav.Size = new System.Drawing.Size(260, 199);
            this.GBNav.TabIndex = 2;
            this.GBNav.TabStop = false;
            this.GBNav.Text = "Personal Nav Device";
            // 
            // BTNNorth
            // 
            this.BTNNorth.Location = new System.Drawing.Point(90, 33);
            this.BTNNorth.Name = "BTNNorth";
            this.BTNNorth.Size = new System.Drawing.Size(78, 34);
            this.BTNNorth.TabIndex = 4;
            this.BTNNorth.Text = "North";
            this.BTNNorth.UseVisualStyleBackColor = true;
            this.BTNNorth.Click += new System.EventHandler(this.BTNNorth_Click);
            // 
            // BTNWest
            // 
            this.BTNWest.Enabled = false;
            this.BTNWest.Location = new System.Drawing.Point(6, 88);
            this.BTNWest.Name = "BTNWest";
            this.BTNWest.Size = new System.Drawing.Size(75, 34);
            this.BTNWest.TabIndex = 3;
            this.BTNWest.Text = "West";
            this.BTNWest.UseVisualStyleBackColor = true;
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
            // GBInfoWest
            // 
            this.GBInfoWest.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GBInfoWest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GBInfoWest.Controls.Add(this.TBRoomDesWest);
            this.GBInfoWest.Controls.Add(this.LABRoomDesWest);
            this.GBInfoWest.Controls.Add(this.TBRoomInfoWest);
            this.GBInfoWest.Controls.Add(this.LABRoomWest);
            this.GBInfoWest.Location = new System.Drawing.Point(1474, 62);
            this.GBInfoWest.Name = "GBInfoWest";
            this.GBInfoWest.Size = new System.Drawing.Size(540, 548);
            this.GBInfoWest.TabIndex = 3;
            this.GBInfoWest.TabStop = false;
            this.GBInfoWest.Text = "Location Information";
            // 
            // TBRoomDesWest
            // 
            this.TBRoomDesWest.Location = new System.Drawing.Point(39, 143);
            this.TBRoomDesWest.Multiline = true;
            this.TBRoomDesWest.Name = "TBRoomDesWest";
            this.TBRoomDesWest.ReadOnly = true;
            this.TBRoomDesWest.Size = new System.Drawing.Size(472, 367);
            this.TBRoomDesWest.TabIndex = 3;
            this.TBRoomDesWest.Text = resources.GetString("TBRoomDesWest.Text");
            // 
            // LABRoomDesWest
            // 
            this.LABRoomDesWest.AutoSize = true;
            this.LABRoomDesWest.Location = new System.Drawing.Point(35, 120);
            this.LABRoomDesWest.Name = "LABRoomDesWest";
            this.LABRoomDesWest.Size = new System.Drawing.Size(136, 20);
            this.LABRoomDesWest.TabIndex = 2;
            this.LABRoomDesWest.Text = "Room Description";
            // 
            // TBRoomInfoWest
            // 
            this.TBRoomInfoWest.Location = new System.Drawing.Point(39, 63);
            this.TBRoomInfoWest.Name = "TBRoomInfoWest";
            this.TBRoomInfoWest.ReadOnly = true;
            this.TBRoomInfoWest.Size = new System.Drawing.Size(185, 26);
            this.TBRoomInfoWest.TabIndex = 1;
            this.TBRoomInfoWest.Text = "Labratory";
            // 
            // LABRoomWest
            // 
            this.LABRoomWest.AutoSize = true;
            this.LABRoomWest.Location = new System.Drawing.Point(35, 40);
            this.LABRoomWest.Name = "LABRoomWest";
            this.LABRoomWest.Size = new System.Drawing.Size(98, 20);
            this.LABRoomWest.TabIndex = 0;
            this.LABRoomWest.Text = "Room Name";
            // 
            // BTNMain
            // 
            this.BTNMain.Location = new System.Drawing.Point(90, 88);
            this.BTNMain.Name = "BTNMain";
            this.BTNMain.Size = new System.Drawing.Size(77, 34);
            this.BTNMain.TabIndex = 4;
            this.BTNMain.Text = "Main";
            this.BTNMain.UseVisualStyleBackColor = true;
            this.BTNMain.Click += new System.EventHandler(this.BTNMain_Click);
            // 
            // FRMWest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Moonbase.Properties.Resources.Lab;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2026, 968);
            this.Controls.Add(this.GBInfoWest);
            this.Controls.Add(this.GBNav);
            this.Name = "FRMWest";
            this.Text = "Moonbase Zero!";
            this.GBNav.ResumeLayout(false);
            this.GBInfoWest.ResumeLayout(false);
            this.GBInfoWest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBNav;
        private System.Windows.Forms.Button BTNEast;
        private System.Windows.Forms.Button BTNSouth;
        private System.Windows.Forms.GroupBox GBInfoWest;
        private System.Windows.Forms.TextBox TBRoomDesWest;
        private System.Windows.Forms.Label LABRoomDesWest;
        private System.Windows.Forms.TextBox TBRoomInfoWest;
        private System.Windows.Forms.Label LABRoomWest;
        private System.Windows.Forms.Button BTNMain;
        private System.Windows.Forms.Button BTNNorth;
        private System.Windows.Forms.Button BTNWest;
    }
}