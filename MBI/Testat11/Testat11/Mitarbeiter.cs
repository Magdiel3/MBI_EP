using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testat11
{
    [Serializable]
    public class Mitarbeiter : Person
    {   
        //Daten
        private int anschriftBuero = 1;

        //Konstruktor
        public Mitarbeiter(string anrede, VollstaendigerName name,
            int anschriftPrivat, string telefonnummer, DateTime geburtsdatum,
            int anschriftBuero) : base(anrede, name, anschriftPrivat,
                telefonnummer, geburtsdatum)
        {
            this.anschriftBuero = anschriftBuero;
        }

        public Mitarbeiter() : base() { }

        //Methoden
        public int AnschriftBuero
        {
            get { return anschriftBuero; }
            set { anschriftBuero = value; }
        }
           
        public override string ToString()
        {
            string text = Anrede + " " + Name.ToString() + "\n" + Telefonnummer +
                "\nGeburtsdatum: " + Geburtsdatum.ToShortDateString() + "\nPrivat(" + Adressbuch.Count() + "):";
            text += "\n" + Adressbuch[AnschriftPrivat].ToString();   
            text += "\nBüro:\n" + Adressbuch[anschriftBuero].ToString();
            return text;
        }
    }
}