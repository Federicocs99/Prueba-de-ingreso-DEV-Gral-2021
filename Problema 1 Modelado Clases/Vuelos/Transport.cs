using System;

namespace Problema_1_Modela.Vuelos
{
    public class Transport
    {
        public string FligthNumbre{get;}
        public Transport() => FligthNumbre = Guid.NewGuid().ToString();
       
        public override string ToString()
        {
            return FligthNumbre;
        }
    }

}