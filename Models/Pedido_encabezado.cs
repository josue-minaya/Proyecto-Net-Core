using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Net_Core.Models
{
    public class Pedido_encabezado
    {
        [Required]
        public int Pedido_encabezadoId { get; set; }
        [Required]
        public string fecha { get; set; }
        [Required]
        public float monto { get; set; }
        [Required]
        public string nombre { get; set; }
        public Vendedor Vendedor { get; set; }
        [Required]
        public int VendedorId { get; set; }
        public Venta Venta { get; set; }
        public List<Pedido_cuerpo> Pedido_cuerpos { get; set; }
         public List<Pedido_Producto> Pedido_Productos { get; set; }
    }
}