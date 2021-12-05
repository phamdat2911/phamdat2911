using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HSBA
{
    public partial class MaBenhAn_sua : Form
    {
        Form1 f;
        public MaBenhAn_sua(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btntiep_Click(object sender, EventArgs e)
        {
            sua_BA sua = new sua_BA(f);
            sua.set(txtmba.Text);
            sua.Show();
            this.Close();
        }
    }
}
