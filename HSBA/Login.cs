using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HSBA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtname;
            txtname.Focus();
        }

        private void txtname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtname.Text))
            {
                e.Cancel = true;
                txtname.Focus();
                errorProvider1.SetError(txtname, "Nhập tài khoản");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtname, null);
            }
        }

        private void txtpass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtpass.Text))
            {
                e.Cancel = true;
                txtpass.Focus();
                errorProvider1.SetError(txtpass, "Nhập mật khẩu");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtpass, null);
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtname.Text.Equals("admin") && txtpass.Text.Equals("2911"))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu !!");
                return;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không ??", "Thông báo", MessageBoxButtons.YesNo);
            if(rs == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
