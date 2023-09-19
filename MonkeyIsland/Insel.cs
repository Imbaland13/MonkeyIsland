using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland
{
    internal class Insel
    {
        string name;
        Strand strand;
        pirat[] pirat;
        Kneipe kneipe;
        Schiff schiff;
        public Insel()
        {
            this.strand = new Strand("Strand");
            this.kneipe = new Kneipe();
        }    
        
        public void SetPirat(pirat[] p) { this.pirat = p; }
        public pirat[] GetPirat() { return this.pirat; }
        public void SetSchiff(Schiff s) { this.schiff = s; }
        public Schiff GetSchiff() { return  this.schiff; }
        public Strand GetStrand() { return this.strand; }
        public void SetName(string name) { this.name = name; }
        public string GetName() { return this.name; }
        public Kneipe GetKneipe() { return kneipe; }
    }
}
