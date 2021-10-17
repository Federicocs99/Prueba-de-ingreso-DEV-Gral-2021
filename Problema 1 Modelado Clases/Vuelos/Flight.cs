using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problema_1_Modela.Vuelos
{
    public class Flight
    {
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
        public DateTime DepartureDate { get; set; }
        public Transport Transport { get; }
        public decimal Price { get; }
        public string Currency { get; set; }
        public Flight()
        {
            Transport = new Transport();
            var guid = Guid.NewGuid();
            var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0, 4));
            var random = new Random(seed);
            var value = random.Next(1, 100);
            decimal Price = value;
        }
        public void MostrarVuelo()
        {
            Console.WriteLine($"El Vuelo Sale de: {DepartureStation} y llega a: {ArrivalStation} En la fecha:{DepartureDate} Tiene numero de Vuelo: {Transport.FligthNumbre } Con precio de: {Price} {Currency}");
        }
    }
}
