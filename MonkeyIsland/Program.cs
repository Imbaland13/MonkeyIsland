using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pirat m = new pirat();
            pirat f = new pirat();
            pirat[] pirates = new pirat[2];
            Meer meer = new Meer();
            Schiff schiff = new Schiff();
            schiff.SetName("Pearl");
            m.SetName("Mathias");
            f.SetName("Ferhat");
            pirates[0] = m;
            pirates[1] = f;
            schiff.SetPirat(pirates);
            Schifffahrt(schiff, meer);
        }
        public static void Schifffahrt(Schiff schiff, Meer meer)
        {
            string eingabe;
            Insel[] inselarr;
            inselarr = meer.GetInseln();
            Console.WriteLine("Zu welcher Insel wollen Sie fahren?");
            Console.WriteLine("Folgende Inseln sind Verfügbar:");
            Console.WriteLine();
            for (int i = 0; i < inselarr.Length; i++)
            {
                Console.WriteLine($"{inselarr[i].GetName()} \n");
            }
            eingabe = Console.ReadLine();
            if (eingabe == "Honolulu")
            {
                inselarr[1].SetSchiff(null);
                inselarr[2].SetSchiff(null);
                inselarr[0].SetSchiff(schiff);
                inselarr[0].SetPirat(schiff.GetPirat());
                Console.WriteLine($"Sie haben am {inselarr[0].GetName()} " +
                    $"{inselarr[0].GetStrand().GetName()} angelegt.");
                Console.WriteLine($"Die Piraten {schiff.GetPirat()[0].GetName()} " +
                    $"und {schiff.GetPirat()[1].GetName()} sind dort.");
            }
            else if (eingabe == "Monkey Island")
            {
                inselarr[0].SetSchiff(null);
                inselarr[2].SetSchiff(null);
                inselarr[1].SetSchiff(schiff);
                inselarr[1].SetPirat(schiff.GetPirat());
                Console.WriteLine($"Sie haben am {inselarr[1].GetName()} " +
                    $"{inselarr[1].GetStrand().GetName()} angelegt.");
                Console.WriteLine($"Die Piraten {schiff.GetPirat()[0].GetName()} " +
                    $"und {schiff.GetPirat()[1].GetName()} sind dort.");
            }
            else if (eingabe == "Tittikaka")
            {
                inselarr[0].SetSchiff(null);
                inselarr[1].SetSchiff(null);
                inselarr[2].SetSchiff(schiff);
                inselarr[2].SetPirat(schiff.GetPirat());
                Console.WriteLine($"Sie haben am {inselarr[2].GetName()} " +
                    $"{inselarr[2].GetStrand().GetName()} angelegt.");
                Console.WriteLine($"Die Piraten {schiff.GetPirat()[0].GetName()} " +
                    $"und {schiff.GetPirat()[1].GetName()} sind dort.");
            }
            else
            {
                Console.WriteLine("Dieser Strand existiert nicht!");
            }
        }
        public static void SaufenGehen(Insel insel, pirat pirat)
        {
            Console.WriteLine($"Der Pirat {insel.GetPirat()} am Strand:{insel.GetStrand()} " +
                $"besäuft sich in der Kneipe{insel.GetKneipe()}");
        }
    }
}
