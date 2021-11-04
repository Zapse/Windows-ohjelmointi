using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buttontestipaska
{
    public class Class1
    {
        public string Sukunimi { get; set; }
        public string Joku { get; set; }

        public Class1(string pSukunimi, string pJoku)
            {
                Sukunimi = pSukunimi;
                Joku = pJoku;
            }
    }

    public class Musti : Class1
    {
        public int mIka { get; set; }
        static string Joku = "tenho";

        public Musti(string henkilonSukunimi, int ika) : base (Joku, henkilonSukunimi)
        {
            mIka = ika;
        }
    }
}
