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
        static long expo(long x, long n)
        {
            long result = 1;
            while (n > 0)
            {
                if (n % 2 == 1)
                {
                    result *= x;
                    result %= mod;
                }
                n /= 2;
                x *= x;
                x %= mod;
            }
            return result % mod;
        }

        private void btn_Hitung_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Txt1.Text);
            int b = Convert.ToInt32(Txt2.Text);

            double hasil;
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
                    TxtHasil.Text = "1";
                }
                else
                {
                    result = (long)pascal(a - 1, b);
                    TxtHasil.Text = result.ToString();
                }
            }
            else if (a > 25 && b == a - 2)
            {
                result = (long)pascal(24, 24);
                int n = b - 24;
                //hasil = (double) result;
                result *= expo(2, n);
                result %= mod;
                TxtHasil.Text = result.ToString();
            }
            else
            {
                TxtHasil.Text = "0";
            }
        }
    }
}
