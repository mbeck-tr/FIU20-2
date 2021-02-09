using System;
using System.Collections.Generic;
using System.Text;

namespace LutzundGrub.GeoObjekte.GeometrischeObjekteLib
{
    public class Line : GeoObject
    {
        //Felder / fields
        //private Point _a;
        private Point _b;

        //Eigenschaften / properties
        public Point A
        {
            get { return Location; }
            set { Location = value; }
        }
        public Point B
        {
            get { return _b; }
            set { _b = value; }
        }

        public float DeltaX { get { return _b.Get_X() - Location.Get_X(); } }
        public float DeltaY { get { return _b.Get_Y() - Location.Get_Y(); } }

        public float Length {
            get 
            {
                float c = GeoMath.GetHypothenuse(DeltaX, DeltaY);
                return c; 
            }
            private set { }
        }

        //Konstruktor / constructor
        public Line(Point a, Point b)
        {
            A = a;
            B = b;
        }
        public Line(float ax, float ay, float bx, float by) : this (new Point(ax, ay), new Point(bx, by))
        {

        }


        //Methoden / methods
        public override string ToString()
        {
            return base.ToString() + $"\nA: {A}\nB: {B}\nLength: {Length}";
        }

        public void Move(float dx, float dy)
        {
            Move(new Point(dx, dy));
        }
        public void Move(Point p)
        {
            A = A + p;
            B = B + p;
        }

        public void Scale(float scalar)
        {
            A = A * scalar;
            B = B * scalar;
        }
    }
}
