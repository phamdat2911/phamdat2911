
namespace HSBA
{
    partial class MaBenhNhan_sua
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtmabn = new System.Windows.Forms.TextBox();
            this.btntieptuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(133, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Bệnh Nhân :";
            // 
            // txtmabn
            // 
            this.txtmabn.Location = new System.Drawing.Point(296, 96);
            this.txtmabn.Multiline = true;
            this.txtmabn.Name = "txtmabn";
            this.txtmabn.Size = new System.Drawing.Size(251, 34);
            this.txtmabn.TabIndex = 1;
            // 
            // btntieptuc
            // 
            this.btntieptuc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btntieptuc.Location = new System.Drawing.Point(281, 185);
            this.btntieptuc.Name = "btntieptuc";
            this.btntieptuc.Size = new System.Drawing.Size(139, 62);
            this.btntieptuc.TabIndex = 2;
            this.btntieptuc.Text = "Tiếp";
            this.btntieptuc.UseVisualStyleBackColor = true;
            this.btntieptuc.Click += new System.EventHandler(this.btntieptuc_Click);
            // 
            // MaBenhNhan_sua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(708, 310);
            this.Controls.Add(this.btntieptuc);
            this.Controls.Add(this.txtmabn);
            this.Controls.Add(this.label1);
            this.Name = "MaBenhNhan_sua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Mã Bệnh Nhân";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmabn;
        private System.Windows.Forms.Button btntieptuc;
    }
}