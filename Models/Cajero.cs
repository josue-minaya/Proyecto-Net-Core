using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Net_Core.Models
{
    public class Cajero
    {
        public int CajeroId { get; set; }
        public int numcaja { get; set; }
        public float sueldo { get; set; }
        public Empleado Empleado { get; set; }
         public int EmpleadoId { get; set; }
        public List<Venta> Ventas { get; set; }
    }
}