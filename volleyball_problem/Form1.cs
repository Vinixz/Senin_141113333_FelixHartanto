using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volleyball_problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int mod = 1000000007;

        static int pascal(int a, int b)
        {
            int[] tp = new int[b];
            for (int i = 0; i < b; i++)
            {
                tp[i] = 1;
            }

            for (int i = b - 2; i > 0; i--)
            {
                for (int j = i; j < b - 1; j++)
                {
                    tp[j] += tp[j + 1];
                    tp[j] %= mod;
                }
            }
            int game = 1;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b - 1; j++)
                {
                    tp[j] += tp[j + 1];
                    tp[j] %= mod;
                }

                game += tp[0];
                game %= mod;
            }
            return game;
        }

        static long expo(long x, long exp_a)
        {
            long result = 1;
            while (exp_a > 0)
            {
                if (exp_a % 2 == 1)
                {
                    result *= x;
                    result %= mod;
                }
                exp_a /= 2;
                x *= x;
                x %= mod;
            }
            return result % mod;
        }

        private void btn_Hitung_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tb_A.Text);
            int b = Convert.ToInt32(tb_B.Text); 

            int temp;
            long result;
  
            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            if (a == 25 && b <= 23)
            {
                if (b < 1)
                {
                    tb_Hasil.Text = "1";
                }
                else
                {
                    result = (long)pascal(a - 1, b);
                    tb_Hasil.Text = result.ToString();
                }
            }
            else if (a > 25 && b == a - 2)
            {
                result = (long)pascal(24, 24);
                int exp_a = b - 24;
                result *= expo(2, exp_a);
                result %= mod;
                tb_Hasil.Text = result.ToString();
            }
            else
            {
                tb_Hasil.Text = "0";
            }
        }
    }
}
