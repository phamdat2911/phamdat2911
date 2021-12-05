
namespace HSBA
{
    partial class MaBenhAn_sua
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
            this.txtmba = new System.Windows.Forms.TextBox();
            this.btntiep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(108, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Mã Bệnh Án : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtmba
            // 
            this.txtmba.Location = new System.Drawing.Point(321, 63);
            this.txtmba.Name = "txtmba";
            this.txtmba.Size = new System.Drawing.Size(195, 27);
            this.txtmba.TabIndex = 1;
            // 
            // btntiep
            // 
            this.btntiep.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btntiep.Location = new System.Drawing.Point(244, 139);
            this.btntiep.Name = "btntiep";
            this.btntiep.Size = new System.Drawing.Size(116, 54);
            this.btntiep.TabIndex = 2;
            this.btntiep.Text = "Tiếp Tục";
            this.btntiep.UseVisualStyleBackColor = true;
            this.btntiep.Click += new System.EventHandler(this.btntiep_Click);
            // 
            // MaBenhAn_sua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 261);
            this.Controls.Add(this.btntiep);
            this.Controls.Add(this.txtmba);
            this.Controls.Add(this.label1);
            this.Name = "MaBenhAn_sua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaBenhAn_sua";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmba;
        private System.Windows.Forms.Button btntiep;
    }
}