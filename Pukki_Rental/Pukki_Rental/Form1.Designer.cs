namespace Pukki_Rental
{
    partial class frmWelcomePage
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
            this.ggToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiveVehicleBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.townToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.townToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomePageToolStripMenuItem,
            this.rentAVehicleOutToolStripMenuItem,
            this.receiveVehicleBackToolStripMenuItem,
            this.vehicleInformationToolStripMenuItem,
            this.clientInformationToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // welcomePageToolStripMenuItem
            // 
            this.welcomePageToolStripMenuItem.Name = "welcomePageToolStripMenuItem";
            this.welcomePageToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.welcomePageToolStripMenuItem.Text = "Welcome Page";
            this.welcomePageToolStripMenuItem.Click += new System.EventHandler(this.welcomePageToolStripMenuItem_Click);
            // 
            // rentAVehicleOutToolStripMenuItem
            // 
            this.rentAVehicleOutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ggToolStripMenuItem});
            this.rentAVehicleOutToolStripMenuItem.Name = "rentAVehicleOutToolStripMenuItem";
            this.rentAVehicleOutToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.rentAVehicleOutToolStripMenuItem.Text = "Rent Out a Vehicle ";
            this.rentAVehicleOutToolStripMenuItem.Click += new System.EventHandler(this.rentAVehicleOutToolStripMenuItem_Click);
            // 
            // ggToolStripMenuItem
            // 
            this.ggToolStripMenuItem.Name = "ggToolStripMenuItem";
            this.ggToolStripMenuItem.Size = new System.Drawing.Size(110, 26);
            this.ggToolStripMenuItem.Text = "gg";
            // 
            // receiveVehicleBackToolStripMenuItem
            // 
            this.receiveVehicleBackToolStripMenuItem.Name = "receiveVehicleBackToolStripMenuItem";
            this.receiveVehicleBackToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.receiveVehicleBackToolStripMenuItem.Text = "Receive a Vehicle Back";
            // 
            // vehicleInformationToolStripMenuItem
            // 
            this.vehicleInformationToolStripMenuItem.Name = "vehicleInformationToolStripMenuItem";
            this.vehicleInformationToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.vehicleInformationToolStripMenuItem.Text = "Vehicle Information";
            this.vehicleInformationToolStripMenuItem.Click += new System.EventHandler(this.vehicleInformationToolStripMenuItem_Click);
            // 
            // clientInformationToolStripMenuItem
            // 
            this.clientInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addressToolStripMenuItem,
            this.townToolStripMenuItem,
            this.townToolStripMenuItem1});
            this.clientInformationToolStripMenuItem.Name = "clientInformationToolStripMenuItem";
            this.clientInformationToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.clientInformationToolStripMenuItem.Text = "Client Information";
            // 
            // addressToolStripMenuItem
            // 
            this.addressToolStripMenuItem.Name = "addressToolStripMenuItem";
            this.addressToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.addressToolStripMenuItem.Text = "Client Details";
            // 
            // townToolStripMenuItem
            // 
            this.townToolStripMenuItem.Name = "townToolStripMenuItem";
            this.townToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.townToolStripMenuItem.Text = "Address";
            // 
            // townToolStripMenuItem1
            // 
            this.townToolStripMenuItem1.Name = "townToolStripMenuItem1";
            this.townToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.townToolStripMenuItem1.Text = "Town";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ToolStripMenuItem clientInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem townToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ggToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem townToolStripMenuItem1;
    }
}

