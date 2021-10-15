using System;
namespace Problema_1_Modelado_Clases.Vuelos
{
    class Flight
    {
        public string DepartureStation{get;}
        string ArrivalStation{get;}
        DateTime DepartureDate{get;}
        //public Transport Transport;
        decimal Price{get;}
        public string Currency{get;}

        public void Mostar()
        {
            Console.WriteLine("El vuelo partira de: "+DepartureStation);
            Console.WriteLine("El vuelo llegara de: "+ArrivalStation);
            Console.WriteLine("con un valor de: "+Price+Currency);
        }
    }
}