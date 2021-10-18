using System;
using System.ComponentModel.DataAnnotations;

namespace Problema2.Models
{
    public class Flight
    {
        [Required]
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
        public DateTime DepartureDate { get; set; }

    }
}

