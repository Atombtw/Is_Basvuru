using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_İş_Başvuru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] diller = { "C#", "C++", "C+", "HTML", "Java", "JavaScript" };
            checkedListBox1.Items.AddRange(diller);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Ad Soyad
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Ad Soyad Giriniz!");
            }
            else
            {
                label6.Text = textBox1.Text;
            }

            if (checkedListBox1.Items.IndexOf(0) == Convert.ToInt32(true))
            {
                label7.Text = Convert.ToString(checkedListBox1.Items.IndexOf(0));
            }

            //Diller
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Lütfen Bildiğiniz Dilleri Seçiniz!");
            }
            else
            {
                string diller = null;
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                {
                    diller += ", " + checkedListBox1.CheckedItems[i];
                }
                diller = diller.Substring(2);
                label7.Text = diller;
            }

            //Mezuniyeti
            if (radioButton1.Checked == true)
            {
                label8.Text = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                label8.Text = radioButton2.Text;
            }
            else if (radioButton3.Checked == true)
            {
                label8.Text = radioButton3.Text;
            }
            else if (radioButton4.Checked == true)
            {
                label8.Text = radioButton4.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Contains(textBox2.Text) == false)
            {
                checkedListBox1.Items.Add(textBox2.Text);
            }
            else
            {
                MessageBox.Show("Girilen Dil Zaten Mevcut!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == null)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            while(checkedListBox1.CheckedIndices.Count > 0)
            {
                checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0], false);
            }
        }
    }
}
