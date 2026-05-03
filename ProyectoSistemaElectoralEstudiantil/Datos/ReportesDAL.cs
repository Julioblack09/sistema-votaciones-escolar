using System.Data;
using System.Data.SqlClient;

namespace ProyectoSistemaElectoralEstudiantil.Datos
{
    public class ReportesDAL
    {
        ConexionDB conexion = new ConexionDB();

        public DataTable ObtenerResultados()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"
                    SELECT ISNULL(p.Nombre, 'Voto Nulo') AS Plancha,
                           COUNT(v.Id) AS TotalVotos
                    FROM Votos v
                    LEFT JOIN Planchas p ON v.PlanchaId = p.Id
                    GROUP BY p.Nombre";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }
    }
}
