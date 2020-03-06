using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testat11
{
    [Serializable]
    public class Datenverwaltung
    {
        //Data
        public List<Kunde> kundenverwaltung = new List<Kunde>();
        public List<Mitarbeiter> mitarbeiterverwaltung = new List<Mitarbeiter>();

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
        public void reset(string type)
        {
            if (type.Equals("Kunden"))
            {
                kundenverwaltung.Clear();
            }
            if (type.Equals("Mitarbeiter"))
            {
                mitarbeiterverwaltung.Clear();
            }

        }

        public void reset()
        {
            foreach(Kunde k in kundenverwaltung)
            {
                k.adressbuch.Clear();
            }
            foreach (Mitarbeiter m in mitarbeiterverwaltung)
            {
                m.adressbuch.Clear();
            }
            kundenverwaltung.Clear();
            mitarbeiterverwaltung.Clear();
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
            return text;
        }
    }
}