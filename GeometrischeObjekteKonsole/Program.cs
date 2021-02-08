using System;
using LutzundGrub.GeoObjekte.GeometrischeObjekteLib;

namespace LutzundGrub.GeoObjekte.GeometrischeObjekteKonsole
{
    class Program
    {
        static void Main(string[] args)
        {
            GeoObject[] geoObjectList = new GeoObject[10];
            Auswahlmenu();
            Console.WriteLine("Hallo GeoObjekte");
            LutzundGrub.GeoObjekte.GeometrischeObjekteLib.GeoObject geoObject = new GeoObject();
            geoObject.Name = "meinErstesObjekt";
            Console.WriteLine(geoObject.Name);
            geoObject.location.Set_X(10);
            geoObject.location.Set_Y(5);
            geoObjectList[0] = geoObject;

            Console.WriteLine("X: " + geoObject.location.Get_X());
            Console.WriteLine("Y: {0}", geoObject.location.Get_Y());
        }

        private static void Auswahlmenu()
        {
            throw new NotImplementedException();
        }
    }
}
