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
    public partial class luasTrapesium : Form
    {
        public luasTrapesium()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sisia = Convert.ToInt32(textBox1.Text);
            int sisib = Convert.ToInt32(textBox2.Text);
            int tinggi  = Convert.ToInt32(textBox3.Text);
            double luas;

            luas = (0.5 * (sisia + sisib) * tinggi);
            textBox4.Text = luas.ToString();
        }
    }
}
