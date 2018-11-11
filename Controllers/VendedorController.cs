using System.Web;
using System.Linq;
using System;

using Microsoft.AspNetCore.Mvc;
using Proyecto_Net_Core.Models;
using System.Collections.Generic;

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
          
             var producto=_context.Producto.FirstOrDefault(q=>q.ProductoId==p.Id);           
            return View(producto);
        }
         
         public IActionResult agregarcarrito(string Id)
         {
             
             if (Session["carrito"]==null)
             {
              List<Carrito> compras=new List<Carrito>(); 
              compras.Add( new Carrito(_context.Producto.Find(Id)));
              Session["carrito"]=compras;
              
             }else{
                List<Carrito> compras=(List<Carrito>)Session["carrito"];
                compras.Add( new Carrito(_context.Producto.Find(Id)));
                Session["carrito"]=compras;
             } 
             return View();
         }
         public IActionResult eliminar(string Id){
               List<Carrito> compras=(List<Carrito>)Session["carrito"];
               compras.RemoveAt(getIndex(Id));
             return View("agregarcarrito");
         }
         public int getIndex(string Id){
              List<Carrito> compras=(List<Carrito>)Session["carrito"];
              for(int i=0;i<compras.Count;i++){
                  if(compras[i].producto.ProductoId==Id){
                      return i;
                  }
              }
            return -1;
        }
    }
}