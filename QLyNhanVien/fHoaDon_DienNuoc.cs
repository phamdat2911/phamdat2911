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
    public partial class fHoaDon_DienNuoc : Form
    {
        public fHoaDon_DienNuoc()
        {
            InitializeComponent();
            this.ActiveControl = txtmaphong;
            txtmaphong.Focus();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-O063M990\SQLEXPRESS;Initial Catalog=QLyKTX;Integrated Security=True");
        void load()
        {
            string s = "select * from hoadon";
            SqlDataAdapter adapter = new SqlDataAdapter(s, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvhoadon.DataSource = dt;
        }

        private void fHoaDon_DienNuoc_Load(object sender, EventArgs e)
        {
            conn.Open();
            load();
            conn.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int sonuoc = Convert.ToInt32(txtsonuoc.Text);
            int sodien = Convert.ToInt32(txtsodien.Text);
            int songaysd = Convert.ToInt32(txtsongaysd.Text);
            txttongcong.Text = ((float)(sodien * 1500 + sonuoc * 6000) * songaysd).ToString();
            conn.Open();
            string s = string.Format("insert into hoadon values('{0}', {1}, {2}, {3}, {4})",
                txtmaphong.Text, txtsodien.Text, txtsonuoc.Text, txtsongaysd.Text, txttongcong.Text);
            SqlCommand cmd = new SqlCommand(s, conn);
            cmd.ExecuteNonQuery();
            load();
            conn.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            int sonuoc = Convert.ToInt32(txtsonuoc.Text);
            int sodien = Convert.ToInt32(txtsodien.Text);
            int songaysd = Convert.ToInt32(txtsongaysd.Text);
            txttongcong.Text = ((float)(sodien * 1500 + sonuoc * 6000) * songaysd).ToString();
            conn.Open();
            string s = string.Format("update hoadon set sodien = {0}, sonuoc = {1}, songaySD = {2}, thanhtien = {3} where " +
                "maphong = '{4}'",txtsodien.Text, txtsonuoc.Text, txtsongaysd.Text, txttongcong.Text, txtmaphong.Text);
            SqlCommand cmd = new SqlCommand(s, conn);
            cmd.ExecuteNonQuery();
            load();
            conn.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này không ???", "Thông Báo", MessageBoxButtons.YesNo);
            if(rs == DialogResult.Yes)
            {
                conn.Open();
                string s = string.Format("delete from hoadon where maphong = '{0}'", txtmaphong.Text);
                SqlCommand cmd = new SqlCommand(s, conn);
                cmd.ExecuteNonQuery();
                load();
                conn.Close();
            }
            else
            {
                return;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn thoát không ???", "Thông Báo", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }
        
        private void btnkiemtra_Click(object sender, EventArgs e)
        {
            conn.Open();
            string ss = "select * from hoadon where maphong = '"+txtkiemtra.Text+"'";
            SqlCommand cmd = new SqlCommand(ss, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvhoadon.DataSource = dt;
            conn.Close();

        }
    }
}
