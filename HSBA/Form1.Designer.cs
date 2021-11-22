
namespace HSBA
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvload = new System.Windows.Forms.DataGridView();
            this.mabn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dantoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doituong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhommau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiUngThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.txtmba = new System.Windows.Forms.TextBox();
            this.cbbnhommau = new System.Windows.Forms.ComboBox();
            this.cbbdoituong = new System.Windows.Forms.ComboBox();
            this.cbbsex = new System.Windows.Forms.ComboBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.txtdiung = new System.Windows.Forms.TextBox();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.txtxdiachi = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtjob = new System.Windows.Forms.TextBox();
            this.txtdantoc = new System.Windows.Forms.TextBox();
            this.txtmbn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btntk = new System.Windows.Forms.Button();
            this.txttk = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvload)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1152, 789);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnthoat);
            this.tabPage1.Controls.Add(this.btnsua);
            this.tabPage1.Controls.Add(this.btnxoa);
            this.tabPage1.Controls.Add(this.btnthem);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btntk);
            this.tabPage1.Controls.Add(this.txttk);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1144, 756);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin bệnh nhân";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label15.Location = new System.Drawing.Point(607, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 20);
            this.label15.TabIndex = 7;
            this.label15.Text = "Mã Bệnh Nhân :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.dgvload);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(51, 489);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1050, 259);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DANH SÁCH BỆNH NHÂN";
            // 
            // dgvload
            // 
            this.dgvload.AllowUserToAddRows = false;
            this.dgvload.AllowUserToDeleteRows = false;
            this.dgvload.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvload.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mabn,
            this.maba,
            this.hoten,
            this.gioitinh,
            this.diachi,
            this.ngaysinh,
            this.cmnd,
            this.sdt,
            this.dantoc,
            this.job,
            this.doituong,
            this.nhommau,
            this.DiUngThuoc,
            this.status});
            this.dgvload.Location = new System.Drawing.Point(6, 37);
            this.dgvload.Name = "dgvload";
            this.dgvload.ReadOnly = true;
            this.dgvload.RowHeadersWidth = 51;
            this.dgvload.RowTemplate.Height = 29;
            this.dgvload.Size = new System.Drawing.Size(1035, 216);
            this.dgvload.TabIndex = 0;
            this.dgvload.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvload_CellClick);
            // 
            // mabn
            // 
            this.mabn.DataPropertyName = "mabn";
            this.mabn.HeaderText = "Mã bệnh nhân";
            this.mabn.MaxInputLength = 3276;
            this.mabn.MinimumWidth = 6;
            this.mabn.Name = "mabn";
            this.mabn.ReadOnly = true;
            this.mabn.Width = 125;
            // 
            // maba
            // 
            this.maba.DataPropertyName = "maba";
            this.maba.HeaderText = "Mã bệnh án";
            this.maba.MinimumWidth = 6;
            this.maba.Name = "maba";
            this.maba.ReadOnly = true;
            this.maba.Width = 125;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            this.hoten.Width = 125;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            this.gioitinh.Width = 125;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            this.diachi.Width = 125;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            this.ngaysinh.Width = 125;
            // 
            // cmnd
            // 
            this.cmnd.DataPropertyName = "cmnd";
            this.cmnd.HeaderText = "Số CMND";
            this.cmnd.MinimumWidth = 6;
            this.cmnd.Name = "cmnd";
            this.cmnd.ReadOnly = true;
            this.cmnd.Width = 125;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số ĐT";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            this.sdt.Width = 125;
            // 
            // dantoc
            // 
            this.dantoc.DataPropertyName = "dantoc";
            this.dantoc.HeaderText = "Dân tộc";
            this.dantoc.MinimumWidth = 6;
            this.dantoc.Name = "dantoc";
            this.dantoc.ReadOnly = true;
            this.dantoc.Width = 125;
            // 
            // job
            // 
            this.job.DataPropertyName = "job";
            this.job.HeaderText = "Nghề nghiệp";
            this.job.MinimumWidth = 6;
            this.job.Name = "job";
            this.job.ReadOnly = true;
            this.job.Width = 125;
            // 
            // doituong
            // 
            this.doituong.DataPropertyName = "doituong";
            this.doituong.HeaderText = "Đối tượng";
            this.doituong.MinimumWidth = 6;
            this.doituong.Name = "doituong";
            this.doituong.ReadOnly = true;
            this.doituong.Width = 125;
            // 
            // nhommau
            // 
            this.nhommau.DataPropertyName = "nhommau";
            this.nhommau.HeaderText = "Nhóm máu";
            this.nhommau.MinimumWidth = 6;
            this.nhommau.Name = "nhommau";
            this.nhommau.ReadOnly = true;
            this.nhommau.Width = 125;
            // 
            // DiUngThuoc
            // 
            this.DiUngThuoc.DataPropertyName = "DiUngThuoc";
            this.DiUngThuoc.HeaderText = "Dị ứng thuốc";
            this.DiUngThuoc.MinimumWidth = 6;
            this.DiUngThuoc.Name = "DiUngThuoc";
            this.DiUngThuoc.ReadOnly = true;
            this.DiUngThuoc.Width = 125;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Trạng thái";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 125;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnthoat.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnthoat.Location = new System.Drawing.Point(998, 384);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(103, 48);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnsua.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnsua.Location = new System.Drawing.Point(1000, 308);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(103, 48);
            this.btnsua.TabIndex = 5;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnxoa.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnxoa.Location = new System.Drawing.Point(1000, 229);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(103, 48);
            this.btnxoa.TabIndex = 5;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnthem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnthem.Location = new System.Drawing.Point(1000, 151);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(103, 48);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDob);
            this.groupBox1.Controls.Add(this.txtmba);
            this.groupBox1.Controls.Add(this.cbbnhommau);
            this.groupBox1.Controls.Add(this.cbbdoituong);
            this.groupBox1.Controls.Add(this.cbbsex);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.txtstatus);
            this.groupBox1.Controls.Add(this.txtdiung);
            this.groupBox1.Controls.Add(this.txtcmnd);
            this.groupBox1.Controls.Add(this.txtxdiachi);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.txtjob);
            this.groupBox1.Controls.Add(this.txtdantoc);
            this.groupBox1.Controls.Add(this.txtmbn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(49, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 380);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Bệnh Nhân";
            // 
            // dtpDob
            // 
            this.dtpDob.CustomFormat = "yyyy-MM-dd";
            this.dtpDob.Enabled = false;
            this.dtpDob.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDob.Location = new System.Drawing.Point(198, 239);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(216, 27);
            this.dtpDob.TabIndex = 4;
            // 
            // txtmba
            // 
            this.txtmba.Enabled = false;
            this.txtmba.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtmba.Location = new System.Drawing.Point(654, 49);
            this.txtmba.Name = "txtmba";
            this.txtmba.Size = new System.Drawing.Size(205, 27);
            this.txtmba.TabIndex = 3;
            // 
            // cbbnhommau
            // 
            this.cbbnhommau.Enabled = false;
            this.cbbnhommau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbnhommau.FormattingEnabled = true;
            this.cbbnhommau.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O",
            "Khác"});
            this.cbbnhommau.Location = new System.Drawing.Point(654, 239);
            this.cbbnhommau.MaximumSize = new System.Drawing.Size(300, 0);
            this.cbbnhommau.MinimumSize = new System.Drawing.Size(100, 0);
            this.cbbnhommau.Name = "cbbnhommau";
            this.cbbnhommau.Size = new System.Drawing.Size(205, 28);
            this.cbbnhommau.TabIndex = 2;
            this.cbbnhommau.Text = "Chọn";
            // 
            // cbbdoituong
            // 
            this.cbbdoituong.Enabled = false;
            this.cbbdoituong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbdoituong.FormattingEnabled = true;
            this.cbbdoituong.Items.AddRange(new object[] {
            "Hộ Nghèo",
            "Hộ Cận Nghèo",
            "Chính Sách",
            "Khác"});
            this.cbbdoituong.Location = new System.Drawing.Point(654, 192);
            this.cbbdoituong.MaximumSize = new System.Drawing.Size(300, 0);
            this.cbbdoituong.MinimumSize = new System.Drawing.Size(100, 0);
            this.cbbdoituong.Name = "cbbdoituong";
            this.cbbdoituong.Size = new System.Drawing.Size(205, 28);
            this.cbbdoituong.TabIndex = 2;
            this.cbbdoituong.Text = "Chọn";
            // 
            // cbbsex
            // 
            this.cbbsex.Enabled = false;
            this.cbbsex.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbsex.FormattingEnabled = true;
            this.cbbsex.Location = new System.Drawing.Point(198, 141);
            this.cbbsex.MaximumSize = new System.Drawing.Size(400, 0);
            this.cbbsex.MinimumSize = new System.Drawing.Size(105, 0);
            this.cbbsex.Name = "cbbsex";
            this.cbbsex.Size = new System.Drawing.Size(216, 28);
            this.cbbsex.TabIndex = 2;
            this.cbbsex.Text = "Chọn";
            // 
            // txtsdt
            // 
            this.txtsdt.Enabled = false;
            this.txtsdt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtsdt.Location = new System.Drawing.Point(198, 336);
            this.txtsdt.Multiline = true;
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(216, 27);
            this.txtsdt.TabIndex = 1;
            // 
            // txtstatus
            // 
            this.txtstatus.Enabled = false;
            this.txtstatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtstatus.Location = new System.Drawing.Point(654, 336);
            this.txtstatus.Multiline = true;
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(205, 27);
            this.txtstatus.TabIndex = 1;
            // 
            // txtdiung
            // 
            this.txtdiung.Enabled = false;
            this.txtdiung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtdiung.Location = new System.Drawing.Point(654, 285);
            this.txtdiung.Multiline = true;
            this.txtdiung.Name = "txtdiung";
            this.txtdiung.Size = new System.Drawing.Size(205, 27);
            this.txtdiung.TabIndex = 1;
            // 
            // txtcmnd
            // 
            this.txtcmnd.Enabled = false;
            this.txtcmnd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcmnd.Location = new System.Drawing.Point(198, 288);
            this.txtcmnd.Multiline = true;
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(216, 27);
            this.txtcmnd.TabIndex = 1;
            // 
            // txtxdiachi
            // 
            this.txtxdiachi.Enabled = false;
            this.txtxdiachi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtxdiachi.Location = new System.Drawing.Point(198, 195);
            this.txtxdiachi.Multiline = true;
            this.txtxdiachi.Name = "txtxdiachi";
            this.txtxdiachi.Size = new System.Drawing.Size(216, 27);
            this.txtxdiachi.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtname.Location = new System.Drawing.Point(198, 96);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(216, 27);
            this.txtname.TabIndex = 1;
            // 
            // txtjob
            // 
            this.txtjob.Enabled = false;
            this.txtjob.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtjob.Location = new System.Drawing.Point(654, 148);
            this.txtjob.Multiline = true;
            this.txtjob.Name = "txtjob";
            this.txtjob.Size = new System.Drawing.Size(205, 27);
            this.txtjob.TabIndex = 1;
            // 
            // txtdantoc
            // 
            this.txtdantoc.Enabled = false;
            this.txtdantoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtdantoc.Location = new System.Drawing.Point(654, 101);
            this.txtdantoc.Multiline = true;
            this.txtdantoc.Name = "txtdantoc";
            this.txtdantoc.Size = new System.Drawing.Size(205, 27);
            this.txtdantoc.TabIndex = 1;
            // 
            // txtmbn
            // 
            this.txtmbn.Enabled = false;
            this.txtmbn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtmbn.Location = new System.Drawing.Point(198, 49);
            this.txtmbn.Multiline = true;
            this.txtmbn.Name = "txtmbn";
            this.txtmbn.Size = new System.Drawing.Size(216, 27);
            this.txtmbn.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(40, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "SĐT :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(40, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số CMND :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(40, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày sinh :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(40, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(40, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giới tính :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(516, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Dị ứng thuốc :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(516, 336);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tình trạng :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(516, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nhóm máu :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(516, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Đối tượng :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(516, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nghề nghiệp :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(516, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Mã bệnh án :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(516, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dân tộc :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bệnh nhân :";
            // 
            // btntk
            // 
            this.btntk.BackColor = System.Drawing.Color.White;
            this.btntk.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btntk.Location = new System.Drawing.Point(998, 29);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(103, 29);
            this.btntk.TabIndex = 2;
            this.btntk.Text = "Tìm Kiếm";
            this.btntk.UseVisualStyleBackColor = false;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(753, 31);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(217, 27);
            this.txttk.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1144, 756);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý Thuốc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1152, 789);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Hồ Sơ Bệnh Án";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvload)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmbn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbnhommau;
        private System.Windows.Forms.ComboBox cbbdoituong;
        private System.Windows.Forms.ComboBox cbbsex;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.TextBox txtdiung;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.TextBox txtxdiachi;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtjob;
        private System.Windows.Forms.TextBox txtdantoc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvload;
        private System.Windows.Forms.TextBox txtmba;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maba;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dantoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn job;
        private System.Windows.Forms.DataGridViewTextBoxColumn doituong;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhommau;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiUngThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Label label15;
    }
}

