using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*kullanıcıdan deger girmesini istemistik ve istedigimiz degeri
             textbox'tan aldırıp listbox'ın icine aktardık ve bunların hepsini
             kod yazarke sandan sola aktarildiginide unutmamak gerek*/
            listBox1.Items.Add(textBox1.Text);
        }
    }
}
