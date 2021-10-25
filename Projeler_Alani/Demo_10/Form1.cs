using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*burda butana basarken richtextboxa kod tarafından metın yazdırdık
             bunu daha cok dus bır satıra sıgmayan cumleler ıcın kullanırız ve 
             yazılan her metnı satır bıterken alt alta getırır*/
            richTextBox1.Text = "Hayatta En Hakiki Mursit Ilimdir, Fendir.!";
        }
    }
}
