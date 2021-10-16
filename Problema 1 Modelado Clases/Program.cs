using System;
using Problema_1_Modela.Vuelos;
using System.IO;
namespace Problema_1_Modelado
{
    class Program
    {

        static void Main(string[] args)
        {
            //  var vuelo = new Engine();
            //  vuelo.Initialize();
            string[] lineas = File.ReadAllLines("./File/Vuelos_Fechas.csv");
            bool marcador = true;
            foreach (var linea in lineas)
            {
                var valor = linea.Split(";");
                DateTime date = Convert.ToDateTime(valor[2]);
                if (date.Year > 2024)
                {
                    Console.WriteLine(linea);
                    marcador = false;
                }
            }
            if (marcador)
            {
                    Console.WriteLine("Los aeropuerto ingresados son incorrectos.");
            }

        }
    }

}