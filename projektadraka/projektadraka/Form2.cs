using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektadraka
{
    public partial class Form2 : Form
    {
        public string tekst = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = tekst;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tekst = textBox1.Text;
        }
    }
}
