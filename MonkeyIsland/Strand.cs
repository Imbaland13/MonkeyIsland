using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland
{
    internal class Strand
    {
        string name;
        public Strand(string name)
        {
            this.name = "Strand";
        }

        public void SetName(string name) { this.name = name; }
        public string GetName() { return this.name; }
    }
}
