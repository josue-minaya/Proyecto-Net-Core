using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proyecto_Net_Core.Models;

namespace Proyecto_Net_Core.Controllers
{
    public class AdministradorController : Controller
    {
        private readonly VentasContext _context;
        public AdministradorController(VentasContext context)
        {
            this._context=context;
        }
        public IActionResult AsignacionCajero()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult AsignacionCajero(Cajero c)
        {
             if (ModelState.IsValid)
            {
                _context.Add(c);
                _context.SaveChanges();

                return RedirectToAction("Administrador");
            }
            return View(c);
        }
        public IActionResult AsignacionVendedor()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult AsignacionVendedor(Vendedor v)
        {
             if (ModelState.IsValid)
            {
                _context.Add(v);
                _context.SaveChanges();

                return RedirectToAction("Administrador");
            }
            return View(v);
        }
        public IActionResult IngresoEmpleado()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult IngresoEmpleado(Empleado e)
        {
            
          if (ModelState.IsValid)
            {
                _context.Add(e);
                _context.SaveChanges();

                return RedirectToAction("Administrador");                
            }
            return View(e);
        }
        public IActionResult Administrador(){
            return View();
        }
    }
}