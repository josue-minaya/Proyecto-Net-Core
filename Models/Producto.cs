using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Net_Core.Models
{
    public class Producto
    {
        [Required]
        public string ProductoId { get; set; }
        
        public string foto { get; set; }
        [Required]
        public string especificaciones { get; set; }
        [Required]
        public int stock { get; set; }
        [Required]
        public float precio { get; set; }
        
        public Categoria Categoria { get; set; }
        [Required]
        public int CategoriaId { get; set; }
        public List<Pedido_Producto> Pedido_Productos { get; set; }
    }
}