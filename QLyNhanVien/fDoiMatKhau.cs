using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKyTucXa
{
    public partial class fDoiMatKhau : Form
    {
        private fDangNhap login;
        public fDoiMatKhau(fDangNhap login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login.setName(txtMKmoi.Text);
            this.Hide();
            login.Show();
        }
    }
}
