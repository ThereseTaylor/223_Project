
namespace Pukki_Rental
{
    partial class frmTown
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
            this.dbViewTown = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteTown = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbTownID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbTownName = new System.Windows.Forms.TextBox();
            this.btnClientTown = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbViewTown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbViewTown
            // 
            this.dbViewTown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbViewTown.Location = new System.Drawing.Point(13, 13);
            this.dbViewTown.Name = "dbViewTown";
            this.dbViewTown.Size = new System.Drawing.Size(775, 150);
            this.dbViewTown.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteTown);
            this.groupBox1.Location = new System.Drawing.Point(13, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Client Town";
            // 
            // btnDeleteTown
            // 
            this.btnDeleteTown.Location = new System.Drawing.Point(6, 42);
            this.btnDeleteTown.Name = "btnDeleteTown";
            this.btnDeleteTown.Size = new System.Drawing.Size(188, 23);
            this.btnDeleteTown.TabIndex = 0;
            this.btnDeleteTown.Text = "Delete";
            this.btnDeleteTown.UseVisualStyleBackColor = true;
            this.btnDeleteTown.Click += new System.EventHandler(this.btnDeleteTown_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClientTown);
            this.groupBox2.Controls.Add(this.txtbTownName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtbTownID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(241, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 268);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Client Town";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Town ID :";
            // 
            // txtbTownID
            // 
            this.txtbTownID.Location = new System.Drawing.Point(90, 26);
            this.txtbTownID.Name = "txtbTownID";
            this.txtbTownID.Size = new System.Drawing.Size(100, 20);
            this.txtbTownID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Town Name :";
            // 
            // txtbTownName
            // 
            this.txtbTownName.Location = new System.Drawing.Point(87, 70);
            this.txtbTownName.Name = "txtbTownName";
            this.txtbTownName.Size = new System.Drawing.Size(100, 20);
            this.txtbTownName.TabIndex = 3;
            // 
            // btnClientTown
            // 
            this.btnClientTown.Location = new System.Drawing.Point(13, 114);
            this.btnClientTown.Name = "btnClientTown";
            this.btnClientTown.Size = new System.Drawing.Size(188, 23);
            this.btnClientTown.TabIndex = 3;
            this.btnClientTown.Text = "Add Client Town";
            this.btnClientTown.UseVisualStyleBackColor = true;
            this.btnClientTown.Click += new System.EventHandler(this.btnClientTown_Click);
            // 
            // frmTown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dbViewTown);
            this.Name = "frmTown";
            this.Text = "frmTown";
            this.Load += new System.EventHandler(this.frmTown_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbViewTown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbViewTown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteTown;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClientTown;
        private System.Windows.Forms.TextBox txtbTownName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbTownID;
        private System.Windows.Forms.Label label1;
    }
}