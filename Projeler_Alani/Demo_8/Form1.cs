using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*burada 2 tane groupbox kullanarak hepsını aynı sablonda tutup 
             gırdı verılerını kullanıcıdan aldırıp lıstboxta gosterdık*/
            listBox1.Items.Add(textBox1.Text + " " + maskedTextBox1.Text + " " + maskedTextBox2.Text + " " + textBox2.Text + " " + comboBox1.Text + " " + textBox3.Text + " " + maskedTextBox3.Text);
        }
    }
}
