namespace Pukki_Rental
{
    partial class frmWelcome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.welcomePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentAVehicleOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiveVehicleBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleModelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.townToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.townToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomePageToolStripMenuItem,
            this.rentAVehicleOutToolStripMenuItem,
            this.receiveVehicleBackToolStripMenuItem,
            this.vehicleInformationToolStripMenuItem,
            this.clientInformationToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // welcomePageToolStripMenuItem
            // 
            this.welcomePageToolStripMenuItem.Name = "welcomePageToolStripMenuItem";
            this.welcomePageToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.welcomePageToolStripMenuItem.Text = "Welcome Page";
            // 
            // rentAVehicleOutToolStripMenuItem
            // 
            this.rentAVehicleOutToolStripMenuItem.Name = "rentAVehicleOutToolStripMenuItem";
            this.rentAVehicleOutToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.rentAVehicleOutToolStripMenuItem.Text = "Rent Out a Vehicle ";
            this.rentAVehicleOutToolStripMenuItem.Click += new System.EventHandler(this.rentAVehicleOutToolStripMenuItem_Click);
            // 
            // receiveVehicleBackToolStripMenuItem
            // 
            this.receiveVehicleBackToolStripMenuItem.Name = "receiveVehicleBackToolStripMenuItem";
            this.receiveVehicleBackToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.receiveVehicleBackToolStripMenuItem.Text = "Receive a Vehicle Back";
            this.receiveVehicleBackToolStripMenuItem.Click += new System.EventHandler(this.receiveVehicleBackToolStripMenuItem_Click);
            // 
            // vehicleInformationToolStripMenuItem
            // 
            this.vehicleInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleTypeToolStripMenuItem,
            this.vehicleColourToolStripMenuItem,
            this.vehicleModelToolStripMenuItem1});
            this.vehicleInformationToolStripMenuItem.Name = "vehicleInformationToolStripMenuItem";
            this.vehicleInformationToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.vehicleInformationToolStripMenuItem.Text = "Vehicle Information";
            this.vehicleInformationToolStripMenuItem.Click += new System.EventHandler(this.vehicleInformationToolStripMenuItem_Click);
            // 
            // vehicleTypeToolStripMenuItem
            // 
            this.vehicleTypeToolStripMenuItem.Name = "vehicleTypeToolStripMenuItem";
            this.vehicleTypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vehicleTypeToolStripMenuItem.Text = "Vehicle Type";
            // 
            // vehicleColourToolStripMenuItem
            // 
            this.vehicleColourToolStripMenuItem.Name = "vehicleColourToolStripMenuItem";
            this.vehicleColourToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vehicleColourToolStripMenuItem.Text = "Vehicle Colour";
            // 
            // vehicleModelToolStripMenuItem1
            // 
            this.vehicleModelToolStripMenuItem1.Name = "vehicleModelToolStripMenuItem1";
            this.vehicleModelToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.vehicleModelToolStripMenuItem1.Text = "Vehicle Model";
            // 
            // clientInformationToolStripMenuItem
            // 
            this.clientInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientListToolStripMenuItem,
            this.townToolStripMenuItem,
            this.townToolStripMenuItem1});
            this.clientInformationToolStripMenuItem.Name = "clientInformationToolStripMenuItem";
            this.clientInformationToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.clientInformationToolStripMenuItem.Text = "Client Information";
            this.clientInformationToolStripMenuItem.Click += new System.EventHandler(this.clientInformationToolStripMenuItem_Click);
            // 
            // clientListToolStripMenuItem
            // 
            this.clientListToolStripMenuItem.Name = "clientListToolStripMenuItem";
            this.clientListToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.clientListToolStripMenuItem.Text = "Client List";
            this.clientListToolStripMenuItem.Click += new System.EventHandler(this.clientListToolStripMenuItem_Click);
            // 
            // townToolStripMenuItem
            // 
            this.townToolStripMenuItem.Name = "townToolStripMenuItem";
            this.townToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.townToolStripMenuItem.Text = "Address";
            this.townToolStripMenuItem.Click += new System.EventHandler(this.townToolStripMenuItem_Click);
            // 
            // townToolStripMenuItem1
            // 
            this.townToolStripMenuItem1.Name = "townToolStripMenuItem1";
            this.townToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.townToolStripMenuItem1.Text = "Town";
            this.townToolStripMenuItem1.Click += new System.EventHandler(this.townToolStripMenuItem1_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmWelcome";
            this.Text = "Welcome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem welcomePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentAVehicleOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiveVehicleBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem townToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleModelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem townToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientListToolStripMenuItem;
    }
}

