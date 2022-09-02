namespace Pukki_Rental
{
    partial class frmVehicleInfo
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
            this.dgVehicleInfo = new System.Windows.Forms.DataGridView();
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoChange = new System.Windows.Forms.RadioButton();
            this.rdoDelete = new System.Windows.Forms.RadioButton();
            this.rdoAdd = new System.Windows.Forms.RadioButton();
            this.btnExecute = new System.Windows.Forms.Button();
            this.cmbChange = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVehicleInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgVehicleInfo
            // 
            this.dgVehicleInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVehicleInfo.Location = new System.Drawing.Point(12, 12);
            this.dgVehicleInfo.Name = "dgVehicleInfo";
            this.dgVehicleInfo.RowHeadersWidth = 51;
            this.dgVehicleInfo.RowTemplate.Height = 24;
            this.dgVehicleInfo.Size = new System.Drawing.Size(737, 490);
            this.dgVehicleInfo.TabIndex = 0;
            // 
            // cmbTable
            // 
            this.cmbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Items.AddRange(new object[] {
            "Vehicle",
            "Model",
            "Type",
            "Colour"});
            this.cmbTable.Location = new System.Drawing.Point(794, 35);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(166, 28);
            this.cmbTable.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoChange);
            this.groupBox1.Controls.Add(this.rdoDelete);
            this.groupBox1.Controls.Add(this.rdoAdd);
            this.groupBox1.Location = new System.Drawing.Point(794, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 151);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functions";
            // 
            // rdoChange
            // 
            this.rdoChange.AutoSize = true;
            this.rdoChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoChange.Location = new System.Drawing.Point(24, 66);
            this.rdoChange.Name = "rdoChange";
            this.rdoChange.Size = new System.Drawing.Size(87, 24);
            this.rdoChange.TabIndex = 3;
            this.rdoChange.TabStop = true;
            this.rdoChange.Text = "Change";
            this.rdoChange.UseVisualStyleBackColor = true;
            this.rdoChange.CheckedChanged += new System.EventHandler(this.rdoChange_CheckedChanged);
            // 
            // rdoDelete
            // 
            this.rdoDelete.AutoSize = true;
            this.rdoDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoDelete.Location = new System.Drawing.Point(24, 96);
            this.rdoDelete.Name = "rdoDelete";
            this.rdoDelete.Size = new System.Drawing.Size(79, 24);
            this.rdoDelete.TabIndex = 2;
            this.rdoDelete.TabStop = true;
            this.rdoDelete.Text = "Delete";
            this.rdoDelete.UseVisualStyleBackColor = true;
            // 
            // rdoAdd
            // 
            this.rdoAdd.AutoSize = true;
            this.rdoAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoAdd.Location = new System.Drawing.Point(24, 36);
            this.rdoAdd.Name = "rdoAdd";
            this.rdoAdd.Size = new System.Drawing.Size(59, 24);
            this.rdoAdd.TabIndex = 0;
            this.rdoAdd.TabStop = true;
            this.rdoAdd.Text = "Add";
            this.rdoAdd.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(794, 413);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(166, 89);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // cmbChange
            // 
            this.cmbChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbChange.FormattingEnabled = true;
            this.cmbChange.Location = new System.Drawing.Point(794, 300);
            this.cmbChange.Name = "cmbChange";
            this.cmbChange.Size = new System.Drawing.Size(166, 28);
            this.cmbChange.TabIndex = 4;
            this.cmbChange.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(790, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data type";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblChange.Location = new System.Drawing.Point(790, 277);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(95, 20);
            this.lblChange.TabIndex = 4;
            this.lblChange.Text = "Data option";
            this.lblChange.Visible = false;
            // 
            // frmVehicleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 514);
            this.ControlBox = false;
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbChange);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbTable);
            this.Controls.Add(this.dgVehicleInfo);
            this.Name = "frmVehicleInfo";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVehicleInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVehicleInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVehicleInfo;
        private System.Windows.Forms.ComboBox cmbTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoDelete;
        private System.Windows.Forms.RadioButton rdoAdd;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.ComboBox cmbChange;
        private System.Windows.Forms.RadioButton rdoChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChange;
    }
}