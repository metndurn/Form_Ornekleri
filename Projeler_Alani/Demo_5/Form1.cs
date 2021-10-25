using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*burada bütün degerleri kullanıcıdan aldırıp listbox'ın ıcıne aktardık*/
            listBox1.Items.Add(textName.Text + " " + textSurName.Text + " " + comboCinsiyet.Text + " " + comboDurum.Text);
        }
    }
}
