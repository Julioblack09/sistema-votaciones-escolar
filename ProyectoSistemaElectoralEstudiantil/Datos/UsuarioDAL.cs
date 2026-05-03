using ProyectoSistemaElectoralEstudiantil.Entidades;
using System.Data.SqlClient;

namespace ProyectoSistemaElectoralEstudiantil.Datos
{
    public class UsuarioDAL
    {
        ConexionDB conexion = new ConexionDB();

        public Usuario Login(string matricula, string password)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                string query = "SELECT * FROM Usuarios WHERE Matricula=@matricula AND Password=@password";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@matricula", matricula);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Usuario
                    {
                        Id = (int)reader["Id"],
                        Nombre = reader["Nombre"].ToString(),
                        Matricula = reader["Matricula"].ToString(),
                        Password = reader["Password"].ToString(),
                        Rol = reader["Rol"].ToString()
                    };
                }
            }
            return null;
        }
    }
}

