using System;
using LutzundGrub.GeoObjekte.GeometrischeObjekteLib;

namespace LutzundGrub.GeoObjekte.GeometrischeObjekteKonsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rad;
            rad = Convert.ToSingle(Console.ReadLine());
            Circle c;
            try
            {
                c = new Circle(10,10,rad,"MeinKreis");
                Console.WriteLine("Kreis erzeugt!");
                int a = 0;
                Console.WriteLine(1/a);
            }
            catch(InvalidMeasureException ex)
            {
                Console.WriteLine("Invalid Measure Exception:");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                return;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Divide by Zero:");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                return;
            }
            catch(Exception exception)
            {
                Console.WriteLine("Common Exception:");
                Console.WriteLine(exception.Message);
                Console.ReadKey();
                return;
            }
            finally
            {
                Console.WriteLine("wird immer ausgeführt!!! zum Beispiel zum Schließen von Streams");
            }
            Console.WriteLine(c);
            Console.ReadLine();

            GeoObject[] geoObjectList = new GeoObject[10];
            Auswahlmenu();
            Console.WriteLine("Hallo GeoObjekte");
            LutzundGrub.GeoObjekte.GeometrischeObjekteLib.GeoObject geoObject = new GeoObject();
            geoObject.Name = "meinErstesObjekt";
            Console.WriteLine(geoObject.Name);
            geoObject.Location.Set_X(10);
            geoObject.Location.Set_Y(5);
            geoObjectList[0] = geoObject;

            Console.WriteLine("X: " + geoObject.Location.Get_X());
            Console.WriteLine("Y: {0}", geoObject.Location.Get_Y());

            Console.WriteLine("P(" + geoObject.Location.Get_X() + "|" + geoObject.Location.Get_Y() + ")"); //P(x-Wert|y-Wert)
            Console.WriteLine(geoObject.Location.ToString());
            Console.WriteLine(geoObject.Location);
            Console.WriteLine();
            Console.WriteLine(geoObject);

            Line l1 = new Line(12, 23, 34, 45);
            Console.WriteLine();
            Console.WriteLine(l1);
            Console.WriteLine(l1.Length);
        }

        private static void Auswahlmenu()
        {
            
        }
    }

}
