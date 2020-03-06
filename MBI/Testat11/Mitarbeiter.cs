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
        public int anschriftBuero = 1;

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
        public override string ToString()
        {
            string text = anrede + " " + name.ToString() + "\n" + telefonnummer +
                "\nGeburtsdatum: " + geburtsdatum.ToShortDateString() + "\nPrivat(" + adressbuch.Count() + "):";
            text += "\n" + adressbuch[anschriftPrivat].ToString();   
            text += "\nBüro:\n" + adressbuch[anschriftBuero].ToString();
            return text;
        }
    }
}