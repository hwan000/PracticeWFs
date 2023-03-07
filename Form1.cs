using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace practiceWFs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int text1 = 0;
        int text2 = 0;
        int plusText;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            text1 = int.Parse(textBox1.Text);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            text2 = int.Parse(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plusText = text1 + text2;

            label1.Text = plusText.ToString();
        }
    }
}
