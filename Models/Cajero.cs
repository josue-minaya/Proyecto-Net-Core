using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Net_Core.Models
{
    public class Cajero
    {
        [Required]
        public int CajeroId { get; set; }
        [Required]
        public int numcaja { get; set; }
        [Required]
        public float sueldo { get; set; }
        
        public Empleado Empleado { get; set; }
        [Required]
         public int EmpleadoId { get; set; }
        
        public List<Venta> Ventas { get; set; }
    }
}