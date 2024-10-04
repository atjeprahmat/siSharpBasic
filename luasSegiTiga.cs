using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siSharpBasic
{
    public partial class luasSegiTiga : Form
    {
        public luasSegiTiga()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int alas = Convert.ToInt32(textBox1.Text);
            int tinggi = Convert.ToInt32(textBox2.Text);
            double luas;

            luas = (0.5 * alas * tinggi);
            textBox3.Text = luas.ToString();
            
        }
    }
}
