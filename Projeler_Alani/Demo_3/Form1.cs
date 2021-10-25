using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*combobox seçim yaptırmak icin kullanılır burada kod tarafından
             button ile cıktı verdırdık*/
            //comboBox1.Items.Add("Trabzon");
            //KULLANICIDAN TEXTBOXTA VERİYİ ALIP COMBOBOXIN ICINE ATTIK
            comboBox1.Items.Add(textBox1.Text);
        }
    }
}
