using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Tee(Mammal - projekti), jossa on Mammal (Nisäkäs), Person(Henkilo) ja Dog(Koira)
luokat.Person - ja Dog - luokat ovat Mammal-luokan aliluokkia. Mammal-luokassa on
attribuuttina merkkijono mType (jossa on teksti ”PERSON” tai ”DOG”). Siinä on
määritelty GetMType()-metodi, joka Person-luokan tapauksessa palauttaa merkkijonon
”PERSON” ja Dog-luokan tapauksessa palauttaa merkkijonon ”DOG”.Tämä muuttuja
alustetaan Mammal-luokan parametrillisessa muodostimessa (konstruktorissa) olion
luontivaiheessa.Lisäksi Mammal-luokassa on määritelty attribuutti mName sekä metodit
SetName() ja GetName()-metodit.Person-luokassa on määritelty attribuutti mAge sekä
SetAge()- ja GetAge()-metodit.Dog-luokassa on määritelty attribuutti (merkkijono)
mOwner sekä SetOwner() ja GetOwner()-metodit.Tee myös aliluokkiin tarvittavat
muodostimet.Tee lisäksi painikkeet ja TextBox:it joilla voit testata ohjelmaa.*/

namespace Mammal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Nisakas
        {
            //alustetaan atribuutit
            public string mTyppi { get; set; }
            public string mNimi { get; set; }

            public Nisakas(string tyyppi, string nimi) //määritellään
            {
                mTyppi = tyyppi;
                mNimi = nimi;
            }
            
        }

        public class Henkilo : Nisakas
        {
            public int mIka { get; set; } //alustetaan
            static string tyyppi = "Ihminen"; // static koska tyyppi ei vaihdu

            public Henkilo(string henkilonNimi, int ika) : base (tyyppi, henkilonNimi) //muistetaan luoda erikseen HENKILONNIMI joka basessa kutsutaan Mnimestä.
            {
                mIka = ika;
            }
            
           
        }

        public class Koira : Nisakas
        {
            public string mOmistaja { get; set; }
            static string tyyppi = "Koira";
            public Koira(string koiranNimi, string omistaja) : base (tyyppi, koiranNimi)
            {
                mOmistaja = omistaja;
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            Henkilo ihminen = new Henkilo("Keijo", 20);
            Koira elain = new Koira("Musti", "Veijo");

            textBox1.Text = ihminen.mTyppi + " on " + ihminen.mNimi + " ikä " + ihminen.mIka + Environment.NewLine + elain.mTyppi + " on " + elain.mNimi + " omistaja " + elain.mOmistaja;
        }


    }
}
