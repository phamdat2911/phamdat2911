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
    public partial class xoa : Form
    {
        Form1 f;
        public xoa(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }


        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-O063M990\SQLEXPRESS;Initial Catalog=HSBA;Integrated Security=True");

        private void btnxoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = string.Format("delete from Info_patient where mabn = '{0}'",txtmabn.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            f.load();
            this.Close();
        }
    }
}
