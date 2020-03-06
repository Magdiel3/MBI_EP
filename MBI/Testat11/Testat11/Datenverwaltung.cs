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
        private List<Kunde> kundenverwaltung = new List<Kunde>();
        private List<Mitarbeiter> mitarbeiterverwaltung = new List<Mitarbeiter>();

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
        public List<Kunde> Kundenverwaltung
        {
            get { return kundenverwaltung; }
            set { kundenverwaltung = value; }
        }

        public List<Mitarbeiter> Mitarbeiterverwaltung
        {
            get { return mitarbeiterverwaltung; }
            set { mitarbeiterverwaltung= value; }
        }

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
                k.Adressbuch.Clear();
            }
            foreach (Mitarbeiter m in mitarbeiterverwaltung)
            {
                m.Adressbuch.Clear();
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