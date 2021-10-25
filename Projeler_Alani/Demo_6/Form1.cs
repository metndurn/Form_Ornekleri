using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*burada maskedtextbox kullanımını gorduk ve kullanıcıdan verileri alıp
             labellara aktarıp gosterdık tarih ve telefon aldık*/
            label3.Text = maskedTextBox1.Text;
            label4.Text = maskedTextBox2.Text;
        }
    }
}
