﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CONTACTO_EJERCICIO.Models;

namespace CONTACTO_EJERCICIO.Controllers
{
    public class ContactoController : Controller
    {
        private readonly ILogger<ContactoController> _logger;

        public ContactoController(ILogger<ContactoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var listcontactos = new List<Contacto>();
            listcontactos.Add(new Contacto(){FirstName="Juan",LastName="Perez"});
            listcontactos.Add(new Contacto(){FirstName="Bob",LastName="Marley"});
            listcontactos.Add(new Contacto(){FirstName="Dante",LastName="Rodriguez"});
            
            ViewData["Message"] = "";
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contacto objContacto)
        {
            ViewData["Message"]="Se registro el contacto";
            return View("Index");
        }
    }
}
