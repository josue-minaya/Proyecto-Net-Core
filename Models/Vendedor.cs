using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Net_Core.Models
{
    public class Vendedor
    {
        public int VendedorId { get; set; }
        public float sueldo_base { get; set; }
       
        public Empleado Empleado { get; set; }
        public int EmpleadoId { get; set; }
        public List<Pedido_encabezado> Pedido_encabezados { get; set; }
}
}