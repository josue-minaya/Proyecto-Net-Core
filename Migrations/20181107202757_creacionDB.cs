using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoNetCore.Migrations
{
    public partial class creacionDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    apellido = table.Column<string>(nullable: true),
                    dni = table.Column<int>(nullable: false),
                    direccion = table.Column<string>(nullable: true),
                    telefono = table.Column<int>(nullable: false),
                    nombre_puesto = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.EmpleadoId);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    ProductoId = table.Column<string>(nullable: false),
                    foto = table.Column<string>(nullable: true),
                    especificaciones = table.Column<string>(nullable: true),
                    stock = table.Column<int>(nullable: false),
                    precio = table.Column<float>(nullable: false),
                    CategoriaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.ProductoId);
                    table.ForeignKey(
                        name: "FK_Producto_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cajero",
                columns: table => new
                {
                    CajeroId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    numcaja = table.Column<int>(nullable: false),
                    sueldo = table.Column<float>(nullable: false),
                    EmpleadoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cajero", x => x.CajeroId);
                    table.ForeignKey(
                        name: "FK_Cajero_Empleado_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleado",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vendedor",
                columns: table => new
                {
                    VendedorId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    sueldo_base = table.Column<float>(nullable: false),
                    EmpleadoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedor", x => x.VendedorId);
                    table.ForeignKey(
                        name: "FK_Vendedor_Empleado_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleado",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedido_encabezado",
                columns: table => new
                {
                    Pedido_encabezadoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fecha = table.Column<string>(nullable: true),
                    monto = table.Column<float>(nullable: false),
                    nombre = table.Column<string>(nullable: true),
                    VendedorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido_encabezado", x => x.Pedido_encabezadoId);
                    table.ForeignKey(
                        name: "FK_Pedido_encabezado_Vendedor_VendedorId",
                        column: x => x.VendedorId,
                        principalTable: "Vendedor",
                        principalColumn: "VendedorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedido_cuerpo",
                columns: table => new
                {
                    Pedido_cuerpoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cantidad = table.Column<int>(nullable: false),
                    precio = table.Column<float>(nullable: false),
                    codproducto = table.Column<string>(nullable: true),
                    Pedido_encabezadoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido_cuerpo", x => x.Pedido_cuerpoId);
                    table.ForeignKey(
                        name: "FK_Pedido_cuerpo_Pedido_encabezado_Pedido_encabezadoId",
                        column: x => x.Pedido_encabezadoId,
                        principalTable: "Pedido_encabezado",
                        principalColumn: "Pedido_encabezadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedido_Producto",
                columns: table => new
                {
                    ProductoId = table.Column<string>(nullable: false),
                    Pedido_encabezadoId = table.Column<int>(nullable: false),
                    tipoc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido_Producto", x => new { x.Pedido_encabezadoId, x.ProductoId });
                    table.ForeignKey(
                        name: "FK_Pedido_Producto_Pedido_encabezado_Pedido_encabezadoId",
                        column: x => x.Pedido_encabezadoId,
                        principalTable: "Pedido_encabezado",
                        principalColumn: "Pedido_encabezadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedido_Producto_Producto_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Producto",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Venta",
                columns: table => new
                {
                    VentaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    numboleta = table.Column<int>(nullable: false),
                    fecha = table.Column<string>(nullable: true),
                    CajeroId = table.Column<int>(nullable: false),
                    Pedido_encabezadoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venta", x => x.VentaId);
                    table.ForeignKey(
                        name: "FK_Venta_Cajero_CajeroId",
                        column: x => x.CajeroId,
                        principalTable: "Cajero",
                        principalColumn: "CajeroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Venta_Pedido_encabezado_Pedido_encabezadoId",
                        column: x => x.Pedido_encabezadoId,
                        principalTable: "Pedido_encabezado",
                        principalColumn: "Pedido_encabezadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cajero_EmpleadoId",
                table: "Cajero",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_cuerpo_Pedido_encabezadoId",
                table: "Pedido_cuerpo",
                column: "Pedido_encabezadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_encabezado_VendedorId",
                table: "Pedido_encabezado",
                column: "VendedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_Producto_ProductoId",
                table: "Pedido_Producto",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_CategoriaId",
                table: "Producto",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendedor_EmpleadoId",
                table: "Vendedor",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_CajeroId",
                table: "Venta",
                column: "CajeroId");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_Pedido_encabezadoId",
                table: "Venta",
                column: "Pedido_encabezadoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pedido_cuerpo");

            migrationBuilder.DropTable(
                name: "Pedido_Producto");

            migrationBuilder.DropTable(
                name: "Venta");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Cajero");

            migrationBuilder.DropTable(
                name: "Pedido_encabezado");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Vendedor");

            migrationBuilder.DropTable(
                name: "Empleado");
        }
    }
}
