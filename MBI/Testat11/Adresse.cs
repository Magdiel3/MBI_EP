using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testat11
{
    public class Adresse
    {
        //Daten
        public string strasse = "strasse";
        public string hausnummer = "123";
        public string plz = "45678";
        public string stadt = "stadt";

        //Konstruktoren
        public Adresse(string strasse, string hausnummer, string plz, string stadt)
        {
            this.strasse = strasse;
            this.hausnummer = hausnummer;
            this.plz = plz;
            this.stadt = stadt;
        }

        public Adresse() { }

        //Methoden
        public override string ToString()
        {
            return strasse + " " + hausnummer + "\n" + plz + " " + stadt;
        }
    }
}