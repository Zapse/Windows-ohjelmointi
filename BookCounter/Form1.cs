using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace BookCounter
{
    
    public partial class Form1 : Form
    {   // tehdään bookarray jolle luodaan maxluku 100
        private const int MAX_BOOK = 100;
        private Book[] bookArray = new Book[MAX_BOOK];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //save
        {
            Book book = new Book();
            book.kirjanNimi = textBox1.Text;
            book.kirjailia = textBox2.Text;
            //muistutetaan, että lisää bookarrayhin kirjan
            bookArray[book.numero - 1] = book;
            //if (book.numero > (MAX_BOOK - 1)) button1.Enabled = false;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e) // print
        {
            textBox3.Text = "";
            for (int i = 0; i < Book.laskija; i++)
            {
                textBox3.Text = textBox3.Text + bookArray[i].kirjanNimi + "" + bookArray[i].kirjailia + " ";  //bookArray[i].numero + Environment.NewLine;
            }
        }

        public class Book
        {
            public string kirjanNimi {get; set;}
            public string kirjailia { get; set;}
            public int numero { get; set; }

            public static int laskija ;

            public Book()
            {
                laskija++;
                this.numero = laskija;
            }
        }
    }
}
