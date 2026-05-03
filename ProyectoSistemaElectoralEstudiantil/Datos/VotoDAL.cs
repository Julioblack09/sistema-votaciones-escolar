using System;
using System.Data.SqlClient;

namespace ProyectoSistemaElectoralEstudiantil.Datos
{
    public class VotoDAL
    {
        ConexionDB conexion = new ConexionDB();

        // ✅ Método para insertar un voto
        public void InsertarVoto(int usuarioId, int? planchaId, int votacionId)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                string query = "INSERT INTO Votos (UsuarioId, PlanchaId, VotacionId) VALUES (@usuarioId, @planchaId, @votacionId)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@usuarioId", usuarioId);
                cmd.Parameters.AddWithValue("@planchaId", (object)planchaId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@votacionId", votacionId);

                cmd.ExecuteNonQuery();
            }
        }
    }
}

