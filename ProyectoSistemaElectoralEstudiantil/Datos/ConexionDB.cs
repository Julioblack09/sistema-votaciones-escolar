using System.Data.SqlClient;

public class ConexionDB
{
    private string cadena = "Server=(localdb)\\MSSQLLocalDB;Database=SistemaVotaciones;Trusted_Connection=True;";

    public SqlConnection ObtenerConexion()
    {
        return new SqlConnection(cadena);
    }
}
