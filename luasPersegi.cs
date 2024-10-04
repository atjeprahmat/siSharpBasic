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
    public partial class luasPersegi : Form
    {
        public luasPersegi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sisi = Convert.ToInt32(textBox1.Text);
            int luas;
            luas = sisi * sisi;
            textBox2.Text = luas.ToString();
            
        }
    }
}
