
namespace BTL_AI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnxacnhan = new System.Windows.Forms.Button();
            this.cbbtraloi = new System.Windows.Forms.ComboBox();
            this.btngiaithich = new System.Windows.Forms.Button();
            this.btntiep = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnkt = new System.Windows.Forms.Button();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(29, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Câu hỏi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Câu hỏi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnxacnhan);
            this.groupBox2.Controls.Add(this.cbbtraloi);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(29, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trả lời";
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnxacnhan.Location = new System.Drawing.Point(239, 55);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(96, 37);
            this.btnxacnhan.TabIndex = 1;
            this.btnxacnhan.Text = "Xác nhận";
            this.btnxacnhan.UseVisualStyleBackColor = true;
            this.btnxacnhan.Click += new System.EventHandler(this.btnxacnhan_Click);
            // 
            // cbbtraloi
            // 
            this.cbbtraloi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbtraloi.FormattingEnabled = true;
            this.cbbtraloi.Location = new System.Drawing.Point(39, 59);
            this.cbbtraloi.Name = "cbbtraloi";
            this.cbbtraloi.Size = new System.Drawing.Size(171, 33);
            this.cbbtraloi.TabIndex = 0;
            this.cbbtraloi.Text = "Câu trả lời";
            // 
            // btngiaithich
            // 
            this.btngiaithich.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btngiaithich.Location = new System.Drawing.Point(68, 469);
            this.btngiaithich.Name = "btngiaithich";
            this.btngiaithich.Size = new System.Drawing.Size(126, 54);
            this.btngiaithich.TabIndex = 2;
            this.btngiaithich.Text = "Giải thích";
            this.btngiaithich.UseVisualStyleBackColor = true;
            this.btngiaithich.Click += new System.EventHandler(this.btngiaithich_Click);
            // 
            // btntiep
            // 
            this.btntiep.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btntiep.Location = new System.Drawing.Point(238, 469);
            this.btntiep.Name = "btntiep";
            this.btntiep.Size = new System.Drawing.Size(126, 54);
            this.btntiep.TabIndex = 2;
            this.btntiep.Text = "Tiếp";
            this.btntiep.UseVisualStyleBackColor = true;
            this.btntiep.Click += new System.EventHandler(this.btntiep_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnkt);
            this.groupBox3.Controls.Add(this.txtkq);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(472, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(567, 489);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            // 
            // btnkt
            // 
            this.btnkt.Location = new System.Drawing.Point(261, 357);
            this.btnkt.Name = "btnkt";
            this.btnkt.Size = new System.Drawing.Size(94, 48);
            this.btnkt.TabIndex = 1;
            this.btnkt.Text = "Kiểm tra";
            this.btnkt.UseVisualStyleBackColor = true;
            this.btnkt.Click += new System.EventHandler(this.btnkt_Click);
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(37, 30);
            this.txtkq.Multiline = true;
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(444, 304);
            this.txtkq.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 560);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btntiep);
            this.Controls.Add(this.btngiaithich);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnxacnhan;
        private System.Windows.Forms.ComboBox cbbtraloi;
        private System.Windows.Forms.Button btngiaithich;
        private System.Windows.Forms.Button btntiep;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnkt;
        private System.Windows.Forms.TextBox txtkq;
    }
}

