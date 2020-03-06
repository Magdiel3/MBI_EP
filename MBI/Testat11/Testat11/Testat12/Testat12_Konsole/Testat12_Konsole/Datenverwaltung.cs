using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testat12_Konsole
{
    [Serializable]
    public class Datenverwaltung
    {
        //Data
        public List<Kunde> kundenverwaltung = new List<Kunde>();
        public List<Mitarbeiter> mitarbeiterverwaltung = new List<Mitarbeiter>();
        public List<Produkt> produktverwaltung = new List<Produkt>();

        //Konstruktoren
        public Datenverwaltung() { }

        public Datenverwaltung(Kunde k, Mitarbeiter m)
        {
            kundenverwaltung.Add(k);
            mitarbeiterverwaltung.Add(m);
        }

        public Datenverwaltung(List<Kunde> kundenverwaltung, List<Mitarbeiter> mitarbeiterverwaltung)
        {
            this.kundenverwaltung = kundenverwaltung;
            this.mitarbeiterverwaltung = mitarbeiterverwaltung;
        }

        //Methoden
        public void reset()
        {
            kundenverwaltung.Clear();
            mitarbeiterverwaltung.Clear();
            produktverwaltung.Clear();
        }

        public override string ToString()
        {
            string text = "\nMitarbeiter(" + mitarbeiterverwaltung.Count() + "):\n\n";
            foreach (Mitarbeiter m in mitarbeiterverwaltung)
            {
                text += m.ToString() + "\n--------------------------------\n";
            }
            text += "\n\nKunden(" + kundenverwaltung.Count() + "):\n\n";
            foreach (Kunde k in kundenverwaltung)
            {
                text += k.ToString() + "\n--------------------------------\n";
            }
            text += "\n\nProdukt anlagen(" + produktverwaltung.Count() + "):\n\n";
            foreach (Produkt p in this.produktverwaltung)
            {
                text += p.ToString() + "--------------------------------\n";
            }
            return text;
        }
    }
}