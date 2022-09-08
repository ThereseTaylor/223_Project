
namespace Pukki_Rental
{
    partial class frmAddress
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
            this.dbViewAddress = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbAddressID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbTownID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbStreetNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbStreetName = new System.Windows.Forms.TextBox();
            this.btnClientAddress = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbViewAddress)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbViewAddress
            // 
            this.dbViewAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbViewAddress.Location = new System.Drawing.Point(13, 13);
            this.dbViewAddress.Name = "dbViewAddress";
            this.dbViewAddress.Size = new System.Drawing.Size(775, 150);
            this.dbViewAddress.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(13, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Client Address";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 44);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(188, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClientAddress);
            this.groupBox2.Controls.Add(this.txtbStreetName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtbStreetNumber);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtbTownID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtbAddressID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(239, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 268);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Client Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address ID : ";
            // 
            // txtbAddressID
            // 
            this.txtbAddressID.Location = new System.Drawing.Point(87, 25);
            this.txtbAddressID.Name = "txtbAddressID";
            this.txtbAddressID.Size = new System.Drawing.Size(100, 20);
            this.txtbAddressID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Town ID :";
            // 
            // txtbTownID
            // 
            this.txtbTownID.Location = new System.Drawing.Point(87, 68);
            this.txtbTownID.Name = "txtbTownID";
            this.txtbTownID.Size = new System.Drawing.Size(100, 20);
            this.txtbTownID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Street Number :";
            // 
            // txtbStreetNumber
            // 
            this.txtbStreetNumber.Location = new System.Drawing.Point(87, 112);
            this.txtbStreetNumber.Name = "txtbStreetNumber";
            this.txtbStreetNumber.Size = new System.Drawing.Size(100, 20);
            this.txtbStreetNumber.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Street Name :";
            // 
            // txtbStreetName
            // 
            this.txtbStreetName.Location = new System.Drawing.Point(87, 151);
            this.txtbStreetName.Name = "txtbStreetName";
            this.txtbStreetName.Size = new System.Drawing.Size(100, 20);
            this.txtbStreetName.TabIndex = 7;
            // 
            // btnClientAddress
            // 
            this.btnClientAddress.Location = new System.Drawing.Point(9, 211);
            this.btnClientAddress.Name = "btnClientAddress";
            this.btnClientAddress.Size = new System.Drawing.Size(188, 23);
            this.btnClientAddress.TabIndex = 8;
            this.btnClientAddress.Text = "Add Client Address";
            this.btnClientAddress.UseVisualStyleBackColor = true;
            this.btnClientAddress.Click += new System.EventHandler(this.btnClientAddress_Click);
            // 
            // frmAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dbViewAddress);
            this.Name = "frmAddress";
            this.Text = "frmAddress";
            this.Load += new System.EventHandler(this.frmAddress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbViewAddress)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbViewAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClientAddress;
        private System.Windows.Forms.TextBox txtbStreetName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbStreetNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbTownID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbAddressID;
        private System.Windows.Forms.Label label1;
    }
}