using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RegistroFutbol.Models;

namespace RegistroFutbol.Controllers
{
   
    public class JugadorController : Controller
    {
        private readonly ILogger<JugadorController> _logger;

        public JugadorController(ILogger<JugadorController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Jugador objJugador)
        {
            const decimal costoInscripcion = 300;
            const decimal impuesto = 0.19m;

            decimal costoTotal = costoInscripcion * objJugador.Temporada;
            decimal totalImpuesto = costoTotal * impuesto;
            objJugador.MontoTotal = costoTotal + totalImpuesto;

            return View("Index",objJugador);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}