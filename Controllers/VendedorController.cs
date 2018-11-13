using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Web;
using System.Linq;
using System;
using Proyecto_Net_Core.Models;
using System.Collections.Generic;
using Newtonsoft.Json;

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
            if(producto==null){
                return RedirectToAction("BusquedaProducto");
            } 
            return View(producto);
        }
        public IActionResult Pedidos(ViewModel p)
        {
            var carrito = JsonConvert.DeserializeObject(HttpContext.Session.GetString("carrito")) as List<Carrito> ?? new List<Carrito>();

            ViewBag.carrito = carrito;

             var producto=_context.Producto.FirstOrDefault(q=>q.ProductoId==p.Id);           
            return View(producto);
        }
         








      
         public IActionResult agregacarrito(ViewModel Id)
         {  
             // Leer de la sesion
            var carrito = JsonConvert.DeserializeObject(HttpContext.Session.GetString("carrito")) as List<Carrito>;

             if (carrito == null)
             {
              List<Carrito> nuevoCarrito =new List<Carrito>(); 
              nuevoCarrito.Add( new Carrito(_context.Producto.Find(Id)));

              // Guardar sesion
              HttpContext.Session.SetString("carrito", JsonConvert.SerializeObject(nuevoCarrito));
              
             }else{
                carrito.Add( new Carrito(_context.Producto.Find(Id)));
                HttpContext.Session.SetString("carrito", JsonConvert.SerializeObject(carrito));
             } 
             return RedirectToAction("Pedidos");
         }









         public IActionResult eliminar(string Id){
               var compras = JsonConvert.DeserializeObject(HttpContext.Session.GetString("carrito")) as List<Carrito>;
               compras.RemoveAt(getIndex(Id));
             return View("agregarcarrito");
         }
         public int getIndex(string Id){
              var compras = JsonConvert.DeserializeObject(HttpContext.Session.GetString("carrito")) as List<Carrito>;
              for(int i=0;i<compras.Count;i++){
                  if(compras[i].producto.ProductoId==Id){
                      return i;
                  }
              }
            return -1;
        }
    }
}