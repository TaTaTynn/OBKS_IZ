using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBKS_IZ
{
    
    public partial class RSA : Form
    {
        //Чтобы не тратить время на генерацию простых чисел, создадим массив с первыми простыми числами
        int[] prim_arr = new int[]
        {
        3,  5,  7,  11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71,
73, 79, 83, 89, 97, 101,    103,    107,    109,    113,    127,    131,    137,    139,    149,    151,    157,    163,    167,    173,
179,    181,    191,    193,    197,    199,    211,    223,    227,    229,    233,    239,    241,    251,    257,    263,    269,    271,    277,    281,
283,    293,    307,    311,    313,    317,    331,    337,    347,    349//,    353,    359,    367,    373,    379,    383,    389,    397,    401,    409,
//419,    421,    431,    433,    439,    443,    449,    457,    461,    463,    467,    479,    487,    491,    499,    503,    509,    521,    523,    541,
//547,    557,    563,    569,    571,    577,    587,    593,    599,    601,    607,    613,    617,    619,    631,    641,    643,    647,    653,    659,
//661,    673,    677,    683,    691,    701,    709,    719,    727,    733,    739,    743,    751,    757,    761,    769,    773,    787,    797,    809,
//811,    821,    823,    827,    829,    839,    853,    857,    859,    863,    877,    881,    883,    887,    907,    911,    919,    929,    937,    941,
//947,    953,    967,    971,    977,    983,    991,    997//,    1009,   1013,   1019,   1021,   1031,   1033,   1039,   1049,   1051,   1061,   1063,   1069,
//1087,   1091,   1093,   1097,   1103,   1109,   1117,   1123,   1129,   1151,   1153,   1163,   1171,   1181,   1187,   1193,   1201,   1213,   1217,   1223,
//1229,   1231,   1237,   1249,   1259,   1277,   1279,   1283,   1289,   1291,   1297,   1301,   1303,   1307,   1319,   1321,   1327,   1361,   1367,   1373,
//1381,   1399,   1409,   1423,   1427,   1429,   1433,   1439,   1447,   1451,   1453,   1459,   1471,   1481,   1483,   1487,   1489,   1493,   1499,   1511,
//1523,   1531,   1543,   1549,   1553,   1559,   1567,   1571,   1579,   1583,   1597,   1601,   1607,   1609,   1613,   1619,   1621,   1627,   1637,   1657,
//1663,   1667,   1669,   1693,   1697,   1699,   1709,   1721,   1723,   1733,   1741,   1747,   1753,   1759,   1777,   1783,   1787,   1789,   1801,   1811,
//1823,   1831,   1847,   1861,   1867,   1871,   1873,   1877,   1879,   1889,   1901,   1907,   1913,   1931,   1933,   1949,   1951,   1973,   1979,   1987,
//1993,   1997,   1999,   2003,   2011,   2017,   2027,   2029,   2039,   2053,   2063,   2069,   2081,   2083,   2087,   2089,   2099,   2111,   2113,   2129,
//2131,   2137,   2141,   2143,   2153,   2161,   2179,   2203,   2207,   2213,   2221,   2237,   2239,   2243,   2251,   2267,   2269,   2273,   2281,   2287,
//2293,   2297,   2309,   2311,   2333,   2339,   2341,   2347,   2351,   2357,   2371,   2377,   2381,   2383,   2389,   2393,   2399,   2411,   2417,   2423,
//2437,   2441,   2447,   2459,   2467,   2473,   2477,   2503,   2521,   2531,   2539,   2543,   2549,   2551,   2557,   2579,   2591,   2593,   2609,   2617,
//2621,   2633,   2647,   2657,   2659,   2663,   2671,   2677,   2683,   2687,   2689,   2693,   2699,   2707,   2711,   2713,   2719,   2729,   2731,   2741,
//2749,   2753,   2767,   2777,   2789,   2791,   2797,   2801,   2803,   2819,   2833,   2837,   2843,   2851,   2857,   2861,   2879,   2887,   2897,   2903,
//2909,   2917,   2927,   2939,   2953,   2957,   2963,   2969,   2971,   2999,   3001,   3011,   3019,   3023,   3037,   3041,   3049,   3061,   3067,   3079,
//3083,   3089,   3109,   3119,   3121,   3137,   3163,   3167,   3169,   3181,   3187,   3191,   3203,   3209,   3217,   3221,   3229,   3251,   3253,   3257,
//3259,   3271,   3299,   3301,   3307,   3313,   3319,   3323,   3329,   3331,   3343,   3347,   3359,   3361,   3371,   3373,   3389,   3391,   3407,   3413,
//3433,   3449,   3457,   3461,   3463,   3467,   3469,   3491,   3499,   3511,   3517,   3527,   3529,   3533,   3539,   3541,   3547,   3557,   3559,   3571

        };
        double p, q, n, fi, d1, d2, ee;

        private void textBox_e_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_e.Text, "[^0-9]"))
            {
                MessageBox.Show("Сдвиг должен быть числом");
                textBox_e.Text = textBox_e.Text.Remove(textBox_e.Text.Length - 1);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox_dec_output2.Text);
        }

        private void textBox_q_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_q.Text, "[^0-9]"))
            {
                MessageBox.Show("Параметр q должен быть числом");
                textBox_q.Text = textBox_q.Text.Remove(textBox_q.Text.Length - 1);
            }
        }

        private void textBox_p_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_p.Text, "[^0-9]"))
            {
                MessageBox.Show("Параметр p должен быть числом");
                textBox_p.Text = textBox_p.Text.Remove(textBox_p.Text.Length - 1);
            }
        }

        public RSA()
        {
            InitializeComponent();
        }
        private void button_rand_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            p = prim_arr[random.Next(prim_arr.Length)];
            do
                q = prim_arr[random.Next(prim_arr.Length)];
            while (p == q);
            n = p * q;
            textBox_o_key_n.Text = n.ToString();
            textBox_c_key1_n.Text = n.ToString();
            textBox_c_key2_n.Text = n.ToString();
            textBox_p.Text = p.ToString();
            textBox_q.Text = q.ToString();

            fi = (p - 1) * (q - 1);
            do
                ee = prim_arr[random.Next(prim_arr.Length)];
            while (ee >= fi || fi % ee == 0);
            textBox_o_key_e.Text = ee.ToString();
            textBox_e.Text = ee.ToString();

            //d1 = prim_arr[random.Next(prim_arr.Length)];
            d1 = 0;
            do
                d1++;
            while ((d1 * ee) % fi != 1);
            textBox_c_key1_d.Text = d1.ToString();

            d2 = d1;
            do
                d2++;
            while ((d2 * ee) % fi != 1);
            textBox_c_key2_d.Text = d2.ToString();

            textBox_enc_input_TextChanged(sender, e);
            textBox_dec_input_TextChanged(sender, e);
            textBox_dec_input2_TextChanged(sender, e);
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            if (textBox_p.Text == "" || textBox_q.Text == "" || textBox_e.Text == "")
            { MessageBox.Show("Введите параметры ключа"); return; }

            p=double.Parse(textBox_p.Text);
            q=double.Parse(textBox_q.Text);
            fi = (p - 1) * (q - 1);
            ee=double.Parse(textBox_e.Text);
            if(ee >= fi || fi % ee == 0)
            { MessageBox.Show("Подберите другой параметр e"); return; }

            textBox_o_key_e.Text = textBox_e.Text;

            n = p * q;
            textBox_o_key_n.Text = n.ToString();
            textBox_c_key1_n.Text = n.ToString();
            textBox_c_key2_n.Text = n.ToString();

            d1 = 0;
            do
                d1++;
            while ((d1 * ee) % fi != 1);
            textBox_c_key1_d.Text = d1.ToString();

            d2 = d1;
            do
                d2++;
            while ((d2 * ee) % fi != 1);
            textBox_c_key2_d.Text = d2.ToString();

            textBox_enc_input_TextChanged(sender, e);
            textBox_dec_input_TextChanged(sender, e);
            textBox_dec_input2_TextChanged(sender, e);
        }


        private void textBox_enc_input_TextChanged(object sender, EventArgs e)
        {
            // Проверки
            if (textBox_enc_input.Text == "")
                return;

            if (textBox_enc_input.Text[textBox_enc_input.Text.Length-1]>=(char)n)
            {
                MessageBox.Show("Шифруем символы от "+(char)1+" до "+ (char)(n-1));
                textBox_enc_input.Text = textBox_enc_input.Text.Remove(textBox_enc_input.Text.Length - 1);
                textBox_enc_input.SelectionStart = textBox_enc_input.Text.Length;
            }

            textBox_enc_output.Text = "";
            if (textBox_o_key_n.Text == "" || textBox_o_key_e.Text == "")
            { MessageBox.Show("Введите ключ!"); textBox_enc_input.Text = ""; return; }

            //double c = double.Parse(textBox_enc_input.Text);
            //if (c >= n)
            //{ MessageBox.Show("Можно шифровать числа только в пределах [0; n-1]"); textBox_dec_input.Text = ""; return; }
            ////double enc = Math.Pow(c, ee) % n;
            //double enc = c;
            //for (double i= 0; i < ee-1; i++)
            //{
            //    enc = (enc * c) % n;
            //}
            //textBox_enc_output.Text = enc.ToString();// ((char)(enc+'A'-1)).ToString();

            // Шифрование
            for (int i = 0; i < textBox_enc_input.Text.Length; i++)
            {
                int c = textBox_enc_input.Text[i];
                //Console.WriteLine("Код шифруемого символа " + textBox_enc_input.Text[i] + " равен " + c.ToString());
                double enc = c;
                for (double j = 0; j < ee - 1; j++)
                {
                    enc = (enc * c) % n;
                }
                char encrypted = (char)(enc);
                //Console.WriteLine("Код зашифрованного символа " + encrypted + " равен " + enc.ToString());
                textBox_enc_output.Text += encrypted;
            }
        }

        private void textBox_dec_input_TextChanged(object sender, EventArgs e)
        {
            // Проверки
            if (textBox_dec_input.Text == "")
                return;

            if (textBox_dec_input.Text[textBox_dec_input.Text.Length - 1] >= (char)n)
            {
                MessageBox.Show("Шифруем символы от " + (char)1 + " до " + (char)(n - 1));
                textBox_dec_input.Text = textBox_dec_input.Text.Remove(textBox_dec_input.Text.Length - 1);
                textBox_dec_input.SelectionStart = textBox_dec_input.Text.Length;
            }

            textBox_dec_output.Text = "";
            if (textBox_c_key1_n.Text == "" || textBox_c_key1_d.Text == "")
            { MessageBox.Show("Введите ключ!"); textBox_dec_input.Text = ""; return; }

            //double c = double.Parse(textBox_dec_input.Text);

            //if (c >= n)
            //{ MessageBox.Show("Можно шифровать числа только в пределах [0; n-1]"); textBox_dec_input.Text = ""; return; }

            //double dec = Math.Pow(c, d1) % n;
            //double dec = c;
            //for(double i = 0; i < d1-1; i++)
            //{
            //    dec = (dec * c) % n;
            //}
            //textBox_dec_output.Text = dec.ToString(); // ((char)(dec + 'A' - 1)).ToString();

            // Дешифрование
            for (int i = 0; i < textBox_dec_input.Text.Length; i++)
            {
                int c = textBox_dec_input.Text[i];
                //Console.WriteLine("Код дешифруемого символа " + textBox_dec_input.Text[i] + " равен " + c.ToString());
                double dec = c;
                for (double j = 0; j < d1 - 1; j++)
                {
                    dec = (dec * c) % n;
                }
                char decrypted = (char)(dec);
                //Console.WriteLine("Код расшифрованного символа " + decrypted +  " равен " + dec.ToString());
                textBox_dec_output.Text += decrypted;
            }
        }

        private void textBox_dec_input2_TextChanged(object sender, EventArgs e)
        {
            if (textBox_dec_input2.Text == "")
                return;

            if (textBox_dec_input2.Text[textBox_dec_input2.Text.Length - 1] >= (char)n)
            {
                MessageBox.Show("Шифруем символы от " + (char)1 + " до " + (char)(n - 1));
                textBox_dec_input2.Text = textBox_dec_input2.Text.Remove(textBox_dec_input2.Text.Length - 1);
                textBox_dec_input2.SelectionStart = textBox_dec_input2.Text.Length;
            }

            textBox_dec_output2.Text = "";
            if (textBox_c_key2_n.Text == "" || textBox_c_key2_d.Text == "")
            { MessageBox.Show("Введите ключ!"); textBox_dec_input2.Text = ""; return; }

            //double c = double.Parse(textBox_dec_input2.Text);

            //if (c >= n)
            //{ MessageBox.Show("Можно шифровать числа только в пределах [0; n-1]"); textBox_dec_input.Text = ""; return; }

            //double dec = Math.Pow(c, d2) % n;
            //textBox_dec_output2.Text = ((char)(dec + 'A' - 1)).ToString();

            for (int i = 0; i < textBox_dec_input2.Text.Length; i++)
            {
                int c = textBox_dec_input2.Text[i];
                double dec = c;
                for (double j = 0; j < d2 - 1; j++)
                {
                    dec = (dec * c) % n;
                }
                char decrypted = (char)(dec);
                textBox_dec_output2.Text += decrypted;
            }
        }
    }
}
