using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*label=etiket görevi görür 
             button ise bir işlemi yapmak için aldığı komutları yapar*/
            /*burada button ve label araclarını kullandık ve ekrana kod 
             tarafından cıktı verdırdık labelın yanındaki text komutu ilgili 
             labelin "metin" kısmına istediğimiz alfabetik ifadeyi yazdırmaya
             için kullanırız ve burda ad soyad ve mesleğimizi butona basarak
             gerekli labellarda gösterdik*/
            label1.Text = "Metin";
            label2.Text = "Duran";
            label3.Text = "Yazilimci";
        }
    }
}
