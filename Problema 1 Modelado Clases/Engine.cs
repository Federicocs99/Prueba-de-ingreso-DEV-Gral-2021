using Problema_1_Modela.Vuelos;
using System;
using System.Collections.Generic;
using System.IO;

namespace Problema_1_Modelado
{
    public class Engine
    {
        private bool parametro;
        private string fecha;

        public Engine()
        {

        }
        public Flight Flight { get; set; }

        public void Initialize()
        {
            Flight = new Flight();
            Flight.Currency = "dolar";
            List<string> Sitios = DepartureArrivalIsOK();
            do
            {
                Console.WriteLine("Ingrese fecha deceada para el vuelo en formato dd/mm/yyyy");
                fecha = Console.ReadLine();
                parametro = Fechahoy(fecha);
            } while (parametro);
            Console.WriteLine(fecha);
            List<string[]> Vuelos = VerificadorDispo(Sitios, fecha);
            ElejirVuelo(Vuelos);


        }
        private List<string> DepartureArrivalIsOK()
        {
            string[] lineas = File.ReadAllLines("./File/Prueba.csv");
            //El archivo contiene las aeropuertos en codigo IATA de las que pueden partir vuelos (uso un csv para emular el uso de BD y se podría replamplazar por un query: SELECT DISTINCT DepartureStation FROM flight;)
            bool marcador = true;
            List<string> DepartureArrival = new List<string>();
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
                        DepartureArrival.Add(departure);
                        DepartureArrival.Add(arrival);
                        break;
                    }

                }
                if (marcador)
                {
                    Console.WriteLine("Los aeropuerto ingresados son incorrectos.");
                }
            }
            return DepartureArrival;

        }
        private bool Fechahoy(string fecha)
        {
            DateTime Date;
            bool marca = true;
            {
                try 
                {
                    Date = Convert.ToDateTime(fecha);
                    int result = DateTime.Compare(Date, DateTime.Now);
                    if (result > 0)
                {
                    Console.WriteLine("Fecha valida");
                    marca = false;

                }
                else
                {
                    Console.WriteLine("Fecha No valida");
                }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
                

                return marca;
            }

        }

        public List<string[]> VerificadorDispo(List<string> Sitios, string fecha)
        {
            string[] lineas = File.ReadAllLines("./File/Vuelos_Fechas.csv");
            //El archivo contiene las aeropuertos en codigo IATA de las que pueden partir vuelos (uso un csv para emular el uso de BD y se podría replamplazar por un query: SELECT DISTINCT DepartureStation FROM flight;)
            bool marcador = true;
            List<string[]> ListaDeVuelos = new List<string[]>();
            foreach (var linea in lineas)
            {

                var valor = linea.Split(";");
                if ((valor[0] + valor[1]).Equals(Sitios[0] + Sitios[1]))
                {
                    DateTime FechaDeVuelo = Convert.ToDateTime(valor[2]);
                    DateTime FechaAprox = Convert.ToDateTime(fecha);

                    int result = DateTime.Compare(FechaDeVuelo, FechaAprox);

                    if (result == 0)
                    {
                        ListaDeVuelos.Add(valor);
                        marcador = false;

                    }
                }

            }
            if (marcador)
            {
                Console.WriteLine("No existen vuelos para la fecha selecionada");
                return ListaDeVuelos;
            }
            else
            {
                Console.WriteLine("Los Vuelos Para esa Fecha son");
                return ListaDeVuelos;

            }

        }
        private void ElejirVuelo(List<string[]> Vuelos)
        {
            int Cont = 0;

            if (Vuelos.Count > 0)
            {
                Console.WriteLine($"La cantidad de vuelos encontrados son {Vuelos.Count}");
                foreach (var Vuelo in Vuelos)
                {
                    Console.WriteLine($"El Vuelo numero {Cont + 1} Sale de: {Vuelo[0]} y llega a: {Vuelo[1]} En la fecha:{Vuelo[2]}");
                    Cont++;

                }
                Console.WriteLine($"Escoja el numero de vuelo que desea elejir");
                var Ele = Console.ReadLine();
                int Selector = Int16.Parse(Ele);
                if (1 <= Selector && Vuelos.Count >= Selector)
                {

                    Flight.DepartureStation = Vuelos[Selector - 1][0];
                    Flight.ArrivalStation = Vuelos[Selector - 1][1];
                    Flight.DepartureDate = Convert.ToDateTime(Vuelos[Selector - 1][2]);
                    Console.WriteLine("El vuelo elejido es:");
                    Flight.MostrarVuelo();
                }
                else
                {
                    Console.WriteLine("Vuelo no existente");
                }
            }
        }

    }
}
