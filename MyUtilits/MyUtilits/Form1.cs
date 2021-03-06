﻿using System;
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
        Random rnd;
        public MainForm()
        {
            InitializeComponent();
            rnd = new Random();
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

        private void btRandom_Click(object sender, EventArgs e)
        {
            int num;
            num = rnd.Next(Convert.ToInt32(nudMin.Value), Convert.ToInt32(nudMax.Value)+1);
            lbRandom.Text = num.ToString();
            if(cbRandom.Checked)
            {
                int i=0;
                while (tbRandom.Text.IndexOf(num.ToString()) != -1)
                { num = rnd.Next(Convert.ToInt32(nudMin.Value), Convert.ToInt32(nudMax.Value) + 1);
                  i++;
                    if (i > 1000) break;
                }
                if(i<1000)
                    tbRandom.AppendText(num + "\n");
            }        
            else
                tbRandom.AppendText(num + "\n");
        }

        private void btRandomClear_Click(object sender, EventArgs e)
        {
            tbRandom.Clear();
        }

        private void btRandomCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRandom.Text);
        }
    }
}
