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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace OBKS_IZ
{
    public partial class Vigenere : Form
    {
        char a, A, z, Z; // Первые и последние буквы алфавитов
        int len = 0;
        string key = "";
        Dictionary<char, Dictionary<char, char>> vigRu = new Dictionary<char, Dictionary<char, char>>();
        Dictionary<char, Dictionary<char, char>> vigEn = new Dictionary<char, Dictionary<char, char>>();
        public Vigenere()
        {
            // Инициализируем таблицы
            a = 'a'; A = 'A'; z = 'z'; Z = 'Z'; vigEn = initTable(); // Для шифрования на английском
            a = 'а'; A = 'А'; z = 'я'; Z = 'Я'; vigRu = initTable(); // Для шифрования на русском
            InitializeComponent();
            comboBox_lang.SelectedIndex = 0;
        }
        Dictionary<char, Dictionary<char, char>> initTable()
        {
            Dictionary<char, Dictionary<char, char>> vig = new Dictionary<char, Dictionary<char, char>>();
            for (char c = a; c <= z; c++)
            {
                Console.Write(c + "  ");
                vig.Add(c, new Dictionary<char, char>());
                for (char s = a; s <= z; s++)
                {
                    char l = (char)(c - a + s);
                    if (!isLatinSmall(l) && z=='z' || !isCyrillSmall(l) && z=='я')
                        l = (char)(l - z + a - 1);
                    vig[c].Add(s, l);
                    Console.Write(l);
                }
                Console.WriteLine();
            }
            return vig;
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
            if (key == "")
            { MessageBox.Show("Введите ключ!"); textBox_enc_input.Text = ""; return; }

            for (int i = 0; i < textBox_enc_input.Text.Length; i++)
            {
                char c = textBox_enc_input.Text[i];
                if (isCyrillBig(c) || isLatinBig(c))
                {
                    textBox_enc_input.Text = textBox_enc_input.Text.Remove(textBox_enc_input.Text.Length - 1);
                    textBox_enc_input.Text += (char)(c + a - A);
                    textBox_enc_input.SelectionStart=textBox_enc_input.Text.Length;
                    c = (char)(c + a - A);
                }
                if (isCyrillSmall(c))
                {
                    char encrypted = vigRu[c][key[i % key.Length]];
                    textBox_enc_output.Text += encrypted;
                }
                else if (isLatinSmall(c))
                {
                    char encrypted = vigEn[c][key[i % key.Length]];
                    textBox_enc_output.Text += encrypted;
                }
                else
                {
                    textBox_enc_output.Text += textBox_enc_input.Text[i];
                }
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

        private void button_apply_Click(object sender, EventArgs e)
        {
            if (textBox_key.Text == "")
            {
                MessageBox.Show("Введите ключ");
            }
            key = textBox_key.Text;
            textBox_enc_input_TextChanged(sender, e);
        }

        private void textBox_dec_input_TextChanged(object sender, EventArgs e)
        {
            textBox_dec_output.Text = "";
            if (key == "")
            { MessageBox.Show("Введите ключ!"); textBox_dec_input.Text = ""; return; }

            for (int i = 0; i < textBox_dec_input.Text.Length; i++)
            {
                char c = textBox_dec_input.Text[i];
                if (isCyrillBig(c) || isLatinBig(c))
                {
                    textBox_dec_input.Text = textBox_dec_input.Text.Remove(textBox_dec_input.Text.Length - 1);
                    textBox_dec_input.Text += (char)(c + a - A);
                    textBox_dec_input.SelectionStart = textBox_dec_input.Text.Length;
                    c = (char)(c + a - A);
                }
                if (isCyrillSmall(c))
                {
                    char decrypted = ' ';
                    for (char n = a; n <= z; n++)
                    {
                        if (vigRu[n][key[i % key.Length]] == c)
                        {
                            decrypted = n;
                            break;
                        }
                    }
                    textBox_dec_output.Text += decrypted;
                }
                else if (isLatinSmall(c))
                {
                    char decrypted = ' ';
                    for (char n = a; n <= z; n++)
                    {
                        if (vigEn[n][key[i % key.Length]] == c)
                        {
                            decrypted = n;
                            break;
                        }
                    }
                    textBox_dec_output.Text += decrypted;
                }
                else
                {
                    textBox_dec_output.Text += textBox_dec_input.Text[i];
                }
            }
        }

        private void textBox_key_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox_key.Text.Length; i++)
            {
                char c = textBox_key.Text[i];
                if (!(isCyrillBig(c) || isLatinBig(c) || isCyrillSmall(c) || isLatinSmall(c)))
                {
                    MessageBox.Show("Вводите буквы");
                    textBox_key.Text = textBox_key.Text.Remove(textBox_key.Text.Length - 1);
                    textBox_key.SelectionStart = textBox_key.Text.Length;
                    return;
                }
                if (isCyrillBig(c) || isLatinBig(c))
                {
                    textBox_key.Text = textBox_key.Text.Remove(textBox_key.Text.Length - 1);
                    textBox_key.Text += (char)(c + a - A);
                    textBox_key.SelectionStart = textBox_key.Text.Length;
                }
                if (comboBox_lang.SelectedIndex == 0 && isCyrillSmall(c) || comboBox_lang.SelectedIndex == 1 && isLatinSmall(c))
                {
                    MessageBox.Show("Язык ключа не совпадает с выбранным");
                    textBox_key.Text = textBox_key.Text.Remove(textBox_key.Text.Length - 1);
                    textBox_key.SelectionStart = textBox_key.Text.Length;
                }
            }
        }

        Label letterLabel(int i, int j)
        {
            Label letter = new Label();
            char l = ' ';
            if (j == 0 && i > 0)
            {
                l = (char)(A + i - 1);
                letter.Font = new Font(letter.Font, FontStyle.Bold);
            }
            else if (j > 0 && i == 0)
            {
                l = (char)(A + j - 1);
                letter.Font = new Font(letter.Font, FontStyle.Bold);
            }
            else if (j>0 && i>0)
            {
                l = (char)(a + i + j - 2);
                if (!isLatinSmall(l) && comboBox_lang.SelectedIndex == 0 || !isCyrillSmall(l) && comboBox_lang.SelectedIndex == 1)
                {
                    l = (char)(l - z + a - 1);
                    letter.Font = new Font(letter.Font, FontStyle.Regular);
                }
            }
            letter.Margin = new Padding(0, 0, 0, 0);
            letter.Text = l.ToString();
            return letter;
        }
        private void comboBox_lang_SelectedIndexChanged(object sender, EventArgs e)
        {
            table_letters.Controls.Clear();

            if (comboBox_lang.SelectedIndex == 0)
            { a = 'a'; A = 'A'; z = 'z'; Z = 'Z'; picture_table.Image = OBKS_IZ.Properties.Resources.visEn; }
            else { a = 'а'; A = 'А'; z = 'я'; Z = 'Я'; picture_table.Image = OBKS_IZ.Properties.Resources.visRu; }

            textBox_key.Text = "";
            textBox_enc_input.Text = "";
            textBox_dec_input.Text = "";

            len = (int)(Z - A);

            //// Перерисовываем таблицу
            //for (int i = 0; i < len + 2; i++)
            //    for (int j = 0; j < len + 2; j++)
            //        table_letters.Controls.Add(letterLabel(i, j), i, j);

        }
    }
}
