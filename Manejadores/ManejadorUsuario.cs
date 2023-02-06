using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL_C
{
    internal class ManejadorUsuario
    {
        // Cadena de Conexión
        public static string cadenaConexion = "Data Source=DESKTOP-7QBII56\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True";

        // Obtener un usuario dado el id del usuario
        public static Usuario ObtenerUsuario(long id)
        {
            Usuario usuario = new Usuario();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Usuario WHERE Id = @id", conexion);
                comando.Parameters.AddWithValue("@id", id);
                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    usuario.Id = reader.GetInt64(0);
                    usuario.Nombre = reader.GetString(1);
                    usuario.Apellido = reader.GetString(2);
                    usuario.NombreUsuario = reader.GetString(3);
                    usuario.Password = reader.GetString(4);
                    usuario.Mail = reader.GetString(5);
                }
            }
            return usuario;
        }

        public static Usuario Login(string nombreUsuario, string password)
        {
            Usuario usuarioMatch = new Usuario();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Usuario " +
                    " WHERE NombreUsuario = @nombreUsuario and Contraseña = @password", conexion);
                comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                comando.Parameters.AddWithValue("@password", password);
                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    usuarioMatch.Id = reader.GetInt64(0);
                    usuarioMatch.Nombre = reader.GetString(1);
                    usuarioMatch.Apellido = reader.GetString(2);
                    usuarioMatch.NombreUsuario = reader.GetString(3);
                    usuarioMatch.Password = reader.GetString(4);
                    usuarioMatch.Mail = reader.GetString(5);
                    Console.WriteLine("Bienvenido !!!");
                }
                else
                {
                    Console.WriteLine("Usuario y/o Contraseña inválidos");
                }
            }
            return usuarioMatch;
        }
    }
}
