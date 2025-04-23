using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest
{
    public partial class Form1 : Form
    {
        string operand1 = null;
        string operand2 = null;
        string operation = null;
        bool isSecond = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void button_Clic_reset(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (!isSecond)
                operand1 = null;

            txtDisplay.Text = null;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Click_add(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (!isSecond)
                operand1 += btn.Text;
            else
                operand2 += btn.Text;

            txtDisplay.Text += btn.Text;

        }
    }
}
