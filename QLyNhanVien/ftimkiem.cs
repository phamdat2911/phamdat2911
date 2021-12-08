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
    public partial class ftimkiem : Form
    {
        public ftimkiem()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-O063M990\SQLEXPRESS;Initial Catalog=QLyKTX;Integrated Security=True");


        private void cbbluachon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbluachon.Text == "Dãy nhà")
            {
                label3.Text = "Nhập tên thòng :";
            }
            else
            {
                if (cbbluachon.Text == "Sinh viên")
                {
                    label3.Text = "Nhập mã sinh viên :";
                }
                else
                {
                    label3.Text = "Nhập thông tin :";
                }
            }
        }

        string s = "";
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            
            if(cbbluachon.Text.Equals("Dãy nhà"))
            {
                s = string.Format("select * from phong where maphong  = '{0}'",txttimkiem.Text.Trim());
            }
            else
            {
                if(cbbluachon.Text.Equals("Sinh viên"))
                {
                    s = string.Format("select * from SinhVien where Masv = {0}", txttimkiem.Text);
                }
                else
                {
                    MessageBox.Show("Thông tin không phù hợp!!");
                }
            }
            SqlCommand cmd = new SqlCommand(s, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvthongtin.DataSource = dt;
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
