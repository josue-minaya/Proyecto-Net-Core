using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Net_Core.Models
{
    public class Pedido_encabezado
    {
        public int Pedido_encabezadoId { get; set; }
        public string fecha { get; set; }
        public float monto { get; set; }
        public string nombre { get; set; }
        public Vendedor Vendedor { get; set; }
        public int VendedorId { get; set; }
        public List<Pedido_cuerpo> Pedido_cuerpos { get; set; }
         public List<Pedido_Producto> Pedido_Productos { get; set; }
    }
}