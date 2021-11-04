using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mammalinterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            Person person;
            person = new Person("David", 20);
            Dog dog;
            dog = new Dog("jerry", "tanja");
            
            //ei tarvi määritellä mammaltypeä, koska se palauttaa sen automaattisesti metodista GetMammalType.

            textBox1.Text = "object type is " + person.Mtype + " is " + person.mName+ " Age is " + person.mAge + Environment.NewLine+ "object type is " + dog.Mtype + " is " + dog.mName+ " Owner is " + dog.mOwner;
        }

        public interface Iid
        {
            //property pistetään suoraan get ja set
            string Mtype
            {
                get; set;
            }

            string GetMammalType();
        }

        public class Mammal
        {
            public string mName { get; set; }

            public Mammal(string name)
            {
                mName = name;

            }
        }

        public class Person : Mammal, Iid
        {
            public int mAge { get; set; }
            
            public string Mtype { get; set; }

            //Mtype määritellään tässä vaiheessa jo PERSONIKSI
            public Person(string personsName, int age) : base (personsName)
            {
                mAge = age;
                Mtype = "Person";
            }


            public string GetMammalType()
            {
                return Mtype;
            }

           
            
        }

        public class Dog : Mammal, Iid
        {
            public string mOwner { get; set; }
            public string Mtype { get ; set ; }
            //Mtype määritellään Dogiksi.
            public Dog(string dogName, string dogOwner) : base (dogName)
            {
                mOwner = dogOwner;
                Mtype = "Dog";
            }

            public string GetMammalType()
            {
                return Mtype;
            }
        }
    }
}
