using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_week_7
{
    public partial class Form1 : Form
    {
        FormPlay form2 = new FormPlay();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Play_Click(object sender, EventArgs e)
        {
            FormPlay.Size = Convert.ToInt32(textBox_inputUser.Text);
            form2.Show();
        }

        private void textBox_inputUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
