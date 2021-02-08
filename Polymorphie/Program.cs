using System;

namespace Polymorphie
{
    class Program
    {
        static void Main(string[] args)
        {
            Giraffe giraffe = new Giraffe() { Name = "Hans" };
            Adler adler = new Adler() { Name = "Peter" };

            giraffe.Fressen(2); // giraffe frisst!!!
            adler.Fressen(4);   // adler frisst!!!

            Tier[] tiere = new Tier[2];
            tiere[0] = giraffe;
            tiere[1] = adler;

            foreach (var item in tiere)
            {
                item.Fressen(5); //
                if (item is Giraffe) (item as Giraffe).Fressen(6); // giraffe frisst!!
                if (item is Adler) (item as Adler).Fressen(7);
            }
        }
    }

    abstract class Tier
    {
        public string Name { get; set; }
        //public int Geschwindigkeit { get; set; }

        public abstract void Fressen(int Brennwert);
    }

    class Giraffe : Tier
    {
        public int Laufgeschwindigkeit { get; set; }
        public override void Fressen(int bw)
        {
            Console.WriteLine("Giraffe frisst!!!");
        }
    }

    class Adler : Tier
    {
        public int Fluggeschwindigkeit { get; set; }
        public override void Fressen(int Brennwert)
        {
            Console.WriteLine("Adler frisst!!!");
        }
    }
}
