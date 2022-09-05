namespace Pukki_Rental
{
    partial class frmRentOut
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
            this.dgRentOut = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgVehicle = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgRentOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRentOut
            // 
            this.dgRentOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgRentOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRentOut.ColumnHeadersVisible = false;
            this.dgRentOut.Location = new System.Drawing.Point(52, 120);
            this.dgRentOut.Name = "dgRentOut";
            this.dgRentOut.Size = new System.Drawing.Size(823, 313);
            this.dgRentOut.TabIndex = 0;
            this.dgRentOut.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRentOut_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Double click on the client that is renting:";
            // 
            // cmbxType
            // 
            this.cmbxType.FormattingEnabled = true;
            this.cmbxType.Location = new System.Drawing.Point(248, 52);
            this.cmbxType.Name = "cmbxType";
            this.cmbxType.Size = new System.Drawing.Size(121, 21);
            this.cmbxType.TabIndex = 4;
            this.cmbxType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // dgVehicle
            // 
            this.dgVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVehicle.Location = new System.Drawing.Point(52, 120);
            this.dgVehicle.Name = "dgVehicle";
            this.dgVehicle.Size = new System.Drawing.Size(504, 313);
            this.dgVehicle.TabIndex = 7;
            this.dgVehicle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVehicle_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "How long will the client be renting the vehicle:";
            // 
            // frmRentOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 559);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgVehicle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbxType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgRentOut);
            this.Name = "frmRentOut";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRentOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRentOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRentOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgVehicle;
        private System.Windows.Forms.Label label4;
    }
}