using ProyectoSistemaElectoralEstudiantil.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoSistemaElectoralEstudiantil.Datos
{
    public class UsuarioDAL
    {
        ConexionDB conexion = new ConexionDB();

        public Usuario Login(string matricula, string password)
        {
            Usuario usuario = null;
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT Id, Nombre, Matricula, Password, Rol, VecesQueHaVotado " +
                               "FROM Usuarios " +
                               "WHERE Matricula=@Matricula AND Password=@Password";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Matricula", matricula);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    usuario = new Usuario
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nombre = reader["Nombre"].ToString(),
                        Matricula = reader["Matricula"].ToString(),
                        Password = reader["Password"].ToString(),
                        Rol = reader["Rol"].ToString(),
                        VecesQueHaVotado = Convert.ToInt32(reader["VecesQueHaVotado"])
                    };
                }
            }
            return usuario;
        }

        public Usuario ObtenerUsuarioPorId(int id)
        {
            Usuario usuario = null;
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT Id, Nombre, Matricula, Password, Rol, VecesQueHaVotado " +
                               "FROM Usuarios WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    usuario = new Usuario
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nombre = reader["Nombre"].ToString(),
                        Matricula = reader["Matricula"].ToString(),
                        Password = reader["Password"].ToString(),
                        Rol = reader["Rol"].ToString(),
                        VecesQueHaVotado = Convert.ToInt32(reader["VecesQueHaVotado"])
                    };
                }
            }
            return usuario;
        }

        public void MarcarComoHaVotado(int id)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "UPDATE Usuarios SET VecesQueHaVotado = VecesQueHaVotado + 1 WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerUsuarios()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT Id, Nombre, Matricula, Password, Rol, VecesQueHaVotado FROM Usuarios";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public void InsertarUsuario(string nombre, string matricula, string password, string rol)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                string queryCheck = "SELECT COUNT(*) FROM Usuarios WHERE Matricula=@Matricula";
                SqlCommand cmdCheck = new SqlCommand(queryCheck, conn);
                cmdCheck.Parameters.AddWithValue("@Matricula", matricula);

                int count = (int)cmdCheck.ExecuteScalar();
                if (count > 0)
                {
                    throw new Exception("Ya existe un usuario con esa matrícula.");
                }

                string query = "INSERT INTO Usuarios (Nombre, Matricula, Password, Rol, VecesQueHaVotado) " +
                               "VALUES (@Nombre, @Matricula, @Password, @Rol, 0)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Matricula", matricula);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Rol", rol);
                cmd.ExecuteNonQuery();
            }
        }

        public void EditarUsuario(int id, string nombre, string matricula, string password, string rol)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "UPDATE Usuarios SET Nombre=@Nombre, Matricula=@Matricula, " +
                               "Password=@Password, Rol=@Rol WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Matricula", matricula);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Rol", rol);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarUsuario(int id)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                string queryVotos = "DELETE FROM Votos WHERE UsuarioId=@Id";
                SqlCommand cmdVotos = new SqlCommand(queryVotos, conn);
                cmdVotos.Parameters.AddWithValue("@Id", id);
                cmdVotos.ExecuteNonQuery();

                string queryUsuario = "DELETE FROM Usuarios WHERE Id=@Id";
                SqlCommand cmdUsuario = new SqlCommand(queryUsuario, conn);
                cmdUsuario.Parameters.AddWithValue("@Id", id);
                cmdUsuario.ExecuteNonQuery();
            }
        }
    }
}
