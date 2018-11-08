using System.ComponentModel.DataAnnotations;

namespace Proyecto_Net_Core.Models
{
    public class Venta
    {
        [Required]
        public int VentaId { get; set; }
        [Required]
        public int numboleta { get; set; }
        [Required]
        public string fecha { get; set; }
        public Cajero Cajero { get; set; }  
        [Required]  
        public int CajeroId { get; set; } 
        public Pedido_encabezado Pedido_encabezado { get; set; }
        [Required]
        public int Pedido_encabezadoId { get; set; }
       
    }
}