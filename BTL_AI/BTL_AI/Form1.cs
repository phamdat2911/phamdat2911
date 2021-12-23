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
        string s = "", s1 = "";
        public DataTable table(string query)
        {
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(data);
            return data;
        }
        private void btntiep_Click(object sender, EventArgs e)
        {
            btntiep.Text = "Tiếp theo";
            btnxacnhan.Enabled = true;
            if (i == 1)
            {
                label1.Text = "Bạn muốn chọn mua laptop với mức giá bao nhiêu?\r\n1.Dưới 10 triệu đồng\r\n2.Từ 10 đến 20 triệu\r\n3.Trên 20 triệu";
                s = "select Mota from Gia";
                label3.Text = "";
            }
            if (i == 2)
            {
                label1.Text = "Bạn muốn mua sản phẩm của hãng nào?\r\n1.Acer\r\n2.Asus\r\n3.Dell\r\n4.HP";
                s = "select Mota from HANGSX";
                label3.Text = "";
            }
            if (i == 3)
            {            
                label1.Text = "Bạn muốn chọn loại Ram nào?\r\n1.4GB\r\n2.8GB\r\n3.16GB";
                s = "select Mota from RAM";
                label3.Text = "";
            }
            if (i == 4)
            {
                label1.Text = "Mục đích sử dụng của bạn để làm gì?\r\n1.Đi học - Đi làm\r\n2.Chơi game";
                s = "select Mota from MUCDICH";
                label3.Text = "";
            }

            if (i > 4)
            {
                //ketQua();
                label3.Text = "";
                btntiep.Enabled = false;
                btnxacnhan.Enabled = false;
            }
            cbbtraloi.DataSource = table(s).Copy();
            cbbtraloi.DisplayMember = "Mota";
            cbbtraloi.ValueMember = "Mota";
            i++;
        }
        int j = 1;
        string q = "";
        string qq = "",n = "";
        List<string> listluat = new List<string>();
        Form2 frm = new Form2();
        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            if(j == 1)
            {
                qq = cbbtraloi.Text;
                q = "select MaGia from Gia where Mota = N'" + qq + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    n = dr["MaGia"].ToString();
                    s1 += dr["MaGia"].ToString() + ':';
                }
                string query = string.Format("select maluat from luat where magia = {0}", n.ToString());
                SqlDataAdapter adapter1 = new SqlDataAdapter(query, conn);
                DataTable dt1 = new DataTable();
                adapter1.Fill(dt1);
                foreach (DataRow dr in dt1.Rows)
                {
                    listluat.Add(dr["maluat"].ToString());
                }

            }
            if (j == 2){
                qq = cbbtraloi.Text;
                qq = cbbtraloi.Text;
                q = "select MaHang from HANGSX where Mota = N'" + qq + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    n = dr["MaHang"].ToString();
                    s1 += dr["MaHang"].ToString() + ':';
                }
                string query = string.Format("select maluat from luat where mahang = {0}", n.ToString());
                SqlDataAdapter adapter1 = new SqlDataAdapter(query, conn);
                DataTable dt1 = new DataTable();
                adapter1.Fill(dt1);
                listluat.Clear();
                foreach (DataRow dr in dt1.Rows)
                {
                    
                    listluat.Add(dr["maluat"].ToString());
                }
            }
            if (j == 3)
            {
                qq = cbbtraloi.Text;
                q = "select MaRam from RAM where Mota = N'" + qq + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    n = dr["MaRam"].ToString();
                    s1 += dr["MaRam"].ToString() + ':';
                }
                string query = string.Format("select maluat from luat where maram = {0}", n.ToString());
                SqlDataAdapter adapter1 = new SqlDataAdapter(query, conn);
                DataTable dt1 = new DataTable();
                adapter1.Fill(dt1);
                listluat.Clear();
                foreach (DataRow dr in dt1.Rows)
                {
                    listluat.Add(dr["maluat"].ToString());
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
                    n = dr["MaMD"].ToString();
                    s1 += dr["MaMD"].ToString() + ':';
                }
                
            }
            int m = s1.Length;
            string h = "";
            if (j > 1)
            {
                 h = s1.Substring(0, m - 1);
            }
            
            frm.set(listluat, h);
            btnxacnhan.Enabled = false;
            j++;
        }
        public void luat1()
        {
            string s = "select mota from SanPham";
            SqlDataAdapter adapter = new SqlDataAdapter(s, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new luat(dr["mota"].ToString()));
            }
        }
        string b = "";
        string c = "";
       void ketQua()
        {
            string query = string.Format("select maluat, MaRam from luat where mota = '{0}'", s1.ToString());            
            foreach (DataRow dr in table(query).Rows)
            {
                b = dr["maluat"].ToString();
                c = dr["MaRam"].ToString();
            }           
            string ss = "select maluat from SanPham";          
            bool ktra = true;
            foreach(DataRow dr in table(ss).Rows)
            {
                if(dr["maluat"].ToString() == b)
                {
                    ktra = true;
                    break;
                }
                else
                {
                    ktra = false;
                }
            }
            if(ktra == true)
            {
                string query1 = string.Format("select mota, giasp from SanPham where maluat = '{0}'", b.Trim());
                string query2 = string.Format("select MoTa from RAM where MaRam = '{0}'", c.ToString());
                label2.Text = table(query1).Rows[0]["mota"].ToString() + "/ RAM " + table(query2).Rows[0]["MoTa"].ToString();
                label4.Text = "Giá : " + table(query1).Rows[0]["giasp"].ToString() + "vnđ";
                Bitmap bm = new Bitmap(Application.StartupPath + "\\images\\" + table(query1).Rows[0]["mota"].ToString().Trim() + ".png");
                pcHinhAnh.Image = bm;                
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm tương ứng với lựa chọn của bạn!!","Thông báo", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void quảnLýLuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLuat frm = new fLuat();
            frm.ShowDialog();
        }

        private void btngiaithich_Click(object sender, EventArgs e)
        {
            frm.Show();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSanPham frm = new fSanPham();
            frm.ShowDialog();
        }

        private void tưVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btntiep.Text = "Bắt đầu";
            btntiep.Enabled = true;
            btnxacnhan.Enabled = false;
            cbbtraloi.Text = "Câu trả lời";
            label1.Text = "Câu hỏi";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            j = 1;
            i = 1;
            s = "";
            s1 = "";
            q = "";
            qq = "";
            b = "";
            pcHinhAnh.Image = null;
        }      
    }
}
