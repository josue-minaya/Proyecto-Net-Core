﻿using System;
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
    public class HomeController : Controller
    {
        private readonly VentasContext _context;
        public HomeController(VentasContext context)
        {
            this._context=context;
        }

        public IActionResult Index(){
            return View();
        }
        
        [HttpPost]
         public IActionResult Index(Login emp)
        {
            if (ModelState.IsValid) {
            var empleado = _context.Empleado.FirstOrDefault
                           (e => e.EmpleadoId == emp.id 
                           && e.password == emp.pass);
                if(empleado==null){
                    return RedirectToAction("Index");  
                } else {
                     if(empleado.nombre_puesto=="Cajero"){
                        return RedirectToAction("OrdenesVenta","Cajero"); 
                     }  else if (empleado.nombre_puesto=="Vendedor") {
                         return RedirectToAction("Vendedor","Vendedor"); 
                     } else if (empleado.nombre_puesto=="Administrador") {
                         return RedirectToAction("Administrador","Administrador");
                     }
                }  
            } 
            return View();
        }
        
       
        
        
       
        
        
        
        
        
    }
}
