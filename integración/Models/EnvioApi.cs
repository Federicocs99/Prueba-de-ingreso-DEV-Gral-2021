using System;
using integración.Models.ApiRest;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Dynamic;
using System.ComponentModel.DataAnnotations;
namespace integración.Models
{
    public class EnvioApi
    {
        [Required]
        public string Origin {get; set;}
        [Required]
        public string Destination { get; set; }
        public string From { get; set; }
       
       
       // serializa la información de la clase EnvioApi y lo deja con la estructura de un json para ser enviado a la api
        public string Serialize(EnvioApi Info)
    {
 
        DBApi dBapi = new DBApi();
        string Datos = JsonConvert.SerializeObject(Info, Formatting.Indented);
        
        string json = dBapi.Post("http://testapi.vivaair.com/otatest/api/values",Datos);
        return json;

        
    }
            public List<Flight> Deserializacion(string json)
        {
            List<Flight> ListaDevuelos= new List<Flight>();
            var listProductos = JsonConvert.DeserializeObject<List<ExpandoObject>>(json);
            foreach(dynamic prod in listProductos)
            {
            Flight Flight = new Flight
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