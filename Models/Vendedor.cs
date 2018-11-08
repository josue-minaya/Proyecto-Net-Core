using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Net_Core.Models
{
    public class Vendedor
    {
        [Required]
        public int VendedorId { get; set; }
        [Required]
        public float sueldo_base { get; set; }
       
        public Empleado Empleado { get; set; }
        [Required]
        public int EmpleadoId { get; set; }
        public List<Pedido_encabezado> Pedido_encabezados { get; set; }
}
}