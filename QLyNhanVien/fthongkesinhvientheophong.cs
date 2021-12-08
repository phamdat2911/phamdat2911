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
    public partial class fthongkesinhvientheophong : Form
    {
        public fthongkesinhvientheophong()
        {
            InitializeComponent();

        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-O063M990\SQLEXPRESS;Initial Catalog=QLyKTX;Integrated Security=True");

        public void fthongkesinhvientheophong_Load(object sender, EventArgs e)
        {
            conn.Open();
            string s = string.Format("select tenphong, TenSV from phong,SinhVien,dangkythuephong where " +
                "dangkythuephong.maphong = '{0}' and dangkythuephong.Masv = SinhVien.MaSV and " +
                "dangkythuephong.maphong = phong.maphong", textBox1.Text);
            SqlCommand cmd = new SqlCommand(s, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvload.DataSource = dt;
            conn.Close();
        }

        public void set(string s)
        {
            textBox1.Text = s.Trim();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
