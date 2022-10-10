using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBKS_IZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form tsez = new Tsezar();
            tsez.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form vig = new Vigenere();
            vig.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form xor = new XOR();
            xor.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form rsa = new RSA();
            rsa.ShowDialog();
        }
    }
}
