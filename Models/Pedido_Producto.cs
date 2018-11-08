using System.ComponentModel.DataAnnotations;

namespace Proyecto_Net_Core.Models
{
    public class Pedido_Producto
    {
        public Pedido_encabezado Pedido_encabezado{ get; set; }
        public Producto Producto { get; set; }
        [Required]
        public string ProductoId { get; set; }
        [Required]
        public int Pedido_encabezadoId { get; set; }
        [Required]
        public string tipoc { get; set; }
    }
}