using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorStatic
{
    public partial class FormJako : Form
    {
        public FormJako()
        {
            InitializeComponent();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            int yksi, kaksi, yhteensa;
            yksi = int.Parse(textBox1.Text);
            kaksi = int.Parse(textBox2.Text);
            yhteensa = Calculate.plussaa(yksi, kaksi);
            label1.Text = "result is" + " " + yhteensa;
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            int yksi, kaksi, yhteensa;
            yksi = int.Parse(textBox1.Text);
            kaksi = int.Parse(textBox2.Text);
            yhteensa = Calculate.minus(yksi, kaksi);
            label1.Text = "result is" + " " + yhteensa;
        }
        private void buttonKerto_Click(object sender, EventArgs e)
        {
            int yksi, kaksi, yhteensa;
            yksi = int.Parse(textBox1.Text);
            kaksi = int.Parse(textBox2.Text);
            yhteensa = Calculate.kerto(yksi, kaksi);
            label1.Text = "result is" + " " + yhteensa;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int yksi, kaksi, yhteensa;
            yksi = int.Parse(textBox1.Text);
            kaksi = int.Parse(textBox2.Text);
            yhteensa = Calculate.jako(yksi, kaksi);
            label1.Text = "result is" + " " + yhteensa;
        }

        public class Calculate
        {
            public static int plussaa(int yksi, int kaksi)
            {
                int yhteensa;
                yhteensa = yksi + kaksi;
                return yhteensa;
            }
            public static int minus(int yksi, int kaksi)
            {
                int yhteensa;
                yhteensa = yksi - kaksi;
                return yhteensa;
            }
            public static int kerto(int yksi, int kaksi)
            {
                int yhteensa;
                yhteensa = yksi * kaksi;
                return yhteensa;
            }
            public static int jako(int yksi, int kaksi)
            {
                int yhteensa;
                yhteensa = yksi / kaksi;
                return yhteensa;
            }


        }

      
    }
}
