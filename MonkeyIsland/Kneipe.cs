using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland
{
    internal class Kneipe
    {
        string name;
        pirat p;
        public void SetName(string name) { this.name = name; }
        public string GetName() { return name; }
        public void SetPiratKneipe(pirat p) { this.p = p; }
        public pirat GetPiratKneipe() { return this.p; }
        public void Saufen() { if (p != null) { Console.WriteLine($"Der Pirat {p} säuft in der Kneipe"); } }
    }
}
