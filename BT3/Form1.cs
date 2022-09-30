using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }


        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void buttonNhap_Click(object sender, EventArgs e)
        {
            List<int> listAll = new List<int>() { 1645, 1689, 8345, 9998, 1006, 1008 };
            List<int> listScientist = new List<int>() { 9998, 1006, 1008 };
            List<int> listCustodians = new List<int>() { 8345 };
            List<int> listTechnicians = new List<int>() { 1645, 1689 };
            int number = Convert.ToInt32(textBox1.Text);
            DateTime aDateTime = DateTime.Now;
            if (listAll.Contains(number))
            {
                foreach (int i in listScientist)
                {
                    if (i == number)
                    {
                        listBox1.Items.Add(aDateTime + " " + "Scientist");
                    }
                }
                foreach (int i in listCustodians)
                 {
                    if (i == number)
                     {
                        listBox1.Items.Add(aDateTime + " " + "Custodians");
                     }

                 }
                foreach (int i in listTechnicians)
                 {
                    if (i == number)
                     {
                          listBox1.Items.Add(aDateTime + " " + "Technicians");
                     }
                 }
            } else{
                listBox1.Items.Add(aDateTime + " " + "Restricted Access!");
            }  
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string path = "";
            StreamWriter streamWriter;
            path = "../TextFile4.txt";
            if (!File.Exists(path))
            {
                streamWriter = new StreamWriter(path);
                foreach(string item in listBox1.Items)
                {
                    streamWriter.WriteLine(item);
                }
                MessageBox.Show("Save", "Lưu file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                streamWriter.Close();
            } else
            {
                streamWriter = File.AppendText(path);
                foreach (string item in listBox1.Items)
                {
                    streamWriter.WriteLine(item);
                }
                MessageBox.Show("Lưu thành công","Lưu file",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}
