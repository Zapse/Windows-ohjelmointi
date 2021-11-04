using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Tee ohjelma (Books-projekti), jossa on Book-luokka. Book-luokassa on kaksi muodostinta
parametritonmuodostin ja muodostin johon viedään seuraavat parametrit kirjan nimi ja
hinta. Luokassa on lisäksi neljä metodia SetName(), SetPrice(), GetName ja GetPrice().
Kirjoita käynnistävän Button-painikkeen tapahtumankäsittelijään käskyt joilla voit testata
em. muodostimia ja metodeita. Käytä tiedon syöttöön ja tulostukseen TextBox:ja.*/
namespace Books
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Book
        {
            string kirjanNimi;
            double hinta;

            public Book()
            {
                kirjanNimi = "Akuankka";
                hinta = 40.50;
            }

            public Book(string kirjanNimmi, double hintaa)
            {
                kirjanNimi = kirjanNimmi;
                hinta = hintaa;
            }
            public string GetNimi()
            {
                return kirjanNimi;
            }
            public double GetHinta()
            {
                return hinta;
            }
            public void SetNimi(string nimiKirjan)
            {
                kirjanNimi = nimiKirjan;
            }
            public void SetHinta(double kirjanHinta)
            {
                hinta = kirjanHinta;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book1 = new Book();
            Book book2 = new Book("roope", 5.50);
            Book book3 = new Book();
            book3.SetNimi("musta-pekka");
            book3.SetHinta(20);
            
            textBox1.Text = book1.GetNimi() + " " + book1.GetHinta() + Environment.NewLine + book2.GetNimi() + " " + book2.GetHinta() + Environment.NewLine + book3.GetNimi() + " " + book3.GetHinta();
        }
    }
}
