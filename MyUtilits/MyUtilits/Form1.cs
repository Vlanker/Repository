using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUtilits
{
    public partial class MainForm : Form
    {
        int count = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа\n\"мои утилиты\". \nАвтор: К ", "О программе");
        }

        private void btnPl_Click(object sender, EventArgs e)
        {
            count++;
            lbCount.Text = count.ToString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {

            count--;
            lbCount.Text = Convert.ToString(count);
        }

        private void btnRes_Click(object sender, EventArgs e)
        {

            count = 0;
            lbCount.Text = " ";
        }
    }
}
