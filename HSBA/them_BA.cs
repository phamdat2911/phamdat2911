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
    public partial class them_BA : Form
    {
        Form1 f;
        public them_BA(Form1 f)
        {
            InitializeComponent();
            this.f = f;
            this.ActiveControl = txtmbn;
            txtmbn.Focus();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-O063M990\SQLEXPRESS;Initial Catalog=HSBA;Integrated Security=True");
        
        private void btnthem_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = string.Format("insert into Info_BenhAn values('{0}', '{1}', N'{2}', N'{3}', " +
                "'{4}', " +
                "N'{5}', '{6}', N'{7}', N'{8}')",
                txtmba.Text, txtmbn.Text,
                txtnameba.Text, txtnamebs.Text, dtpngaykham.Text, txtxn.Text, dtpngaylapba.Text, txtchuandoan.Text,
                txtdienbien.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            f.load1();
            this.Close();
        }
    }
}
