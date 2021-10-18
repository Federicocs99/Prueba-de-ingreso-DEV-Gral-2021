using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using integración.Models;
using integración.Models.ApiRest;

namespace integración.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var vuelo = new EnvioApi();
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(EnvioApi vuelo)
        {   
            if (ModelState.IsValid){
                vuelo.From= "2022-01-27"; // No logre integrar la fecha con la web por lo que la fecha la set desde el codigo.
                string json=vuelo.Serialize(vuelo);
                
                List<Flight> flight=vuelo.Deserializacion(json);

                return View();
                }
                else
                {
                    ViewBag.mensaje="Ingresar valor en Origen y o Destino";
                    return View();
                }
            
            
        }
        public IActionResult Resultado()
        {
                Flight Flight = new Flight(){
                    DepartureStation="BOG",
                    ArrivalStation="MDE",
                    Price=1000
                };
            return View(Flight);
        }
    }
}
