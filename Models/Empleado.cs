using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Net_Core.Models
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public string nombre_puesto { get; set; }
        public string  password { get; set; }
        public Empleado empleado { get; set; }
        
        public List<Vendedor> Vendedores { get; set; }
        public List<Cajero> Cajeros { get; set; }
    }
}