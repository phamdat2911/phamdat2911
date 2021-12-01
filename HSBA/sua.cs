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
    
    public partial class sua : Form
    {
        Form1 f;
        public sua(Form1 f)
        {
            InitializeComponent();
            this.f = f;
            this.ActiveControl = txthoten;
            txthoten.Focus();

        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-O063M990\SQLEXPRESS;Initial Catalog=HSBA;Integrated Security=True");


        public void set(string s)
        {
            txtmabn.Text = s;
            txtmaba.Text = s;
        }
        
        private void btnsua_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = string.Format("update Info_patient set hoten = N'{0}', gioitinh = N'{1}', " +
                "diachi = N'{2}', ngaysinh = '{3}', cmnd = '{4}', sdt = '{5}', dantoc = N'{6}', " +
                "job = N'{7}', doituong = N'{8}', nhommau = '{9}', DiUngThuoc = N'{10}', status = N'{11}', " +
                "maba = '{12}' where mabn = '{13}'",txthoten.Text, cbbsex.Text, txtdiachi.Text, dtpDob.Text,
                txtcmnd.Text, txtsdt.Text, txtdantoc.Text, txtjob.Text, cbbdoituong.Text, cbbnhommau.Text, txtdiungthuoc.Text, txtstatus.Text,txtmaba.Text,txtmabn.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            f.load();
            this.Close();
        }

        private void sua_Load(object sender, EventArgs e)
        {

        }
    }
}
