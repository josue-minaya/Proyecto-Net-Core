# Proyecto-PM
Proyecto Programación Multiplataforma

## Nombre del Proyecto
PagoFácil

## Descripcion del Proyecto
Una aplicación web que agilice el proceso de compra en las sucursales de una tienda de electrodomésticos. Para esto, se dispondrá de una aplicación con interfaces específicas dirigida para el personal en caja y otra para los miembros del equipo de ventas. Con esto, se busca reducir el tiempo de espera del cliente al momento de cancelar los productos que desea llevar, los tiempos de cierre de venta para atender a nuevos clientes, mejor control de comisiones por vendedor, control de inventario en tiempo real, evitar los viajes a almacén, revisión eficiente de ventas logradas en diferentes periodos de tiempo y reducir costos invertidos en papel de impresión. 

## Autores
* Minaya, Josue
* Rodriguez, Jorge

## Manual de Instalación y de Uso

### Inicio
La aplicación web recibirá a cada usuario con una pantalla de ingreso en el cual pedirá sus credenciales y los llevará a las subpáginas específicas de acuerdo a las funcionalidades y funciones propias de su rol en la tienda. 

### Administrador
Las vistas de administrador proveen a cada miembro de su equipo con las funcionalidades de Ingreso de Empleado a la base de datos de la tienda. Esta sera diferenciada a manera de designación de roles con atributos específicos. De esta manera, un administrador ingresará a un empleado genérico, y luego pasará a darle el rol de cajero o vendedor. Una vez finalizado el llenado, un nuevo colaborador pasará a formar parte del equipo de la tienda. 

#### Pantalla de Administrador
1. Seleccionar la pantalla a la que se desea acceder

#### Asignacion de Empleado
1. Proceder a llenar los campos con la informacion adecuada del empleado
1. Verificar la informacion previamente llenada
1. Acabar dando clic en "Ingresar Empleado" para almacenar al nuevo colaborador en la base de datos de la tienda

#### Asignacion de Vendedor y Asignacion de Cajero
1. Completar todos los campos mostrados de acuerdo al rol del nuevo empleado
1. Verificar la información a almacenar
1. Clic en "Ingresar" para culminar con el proceso

### Cajero
La vista del cajero proporcionará a cada uno de estos trabajadores con una vista especializada de las ventas por confirmar que serán escritas por los vendedores. Ante esto, los cajeros recibirán la información y procederán a cerrar la venta una vez el cliente a proporcionado sus datos. 

#### Ordenes de Venta
1. Pedir al cliente sus datos
1. Verificar que se encuentre dentro de los ultimos pedidos enviador por los vendedores
1. Proceder con el cierre de la venta 

### Vendedor
En el caso de los vendedores, este tipo de trabajador posee la mayor cantidad de funcionalidades. Empezando por el ingreso de un nuevo producto, al cual debe colocarse todas sus especificaciones de acuerdo al modelo trabajado. Segundo, la parte de búsqueda de producto, en donde se rellena el campo de código de producto. Una vez completado, nos dirigirá a la vista de Detalle de Producto donde nos mostrará toda la información acerca de lo que se busca con el fin de informar adecuadamente al cliente en cuestión. Finalmente, en la parte de Pedidos es lo que actuará como un carrito de compras donde se almacenarán todos los productos deseados por el cliente a ser pasados al cajero para que este finalice la venta. Todo lo anterior dicho, ofrecido a través de enlances desde un vista general denominada Vendedor con un acceso a todas las demas funcionalidades que se le ofrece a este tipo de trabajador.

#### Ingreso de Producto
1. Llene los campos de acuerdo lo pedido 
1. Revise que se ha completado adecuadamente
1. Clic en "Ingrese Producto" para culimnar con el proceso

#### Búsqueda de Producto
1. Digite el codigo del producto a buscar
1. Clic en "Buscar" para culimnar con el proceso
1. Clic en "Regresar" para salir de la pantalla

#### Pedidos
1. Verificar conformidad de los pedidos agendados
1. Clic en "Seguir comprando" para agregar más productos
1. Clic en "Finalizar" para enviar el pedido a cajero
