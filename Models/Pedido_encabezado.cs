using System.ComponentModel.DataAnnotations;

namespace Proyecto_Net_Core.Models
{
    public class Pedido_encabezado
    {
        public int Pedido_encabezadoId { get; set; }
        public string fecha { get; set; }
        public float monto { get; set; }
        public int VendedorId { get; set; }
    }
}