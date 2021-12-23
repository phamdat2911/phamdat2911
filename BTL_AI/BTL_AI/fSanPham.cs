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
    public partial class fSanPham : Form
    {
        public fSanPham()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6FGF4P7Q\SQLEXPRESS2012;Initial Catalog=HCG;Integrated Security=True");
        void load()
        {
            string query = "select * from SanPham";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dvgSanPham.DataSource = dt;
        }

        private void fSanPham_Load(object sender, EventArgs e)
        {
            con.Open();
            load();
            con.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = string.Format("Insert into SanPham values(N'{0}','{1}','{2}')",txtMoTa.Text,txtMaLuat.Text,txtGia.Text);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            load();
            con.Close();
            txtMaLuat.Text = "";
            txtMoTa.Text = "";
            txtGia.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = string.Format("Update SanPham set mota = N'{0}', giasp = '{1}' WHERE maluat = '{2}'", txtMoTa.Text, txtGia.Text, txtMaLuat.Text);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            load();
            con.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = string.Format("delete from SanPham where maluat = '{0}'", txtMaLuat.Text);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            load();
            con.Close();
        }
    }
}
