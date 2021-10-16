using Problema_1_Modela.Vuelos;
using System;
using System.IO;

namespace Problema_1_Modelado
{
    public class Engine
    {
        public Engine()
        {

        }
        public Flight Flight { get; set; }

        public void Initialize()
        {
            Flight = new Flight();
            Flight.Currency = "dolar";
            DepartureArrivalIsOK();
            Flight.Mostar();

        }
        private void DepartureArrivalIsOK()
        {
            string[] lineas = File.ReadAllLines("./File/Prueba.csv");
            //El archivo contiene las aeropuertos en codigo IATA de las que pueden partir vuelos (uso un csv para emular el uso de BD y se podría replamplazar por un query: SELECT DISTINCT DepartureStation FROM flight;)
            bool marcador = true;
                Console.WriteLine("Ingrese aeropuerto de salida");
                var departure = Console.ReadLine();
                Console.WriteLine("Ingrese aeropuerto de llegada");
                var arrival = Console.ReadLine();
                foreach (var linea in lineas)
                {
                    if (linea.Equals(departure + ";" + arrival))
                    {
                        Console.WriteLine("El aeropuerto de Destino es valido");
                        marcador = false;
                        Flight.DepartureStation = departure;
                        Flight.ArrivalStation = arrival;
                        break;
                    }

                }
                if (marcador)
                {
                    Console.WriteLine("Los aeropuerto ingresados son incorrectos.");
                }

        }

    }
}
