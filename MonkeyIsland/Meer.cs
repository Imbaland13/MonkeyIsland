using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland
{
    internal class Meer
    {
        pirat p;
        Insel[] inseln = new Insel[3];
        public Meer()
        {
            inseln[0] = new Insel();
            inseln[0].SetName("Honolulu");
            inseln[0].GetKneipe().SetName("Zur Schenke");
            inseln[1] = new Insel();
            inseln[1].SetName("Monkey Island");
            inseln[1].GetKneipe().SetName("Zur blauen Eule");
            inseln[2] = new Insel();
            inseln[2].GetKneipe().SetName("Die goldene Schenke");
            inseln[2].SetName("Tittikaka");
        }
        public Insel[] GetInseln() { return inseln; }
        public void SetPirat(pirat p) { this.p = p; }
        public pirat GetPirat() { return p; }
    }
}
