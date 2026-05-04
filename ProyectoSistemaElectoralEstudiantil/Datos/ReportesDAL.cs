using System;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoSistemaElectoralEstudiantil.Datos
{
    public class ReportesDAL
    {
        private ConexionDB conexion = new ConexionDB();

        // ✅ Resultados por plancha
        public DataTable ObtenerResultados()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"
                    SELECT p.Nombre AS Plancha, COUNT(v.Id) AS TotalVotos
                    FROM Votos v
                    INNER JOIN Planchas p ON v.PlanchaId = p.Id
                    WHERE v.EsNulo = 0 AND v.PlanchaId IS NOT NULL
                    GROUP BY p.Nombre
                    ORDER BY TotalVotos DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(tabla);
            }
            return tabla;
        }

        // ✅ Votos nulos
        public int ObtenerVotosNulos()
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Votos WHERE EsNulo = 1 OR PlanchaId IS NULL";
                SqlCommand cmd = new SqlCommand(query, conn);
                return (int)cmd.ExecuteScalar();
            }
        }

        // ✅ Participación
        public double ObtenerParticipacion()
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        COUNT(DISTINCT UsuarioId) * 100.0 /
                        (SELECT COUNT(*) FROM Usuarios) AS Participacion
                    FROM Votos";
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToDouble(result) : 0;
            }
        }

        // ✅ Plancha ganadora
        public string ObtenerPlanchaGanadora()
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"
                    SELECT TOP 1 p.Nombre
                    FROM Votos v
                    INNER JOIN Planchas p ON v.PlanchaId = p.Id
                    WHERE v.EsNulo = 0 AND v.PlanchaId IS NOT NULL
                    GROUP BY p.Nombre
                    ORDER BY COUNT(v.Id) DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : "Ninguna";
            }
        }
    }
}

