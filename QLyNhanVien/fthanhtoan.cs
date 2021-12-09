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
    public partial class fthanhtoan : Form
    {
        public fthanhtoan()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-O063M990\SQLEXPRESS;Initial Catalog=QLyKTX;Integrated Security=True");

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            conn.Open();
            string s = string.Format("select TenSV, tenphong, giaphong, loaiphong, GioiTinh, NgaySinh, DiaChi, SoDT " +
                "from SinhVien, phong, dangkythuephong where SinhVien.MaSV = {0} and " +
                "dangkythuephong.Masv = SinhVien.MaSV and dangkythuephong.maphong = phong.maphong", txttimkiem.Text);
            SqlCommand cmd = new SqlCommand(s, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            txtnamesv.Text = dt.Rows[0]["TenSV"].ToString();
            txtnamephong.Text = dt.Rows[0]["tenphong"].ToString();
            txtgia.Text = dt.Rows[0]["giaphong"].ToString();
            txtloaiphong.Text = dt.Rows[0]["loaiphong"].ToString();
            txtsex.Text = dt.Rows[0]["GioiTinh"].ToString();
            txtDob.Text = dt.Rows[0]["NgaySinh"].ToString();
            txtdiachi.Text = dt.Rows[0]["DiaChi"].ToString();
            txtsdt.Text = dt.Rows[0]["SoDT"].ToString();
            conn.Close();
            txttongcong.Text = txtgia.Text;
        }

        private void fthanhtoan_Load(object sender, EventArgs e)
        {
            
        }
    }
}
