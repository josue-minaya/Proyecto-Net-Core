using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Net_Core.Models
{
    public class Categoria
    {
        [Required]
        public int CategoriaId { get; set; }
        [Required]
        public string nombre { get; set; }
        public List<Producto> Productos { get; set; }
    }
}