using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CONTACTO_EJERCICIO.Models;

namespace CONTACTO_EJERCICIO.Controllers
{
    public class CalculadoraController : Controller
    {
        private readonly ILogger<CalculadoraController> _logger;

        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Execute(Calculadora objCalculadora)
        {
            Double res= 0.0;
            String msj = "";

            if("+" == objCalculadora.Operando){
                res = objCalculadora.Operador1 + objCalculadora.Operador2;
                msj = "El resultado es  "+ res;
            }
            if("/" == objCalculadora.Operando){
                if(objCalculadora.Operador2 == 0){
                    msj="El numero no puede ser divido entre 0";    
                }else{
                    res= objCalculadora.Operador1 / objCalculadora.Operador2;
                    msj="El resultado es "+ res;
                }
            }
            ViewData["Message"]="El resultado es"+res;
            return View("Index");
        }
    }
}
