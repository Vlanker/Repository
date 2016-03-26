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
    public partial class MyUtils : Form
    {
        int count = 0;
        Random rnd;
        char[] sp_char = new char[] { '%', '*', ')', '?', '#', '$', '^', '?', '&', '~', ',', '.', '<', '>', '/', '-', '+','\'',';','"',':','(','_','=','\\','|','@','!' };
        Dictionary<string, double> metrica;

        public MyUtils()
        {
            InitializeComponent();
            rnd = new Random();
            metrica = new Dictionary<string, double>();
            

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
            num = rnd.Next(Convert.ToInt32(nudMin.Value), Convert.ToInt32(nudMax.Value) + 1);
            lbRandom.Text = num.ToString();
            if (cbRandom.Checked)
            {
                int i = 0;
                while (tbRandom.Text.IndexOf(num.ToString()) != -1)
                {
                    num = rnd.Next(Convert.ToInt32(nudMin.Value), Convert.ToInt32(nudMax.Value) + 1);
                    i++;
                    if (i > 1000) break;
                }
                if (i < 1000)
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

        private void tc_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tc.SelectedTab == tp3)
                tsmiNotepad.Visible = true;
            else tsmiNotepad.Visible = false;
        }

        private void tsmiInsDate_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortDateString() + " ");
        }

        private void tsmiInsTime_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortTimeString() + " ");
        }

        private void tsmiFSave_Click(object sender, EventArgs e)
        {
            try
            {
                rtbNotepad.SaveFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Не сохраненео!", "Ошибка");
            }
        }

        void LoadNotedap()
        {
            try
            {
                rtbNotepad.LoadFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Не открывается!", "Ошибка");
            }
        }

        private void tsmiFLoad_Click(object sender, EventArgs e)
        {
            LoadNotedap();
        }

        void LoadItemsCb()
        {
            cbTo.Items.Clear();
            //копируем элементы из cbIS в cbTo
            for (int i = 0; i < cbIs.Items.Count; i++)
                cbTo.Items.Add(cbIs.Items[i]);
            cbTo.Text = cbIs.Text;
        }

        private void MyUtils_Load(object sender, EventArgs e)
        {
            LoadNotedap();
            LoadItemsCb();
            clbPassword.SetItemChecked(0, true);
           
        }


        private void btGenPassword_Click(object sender, EventArgs e)
        {
            if (clbPassword.CheckedItems.Count == 0) return;
            string password = "";
            for (int i=0; i<nudLengs.Value; i++)
            {
                int n = rnd.Next(0, clbPassword.CheckedItems.Count);
                string s = clbPassword.CheckedItems[n].ToString();
                switch(s)
                {
                    case "Цифры":password += rnd.Next(10).ToString();
                        break;
                    case "Прописные буквы":
                        password += Convert.ToChar(rnd.Next(65, 80));
                        break;
                    case "Строчные буквы":
                        password += Convert.ToChar(rnd.Next(97, 122));
                        break;
                    default:
                        password +=sp_char[rnd.Next(sp_char.Length)];
                        break;
                }
                tbPassword.Text = password;
                Clipboard.SetText(password);
            }
        }

        private void btConvert_Click(object sender, EventArgs e)
        {
            double m1 = metrica[cbIs.Text];
            double m2 = metrica[cbTo.Text];
            double num =Convert.ToDouble(tbIs.Text);
            tbTo.Text = (num * m1 / m2).ToString();
        }

        private void btSwap_Click(object sender, EventArgs e)
        {
            string t = cbIs.Text;
            cbIs.Text = cbTo.Text;
            cbTo.Text = t;
        }

        private void cbMetric_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbMetric.Text)
            {
                case "длинна":
                    metrica.Clear();
                    metrica.Add("мм", 1);
                    metrica.Add("см", 10);
                    metrica.Add("дц", 100);
                    metrica.Add("м", 1000);
                    metrica.Add("км", 1000000);
                    metrica.Add("миль", 1609344);

                    cbIs.Items.Clear();
                    cbIs.Items.Add("мм");
                    cbIs.Items.Add("см");
                    cbIs.Items.Add("дц");
                    cbIs.Items.Add("м");
                    cbIs.Items.Add("км");
                    cbIs.Items.Add("миль");
                    cbIs.Text = cbIs.Items[0].ToString();
                    LoadItemsCb();
                    break;

                case "вес":
                    metrica.Clear();
                    metrica.Add("гр", 1);
                    metrica.Add("кг", 1000);
                    metrica.Add("т", 1000000);
                    metrica.Add("фунт", 453.6);
                    metrica.Add("oz", 283);

                    cbIs.Items.Clear();
                    cbIs.Items.Add("гр");
                    cbIs.Items.Add("кг");
                    cbIs.Items.Add("т");
                    cbIs.Items.Add("фунт");
                    cbIs.Items.Add("oz");
                    cbIs.Text = cbIs.Items[0].ToString();
                    LoadItemsCb();
                    break;
                default:
                    break;
            }
        }
    }
}
   

