using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Proyecto_Net_Core.Models
{
    public class Carrito 
    {
        
        public Carrito(Producto producto, int cantidad) 
        {
            this.producto = producto;
                this.cantidad = cantidad;
               
        }
                public Producto producto { get; set; }
        public int cantidad { get; set; }
        public Carrito(Producto producto)
        {
            this.producto=producto;
            
        }
        public Carrito(){

        }
    
    }
}