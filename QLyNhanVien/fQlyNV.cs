using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKyTucXa
{
    public partial class fQlyNV : Form
    {
        public fQlyNV()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-O063M990\SQLEXPRESS;Initial Catalog=QLyKTX;Integrated Security=True");
        void load()
        {
            string query = "select * from QLyNhanVien";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvnhanvien.DataSource = dt;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtcmnd.Enabled = true;
            txtmnv.Enabled = true;
            txtname.Enabled = true;
            txtphucap.Enabled = true;
            txtquequan.Enabled = true;
            txtsdt.Enabled = true;
            cbbjob.Enabled = true;
        }

        private void fQlyNV_Load(object sender, EventArgs e)
        {
            conn.Open();
            load();
            conn.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
           
            double hsl = Convert.ToDouble(txthsl.Text);
            int phucap = Convert.ToInt32(txtphucap.Text);
            txtluong.Text = ((int)(hsl * 1490000 + phucap)).ToString();
            conn.Open();
            string query = string.Format("update QLyNhanVien set name = N'{0}', cmnd = '{1}', quequan = N'{2}', sdt = '{3}', " +
                "job = N'{4}', hsl = {5}, phucap = {6}, luong = {7} where mnv = '{8}'", txtname.Text, txtcmnd.Text, txtquequan.Text
                , txtsdt.Text, cbbjob.Text, txthsl.Text, txtphucap.Text, txtluong.Text, txtmnv.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            load();
        }

        private void cbbjob_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbjob.Text == "Quản lý")
            {
                txthsl.Text = "4.0";
            }
            else
            {
                if (cbbjob.Text == "Bảo vệ")
                {
                    txthsl.Text = "3.5";
                }
                else
                {
                    txthsl.Text = "3.0";
                }

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = string.Format("delete from QLyNhanVien where mnv = '{0}'", txtmnv.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            load();
            conn.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            double hsl = Convert.ToDouble(txthsl.Text);
            int phucap = Convert.ToInt32(txtphucap.Text);
            txtluong.Text = ((int)(hsl * 1490000 + phucap)).ToString();
            conn.Open();
            string query = string.Format("insert into QLyNhanVien values('{0}', N'{1}', '{2}', N'{3}', '{4}', N'{5}', {6}, {7},{8})"
            , txtmnv.Text, txtname.Text, txtcmnd.Text, txtquequan.Text, txtsdt.Text, cbbjob.Text, txthsl.Text
            ,txtphucap.Text,txtluong.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            load();
            conn.Close();

        }
    }
}
