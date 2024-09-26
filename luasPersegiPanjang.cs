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
    public partial class luasPersegiPanjang : Form
    {
        public luasPersegiPanjang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int panjang = Convert.ToInt32(textBox1.Text);
            int lebar = Convert.ToInt32(textBox2.Text);
            int luas;

            luas = panjang * lebar;
            textBox3.Text = luas.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
