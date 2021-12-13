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
        List<luat> list = new List<luat>();
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-O063M990\SQLEXPRESS;Initial Catalog=HCG;Integrated Security=True");
        int i = 1;
        string s = "",s1 = "";
        private void btntiep_Click(object sender, EventArgs e)
        {
            btnxacnhan.Enabled = true;
            if (i == 1)
            {
                label1.Text = "Chọn giá thành phù hợp ?";
                s = "select Mota from Gia";
            }
            if (i == 2)
            {
                label1.Text = "Chọn hãng sản xuất\r\n   bạn yêu thích ?";
                s = "select Mota from HANGSX";
            }
            if (i == 3)
            {
                label1.Text = "Bộ nhớ trong phù hợp với bạn ?";
                s = "select Mota from RAM";
            }
            if (i == 4)
            {
                label1.Text = "Mục đích sử dụng ?";
                s = "select Mota from MUCDICH";
            }
            
            if(i > 4)
            {
                btntiep.Enabled = false;
            }
            SqlDataAdapter adapter = new SqlDataAdapter(s, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbbtraloi.DataSource = dt.Copy();
            cbbtraloi.DisplayMember = "Mota";
            cbbtraloi.ValueMember = "Mota";
            i++;
        }

        public void luat1()
        {
            string ss = "select mota from luat";
            SqlDataAdapter adapter = new SqlDataAdapter(ss, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                list.Add(new luat(dr["mota"].ToString()));
            }
        }

        private void btngiaithich_Click(object sender, EventArgs e)
        {
            fgiaithich frm = new fgiaithich();
            frm.Show();
        }

        int j = 0;
        string q = "";
        string qq = "";
        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            j++;
            
            if(j == 1)
            {
                qq = cbbtraloi.Text;
                q = "select MaGia from Gia where Mota = N'"+qq+"'";
                SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach(DataRow dr in dt.Rows)
                {
                    s1 += dr["MaGia"].ToString() + ':';
                }
                
            }
            if(j == 2){
                qq = cbbtraloi.Text;
                q = "select MaHang from HANGSX where Mota = '" + qq + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    s1 += dt.Rows[0]["MaHang"].ToString() + ':';
                }
                
            }
            if (j == 3)
            {
                qq = cbbtraloi.Text;
                q = "select MaRam from RAM where Mota = '" + qq + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    s1 += dt.Rows[0]["MaRam"].ToString() + ':';
                }
                
            }
            if (j == 4)
            {
                qq = cbbtraloi.Text;
                q = "select MaMD from MUCDICH where Mota = N'" + qq + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    s1 += dt.Rows[0]["MaMD"].ToString();
                }
                
            }
            btnxacnhan.Enabled = false;
        }

        int o = 1;
        string b = "";
        private void btnkt_Click(object sender, EventArgs e)
        {
            luat1();
            
            string query = string.Format("select maluat from luat where mota = '{0}'", s1.ToString());
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                b = dr["maluat"].ToString();
            }
            string query1 = string.Format("select mota from ketqua where maluat = '{0}'", b.Trim());
            SqlDataAdapter adapter1 = new SqlDataAdapter(query1, conn);
            DataTable dt1 = new DataTable();
            adapter1.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                txtkq.Text = dr["mota"].ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
