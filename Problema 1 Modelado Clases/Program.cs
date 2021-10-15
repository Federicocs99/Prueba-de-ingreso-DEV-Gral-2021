using System;
using Problema_1_Modelado_Clases.Vuelos;
namespace Problema_1_Modelado_Clases
{
        class Program
    {
        static void Main(string[] args)
        {
            var vuelo = new Flight();
            vuelo.DepartureStation = "Miami";
            vuelo.ArrivalStation = "Bogota";
            vuelo.Currency = "$";
            vuelo.Mostar();
        }
    }
}
