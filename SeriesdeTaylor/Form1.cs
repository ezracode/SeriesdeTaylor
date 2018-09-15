using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SeriesdeTaylor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double factorial(double n)
        {
            double i = 0;
            double j = 1;
            for (i = 1; i <= n; i++)
            {
                j = i * j;
            }
            return j;
        }

        private double elevar(double x, double n)
        {
            double i = 0;
            double j = 1;
            for (i = 1; i <= n; i++)
            {
                j = j * x;
            }
            return j;
        }

        private double exponencial(double x, double n)
        {
            double i = 0;
            double j = 0;
            for (i = 0; i <= n; i++)
            {
                j = j + elevar(x, i) / factorial(i);
                //MessageBox.Show("" + i + " - " + factorial(i) + " - "  + elevar(x, i) + " - " + j);
            }
            return j;
        }

        private int menosunoalan(double n) {
            if (n % 2 == 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        private double logaritmo_natural(double x, double n)
        {
            double i = 0;
            double j = 0;
            for (i = 1; i <= n; i++)
            {
                j = j + menosunoalan(i + 1) * elevar(x, i) / i;
                //MessageBox.Show("" + i + " - " + factorial(i) + " - "  + elevar(x, i) + " - " + j);
            }
            return j;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Xp = 0;
            double np = 0;

            Xp = double.Parse (X.Text);
            np = double.Parse(n.Text);

            //MessageBox.Show("" + factorial(np));
            //MessageBox.Show("" + elevar(Xp, np));
            //MessageBox.Show("" + exponencial(Xp, np));
            textBox1.Text = "" + exponencial(Xp, np);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Xp = 0;
            double np = 0;

            Xp = double.Parse(X.Text);
            np = double.Parse(n.Text);

            //MessageBox.Show("" + factorial(np));
            //MessageBox.Show("" + elevar(Xp, np));
            //MessageBox.Show("" + exponencial(Xp, np));
            textBox2.Text = "" + logaritmo_natural(Xp, np);
        }
    }
}
