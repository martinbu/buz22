using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise
{
    internal class Kaffemaschine
    {
        public string Farbe;
        public int Stärke;

        public void SetMahlgrad(int mahlgrad)
        {
            Console.WriteLine("Setze Mahlgrad auf {0}", mahlgrad);
        }

        public void SetStärke(int stärke)
        {
            Stärke = stärke;
            Console.WriteLine("Setze sträke auf {0}", stärke);
        }

        public void ErstelleGroßenKaffe()
        {
            StarteHeizung();

            Console.WriteLine("Mahlen, Wasserheizen und großen Menge Wasser durchlaufen lassen");
        }

        public void ErstelleKleinenKaffee()
        {
            StarteHeizung();

            Console.WriteLine("{0} Maschine: Mahlen, Wasserheizen und kleine Menge Wasser durchlaufen lassen", Farbe);
        }

        private void StarteHeizung()
        {
            Console.WriteLine("Ich starte die Heinzung");
        }
    }
}
