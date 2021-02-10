using System;

namespace Delegates
{
    public delegate void ConsoleWriteHandler(string s);
    public delegate double CalculateHandler(double x, double y);

    class Program
    {
        static void Main(string[] args)
        {
            CalculateHandler calculate = new CalculateHandler(Add);

            ConsoleWriteHandler cwh = new ConsoleWriteHandler(Console.WriteLine);
            cwh("Hallo von ConsoleWriteHandler");

            cwh = Console.Write;
            cwh("Ohne Zeilenumbruch -->");

            Console.WriteLine("Hello World!");

            while (true)
            {
                Console.WriteLine("Zahl1:");
                double zahl1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Zahl2:");
                double zahl2 = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Operation (+,-,x,/):");
                ConsoleKeyInfo op = Console.ReadKey();

                switch (op.KeyChar)
                {
                    case '+':
                        calculate = new CalculateHandler(Add);
                        break;
                    case '-':
                        calculate = Sub;
                        break;
                    case 'x':
                        calculate = delegate (double a, double b) { return a * b; }; //anonyme Methode
                        break;
                    case '/':
                        calculate = (a, b) => { return a / b; }; //Lambda Expression (auch anonym)
                        break;
                }
                Console.WriteLine("Ergebnis: {0}", calculate(zahl1, zahl2));
                Console.WriteLine("Taste drücken ...");

                if (Console.ReadKey().KeyChar == 'e') return;
                Console.Clear();
            }
        }

        static double Add(double a, double b)
        {
            return a + b;
        }
        static double Sub(double a, double b)
        {
            return a - b;
        }

    }
}
