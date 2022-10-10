using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OBKS_IZ
{
    public partial class Tsezar : Form
    {
        int shift = 0;
        public Tsezar()
        {
            InitializeComponent();
        }

        private void textBox_shift_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_shift.Text, "[^0-9]"))
            {
                MessageBox.Show("Сдвиг должен быть числом");
                textBox_shift.Text = textBox_shift.Text.Remove(textBox_shift.Text.Length - 1);
            }
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            if (textBox_shift.Text=="")
            {
                MessageBox.Show("Введите сдвиг");
            }
            else
            {
                shift = int.Parse(textBox_shift.Text);
                textBox_enc_input_TextChanged(sender, e);
                textBox_dec_input_TextChanged(sender, e);
            }
        }

        private void button_rand_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            shift = rnd.Next(100);
            textBox_shift.Text = shift.ToString();
            textBox_enc_input_TextChanged(sender, e);
            textBox_dec_input_TextChanged(sender, e);
        }

        private void button_enc_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox_enc_output.Text);
        }

        private void button_dec_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox_dec_output.Text);
        }
        bool isCyrillSmall(char c)
        {
            return ((c >= 'а') && (c <= 'я'));
        }
        bool isCyrillBig(char c)
        {
            return ((c >= 'А') && (c <= 'Я'));
        }
        bool isLatinSmall(char c)
        {
            return ((c >= 'a') && (c <= 'z'));
        }
        bool isLatinBig(char c)
        {
            return ((c >= 'A') && (c <= 'Z'));
        }
        private void textBox_enc_input_TextChanged(object sender, EventArgs e)
        {
            textBox_enc_output.Text = "";
            if (shift == 0)
            { MessageBox.Show("Введите сдвиг!"); return; }
            for (int i = 0; i < textBox_enc_input.Text.Length; i++)
            {
                if (isCyrillSmall(textBox_enc_input.Text[i]) || isCyrillBig(textBox_enc_input.Text[i]))
                {
                    int count = (int)('Я' - 'А');
                    int move = shift % count;
                    char encrypted = (char)(textBox_enc_input.Text[i] + move);
                    if (isCyrillBig(textBox_enc_input.Text[i]) && !isCyrillBig(encrypted))
                    {
                        encrypted = (char)(encrypted - count);
                    }
                    if (isCyrillSmall(textBox_enc_input.Text[i]) && !isCyrillSmall(encrypted))
                    {
                        encrypted = (char)(encrypted - count);
                    }
                    textBox_enc_output.Text += encrypted;
                }
                else if (isLatinBig(textBox_enc_input.Text[i]) || isLatinSmall(textBox_enc_input.Text[i]))
                {
                    int count = (int)('Z' - 'A');
                    int move = shift % count;
                    char encrypted = (char)(textBox_enc_input.Text[i] + move);
                    if (isLatinBig(textBox_enc_input.Text[i]) && !isLatinBig(encrypted))
                    {
                        encrypted = (char)(encrypted - count);
                    }
                    if (isLatinSmall(textBox_enc_input.Text[i]) && !isLatinSmall(encrypted))
                    {
                        encrypted = (char)(encrypted - count);
                    }
                    textBox_enc_output.Text += encrypted;
                }
                else
                {
                    textBox_enc_output.Text += textBox_enc_input.Text[i];
                }
            }
        }

        private void textBox_dec_input_TextChanged(object sender, EventArgs e)
        {
            textBox_dec_output.Text = "";
            for (int i = 0; i < textBox_dec_input.Text.Length; i++)
            {
                if (isCyrillSmall(textBox_dec_input.Text[i]) || isCyrillBig(textBox_dec_input.Text[i]))
                {
                    int count = (int)('Я' - 'А');
                    int move = shift % count;
                    char decrypted = (char)(textBox_dec_input.Text[i] - move);
                    if (isCyrillBig(textBox_dec_input.Text[i]) && !isCyrillBig(decrypted))
                    {
                        decrypted = (char)(decrypted + count);
                    }
                    if (isCyrillSmall(textBox_dec_input.Text[i]) && !isCyrillSmall(decrypted))
                    {
                        decrypted = (char)(decrypted + count);
                    }
                    textBox_dec_output.Text += decrypted;
                }
                else if (isLatinBig(textBox_dec_input.Text[i]) || isLatinSmall(textBox_dec_input.Text[i]))
                {
                    int count = (int)('Z' - 'A');
                    int move = shift % count;
                    char decrypted = (char)(textBox_dec_input.Text[i] - move);
                    if (isLatinBig(textBox_dec_input.Text[i]) && !isLatinBig(decrypted))
                    {
                        decrypted = (char)(decrypted + count);
                    }
                    if (isLatinSmall(textBox_dec_input.Text[i]) && !isLatinSmall(decrypted))
                    {
                        decrypted = (char)(decrypted + count);
                    }
                    textBox_dec_output.Text += decrypted;
                }
                else
                {
                    textBox_dec_output.Text += textBox_dec_input.Text[i];
                }
            }
        }
    }
}
