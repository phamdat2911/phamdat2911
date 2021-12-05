using System;
using System.Windows.Forms;

namespace HSBA
{
    public partial class fHoSoBenhAn : Form
    {
        Login login;
        public fHoSoBenhAn(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDoiMatKhau f = new fDoiMatKhau(login);
            this.Hide();
            f.ShowDialog();

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }

        private void fHoSoBenhAn_Load(object sender, EventArgs e)
        {

        }
    }
}
