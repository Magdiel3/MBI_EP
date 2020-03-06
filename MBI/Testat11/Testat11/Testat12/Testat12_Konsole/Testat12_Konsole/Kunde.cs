using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testat12_Konsole
{
    [Serializable]
    public class Kunde : Person
    {
        //Daten
        public int anschriftLieferung = 1;
        public DateTime kundeSeit = new DateTime(2015, 11, 15);

        //Kosntruktoren
        public Kunde() : base() { }

        public Kunde(string anrede, VollstaendigerName name, int anschriftPrivat,
            string telefonnummer, DateTime geburtsdatum, int anschriftLieferung,
            DateTime kundeSeit) : base(anrede, name, anschriftPrivat, telefonnummer, geburtsdatum)
        {
            this.anschriftLieferung = anschriftLieferung;
            this.kundeSeit = kundeSeit;
        }

        //Methoden
       public override string ToString()
        {
            string text = anrede + " " + name.ToString() + "\n" + telefonnummer +
                "\nGeburtsdatum: " + geburtsdatum.ToShortDateString() + "\nKunde seit: " +
                kundeSeit.ToShortDateString() + "\nPrivat(" + adressbuch.Count() + "):";
            text += "\n" + adressbuch[anschriftPrivat].ToString();
            text += "\nLieferadresse:\n" + adressbuch[anschriftLieferung].ToString();
            return text;
        }
    }
}