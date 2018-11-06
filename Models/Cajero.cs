using System.ComponentModel.DataAnnotations;

namespace Proyecto_Net_Core.Models
{
    public class Cajero
    {
        public int CajeroId { get; set; }
        public int numcaja { get; set; }
        public float sueldo { get; set; }
        public int EmpleadoId { get; set; }
    }
}