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
         public IActionResult Index(Empleado emp)
        {
            if (ModelState.IsValid) {
            var empleado = _context.Empleado.FirstOrDefault
                           (e => e.EmpleadoId == emp.EmpleadoId 
                           && e.password == emp.password);
                if(empleado==null){
                    return RedirectToAction("Index");  
                } else {
                     if(empleado.nombre_puesto=="Cajero"){
                        return RedirectToAction("IngresoProducto"); 
                     }  else if (empleado.nombre_puesto=="Vendedor") {
                         return RedirectToAction("Pedidos"); 
                     } else if (empleado.nombre_puesto=="Administrador") {
                         return RedirectToAction("IngresoEmpleado");
                     }
                }  
            } 
            return View();
        }
        
       
        
        
       
        
        
        
        
        
    }
}
