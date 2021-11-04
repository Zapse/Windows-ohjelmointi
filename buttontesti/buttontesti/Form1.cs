using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttontestipaska
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Klassi eka;
            Class1 ekalaussi;

            ekalaussi = new Class1();
            ekalaussi.Sukunimi = "Lindemannit";

            eka = new Klassi("tenho", ekalaussi);
            textBox1.Text = eka.Name + " " + eka.Suku.Sukunimi;

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "hello you";
        }

        public class Klassi
        {
            public string Name { get; set; }
            public Class1 Suku { get; set; }
            public Musti
            public Klassi(string pname, Class1 psuku, Class1 joku)
            {
                Name = pname;
                Suku = psuku;
            }
        }
    }
}
