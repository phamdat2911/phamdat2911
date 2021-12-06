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
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }
        public string s = "12345";
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text == "admin" && txtMatKhau.Text == s)
            {
                MessageBox.Show("Đăng nhập thành công!!!", "Thông báo");
                fKiTucXa f = new fKiTucXa(this);
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Bạn nhập sai tài khoản/mật khẩu rồi", "Thông báo");
            }
        }
        public void setName(string name)
        {
            s = name;
            txtMatKhau.Text = s;
        }

        private void ckbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbHienMK.Checked == true)
            {
                txtMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void fDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
