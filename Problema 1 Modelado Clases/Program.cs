using System;
using Problema_1_Modela.Vuelos;
using System.IO;
namespace Problema_1_Modelado
{
        class Program
    {
        static void Main(string[] args)
        {
            string[] lineas=File.ReadAllLines("./File/Cuidades.csv");
            foreach(var linea in lineas)
            {
                if (linea.Equals("AGS"))
                {
                    Console.WriteLine("Todo bien");
                }
                
            }
        }
    }

}