using ProyectoSistemaElectoralEstudiantil.Datos;
using System.Data;

namespace ProyectoSistemaElectoralEstudiantil.Negocio
{
    public class PlanchaBLL
    {
        PlanchaDAL dal = new PlanchaDAL();

        public DataTable ObtenerPlanchas()
        {
            return dal.GetAll();
        }

        public void InsertarPlancha(string nombre, string descripcion)
        {
            dal.InsertarPlancha(nombre, descripcion);
        }

        public void EditarPlancha(int id, string nombre, string descripcion)
        {
            dal.EditarPlancha(id, nombre, descripcion);
        }

        public void EliminarPlancha(int id)
        {
            dal.EliminarPlancha(id);
        }
    }
}

