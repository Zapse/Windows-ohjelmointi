using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.Red;
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel1.Cursor = Cursors.Cross;
            textBox1.Text = "Cursor is cross";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Cursor = Cursors.Hand;
            textBox1.Text = "Cursor is hand";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = "Cursor is normal";
        }

       
    }
}
