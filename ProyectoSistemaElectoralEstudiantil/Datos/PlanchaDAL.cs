using System.Collections.Generic;
using System.Data.SqlClient;
using ProyectoSistemaElectoralEstudiantil.Entidades;

namespace ProyectoSistemaElectoralEstudiantil.Datos
{
    public class PlanchaDAL
    {
        ConexionDB conexion = new ConexionDB();

        public List<Plancha> GetAll()
        {
            List<Plancha> lista = new List<Plancha>();

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT * FROM Planchas";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Plancha
                    {
                        Id = (int)reader["Id"],
                        Nombre = reader["Nombre"].ToString(),
                        Logo = reader["Logo"].ToString(),
                        Descripcion = reader["Descripcion"].ToString()
                    });
                }
            }
            return lista;
        }
    }
}
