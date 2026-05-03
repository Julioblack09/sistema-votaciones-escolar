using ProyectoSistemaElectoralEstudiantil.Datos;
using ProyectoSistemaElectoralEstudiantil.Entidades;

namespace ProyectoSistemaElectoralEstudiantil.Negocio
{
    public class UsuarioBLL
    {
        UsuarioDAL dal = new UsuarioDAL();

        public Usuario Login(string matricula, string password)
        {
            return dal.Login(matricula, password);
        }
    }
}

