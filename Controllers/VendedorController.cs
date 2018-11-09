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
    public class VendedorController : Controller
    {
        private readonly VentasContext _context;
        public VendedorController(VentasContext context)
        {
            this._context=context;
        }
        public IActionResult Vendedor()
        {
            
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
        public IActionResult Pedidos(ViewModel p)
        {
          
             var producto=_context.Producto.FirstOrDefault(q=>q.ProductoId==p.Id);           
            return View(producto);
        }
         
    }
}