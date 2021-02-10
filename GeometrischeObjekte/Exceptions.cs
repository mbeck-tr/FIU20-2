using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace LutzundGrub.GeoObjekte.GeometrischeObjekteLib
{
    public class InvalidMeasureException : Exception
    {
        public InvalidMeasureException() { }
        public InvalidMeasureException(string message) : base(message) { }
        public InvalidMeasureException(string message, Exception inner) : base(message, inner) { }
        protected InvalidMeasureException(SerializationInfo info, StreamingContext context) : base(info, context) { } 
    }
}
