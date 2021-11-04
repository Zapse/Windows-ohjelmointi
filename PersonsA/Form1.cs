using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonsA
{
    public partial class Form1 : Form
    {
        //Alustetaan arrayn ja laskin.
        string[] persons = new string[10];
        int laskin = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Person henkilo = new Person();

            //ToString(), koska ilman tätä tietojen tallennus ei toimi kun yhdelle henkilölle.
            henkilo.SetTiedot(textBoxFirst.Text, textBoxLast.Text, textBoxAge.Text.ToString());

            //lisätään tiedot ja samalla kasvatetaan laskinta
            persons[laskin] = henkilo.GetTiedot();
            laskin++;
            //nollataan textBoxien kentät, kun savea on painettu
            textBoxAge.Text = " ";
            textBoxFirst.Text = " ";
            textBoxLast.Text = " ";

            if (laskin >= 10) buttonSave.Enabled = false;
            
        }
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < persons.Length; i++)
            {
                textBoxPrint.Text = textBoxPrint.Text + persons[i] + Environment.NewLine;
            }
            
        }

        public class Person
        {
            string firstName, lastName, age, info;

            public void SetTiedot (string nimi, string sukunimi, string ika)
            {
                firstName = nimi;
                lastName = sukunimi;
                age = ika;
                //infoon tallennetaan edellämainitut stringit
                info = firstName + " " + lastName + " " + age;
            }

            public string GetTiedot()
            {
                return info;
            }
        }

        
    }
}
