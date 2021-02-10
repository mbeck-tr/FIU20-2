using System;
using System.Collections.Generic;
using System.Text;
using static LutzundGrub.GeoObjekte.GeometrischeObjekteLib.GeoMath;

namespace LutzundGrub.GeoObjekte.GeometrischeObjekteLib
{
    public class Circle : GeoObject
    {
        //Klassenvariable(n)
        static int _count;
        new static public int Count //new Schlüsselwort kennzeichnet das gewollte ausblenden von Count
        {
            get { return _count; }
        }

        //Felder
        private float _radius;

        //Eigenschaften
        public Point MP
        {
            get { return Location; }
            set { Location = value; }
        }
        public float Radius
        {
            get { return _radius; }
            set {
                if (value > 0)
                    _radius = value;
                else throw new InvalidMeasureException("Fehler: Der Radius darf nicht negativ oder Null sein!");
            }
        }
        public float Area
        {
            get { return Radius * Radius * PI; } // r*r*PI
        }
        public float Circumference
        {
            get { return 2 * PI * Radius; } // 2*PI*r
        }

        //Konstruktor(en)
        public Circle(Point mp, float radius, string name = "Circle")
        {
            Name = name;
            Radius = radius;
            MP = mp;
            _count++;
            GeoObject.Count++;
        }
        public Circle(float mx, float my, float radius, string name = "Circle")
            : this(new Point(mx, my), radius, name) { }

        //Methoden
        public void Move(float dx, float dy)
        {
            Move(new Point(dx, dy));
        }
        public void Move(Point p)
        {
            MP = MP + p;
        }

        public void Scale(float scalar)
        {
            Radius *= scalar;
        }

        public override string ToString()
        {
            return base.ToString() + "\nRadius: " + Radius;
        }
    }
}
