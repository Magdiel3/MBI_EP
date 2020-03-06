using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testat11
{
    [Serializable]
    public class Kunde : Person
    {
        //Daten
        private int anschriftLieferung = 1;
        private DateTime kundeSeit = new DateTime(2015, 11, 15);

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
        public int AnschriftLieferung
        {
            get { return anschriftLieferung; }
            set { anschriftLieferung = value; }
        }

        public DateTime KundeSeit
        {
            get { return kundeSeit; }
            set { kundeSeit = value; }
        }

        public override string ToString()
        {
            string text = Anrede + " " + Name.ToString() + "\n" + Telefonnummer +
                "\nGeburtsdatum: " + Geburtsdatum.ToShortDateString() + "\nKunde seit: " +
                kundeSeit.ToShortDateString() + "\nPrivat(" + Adressbuch.Count() + "):";
            text += "\n" + Adressbuch[AnschriftPrivat].ToString();
            text += "\nLieferadresse:\n" + Adressbuch[anschriftLieferung].ToString();
            return text;
        }
    }
}