using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Net_Core.Models
{
    public class Login
    {
        [Required]
        public int id { get; set; }
        public string pass { get; set; }

    }
}