using System.ComponentModel.DataAnnotations;

namespace Proyecto_Net_Core.Models
{
    public class vendedor
    {
        public int VendedorId { get; set; }
        public float sueldo_base { get; set; }
        public int AdministradorId { get; set; }
    }
}