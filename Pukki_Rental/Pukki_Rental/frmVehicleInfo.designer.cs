﻿namespace Pukki_Rental
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.cmbSelectID = new System.Windows.Forms.ComboBox();
            this.lblSelectID = new System.Windows.Forms.Label();
            this.cmBox3_DeleteVehicle = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgVehicleInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgVehicleInfo
            // 
            this.dgVehicleInfo.AllowUserToAddRows = false;
            this.dgVehicleInfo.AllowUserToDeleteRows = false;
            this.dgVehicleInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVehicleInfo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVehicleInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgVehicleInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVehicleInfo.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgVehicleInfo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgVehicleInfo.Location = new System.Drawing.Point(10, 11);
            this.dgVehicleInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dgVehicleInfo.Name = "dgVehicleInfo";
            this.dgVehicleInfo.ReadOnly = true;
            this.dgVehicleInfo.RowHeadersVisible = false;
            this.dgVehicleInfo.RowHeadersWidth = 51;
            this.dgVehicleInfo.RowTemplate.Height = 24;
            this.dgVehicleInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgVehicleInfo.Size = new System.Drawing.Size(771, 212);
            this.dgVehicleInfo.TabIndex = 0;
            this.dgVehicleInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVehicleInfo_CellContentClick);
            // 
            // cmbTable
            // 
            this.cmbTable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Items.AddRange(new object[] {
            "Vehicle",
            "Model",
            "Type",
            "Colour"});
            this.cmbTable.Location = new System.Drawing.Point(9, 275);
            this.cmbTable.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(126, 28);
            this.cmbTable.TabIndex = 1;
            this.cmbTable.SelectedIndexChanged += new System.EventHandler(this.cmbTable_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.rdoChange);
            this.groupBox1.Controls.Add(this.rdoDelete);
            this.groupBox1.Controls.Add(this.rdoAdd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 316);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(186, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions:";
            // 
            // rdoChange
            // 
            this.rdoChange.AutoSize = true;
            this.rdoChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChange.Location = new System.Drawing.Point(18, 54);
            this.rdoChange.Margin = new System.Windows.Forms.Padding(2);
            this.rdoChange.Name = "rdoChange";
            this.rdoChange.Size = new System.Drawing.Size(83, 24);
            this.rdoChange.TabIndex = 3;
            this.rdoChange.TabStop = true;
            this.rdoChange.Text = "Change";
            this.rdoChange.UseVisualStyleBackColor = true;
            this.rdoChange.Visible = false;
            this.rdoChange.CheckedChanged += new System.EventHandler(this.rdoChange_CheckedChanged);
            // 
            // rdoDelete
            // 
            this.rdoDelete.AutoSize = true;
            this.rdoDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDelete.Location = new System.Drawing.Point(18, 78);
            this.rdoDelete.Margin = new System.Windows.Forms.Padding(2);
            this.rdoDelete.Name = "rdoDelete";
            this.rdoDelete.Size = new System.Drawing.Size(74, 24);
            this.rdoDelete.TabIndex = 2;
            this.rdoDelete.TabStop = true;
            this.rdoDelete.Text = "Delete";
            this.rdoDelete.UseVisualStyleBackColor = true;
            this.rdoDelete.CheckedChanged += new System.EventHandler(this.rdoDelete_CheckedChanged);
            // 
            // rdoAdd
            // 
            this.rdoAdd.AutoSize = true;
            this.rdoAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAdd.Location = new System.Drawing.Point(18, 29);
            this.rdoAdd.Margin = new System.Windows.Forms.Padding(2);
            this.rdoAdd.Name = "rdoAdd";
            this.rdoAdd.Size = new System.Drawing.Size(56, 24);
            this.rdoAdd.TabIndex = 0;
            this.rdoAdd.TabStop = true;
            this.rdoAdd.Text = "Add";
            this.rdoAdd.UseVisualStyleBackColor = true;
            this.rdoAdd.CheckedChanged += new System.EventHandler(this.rdoAdd_CheckedChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.FlatAppearance.BorderSize = 4;
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.Location = new System.Drawing.Point(660, 370);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(2);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(124, 72);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // cmbChange
            // 
            this.cmbChange.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChange.FormattingEnabled = true;
            this.cmbChange.Items.AddRange(new object[] {
            "Vehicle Colour",
            "Vehicle Registration Plate",
            "Vehicle Rental Cost"});
            this.cmbChange.Location = new System.Drawing.Point(230, 341);
            this.cmbChange.Margin = new System.Windows.Forms.Padding(2);
            this.cmbChange.Name = "cmbChange";
            this.cmbChange.Size = new System.Drawing.Size(182, 28);
            this.cmbChange.TabIndex = 4;
            this.cmbChange.Visible = false;
            this.cmbChange.SelectedIndexChanged += new System.EventHandler(this.cmbChange_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 243);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select the table to change:";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(226, 307);
            this.lblChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(220, 20);
            this.lblChange.TabIndex = 4;
            this.lblChange.Text = "Select the field to change:";
            this.lblChange.Visible = false;
            // 
            // cmbSelectID
            // 
            this.cmbSelectID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbSelectID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectID.FormattingEnabled = true;
            this.cmbSelectID.Location = new System.Drawing.Point(230, 414);
            this.cmbSelectID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelectID.Name = "cmbSelectID";
            this.cmbSelectID.Size = new System.Drawing.Size(69, 28);
            this.cmbSelectID.TabIndex = 6;
            this.cmbSelectID.Visible = false;
            // 
            // lblSelectID
            // 
            this.lblSelectID.AutoSize = true;
            this.lblSelectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectID.Location = new System.Drawing.Point(226, 380);
            this.lblSelectID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectID.Name = "lblSelectID";
            this.lblSelectID.Size = new System.Drawing.Size(209, 20);
            this.lblSelectID.TabIndex = 7;
            this.lblSelectID.Text = "Select the client number:";
            this.lblSelectID.Visible = false;
            // 
            // cmBox3_DeleteVehicle
            // 
            this.cmBox3_DeleteVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBox3_DeleteVehicle.FormattingEnabled = true;
            this.cmBox3_DeleteVehicle.Location = new System.Drawing.Point(230, 413);
            this.cmBox3_DeleteVehicle.Name = "cmBox3_DeleteVehicle";
            this.cmBox3_DeleteVehicle.Size = new System.Drawing.Size(94, 28);
            this.cmBox3_DeleteVehicle.TabIndex = 8;
            // 
            // frmVehicleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pukki_Rental.Properties.Resources.pngtree_plain_aesthetic_background_with_cool_wallpaper_image_914477;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(795, 453);
            this.ControlBox = false;
            this.Controls.Add(this.cmBox3_DeleteVehicle);
            this.Controls.Add(this.lblSelectID);
            this.Controls.Add(this.cmbSelectID);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbChange);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbTable);
            this.Controls.Add(this.dgVehicleInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ComboBox cmbSelectID;
        private System.Windows.Forms.Label lblSelectID;
        private System.Windows.Forms.ComboBox cmBox3_DeleteVehicle;
    }
}