using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKyTucXa
{
    public partial class fKiTucXa : Form
    {
        private fDangNhap login;
        public fKiTucXa(fDangNhap login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDoiMatKhau f = new fDoiMatKhau(login);
            f.Show();
        }

        private void fKiTucXa_Load(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Hide();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQlyNV frm = new fQlyNV();
            frm.Show();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLSV frm = new fQLSV();
            frm.Show();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fphong frm = new fphong();
            frm.Show(); 
        }

        private void đăngKýThuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fdangkyphong frm = new fdangkyphong();
            frm.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ftimkiem frm = new ftimkiem();
            frm.Show();
        }

        private void thôngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongke_PhongNotFull frm = new fThongke_PhongNotFull();
            frm.Show();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fthanhtoan frm = new fthanhtoan();
            frm.Show();
        }

        private void quảnLýHóaĐơnĐiệnNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fHoaDon_DienNuoc frm = new fHoaDon_DienNuoc();
            frm.Show();
        }
    }
}
