using ProyectoSistemaElectoralEstudiantil.Entidades;
using System;
using System.Data.SqlClient;

namespace ProyectoSistemaElectoralEstudiantil.Datos
{
    public class VotoDAL
    {
        private ConexionDB conexion = new ConexionDB();

        // ✅ Obtener Id de la votación activa
        public int ObtenerVotacionActivaId()
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT TOP 1 Id FROM Votaciones WHERE Activa = 1";
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        // ✅ Insertar un voto
        public void InsertarVoto(Voto voto)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                // Si no se asignó IdVotacion, lo obtenemos automáticamente
                int votacionId = voto.IdVotacion > 0 ? voto.IdVotacion : ObtenerVotacionActivaId();

                string query = "INSERT INTO Votos (UsuarioId, PlanchaId, VotacionId, Fecha, EsNulo) " +
                               "VALUES (@UsuarioId, @PlanchaId, @VotacionId, @Fecha, @EsNulo)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UsuarioId", voto.IdUsuario);
                cmd.Parameters.AddWithValue("@PlanchaId", voto.IdPlancha == 0 ? (object)DBNull.Value : voto.IdPlancha);
                cmd.Parameters.AddWithValue("@VotacionId", votacionId);
                cmd.Parameters.AddWithValue("@Fecha", voto.Fecha);
                cmd.Parameters.AddWithValue("@EsNulo", voto.EsNulo);
                cmd.ExecuteNonQuery();
            }
        }

        // ✅ Contar votos totales
        public int ContarVotos()
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Votos";
                SqlCommand cmd = new SqlCommand(query, conn);
                return (int)cmd.ExecuteScalar();
            }
        }

        // ✅ Contar votos nulos
        public int ContarVotosNulos()
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Votos WHERE EsNulo = 1 OR PlanchaId IS NULL";
                SqlCommand cmd = new SqlCommand(query, conn);
                return (int)cmd.ExecuteScalar();
            }
        }

        // ✅ Obtener ID de la plancha ganadora
        public int ObtenerPlanchaGanadoraId()
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"
                    SELECT TOP 1 PlanchaId
                    FROM Votos
                    WHERE EsNulo = 0 AND PlanchaId IS NOT NULL
                    GROUP BY PlanchaId
                    ORDER BY COUNT(*) DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }
    }
}




