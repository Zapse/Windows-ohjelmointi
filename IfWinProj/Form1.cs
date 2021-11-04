using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfWinProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // luodaan b tyyppinen atribuutti 
            int b;
            b = int.Parse(textBox1.Text);

            if (b == 1)
            {
                label2.Text = "voitit veneen";
            }
            if (b == 2)
            {
                label2.Text = "voitit talon";
            }
            if (b == 3)
            {
                label2.Text = "voitit euron";
            }
            else if (b >= 4)
                label2.Text = "Laita numero 1, 2 tai 3";
        }
    }
}
