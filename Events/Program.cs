using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Events");
            // Client --> Server
            // Client <-- Server (Events)
            
            Bibliothek b = new Bibliothek(6);
            b.ZahlenZiehen();

            b.Gewinn += Ausgabe;
            Console.WriteLine("Glückszahl: ");
            int zahl = Convert.ToInt32(Console.ReadLine());
            while(true){
                b.tuetwas(zahl);
                if (Console.ReadKey().KeyChar == 'x') return;
            }
        }
        static void Ausgabe()
        {
            Console.WriteLine("Hauptgewinn!!!");
        }
    }
}
