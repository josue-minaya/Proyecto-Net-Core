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
            modelbuilder.Entity<Pedido_Producto>().HasKey(pc=> new{pc.Pedido_encabezadoId,pc.ProductoId});
            
            modelbuilder.Entity<Pedido_Producto>()
            .HasOne(pc=>pc.Pedido_encabezado)
            .WithMany(p=>p.Pedido_Productos)
            .HasForeignKey(pc=>pc.Pedido_encabezadoId);

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