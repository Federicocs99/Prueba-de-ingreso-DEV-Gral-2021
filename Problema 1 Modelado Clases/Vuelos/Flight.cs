using System;
using System.IO;

namespace Problema_1_Modela.Vuelos
{
    public class Flight
    {
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
        public DateTime DepartureDate { get; set; }
        private Transport transport;
        public decimal Price { get; }
        public string Currency { get; set; }


        public void MostarVuelos()
        {
            string[] lineas = File.ReadAllLines("./File/Vuelos_Fechas.csv");
            //El archivo contiene las aeropuertos en codigo IATA de las que pueden partir vuelos (uso un csv para emular el uso de BD y se podría replamplazar por un query: SELECT DISTINCT DepartureStation FROM flight;)
            bool marcador = true;
                foreach (var linea in lineas)
                {

                    var valor = linea.Split(";");
                    if ((valor[0]+valor[1]).Equals(DepartureStation + ArrivalStation))
                    {
                        DateTime FechaDeVuelo = Convert.ToDateTime(valor[2]);
                        Console.WriteLine(FechaDeVuelo);
                        int result = DateTime.Compare(FechaDeVuelo,DepartureDate);

                        if(result==0)
                        {

                            Console.WriteLine("Existe un vuelo para fecha seleccionada y es: "+ FechaDeVuelo );
                            marcador=false;

                        }
                    }

                }
                if (marcador)
                {
                    Console.WriteLine("No existen vuelos para la fecha selecionada");
                }




        }
    }
}