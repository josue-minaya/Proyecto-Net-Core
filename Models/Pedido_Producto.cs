using System.ComponentModel.DataAnnotations;

namespace Proyecto_Net_Core.Models
{
    public class Pedido_Producto
    {
        public string ProductoId { get; set; }
        public int Pedido_encabezadoId { get; set; }
       public string nombre_cliente { get; set; }
    }
}