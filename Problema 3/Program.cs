using System;
using Clases.ApiRest;
using Newtonsoft.Json;

namespace Problema_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DBApi dBapi = new DBApi();
            string json = "{\"Origin\": \"MDE\",\"Destination\": \"CTG\",\"From\": \"2022-01-27\"}";
            dynamic datos = dBapi.Post("http://testapi.vivaair.com/otatest/api/values",json);
            dynamic Desdatos = JsonConvert.DeserializeObject(datos);
            foreach(var dato in Desdatos)
            {
                //hacer algo
            }
        }
}
}
