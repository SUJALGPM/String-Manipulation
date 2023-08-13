using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STRINGMNP
{
    public partial class Form1 : Form
    {
        public static Form1 obj;
        public TextBox txt1;
        public Form1()
        {
            InitializeComponent();
            obj = this;
            txt1 = textBox3;
        }

        private void groupBox1_Leave(object sender, EventArgs e)
        {/*
            if (String.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "FIRST ENTER STR");
            }
            else
            {
                errorProvider1.Clear();
            }*/
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text) == true)
            {
                textBox2.Focus();
                errorProvider2.SetError(textBox2, "FIRST ENTER STR");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String txt1 = textBox1.Text + textBox2.Text;
            Form1.obj.txt1.Text = txt1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean txt1 = textBox1.Text.Equals(textBox2.Text);
            Form1.obj.txt1.Text = "str1 and str2 = " + txt1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String txt1 = textBox1.Text + textBox2.Text;
            String str = txt1.ToUpper();
            Form1.obj.txt1.Text = str;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String txt1 = textBox1.Text + textBox2.Text;
            String str1 = txt1.ToLower();
            Form1.obj.txt1.Text = str1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String txt1 = textBox1.Text + textBox2.Text;
            String str2 = txt1.Replace("s","a");
            Form1.obj.txt1.Text = str2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String txt1 = textBox1.Text + textBox2.Text;
            String reverse = "";
            int num = 0;
            num = txt1.Length - 1;
            while (num >= 0){
                reverse = reverse + txt1[num];
                num--;
            }
            Form1.obj.txt1.Text = reverse;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "First Enter str");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
