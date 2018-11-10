using System.ComponentModel.DataAnnotations;

namespace Proyecto_Net_Core.Models
{
    public class Pedido_Producto
    {
        public Pedido_cuerpo Pedido_cuerpo{ get; set; }
        public Producto Producto { get; set; }
        [Required]
        public string ProductoId { get; set; }
        [Required]
        public int Pedido_cuerpoId { get; set; }
        [Required]
        public string tipoc { get; set; }
    }
}