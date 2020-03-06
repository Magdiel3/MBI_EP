using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testat12_Konsole
{
    [Serializable]
    public class Bauteil : VerwaltetesElement
    {
        //Daten
        

        //Konstruktoren
        public Bauteil() : base() { }

        public Bauteil(string bezeichnigung, string id, string revision,
            LifeCycleStates lifecyclestate, DateTime erstellungsdatum) :
            base(bezeichnigung, id, revision, lifecyclestate, erstellungsdatum) { }

        public Bauteil(string bezeichnigung, string id, LifeCycleStates lifecyclestate) :
            base(bezeichnigung, id, lifecyclestate)
        { }

        //Methoden 
        public Bauteil newRevision()
        {
            Bauteil b = (Bauteil)this.MemberwiseClone();
            b.revision = Toolbox.NexRevisionName(b.revision);
            return b;
        }

        public override string ToString()
        {
            string text = "Bauteil:\t" + this.bezeichnigung + " (" + this.id + ", Rev. " + this.revision;
            text += ", " + this.lifecyclestate + ")\n";
            return text;
        }

    }
}