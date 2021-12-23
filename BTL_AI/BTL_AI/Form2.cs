using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BTL_AI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int j = 1;
        public void set(List<string> list, string s)
        {
            richTextBox1.Text += "Sau lần chọn thứ : "+j.ToString()+"\r\nTập KL: "+s + "\r\nTập luật thứ:"+j.ToString();
            foreach(string i in list)
            {
                richTextBox1.Text += i;
            }

            richTextBox1.Text += "\r\n";
            j++;
            if (j > 4)
            {
                richTextBox1.Text += "Tìm Kiếm Thành Công";
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
