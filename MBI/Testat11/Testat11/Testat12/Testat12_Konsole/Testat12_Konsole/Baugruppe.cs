using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testat12_Konsole
{
    [Serializable]
    public class Baugruppe : VerwaltetesElement
    {
        //Daten
        public List<Baugruppe> baugruppen = new List<Baugruppe>();
        public List<Bauteil> bauteile = new List<Bauteil>();

        //Konstruktoren
        public Baugruppe():base() { }

        public Baugruppe(string bezeichnigung, string id, string revision, LifeCycleStates lifecyclestate,
            DateTime erstellungsdatum, List<Baugruppe> baugruppen, List<Bauteil> bauteile) : 
            base(bezeichnigung, id, revision, lifecyclestate, erstellungsdatum)
        {
            this.baugruppen = baugruppen;
            this.bauteile = bauteile;
        }

        public Baugruppe(Baugruppe b)
        {
            new Baugruppe(b.bezeichnigung,b.id,b.revision,b.lifecyclestate,b.erstellungsdatum,b.baugruppen,b.bauteile);
        }
       
        //Methoden
        public Baugruppe newRevision()
        {
            Baugruppe b = this;
            b.revision = Toolbox.NexRevisionName(b.revision);
            return b;
        }

        public override string ToString()
        {
            string text = "";
            foreach (Baugruppe b in this.baugruppen)
            {
                text += "Baugruppe:\t" + b.bezeichnigung + " (" + b.id + ", Rev. " + b.revision;
                text += ", " + b.lifecyclestate + ")\n";
                foreach (Bauteil bt in b.bauteile)
                {
                    //text += bt.ToString();
                }
            }
            return text;
        }
    }
}