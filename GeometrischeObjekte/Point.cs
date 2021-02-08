using System;
using System.Collections.Generic;
using System.Text;

namespace LutzundGrub.GeoObjekte.GeometrischeObjekteLib
{
    public struct Point
    {
        float _x;
        float _y;

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
    }
}
