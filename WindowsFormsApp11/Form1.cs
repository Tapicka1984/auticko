using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("máme auto TATRA T 815 o nostnosti 26 tun - mínus průměrný řidič takže 25,8");
        }

        int pocitadlo_kliku = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if ((textBox1.Text == string.Empty) || (textBox2.Text == string.Empty))
            {
                MessageBox.Show("jeden textbox je empty");
            }
            else
            {
                double hmotnost_nakladu = double.Parse(textBox1.Text);
                Nakladni_auto Auto = new Nakladni_auto(hmotnost_nakladu);
                MessageBox.Show(Auto.NalozNaklad());

                double hmotnost_vykladky = double.Parse(textBox2.Text);
                Auto.VylozNaklad(hmotnost_vykladky);
                MessageBox.Show(Auto.VylozNaklad(hmotnost_vykladky));
            }
        }
    }
}
