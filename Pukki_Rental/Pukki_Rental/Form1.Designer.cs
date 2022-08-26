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
            this.vehicleModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.townToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            // 
            // receiveVehicleBackToolStripMenuItem
            // 
            this.receiveVehicleBackToolStripMenuItem.Name = "receiveVehicleBackToolStripMenuItem";
            this.receiveVehicleBackToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.receiveVehicleBackToolStripMenuItem.Text = "Receive a Vehicle Back";
            // 
            // vehicleInformationToolStripMenuItem
            // 
            this.vehicleInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleModelToolStripMenuItem,
            this.vehicleTypeToolStripMenuItem,
            this.vehicleColourToolStripMenuItem});
            this.vehicleInformationToolStripMenuItem.Name = "vehicleInformationToolStripMenuItem";
            this.vehicleInformationToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.vehicleInformationToolStripMenuItem.Text = "Vehicle Information";
            // 
            // vehicleModelToolStripMenuItem
            // 
            this.vehicleModelToolStripMenuItem.Name = "vehicleModelToolStripMenuItem";
            this.vehicleModelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vehicleModelToolStripMenuItem.Text = "Vehicle Model";
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
            // clientInformationToolStripMenuItem
            // 
            this.clientInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addressToolStripMenuItem,
            this.townToolStripMenuItem});
            this.clientInformationToolStripMenuItem.Name = "clientInformationToolStripMenuItem";
            this.clientInformationToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.clientInformationToolStripMenuItem.Text = "Client Information";
            // 
            // addressToolStripMenuItem
            // 
            this.addressToolStripMenuItem.Name = "addressToolStripMenuItem";
            this.addressToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addressToolStripMenuItem.Text = "Address";
            // 
            // townToolStripMenuItem
            // 
            this.townToolStripMenuItem.Name = "townToolStripMenuItem";
            this.townToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.townToolStripMenuItem.Text = "Town";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmWelcome";
            this.Text = "Welcome";
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
        private System.Windows.Forms.ToolStripMenuItem vehicleModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem townToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
    }
}

