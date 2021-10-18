using System;
using System.Collections.Generic;
using Problema_3_Modela.Vuelos;
using Newtonsoft.Json;
using System.Dynamic;
namespace Problema_3
{

    //
    //Clase para cuando se resivan un dato de la api guardarlo en Las Clases del Problema 1
    //
    public class ClaseInicio
    {
        public Flight Flight { get; set; }
        // public List<Flight> ListaDevuelos;
        public ClaseInicio()
        {

        }

        public List<Flight> Deserializacion(string json)
        {
            List<Flight> ListaDevuelos= new List<Flight>();
            var listProductos = JsonConvert.DeserializeObject<List<ExpandoObject>>(json);
            foreach(dynamic prod in listProductos)
            {
            Flight = new Flight
            {
                DepartureStation = prod.DepartureStation,
                ArrivalStation = prod.ArrivalStation,
                DepartureDate = prod.DepartureDate,
                Price = prod.Price,
                Currency = prod.Currency,
                Transport = new Transport
                {
                    FlightNumber=prod.FlightNumber
                }

            };
            ListaDevuelos.Add(Flight);
            
            }
            foreach(Flight vuelo in ListaDevuelos)
            vuelo.MostrarVuelo();
            return ListaDevuelos;
        }

    }
}