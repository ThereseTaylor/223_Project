
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
            this.btnClientTown = new System.Windows.Forms.Button();
            this.txtbTownName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbViewTown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(561, 198);
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
            this.groupBox2.Location = new System.Drawing.Point(22, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Client Town";
            // 
            // btnClientTown
            // 
            this.btnClientTown.Location = new System.Drawing.Point(13, 63);
            this.btnClientTown.Name = "btnClientTown";
            this.btnClientTown.Size = new System.Drawing.Size(188, 23);
            this.btnClientTown.TabIndex = 3;
            this.btnClientTown.Text = "Add Client Town";
            this.btnClientTown.UseVisualStyleBackColor = true;
            this.btnClientTown.Click += new System.EventHandler(this.btnClientTown_Click);
            // 
            // txtbTownName
            // 
            this.txtbTownName.Location = new System.Drawing.Point(87, 28);
            this.txtbTownName.Name = "txtbTownName";
            this.txtbTownName.Size = new System.Drawing.Size(100, 20);
            this.txtbTownName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Town Name :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(287, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Client Town";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // frmTown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dbViewTown);
            this.Name = "frmTown";
            this.Load += new System.EventHandler(this.frmTown_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbViewTown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}