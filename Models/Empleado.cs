using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Net_Core.Models
{
    public class Empleado
    {
        [Required]
        public int EmpleadoId { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string apellido { get; set; }
        [Required]
        public int dni { get; set; }
        [Required]
        public string direccion { get; set; }
        [Required]
        public int telefono { get; set; }
        [Required]
        public string nombre_puesto { get; set; }
        [Required]
        public string  password { get; set; }
        
       
        
        public List<Vendedor> Vendedores { get; set; }
        public List<Cajero> Cajeros { get; set; }
    }
}