using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HSBA
{
    public partial class xoa_BA : Form
    {
        Form1 f;
        public xoa_BA(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }


        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-O063M990\SQLEXPRESS;Initial Catalog=HSBA;Integrated Security=True");
        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chăc muốn xóa không ?", "Thông Báo", MessageBoxButtons.YesNo);
            if(rs == DialogResult.Yes)
            {
                conn.Open();
                string query = string.Format("delete from Info_BenhAn where maba = '{0}'", txtxoa.Text);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                f.load1();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void xoa_BA_Load(object sender, EventArgs e)
        {

        }
    }
}
