using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclick_Click(object sender, EventArgs e)
        {
           if (txtname.Text != "")
            lblhello.Text = txtname.Text + "님! 안녕하세요";
            else
                MessageBox.Show("이름을 입력하세요", "Warning");
                
        }
    }
}
