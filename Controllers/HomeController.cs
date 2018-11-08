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
                    return RedirectToAction("IngresoProducto");  
                } else {
                     if(empleado.nombre_puesto=="Cajero"){
                        return RedirectToAction("IngresoProducto"); 
                    }  
                }  
            } 
            return View();
        }
        public IActionResult IngresoProducto()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult IngresoProducto(Producto pr)
        {
             if (ModelState.IsValid)
            {
                _context.Add(pr);
                _context.SaveChanges();
            
                return RedirectToAction("IngresoProducto");
            }
            return View(pr);
            
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

                return RedirectToAction("Index");
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

                return RedirectToAction("AsignacionVendedor");
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
                return RedirectToAction("AsignacionVendedor");
                
            }
            return View(e);
        }
        
        public IActionResult BusquedaProducto( )
        {
             
            
            return View();
        }

        
        public IActionResult DetalleProducto(ViewModel v)
        {
             if (!ModelState.IsValid)
            {
                return RedirectToAction("BusquedaProducto");
                
            }
        
            var producto=_context.Producto.FirstOrDefault(q=>q.ProductoId==v.Id);           
            return View(producto);
        }












        public IActionResult Pedidos(ViewModel2 p)
        {
          
            return View();
        }
        
       
       
        
        
        
    }
}
