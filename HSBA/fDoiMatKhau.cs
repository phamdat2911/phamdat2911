using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HSBA
{
    public partial class fDoiMatKhau : Form
    {
        private Login login;

      

        public fDoiMatKhau(Login login) 
        {
            InitializeComponent();
            this.login = login;
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            login.setName(txtMKMoi.Text);
            this.Hide();
            login.Show();
        }

        private void fDoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
