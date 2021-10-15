using System;
using Problema_1_Modela.Vuelos;
using System.IO;
namespace Problema_1_Modelado
{
        class Program
    {
        static void Main(string[] args)
        {
            string[] lineas=File.ReadAllLines("./File/Prueba.csv");
            foreach(var linea in lineas)
            {
                var valores = linea.Split(';');
                Console.WriteLine("parte de: "+valores[0][0]+"llega a:" +valores[0][1]);
            }
        }
    }

}