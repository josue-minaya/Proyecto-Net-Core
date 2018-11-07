using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Net_Core.Models
{
    public class Pedido_cuerpo
    {
        public int Pedido_cuerpoId { get; set; }
        public int cantidad { get; set; }
        public float precio { get; set; }
        public string codproducto { get; set; }
        public Pedido_encabezado Pedido_encabezado { get; set; }
        public int Pedido_encabezadoId { get; set; }
       
    }
}