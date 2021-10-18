using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problema_3_Modela.Vuelos
{
    public class Flight
    {
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
        public DateTime DepartureDate { get; set; }
        public Transport Transport { get;set; }
        public double Price { get;set; }
        public string Currency { get; set; }
        public Flight()
        {
        }
        //Metodo para hacer debuging
        public void MostrarVuelo()
        {
            Console.WriteLine($"El Vuelo Sale de: {DepartureStation} y llega a: {ArrivalStation} En la fecha:{DepartureDate} Tiene numero de Vuelo:{Transport.FlightNumber} Con precio de: {Price} {Currency}");
        }
    }
}
