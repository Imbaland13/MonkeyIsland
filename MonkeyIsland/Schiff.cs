using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland
{
    internal class Schiff
    {
        string name;
        pirat[] p;
        public void SetName(string name) { this.name = name; }
        public string GetName(){ return this.name; }
        public void SetPirat(pirat[] p) { this.p = p; }
        public pirat[] GetPirat() { return this.p; }
    }
}
