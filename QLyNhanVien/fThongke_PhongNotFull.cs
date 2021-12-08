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
    public partial class fThongke_PhongNotFull : Form
    {
        public fThongke_PhongNotFull()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-O063M990\SQLEXPRESS;Initial Catalog=QLyKTX;Integrated Security=True");
        private void fThongke_PhongNotFull_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string s = "select * from phong where soluong < soluongmax";
            SqlCommand cmd = new SqlCommand(s, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string s = "select * from phong where soluong = soluongmax";
            SqlCommand cmd = new SqlCommand(s, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult rs =  MessageBox.Show("Xem chi tiết !", "Thông Báo", MessageBoxButtons.YesNo);
            if(rs == DialogResult.Yes)
            {
                string s = "";
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    s = row.Cells[0].Value.ToString();
                }
                fthongkesinhvientheophong frm = new fthongkesinhvientheophong();
                frm.set(s);
                frm.Show();
            }
            else
            {
                return;
            }
        }
    }
}
