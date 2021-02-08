using System;
using LutzundGrub.GeoObjekte.GeometrischeObjekteLib;

namespace LutzundGrub.GeoObjekte.GeometrischeObjekteKonsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo GeoObjekte");
            LutzundGrub.GeoObjekte.GeometrischeObjekteLib.GeoObject geoObject = new GeoObject();
            geoObject.Name = "meinErstesObjekt";
        }
    }
}
