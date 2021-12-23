using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BTL_AI
{
    public partial class fLuat : Form
    {
        public fLuat()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6FGF4P7Q\SQLEXPRESS2012;Initial Catalog=HCG;Integrated Security=True");
        void load()
        {
            string query = "select maluat, mota from luat";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dvgLuat.DataSource = dt;
        }
        private void fLuat_Load(object sender, EventArgs e)
        {
            con.Open();
            load();
            con.Close();
        }

        private void dvgLuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dvgLuat.CurrentRow.Index;
            txtMaLuat.Text = dvgLuat.Rows[i].Cells[0].Value.ToString();
            txtMoTa.Text = dvgLuat.Rows[i].Cells[1].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = "Select maluat, mota from luat Where maluat = '" + txtTimKiem.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dvgLuat.DataSource = dt;
        }
    }
}
