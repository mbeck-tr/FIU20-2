using System;
using System.Collections.Generic;
using System.Text;

namespace LutzundGrub.GeoObjekte.GeometrischeObjekteLib
{
    public struct Point
    {
        //Felder
        float _x;
        float _y;

        //Eigenschaften
        public void Set_X(float x)
        {
            _x = x;
        }
        public float Get_X()
        {
            return _x;
        }

        public void Set_Y(float y)
        {
            _y = y;
        }
        public float Get_Y()
        {
            return _y;
        }

        //Konstruktor
        public Point(float x, float y)
        {
            _x = x;
            _y = y;
        }

        //Methoden
        public override string ToString()
        {
            return $"P({_x}|{_y})";
        }

        //Operatorüberladungen / operator overloading
        public static Point operator +(Point p1, Point p2)
        {
            Point newPoint = new Point(
                p1.Get_X() + p2.Get_X(), 
                p1.Get_Y() + p2.Get_Y());
            return newPoint;
        }

        public static Point operator *(Point p, float s)
        {
            Point newPoint = new Point(
                p.Get_X() * s,
                p.Get_Y() * s);
            return newPoint;
        }
    }
}
