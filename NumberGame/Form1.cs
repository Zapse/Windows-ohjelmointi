using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class numerot
        {
            int a, b, c, result;
            private string teksti;
            
            public numerot(int numeroKaksi, int numeroKolme, int oikeaVastaus)
            {
                
                b = numeroKaksi;
                c = numeroKolme;
                result = oikeaVastaus;
                
            }

            public numerot(String tekstii)
            {
                this.teksti = tekstii;
                if (tekstii == "1")
                {
                    
                }
            }
           
        }

            

        private void button1_Click(object sender, EventArgs e)
        {
            numerot numero = new numerot(this.textBox1.Text);
            if (textBox1.Text == "1")
            {
                textBoxAnswer.Text = "oikein";
            }
        }
    }
}
