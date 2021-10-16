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
            Fechahoy();
            Flight.MostarVuelos();

        }
        private void DepartureArrivalIsOK()
        {
            string[] lineas = File.ReadAllLines("./File/Prueba.csv");
            //El archivo contiene las aeropuertos en codigo IATA de las que pueden partir vuelos (uso un csv para emular el uso de BD y se podría replamplazar por un query: SELECT DISTINCT DepartureStation FROM flight;)
            bool marcador = true;

            while (marcador)
            {
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
        private void Fechahoy()
        {
            bool marca= true;
            while(marca)
            {
            Console.WriteLine("Ingrese fecha deceada para el vuelo en formato dd/mm/yyyy");
            var fecha = Console.ReadLine();
            DateTime date = Convert.ToDateTime(fecha);
            int result = DateTime.Compare(date, DateTime.Now);
            if (result > 0)
            {
                Console.WriteLine("Fecha valida");
                marca=false;
                Flight.DepartureDate=date;

            }
            else
            {
                Console.WriteLine("Fecha No valida");
            }
            }
        }

    }
}
