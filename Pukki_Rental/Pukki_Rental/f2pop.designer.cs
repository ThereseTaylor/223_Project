namespace Pukki_Rental
{
    partial class f2pop
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
            this.lb1_Confirm = new System.Windows.Forms.Label();
            this.btn2_Sumbit = new System.Windows.Forms.Button();
            this.btn1_Canc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1_Confirm
            // 
            this.lb1_Confirm.AutoSize = true;
            this.lb1_Confirm.Location = new System.Drawing.Point(76, 50);
            this.lb1_Confirm.Name = "lb1_Confirm";
            this.lb1_Confirm.Size = new System.Drawing.Size(268, 16);
            this.lb1_Confirm.TabIndex = 0;
            this.lb1_Confirm.Text = "Are you sure you want to delete this recored ";
            // 
            // btn2_Sumbit
            // 
            this.btn2_Sumbit.Location = new System.Drawing.Point(460, 176);
            this.btn2_Sumbit.Name = "btn2_Sumbit";
            this.btn2_Sumbit.Size = new System.Drawing.Size(206, 57);
            this.btn2_Sumbit.TabIndex = 1;
            this.btn2_Sumbit.Text = "Sumbit";
            this.btn2_Sumbit.UseVisualStyleBackColor = true;
            this.btn2_Sumbit.Click += new System.EventHandler(this.btn2_Sumbit_Click);
            // 
            // btn1_Canc
            // 
            this.btn1_Canc.Location = new System.Drawing.Point(51, 176);
            this.btn1_Canc.Name = "btn1_Canc";
            this.btn1_Canc.Size = new System.Drawing.Size(206, 57);
            this.btn1_Canc.TabIndex = 2;
            this.btn1_Canc.Text = "btn1_Canc";
            this.btn1_Canc.UseVisualStyleBackColor = true;
            this.btn1_Canc.Click += new System.EventHandler(this.btn1_Canc_Click);
            // 
            // f2pop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn1_Canc);
            this.Controls.Add(this.btn2_Sumbit);
            this.Controls.Add(this.lb1_Confirm);
            this.Name = "f2pop";
            this.Text = "f2pop";
            this.Load += new System.EventHandler(this.f2pop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1_Confirm;
        private System.Windows.Forms.Button btn2_Sumbit;
        private System.Windows.Forms.Button btn1_Canc;
    }
}