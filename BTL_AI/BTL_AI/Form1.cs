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

namespace BTL_AI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-O063M990\SQLEXPRESS;Initial Catalog=BTL_AI;Integrated Security=True");
        int i = 1;
        string s = "";
        private void btntiep_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                label1.Text = "Chọn giới tính của bạn ?";
                s = "select mota from gioitinh";
            }
            if (i == 2)
            {
                label1.Text = "Chọn hãng sản xuất\r\n   bạn yêu thích ?";
                s = "select mota from hangsanxuat";
            }
            if (i == 3)
            {
                label1.Text = "Chọn giá cả phù hợp ?";
                s = "select mota from gia_laptop";
            }
            if (i == 4)
            {
                label1.Text = "Chọn màu sắc laptop ?";
                s = "select mota from mausac";
            }
            if (i == 5)
            {
                label1.Text = "Chọn hệ điều hành\r\n bạn mong muốn ?";
                s = "select mota from he_dieu_hanh";
            }
            if (i == 6)
            {
                label1.Text = "Chọn bộ nhớ trong phù hợp ?";
                s = "select mota from bo_nho_trong";
            }
            if (i == 7)
            {
                label1.Text = "Chọn kích thước màn\r\n hình phù hợp ?";
                s = "select mota from man_hinh";
            }
            if (i == 8)
            {
                label1.Text = "Mục đích sử dụng ?";
                s = "select mota from nhiem_vu_maytinh";
                btntiep.Text = "Kiểm tra";
            }
            if(i > 8)
            {
                fgiaithich frm = new fgiaithich();
                frm.Show();
            }
            SqlDataAdapter adapter = new SqlDataAdapter(s, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbbtraloi.DataSource = dt.Copy();
            cbbtraloi.DisplayMember = "mota";
            cbbtraloi.ValueMember = "mota";
            i++;
        }
    }
}
