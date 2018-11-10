using Microsoft.EntityFrameworkCore;

namespace Proyecto_Net_Core.Models
{
    public class VentasContext : DbContext
    {
        public VentasContext(DbContextOptions<VentasContext> options) 
        : base(options) {

        }
      
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Pedido_Producto>().HasKey(pc=> new{pc.Pedido_cuerpoId,pc.ProductoId});
            
            modelbuilder.Entity<Pedido_Producto>()
            .HasOne(pc=>pc.Pedido_cuerpo)
            .WithMany(p=>p.Pedido_Productos)
            .HasForeignKey(pc=>pc.Pedido_cuerpoId);

            modelbuilder.Entity<Pedido_Producto>()
            .HasOne(pc=>pc.Producto)
            .WithMany(c=>c.Pedido_Productos)
            .HasForeignKey(pc=>pc.ProductoId);

            modelbuilder.Entity<Categoria>().HasData(
                new Categoria{
                    CategoriaId=1,
                    nombre="Refrigeradora",
                },
                new Categoria{
                    CategoriaId=2,
                    nombre="Cocina",
                },
                new Categoria{
                    CategoriaId=3,
                    nombre="Microondas",
                }
            );
            modelbuilder.Entity<Empleado>().HasData(
                new Empleado{
                    EmpleadoId=1,
                    nombre="Manuel",
                    apellido="Perez",
                    dni=7541235,
                    direccion="Av. La fontana",
                    telefono=957421454,
                    nombre_puesto="Administrador",
                    password="12345",
                },
                new Empleado{
                    EmpleadoId=2,
                    nombre="Juan",
                    apellido="Vasquez",
                    dni=4785478,
                    direccion="Av. La Molina",
                    telefono=954781256,
                    nombre_puesto="Vendedor",
                    password="abcd",
                },
                new Empleado{
                    EmpleadoId=3,
                    nombre="Tomas",
                    apellido="Sanchez",
                    dni=5478547,
                    direccion="Av. aviacion",
                    telefono=952147563,
                    nombre_puesto="Cajero",
                    password="98765",
                }
            );
            
        }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Empleado> Empleado { get; set; }

        public DbSet<Cajero> Cajero { get; set; }
        
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Pedido_encabezado> Pedido_encabezado{get;set;}
        public DbSet<Pedido_cuerpo> Pedido_cuerpo { get; set; }
        public DbSet<Pedido_Producto> Pedido_Producto{get;set;}
        
         
        public DbSet<Venta> Venta { get; set; }


    }
    
}