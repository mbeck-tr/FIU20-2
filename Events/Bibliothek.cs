using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    delegate void GewinnEventHandler();

    class Bibliothek
    {
        int maxZahlen;
        List<int> zahlen;
        public Bibliothek(int maxZahlen)
        {
            this.maxZahlen = maxZahlen;
            zahlen = new List<int>();
        }

        int a;

        public event GewinnEventHandler Gewinn;
        public void tuetwas(int gewinnzahl)
        {

            int durchgaenge = maxZahlen;
            zahlen.Clear();
            Random random = new Random((int)DateTime.Now.Ticks);
            do
            {
                a = random.Next(1, 50);
                if (!zahlen.Exists(ExistiertPruefung))
                {
                    zahlen.Add(a);
                    durchgaenge--;
                    Console.WriteLine(a);
                    if (a == gewinnzahl) Gewinn();
                }
                else
                {
                    Console.WriteLine("Doppelt: {0}", a);
                }
            } while (durchgaenge > 0);
        }


        bool ExistiertPruefung(int element)
        {
            return element == a;
        }

        int gezogeneZahlen = 0;
        public void ZahlenZiehen()
        {
            for (int i = 0; i < 20; i++)
            {
                Random random = new Random((int)DateTime.Now.Ticks);
                int zahl = random.Next(0, 16);
                Console.WriteLine("gezogen: " + zahl);
                if ((gezogeneZahlen & (int)Math.Pow(2, zahl)) == (int)Math.Pow(2, zahl)) Console.WriteLine("doppelt");
                else gezogeneZahlen |= (int)Math.Pow(2,zahl);
            }
        }

        /*
        
        1 2 4 8 16 32 64 128 256
        1 2 3 4 5  6  7   8  9   0 1 2 3 4 5 6
        _ _ _ _ 1  _  _   _  1   _ _ 1 _ _ _ _  ==> gezogeneZahlen (short)
                             1
        (gezogeneZahlen | 256) != 256;
         
         */
    }

}
