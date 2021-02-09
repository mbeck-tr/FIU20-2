using System;
using System.Collections.Generic;
using System.Text;

namespace LutzundGrub.GeoObjekte.GeometrischeObjekteLib
{
    public static class GeoMath
    {
        public const float PI = 3.141592F; //Festlegung zur Compilezeit
        public static float GetHypothenuse(float a, float b)
        {
            return (float)Math.Sqrt(a * a + b * b);
        }
    }
}
