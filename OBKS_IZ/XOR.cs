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
    public partial class XOR : Form
    {
        int key = 0;
        public XOR()
        {
            InitializeComponent();
        }

        private void textBox_key_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_key.Text, "[^0-9]"))
            {
                MessageBox.Show("Сдвиг должен быть числом");
                textBox_key.Text = textBox_key.Text.Remove(textBox_key.Text.Length - 1);
            }
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            if (textBox_key.Text == "")
            {
                MessageBox.Show("Введите сдвиг");
            }
            else
            {
                key = int.Parse(textBox_key.Text);
                textBox_enc_input_TextChanged(sender, e);
                textBox_dec_input_TextChanged(sender, e);
            }
        }

        private void textBox_enc_input_TextChanged(object sender, EventArgs e)
        {
            textBox_enc_output.Text = "";
            if (key == 0)
            { MessageBox.Show("Введите ключ!"); return; }
            for (int i = 0; i < textBox_enc_input.Text.Length; i++)
            {
                char c = textBox_enc_input.Text[i];
                char encrypted = (char)(c^key);
                textBox_enc_output.Text += encrypted;
            }
        }

        private void button_rand_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            key = rnd.Next();
            textBox_key.Text = key.ToString();
            textBox_enc_input_TextChanged(sender, e);
            textBox_dec_input_TextChanged(sender, e);
        }

        private void textBox_dec_input_TextChanged(object sender, EventArgs e)
        {
            textBox_dec_output.Text = "";
            if (key == 0)
            { MessageBox.Show("Введите ключ!"); return; }
            for (int i = 0; i < textBox_dec_input.Text.Length; i++)
            {
                char c = textBox_dec_input.Text[i];
                char decrypted = (char)(c ^ key);
                textBox_dec_output.Text += decrypted;
            }
        }

        private void button_enc_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox_enc_output.Text);
        }

        private void button_dec_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox_dec_output.Text);
        }
    }
}
