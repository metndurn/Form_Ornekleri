using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*textbox = metinkutusu kullanımı şöyledir genelde kullanıcıdan metin 
            girişi yapılması istenir biz burda kod tarafından ekrana cıktı verdık*/
            //textBox1.Text = "Bugun Hava Karli Ve Cok Soguk";

            /*textboxtan kullanarak kullanıcıdan aldığımız metinsel ifadeyi
             labela aktarıp ekrana cıktı olarak verdık
             alttaki projede ilgili labelları textboxlardan alıp diğer labellara
             aktardık ve bunları kullanıcıdan yaptık*/
            label6.Text = textBox1.Text;
            label7.Text = textBox2.Text;
            label8.Text = textBox3.Text;
            label9.Text = textBox4.Text;
        }
    }
}
