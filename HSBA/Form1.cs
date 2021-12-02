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

namespace HSBA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-O063M990\SQLEXPRESS;Initial Catalog=HSBA;Integrated Security=True");
        public void load()
        {
            string query = "select * from Info_patient";
            SqlCommand cmd = new SqlCommand(query,conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvload.DataSource = dt;
        }

        public void load1()
        {
            string query = "select maba, hoten, tenBa, tenBs, ngaykham, loaiXN, ngaylapBa, chuandoan, dienbien from Info_BenhAn, Info_patient where Info_BenhAn.mabn = Info_patient.mabn";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvba.DataSource = dt;
        }
        public void loadByMabn()
        {
            string query = string.Format("select * from Info_patient where mabn like '%{0}%'",txttk.Text.Trim());
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvload.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.ShowDialog();
            conn.Open();
            load();
            load1();
            conn.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            them them = new them(this);
            them.Show();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            xoa xoa = new xoa(this);
            xoa.Show();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            MaBenhNhan_sua sua = new MaBenhNhan_sua(this);
            sua.Show();
        }

        private void dgvload_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvload.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvload.CurrentRow.Selected = true;
                txtmbn.Text = dgvload.Rows[e.RowIndex].Cells["mabn"].Value.ToString();
                txtname.Text = dgvload.Rows[e.RowIndex].Cells["hoten"].Value.ToString();
                cbbsex.Text = dgvload.Rows[e.RowIndex].Cells["gioitinh"].Value.ToString();
                txtxdiachi.Text = dgvload.Rows[e.RowIndex].Cells["diachi"].Value.ToString();
                dtpDob.Text = dgvload.Rows[e.RowIndex].Cells["ngaysinh"].Value.ToString();
                txtcmnd.Text = dgvload.Rows[e.RowIndex].Cells["cmnd"].Value.ToString();
                txtsdt.Text = dgvload.Rows[e.RowIndex].Cells["sdt"].Value.ToString();
                txtdantoc.Text = dgvload.Rows[e.RowIndex].Cells["dantoc"].Value.ToString();
                txtjob.Text = dgvload.Rows[e.RowIndex].Cells["job"].Value.ToString();
                cbbdoituong.Text = dgvload.Rows[e.RowIndex].Cells["doituong"].Value.ToString();
                cbbnhommau.Text = dgvload.Rows[e.RowIndex].Cells["nhommau"].Value.ToString();
                txtdiung.Text = dgvload.Rows[e.RowIndex].Cells["DiUngThuoc"].Value.ToString();
                txtstatus.Text = dgvload.Rows[e.RowIndex].Cells["status"].Value.ToString();
            }
        }

       

        private void txttk_TextChanged(object sender, EventArgs e)
        {
            if (txttk.Text == "")
            {
                conn.Open();
                load();
                conn.Close();
            }
            else
            {
                conn.Open();
                loadByMabn();
                conn.Close();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
