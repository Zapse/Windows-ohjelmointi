using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Laskin 4 eri laskutoimituksella, muutetaan lopuksi atribuutti j stringiksi, jotta voimme printata sen label komponenttiin.
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            int a, b, j;

            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            j = a + b;
            labelR.Text = j.ToString();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            int a, b, j;

            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            j = a - b;
            labelR.Text = j.ToString();

        }

        private void buttonKerto_Click(object sender, EventArgs e)
        {
            int a, b, j;

            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            j = a * b;
            labelR.Text = j.ToString();
        }

        private void buttonJako_Click(object sender, EventArgs e)
        {
            int a, b, j;

            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            j = a / b;
            labelR.Text = j.ToString();
        }
    }
}
