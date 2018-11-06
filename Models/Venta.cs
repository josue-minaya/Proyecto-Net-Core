using System.ComponentModel.DataAnnotations;

namespace Proyecto_Net_Core.Models
{
    public class Venta
    {
        public int VentaId { get; set; }
        public int numboleta { get; set; }
        public string fecha { get; set; }
        public int CajeroId { get; set; }
        public int Pedido_encabezadoId { get; set; }
       
    }
}