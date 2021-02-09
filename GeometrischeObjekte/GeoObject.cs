using System;

namespace LutzundGrub.GeoObjekte.GeometrischeObjekteLib
{
    public class GeoObject //Basisklasse
    {
        static int _count;
        static public int Count
        {
            get { return _count; }
            protected set { _count = value; } //Zugriff innerhalb der Vererbungshierachie
        }
        public Point Location;
        public string Name { get; set; }

        public override string ToString()
        {
            string s = Name + "\nLocation: " + Location.ToString();
            return s;
        }
    }
}


/* ^Y
 * |
 * |  D              C --> _c
 * |  +--------------+            +
 * |  |              |           /
 * |  |              |          /
 * |  |              |         /
 * |  +--------------+        +    
 * |  A-->Location   B(Property) return B berechnen
 * +---------------------->X
 */
