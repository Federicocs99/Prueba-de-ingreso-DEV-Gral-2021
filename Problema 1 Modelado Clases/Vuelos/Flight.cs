using System;
using System.IO;

namespace Problema_1_Modela.Vuelos
{
    class Flight
    {
        public Ciudades DepartureStation{get; set;}
        public Ciudades ArrivalStation{get; set;}
        public DateTime DepartureDate{get; set;}
        private Transport transport;
        public decimal Price{get;}
        public string Currency{get; set;}

        public void Mostar()
        {
            Console.WriteLine("El vuelo partira de: "+DepartureStation);
            Console.WriteLine("El vuelo llegara de: "+ArrivalStation);
            Console.WriteLine("con un valor de: "+Price+Currency);
        }

        

    }
}
