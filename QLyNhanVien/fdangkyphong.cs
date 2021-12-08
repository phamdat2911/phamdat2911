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
    public partial class fdangkyphong : Form
    {
        public fdangkyphong()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-O063M990\SQLEXPRESS;Initial Catalog=QLyKTX;Integrated Security=True");

        private void cbbnamephong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void fdangkyphong_Load(object sender, EventArgs e)
        { 
            
            conn.Open();
            string query = "select maphong from phong";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbbdanhsachphong.DataSource = dt.Copy();
            cbbdanhsachphong.DisplayMember = "maphong";
            cbbdanhsachphong.ValueMember = "maphong";
            conn.Close();
        }

        private void cbbdanhsachphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = string.Format("select khu, giaphong, soluong, soluongmax from phong where maphong = '{0}'",cbbdanhsachphong.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                txtdaynha.Text = dt.Rows[0]["khu"].ToString();
                txtgia.Text = dt.Rows[0]["giaphong"].ToString();
                txtSLReal.Text = dt.Rows[0]["soluong"].ToString();
                txtSLMax.Text = dt.Rows[0]["soluongmax"].ToString();
            }
        }

        void load1()
        {
            string query = "select soluong from phong";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtSLReal.Text = dt.Rows[0]["soluong"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query1 = string.Format("insert into dangkythuephong values('{0}', {1})", cbbdanhsachphong.Text, txtmsv.Text);
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            cmd1.ExecuteNonQuery();
            load1();
            conn.Close();
            txtmsv.Text = "";
            MessageBox.Show("Đã thêm sinh viên vào phòng " + cbbdanhsachphong.Text);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query1 = string.Format("delete from dangkythuephong where Masv = '{0}'", txtmsv.Text);
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            cmd1.ExecuteNonQuery();
            load1();
            conn.Close();
            txtmsv.Text = "";
            MessageBox.Show("Đã xóa sinh viên khỏi phòng " + cbbdanhsachphong.Text);
        }
    }
}
