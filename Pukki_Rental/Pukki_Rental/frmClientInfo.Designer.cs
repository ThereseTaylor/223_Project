namespace Pukki_Rental
{
    partial class frmClientInfo
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
            this.dgClientInfo = new System.Windows.Forms.DataGridView();
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoAdd = new System.Windows.Forms.RadioButton();
            this.rdoChange = new System.Windows.Forms.RadioButton();
            this.rdoDelete = new System.Windows.Forms.RadioButton();
            this.cmbChange = new System.Windows.Forms.ComboBox();
            this.cmBox3_DeleteVehicle = new System.Windows.Forms.ComboBox();
            this.cmbSelectID = new System.Windows.Forms.ComboBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblSelectID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgClientInfo
            // 
            this.dgClientInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientInfo.Location = new System.Drawing.Point(12, 12);
            this.dgClientInfo.Name = "dgClientInfo";
            this.dgClientInfo.Size = new System.Drawing.Size(776, 194);
            this.dgClientInfo.TabIndex = 0;
            // 
            // cmbTable
            // 
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Items.AddRange(new object[] {
            "Client",
            "Address",
            "Town"});
            this.cmbTable.Location = new System.Drawing.Point(12, 263);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(147, 21);
            this.cmbTable.TabIndex = 1;
            this.cmbTable.SelectedIndexChanged += new System.EventHandler(this.cmbTable_SelectedIndexChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoAdd);
            this.groupBox1.Controls.Add(this.rdoChange);
            this.groupBox1.Controls.Add(this.rdoDelete);
            this.groupBox1.Location = new System.Drawing.Point(12, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions:";
            // 
            // rdoAdd
            // 
            this.rdoAdd.AutoSize = true;
            this.rdoAdd.Location = new System.Drawing.Point(21, 36);
            this.rdoAdd.Name = "rdoAdd";
            this.rdoAdd.Size = new System.Drawing.Size(44, 17);
            this.rdoAdd.TabIndex = 3;
            this.rdoAdd.TabStop = true;
            this.rdoAdd.Text = "Add";
            this.rdoAdd.UseVisualStyleBackColor = true;
            this.rdoAdd.CheckedChanged += new System.EventHandler(this.rdoAdd_CheckedChanged_1);
            // 
            // rdoChange
            // 
            this.rdoChange.AutoSize = true;
            this.rdoChange.Location = new System.Drawing.Point(21, 59);
            this.rdoChange.Name = "rdoChange";
            this.rdoChange.Size = new System.Drawing.Size(62, 17);
            this.rdoChange.TabIndex = 4;
            this.rdoChange.TabStop = true;
            this.rdoChange.Text = "Change";
            this.rdoChange.UseVisualStyleBackColor = true;
            this.rdoChange.CheckedChanged += new System.EventHandler(this.rdoChange_CheckedChanged_1);
            // 
            // rdoDelete
            // 
            this.rdoDelete.AutoSize = true;
            this.rdoDelete.Location = new System.Drawing.Point(21, 82);
            this.rdoDelete.Name = "rdoDelete";
            this.rdoDelete.Size = new System.Drawing.Size(56, 17);
            this.rdoDelete.TabIndex = 5;
            this.rdoDelete.TabStop = true;
            this.rdoDelete.Text = "Delete";
            this.rdoDelete.UseVisualStyleBackColor = true;
            this.rdoDelete.CheckedChanged += new System.EventHandler(this.rdoDelete_CheckedChanged_1);
            // 
            // cmbChange
            // 
            this.cmbChange.FormattingEnabled = true;
            this.cmbChange.Location = new System.Drawing.Point(256, 338);
            this.cmbChange.Name = "cmbChange";
            this.cmbChange.Size = new System.Drawing.Size(153, 21);
            this.cmbChange.TabIndex = 3;
            this.cmbChange.SelectedIndexChanged += new System.EventHandler(this.cmbChange_SelectedIndexChanged_1);
            // 
            // cmBox3_DeleteVehicle
            // 
            this.cmBox3_DeleteVehicle.FormattingEnabled = true;
            this.cmBox3_DeleteVehicle.Location = new System.Drawing.Point(256, 335);
            this.cmBox3_DeleteVehicle.Name = "cmBox3_DeleteVehicle";
            this.cmBox3_DeleteVehicle.Size = new System.Drawing.Size(153, 21);
            this.cmBox3_DeleteVehicle.TabIndex = 4;
            // 
            // cmbSelectID
            // 
            this.cmbSelectID.FormattingEnabled = true;
            this.cmbSelectID.Location = new System.Drawing.Point(336, 385);
            this.cmbSelectID.Name = "cmbSelectID";
            this.cmbSelectID.Size = new System.Drawing.Size(73, 21);
            this.cmbSelectID.TabIndex = 5;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(667, 362);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(121, 64);
            this.btnExecute.TabIndex = 6;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data type";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(253, 303);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(62, 13);
            this.lblChange.TabIndex = 8;
            this.lblChange.Text = "Data option";
            // 
            // lblSelectID
            // 
            this.lblSelectID.AutoSize = true;
            this.lblSelectID.Location = new System.Drawing.Point(253, 389);
            this.lblSelectID.Name = "lblSelectID";
            this.lblSelectID.Size = new System.Drawing.Size(64, 13);
            this.lblSelectID.TabIndex = 9;
            this.lblSelectID.Text = "Data Option";
            // 
            // frmClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblSelectID);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.cmbSelectID);
            this.Controls.Add(this.cmBox3_DeleteVehicle);
            this.Controls.Add(this.cmbChange);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbTable);
            this.Controls.Add(this.dgClientInfo);
            this.Name = "frmClientInfo";
            this.Load += new System.EventHandler(this.frmClientInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgClientInfo;
        private System.Windows.Forms.ComboBox cmbTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoAdd;
        private System.Windows.Forms.RadioButton rdoChange;
        private System.Windows.Forms.RadioButton rdoDelete;
        private System.Windows.Forms.ComboBox cmbChange;
        private System.Windows.Forms.ComboBox cmBox3_DeleteVehicle;
        private System.Windows.Forms.ComboBox cmbSelectID;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblSelectID;
    }
}