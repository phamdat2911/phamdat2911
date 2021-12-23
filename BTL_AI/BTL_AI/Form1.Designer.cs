
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnxacnhan = new System.Windows.Forms.Button();
            this.cbbtraloi = new System.Windows.Forms.ComboBox();
            this.btntiep = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pcHinhAnh = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tưVấnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLuậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btngiaithich = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcHinhAnh)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Calligraphy", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(29, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Câu hỏi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnxacnhan);
            this.groupBox2.Controls.Add(this.cbbtraloi);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(29, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trả lời";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(35, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 5;
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.Enabled = false;
            this.btnxacnhan.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnxacnhan.Location = new System.Drawing.Point(235, 41);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(96, 37);
            this.btnxacnhan.TabIndex = 1;
            this.btnxacnhan.Text = "Xác nhận";
            this.btnxacnhan.UseVisualStyleBackColor = true;
            this.btnxacnhan.Click += new System.EventHandler(this.btnxacnhan_Click);
            // 
            // cbbtraloi
            // 
            this.cbbtraloi.Font = new System.Drawing.Font("Roboto Medium", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cbbtraloi.FormattingEnabled = true;
            this.cbbtraloi.Location = new System.Drawing.Point(35, 45);
            this.cbbtraloi.Name = "cbbtraloi";
            this.cbbtraloi.Size = new System.Drawing.Size(171, 30);
            this.cbbtraloi.TabIndex = 0;
            this.cbbtraloi.Text = "---Câu trả lời";
            // 
            // btntiep
            // 
            this.btntiep.Font = new System.Drawing.Font("Lucida Calligraphy", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btntiep.Location = new System.Drawing.Point(234, 480);
            this.btntiep.Name = "btntiep";
            this.btntiep.Size = new System.Drawing.Size(126, 35);
            this.btntiep.TabIndex = 2;
            this.btntiep.Text = "Bắt đầu";
            this.btntiep.UseVisualStyleBackColor = true;
            this.btntiep.Click += new System.EventHandler(this.btntiep_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.pcHinhAnh);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(472, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(598, 502);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(28, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(136, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 2;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcHinhAnh
            // 
            this.pcHinhAnh.Location = new System.Drawing.Point(6, 131);
            this.pcHinhAnh.Margin = new System.Windows.Forms.Padding(2);
            this.pcHinhAnh.Name = "pcHinhAnh";
            this.pcHinhAnh.Size = new System.Drawing.Size(584, 366);
            this.pcHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcHinhAnh.TabIndex = 1;
            this.pcHinhAnh.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tưVấnToolStripMenuItem,
            this.quảnLýDữLiệuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1080, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tưVấnToolStripMenuItem
            // 
            this.tưVấnToolStripMenuItem.Name = "tưVấnToolStripMenuItem";
            this.tưVấnToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.tưVấnToolStripMenuItem.Text = "Tư vấn";
            this.tưVấnToolStripMenuItem.Click += new System.EventHandler(this.tưVấnToolStripMenuItem_Click);
            // 
            // quảnLýDữLiệuToolStripMenuItem
            // 
            this.quảnLýDữLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýLuậtToolStripMenuItem,
            this.quảnLýSảnPhẩmToolStripMenuItem});
            this.quảnLýDữLiệuToolStripMenuItem.Name = "quảnLýDữLiệuToolStripMenuItem";
            this.quảnLýDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.quảnLýDữLiệuToolStripMenuItem.Text = "Quản lý dữ liệu";
            // 
            // quảnLýLuậtToolStripMenuItem
            // 
            this.quảnLýLuậtToolStripMenuItem.Name = "quảnLýLuậtToolStripMenuItem";
            this.quảnLýLuậtToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.quảnLýLuậtToolStripMenuItem.Text = "Quản lý luật";
            this.quảnLýLuậtToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLuậtToolStripMenuItem_Click);
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm";
            this.quảnLýSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSảnPhẩmToolStripMenuItem_Click);
            // 
            // btngiaithich
            // 
            this.btngiaithich.Location = new System.Drawing.Point(64, 480);
            this.btngiaithich.Name = "btngiaithich";
            this.btngiaithich.Size = new System.Drawing.Size(119, 35);
            this.btngiaithich.TabIndex = 5;
            this.btngiaithich.Text = "Giải thích";
            this.btngiaithich.UseVisualStyleBackColor = true;
            this.btngiaithich.Click += new System.EventHandler(this.btngiaithich_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 544);
            this.Controls.Add(this.btngiaithich);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btntiep);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ chuyên gia tư vấn mua laptop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcHinhAnh)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnxacnhan;
        private System.Windows.Forms.ComboBox cbbtraloi;
        private System.Windows.Forms.Button btntiep;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tưVấnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDữLiệuToolStripMenuItem;
        private System.Windows.Forms.PictureBox pcHinhAnh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLuậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.Button btngiaithich;
    }
}

