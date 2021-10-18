using System;
using Clases.ApiRest;
using Newtonsoft.Json;
namespace Problema_3
{
    public class EnvioApi
    {
        public string Origin {get; set;}
        public string Destination { get; set; }
        public string From { get; set; }
        public string Serialize(EnvioApi Info)
    {
        string Datos = JsonConvert.SerializeObject(Info, Formatting.Indented);
        return Datos;
    }

    }
    
} 