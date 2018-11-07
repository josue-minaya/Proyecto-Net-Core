using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Net_Core.Models
{
    public class Producto
    {
        public string ProductoId { get; set; }
        public string foto { get; set; }
        public string especificaciones { get; set; }
        public int stock { get; set; }
        public float precio { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
        public List<Pedido_Producto> Pedido_Productos { get; set; }
}
}