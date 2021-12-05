using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HSBA
{
    public partial class sua_BA : Form
    {
        Form1 f;
        public sua_BA(Form1 f)
        {
            InitializeComponent();
            this.f = f;
            this.ActiveControl = txtmba;
            txtmba.Focus();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-O063M990\SQLEXPRESS;Initial Catalog=HSBA;Integrated Security=True");

        private void btnsua_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = string.Format("update Info_BenhAn set mabn = '{0}', tenBa = N'{1}', " +
                "tenBs = N'{2}', ngaykham = '{3}', loaiXN = N'{4}', ngaylapBa = '{5}', chuandoan = N'{6}', " +
                "dienbien = N'{7}' where maba = '{8}'", txtmbn.Text, txtnameba.Text, txtnamebacsi.Text, dtpngaykham.Text,
                txtxn.Text, dtplapba.Text, txtchuandoan.Text, txtdienbien.Text, txtmba.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            f.load1();
            this.Close();
        }

        public void set(string s)
        {
            txtmba.Text = s;
        }

        private void txtmba_TextChanged(object sender, EventArgs e)
        {
            if(txtmba.Text == "")
            {
                txtchuandoan.Enabled = false;
                txtdienbien.Enabled = false;
                txtmbn.Enabled = false;
                txtnameba.Enabled = false;
                txtnamebacsi.Enabled = false;
                txtxn.Enabled = false;
                dtplapba.Enabled = false;
                dtpngaykham.Enabled = false;
            }
            else
            {
                txtchuandoan.Enabled = true;
                txtdienbien.Enabled = true;
                txtmbn.Enabled = true;
                txtnameba.Enabled = true;
                txtnamebacsi.Enabled = true;
                txtxn.Enabled = true;
                dtplapba.Enabled = true;
                dtpngaykham.Enabled = true;
            }
        }
    }
}
