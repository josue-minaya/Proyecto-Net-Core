using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Net_Core.Models
{
    public class Pedido_cuerpo
    {
        [Required]
        public int Pedido_cuerpoId { get; set; }
        [Required]
        public int cantidad { get; set; }
        [Required]
        public float precio { get; set; }
        [Required]
        public string codproducto { get; set; }
       
        public Pedido_encabezado Pedido_encabezado { get; set; }
        [Required]
        public int Pedido_encabezadoId { get; set; }
         public List<Pedido_Producto> Pedido_Productos { get; set; }
       
    }
}