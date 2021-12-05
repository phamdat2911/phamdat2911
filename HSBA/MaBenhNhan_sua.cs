using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HSBA
{
    public partial class MaBenhNhan_sua : Form
    {
        Form1 f;
        public MaBenhNhan_sua(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }


        private void btntieptuc_Click(object sender, EventArgs e)
        {

            sua sua = new sua(f);
            sua.set(txtmabn.Text);
            sua.Show();
            this.Close();
        }

        private void MaBenhNhan_sua_Load(object sender, EventArgs e)
        {

        }
    }
}
