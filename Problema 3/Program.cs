using System;
using Clases.ApiRest;
using Newtonsoft.Json;

namespace Problema_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseInicio Inicio =new ClaseInicio();
            DBApi dBapi = new DBApi();
            EnvioApi Info = new EnvioApi
            {
                Origin ="MDE",
                Destination = "CTG",
                From= "2022-01-27"
            };
            string Datos=Info.Serialize(Info);
            string json = dBapi.Post("http://testapi.vivaair.com/otatest/api/values",Datos);
            Inicio.Deserializacion(json);
            
        }       
    }
}
