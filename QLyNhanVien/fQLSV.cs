﻿using System;
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
    public partial class fQLSV : Form
    {
        public fQLSV()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-O063M990\SQLEXPRESS;Initial Catalog=QLyKTX;Integrated Security=True");
        void load()
        {
            string query = "select * from SinhVien";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = string.Format("insert into SinhVien values({0}, N'{1}', '{2}', N'{3}', N'{4}', '{5}')",
                txtmsv.Text, txtnamesv.Text, dtpDob.Text, cbbsex.Text, txtdiachi.Text, txtsdt.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void fQLSV_Load(object sender, EventArgs e)
        {
            conn.Open();
            load();
            conn.Close();
        }
    }
}
