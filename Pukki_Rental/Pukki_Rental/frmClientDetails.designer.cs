
namespace Pukki_Rental
{
    partial class frmClientDetails
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
            this.dbViewClient = new System.Windows.Forms.DataGridView();
            this.gbaddClient = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbClientTelNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbClientIDNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbViewClient)).BeginInit();
            this.gbaddClient.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbViewClient
            // 
            this.dbViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbViewClient.Location = new System.Drawing.Point(12, 12);
            this.dbViewClient.Name = "dbViewClient";
            this.dbViewClient.Size = new System.Drawing.Size(776, 150);
            this.dbViewClient.TabIndex = 0;
            // 
            // gbaddClient
            // 
            this.gbaddClient.Controls.Add(this.comboBox1);
            this.gbaddClient.Controls.Add(this.btnAdd);
            this.gbaddClient.Controls.Add(this.label6);
            this.gbaddClient.Controls.Add(this.txtbEmail);
            this.gbaddClient.Controls.Add(this.label5);
            this.gbaddClient.Controls.Add(this.txtbClientTelNumber);
            this.gbaddClient.Controls.Add(this.label4);
            this.gbaddClient.Controls.Add(this.txtbClientIDNumber);
            this.gbaddClient.Controls.Add(this.label3);
            this.gbaddClient.Controls.Add(this.txtbFirstName);
            this.gbaddClient.Controls.Add(this.label2);
            this.gbaddClient.Controls.Add(this.txtbLastName);
            this.gbaddClient.Controls.Add(this.label1);
            this.gbaddClient.Location = new System.Drawing.Point(12, 181);
            this.gbaddClient.Name = "gbaddClient";
            this.gbaddClient.Size = new System.Drawing.Size(253, 317);
            this.gbaddClient.TabIndex = 1;
            this.gbaddClient.TabStop = false;
            this.gbaddClient.Text = "Add a New Client";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(139, 238);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(35, 278);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(189, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add Client";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Client Address:";
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(139, 199);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(100, 20);
            this.txtbEmail.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Client Email:";
            // 
            // txtbClientTelNumber
            // 
            this.txtbClientTelNumber.Location = new System.Drawing.Point(139, 159);
            this.txtbClientTelNumber.Name = "txtbClientTelNumber";
            this.txtbClientTelNumber.Size = new System.Drawing.Size(100, 20);
            this.txtbClientTelNumber.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Client Telephone Number:";
            // 
            // txtbClientIDNumber
            // 
            this.txtbClientIDNumber.Location = new System.Drawing.Point(139, 112);
            this.txtbClientIDNumber.Name = "txtbClientIDNumber";
            this.txtbClientIDNumber.Size = new System.Drawing.Size(100, 20);
            this.txtbClientIDNumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Client ID Number:";
            // 
            // txtbFirstName
            // 
            this.txtbFirstName.Location = new System.Drawing.Point(139, 69);
            this.txtbFirstName.Name = "txtbFirstName";
            this.txtbFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtbFirstName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client First Name:";
            // 
            // txtbLastName
            // 
            this.txtbLastName.Location = new System.Drawing.Point(139, 26);
            this.txtbLastName.Name = "txtbLastName";
            this.txtbLastName.Size = new System.Drawing.Size(100, 20);
            this.txtbLastName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Last Name:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(23, 44);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(189, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(548, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Selected Client";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(300, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Selected Client";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmClientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbaddClient);
            this.Controls.Add(this.dbViewClient);
            this.Name = "frmClientDetails";
            this.Load += new System.EventHandler(this.frmClientDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbViewClient)).EndInit();
            this.gbaddClient.ResumeLayout(false);
            this.gbaddClient.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbViewClient;
        private System.Windows.Forms.GroupBox gbaddClient;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbClientTelNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbClientIDNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}