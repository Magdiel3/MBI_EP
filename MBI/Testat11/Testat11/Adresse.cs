using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testat11
{
    public class Adresse
    {
        //Daten
        private string strasse = "strasse";
        private string hausnummer = "123";
        private string plz = "45678";
        private string stadt = "stadt";

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
        public string Strasse
        {
            get { return strasse; }
            set { strasse = value; }
        }

        public string Hausnummer
        {
            get { return hausnummer; }
            set { hausnummer = value; }
        }

        public string Plz
        {
            get { return plz; }
            set { plz = value; }
        }

        public string Stadt
        {
            get { return stadt; }
            set { stadt = value; }
        }

        public override string ToString()
        {
            return strasse + " " + hausnummer + "\n" + plz + " " + stadt;
        }
    }
}