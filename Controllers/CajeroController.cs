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
    public class CajeroController : Controller
    {
        private readonly VentasContext _context;
        public CajeroController(VentasContext context)
        {
            this._context=context;
        }
        public IActionResult Cajero()
        {
            
            return View();
        }
        public IActionResult OrdenesVenta(string nombre){
              if (!ModelState.IsValid)
            {
                return RedirectToAction("OrdenesVenta");
                
            }
        
            var lista=_context.Pedido_encabezado.FirstOrDefault(q=>q.nombre==nombre);          
            if(lista==null){
                return RedirectToAction("OrdenesVenta");
            } 
            return View(lista);
        }
       
    }
}