

namespace PROYECTO_FINAL_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // **PRODUCTO**

            // OBTENER PRODUCTO POR ID - OK

            //Producto producto = ManejadorProducto.ObtenerProducto(1);
            //Console.WriteLine(producto.Descripciones);

            // INSERTAR UN PRODUCTO - OK

            //Producto productoAInsertar = new Producto();
            //productoAInsertar.Descripciones = "Producto Prueba";
            //productoAInsertar.Costo = 90;
            //productoAInsertar.PrecioVenta = 160;
            //productoAInsertar.Stock = 10;
            //productoAInsertar.IdUsuario = 3;
            //if (ManejadorProducto.InsertarProducto(productoAInsertar) >= 1)
            //{
            //    Console.WriteLine("Producto Insertado");
            //}
            //else
            //{
            //    Console.WriteLine("No se pudo insertar el producto");
            //}

            // ELIMINAR PRODUCTO - FALTA RESOLVER CUANDO EL PRODUCTO ESTA EN TABLA PRODUCTOVENDIDO

            //int verificador = ManejadorProducto.DeleteProducto(1);
            //if (verificador < 1)
            //{
            //    Console.WriteLine("Hubo un problema al eliminar");
            //}
            //else
            //{
            //    Console.WriteLine("Se elimino correctamente");
            //}

            // ACTUALIZAR PRODUCTO - OK

            //Producto productoUpdate = new Producto();
            //productoUpdate.Id = 1;
            //productoUpdate.Descripciones = "Remera Musculosa";
            //productoUpdate.Costo = 400;
            //productoUpdate.PrecioVenta = 600;
            //productoUpdate.Stock = 40;
            //productoUpdate.IdUsuario = 3;
            //if (ManejadorProducto.UpdateProducto(productoUpdate) >= 1)
            //{
            //    Console.WriteLine("Producto Actualizado");
            //}
            //else
            //{
            //    Console.WriteLine("Producto no fue actualizado");
            //}

            // OBTENER LISTA DE PRODUCTOS - OK

            //List<Producto> listaProductos = ManejadorProducto.ObtenerProductos();
            //foreach (var producto in listaProductos)
            //{
            //    Console.WriteLine(producto.Descripciones);
            //}

            //// OBTENER LISTA DE PRODUCTOS RECIBE ID USUARIO - OK
            //List<Producto> productos = ManejadorProducto.ObtenerProductosCargados(3);
            //foreach (var item in productos)
            //{
            //    Console.WriteLine(item.Descripciones);
            //}

            // **PRODUCTO VENDIDO**

            // OBTENER LISTA PRODUCTOS VENDIDOS POR ID USUARIO

            //List<Producto> productos = ManejadorProductoVendido.ObtenerProductosVendidos(3);
            //foreach (var item in productos)
            //{
            //    Console.WriteLine(item.Descripciones);
            //}

            // **USUARIO**

            // OBTENER USUARIO POR ID

            //Usuario usuario = ManejadorUsuario.ObtenerUsuario(1);
            //Console.WriteLine(usuario.Nombre);

            // INSERTAR UN USUARIO

            //Usuario usuarioIngresado = new Usuario();
            //usuarioIngresado.Nombre = "Pepito";
            //usuarioIngresado.Apellido = "El Sapito";
            //usuarioIngresado.NombreUsuario = "sapitoPepe";
            //usuarioIngresado.Password = "123456";
            //usuarioIngresado.Mail = "pepito@mail.com";
            //if (ManejadorUsuario.InsertarUsuario(usuarioIngresado) >= 1)
            //{
            //    Console.WriteLine("Usuario Ingresado");
            //}
            //else
            //{
            //    Console.WriteLine("No se pudo ingresar el usuario");
            //}

            // ACTUALIZAR USUARIO - OK

            //Usuario usuarioUpdate = new Usuario();
            //usuarioUpdate.Id = 1;
            //usuarioUpdate.Nombre = "Alejandro";
            //usuarioUpdate.Apellido = "Merle";
            //usuarioUpdate.NombreUsuario = "alemer";
            //usuarioUpdate.Password = "123456";
            //usuarioUpdate.Mail = "ale@mail.com";
            //if (ManejadorUsuario.UpdateUsuario(usuarioUpdate) >= 1)
            //{
            //    Console.WriteLine("Usuario Actualizado");
            //}
            //else
            //{
            //    Console.WriteLine("Usuario no fue actualizado");
            //}

            // LOGUIN USUARIO - OK

            //Console.WriteLine("Ingrese usuario: ");
            //string nombreUsuario;
            //nombreUsuario = Console.ReadLine();
            //Console.WriteLine("Ingrese contraseña: ");
            //string password;
            //password = Console.ReadLine();
            //Usuario usuario = ManejadorUsuario.Login(nombreUsuario, password);
            //Console.WriteLine(usuario.Nombre + " " + usuario.Apellido);

            // **VENTA**

            // OBTENER VENTAS RECIBE ID USUARIO - PULIR QUERY, SOLO TRAE ID VENTA

            //List<Venta> ventas = ManejadorVentas.ObtenerVentas(1);
            //foreach (var item in ventas)
            //{
            //    Console.WriteLine(item.Id);
            //}
        }
    }
}