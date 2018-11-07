using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Net_Core.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string nombre { get; set; }
        public List<Producto> Productos { get; set; }
    }
}