using System.IO;

namespace Problema_1_Modelado_Clases.Vuelos
{
    public class Ciudades
    {
        public string Codigo { get; private set; }
        public Ciudades() => Codigo = 0;
        private static void PosiblesCuidades()
        {
            string[] lineas = File.ReadAllLines("./File/Prueba.csv");
            // var CiudadSalida = 
            foreach (var linea in lineas)
            {

            }

        }
    }
}