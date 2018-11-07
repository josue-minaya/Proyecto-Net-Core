using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Proyecto_Net_Core.Models;

namespace Proyecto_Net_Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly VentasContext _context;
        public HomeController(VentasContext context)
        {
            this._context=context;
        }
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult IngresoProducto()
        {
            
            return View();
        }
        
        public IActionResult BusquedaProducto()
        {
            
            return View();
        }

        public IActionResult Pedidos()
        {
            
            return View();
        }
        public IActionResult IngresoEmpleado()
        {
            
            return View();
        }
        public IActionResult AsignacionPuesto()
        {
            
            return View();
        }
        
    }
}
