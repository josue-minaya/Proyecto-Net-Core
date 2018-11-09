using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proyecto_Net_Core.Models;

namespace Proyecto_Net_Core.Controllers
{
    public class AdministradorController : Controller
    {
        private readonly VentasContext _context;
        public AdministradorController(VentasContext context)
        {
            this._context=context;
        }
    }
}