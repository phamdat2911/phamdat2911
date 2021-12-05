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
        public string s = "123456";
        private void btnlogin_Click(object sender, EventArgs e)
        {

            if(txtname.Text == "admin" && txtpass.Text == s)
            {
                MessageBox.Show("Đăng nhập thành công!!", "Thông báo");
                fHoSoBenhAn f = new fHoSoBenhAn(this);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!!!\t\nVui lòng kiểm tra lại mật khẩu", "Thông báo");
            }
        }
        public void setName(string name)
        {
            s = name;
            txtpass.Text = s;

        }

        private void ckbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbHienMK.Checked == true)
            {
                txtpass.PasswordChar = (char)0; 
            }
            else
            {
                txtpass.PasswordChar = '*';
            }
        }
    }
}
