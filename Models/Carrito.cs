using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Proyecto_Net_Core.Models
{
    public class Carrito 
    {
        
        public Producto producto { get; set; }
        

        public Carrito(Producto producto) 
        {
            this.producto = producto;
           
               
        }
        
        public Carrito(){

        }
    
    }
}