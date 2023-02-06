using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL_C
{
    internal class ManejadorProducto
    {
        // Cadena de Conexión
        public static string cadenaConexion = "Data Source=DESKTOP-7QBII56\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True";

        // Obtener un producto dado el id del producto
        public static Producto ObtenerProducto(long id)
        {
            Producto producto = new Producto();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Producto WHERE Id = @id", conexion);

                comando.Parameters.AddWithValue("@id", id);

                conexion.Open();

                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    producto.Id = reader.GetInt64(0);
                    producto.Descripciones = reader.GetString(1);
                    producto.Costo = reader.GetDecimal(2);
                    producto.PrecioVenta = reader.GetDecimal(3);
                    producto.Stock = reader.GetInt32(4);
                    producto.IdUsuario = reader.GetInt64(5);
                }
            }
            return producto;
        }
        // Traer Productos - recibe un id de usuario y devuelve lista productos cargados por ese usuario
        public static List<Producto> ObtenerProductosCargados(long idUsuario)
        {
            List<long> productoCargado = new List<long>();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand("SELECT Id FROM Producto " +
                    " WHERE IdUsuario = @idUsuario", conexion);
                comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        productoCargado.Add(reader.GetInt64(0));
                    }
                }
            }
            List<Producto> listaProductosCargados = new List<Producto>();
            foreach (var id in productoCargado)
            {
                Producto productoTempporal = ObtenerProducto(id);
                listaProductosCargados.Add(productoTempporal);
            }
            return listaProductosCargados;
        }

        // Traer Productos Vendidos - recibe id de usuario y devuelve una lista de productos vendidos por ese usuario
        public static List<Producto> ObtenerProductosVendidos(long idUsuario)
        {
            List<long> idProductos = new List<long>();
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando2 = new SqlCommand("SELECT IdProducto FROM Venta" +
                    " INNER JOIN ProductoVendido" +
                    " ON Venta.Id = ProductoVendido.IdVenta" +
                    " WHERE IdUsuario = @idUsuario", conn);
                comando2.Parameters.AddWithValue("@idUsuario", idUsuario);
                conn.Open();
                SqlDataReader reader = comando2.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        idProductos.Add(reader.GetInt64(0));
                    }
                }
            }
            List<Producto> productos = new List<Producto>();
            foreach (var id in idProductos)
            {
                Producto prodTemp = ObtenerProducto(id);
                productos.Add(prodTemp);
            }
            return productos;
        }
    }
}
