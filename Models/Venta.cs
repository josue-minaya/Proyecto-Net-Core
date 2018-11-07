using System.ComponentModel.DataAnnotations;

namespace Proyecto_Net_Core.Models
{
    public class Venta
    {
        public int VentaId { get; set; }
        public int numboleta { get; set; }
        public string fecha { get; set; }
        public Cajero Cajero { get; set; }    
        public int CajeroId { get; set; } 
        public Pedido_encabezado Pedido_encabezado { get; set; }
       
    }
}