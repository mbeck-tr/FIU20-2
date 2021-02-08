using System;

namespace LutzundGrub.GeoObjekte.GeometrischeObjekteLib
{
    public class GeoObject //Basisklasse
    {
        public string Name { get; set; }
        public Location location { get; set; } = new Location();

        //Konstruktor
        public GeoObject()
        {
            location = new Location();
        }
    }
}


/* ^Y
 * |
 * |
 * |  +----------+
 * |  |          |
 * |  |          |
 * |  |          |
 * |  +----------+
 * |
 * +---------------------->X
 */
