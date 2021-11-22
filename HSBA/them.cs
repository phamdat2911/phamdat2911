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
    public partial class them : Form
    {
        Form1 f;
        public them(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-O063M990\SQLEXPRESS;Initial Catalog=HSBA;Integrated Security=True");
        

        private void btnthem_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = string.Format("insert into Info_patient values('{0}', N'{1}', N'{2}', N'{3}', " +
                "'{4}', " +
                "'{5}', '{6}', N'{7}', N'{8}', N'{9}', '{10}', N'{11}', N'{12}', '{13}')",
                txtmbn.Text, txtname.Text,
                cbbsex.Text, txtdiachi.Text, dtpDob.Text, txtcmnd.Text, txtsdt.Text, txtdantoc.Text,
                txtjob.Text, cbbdoituong.Text, cbbnhommau.Text, 
                txtdiungthuoc.Text, txtstatus.Text,txtmba.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            f.load();
            this.Close();
        }
    }
}
