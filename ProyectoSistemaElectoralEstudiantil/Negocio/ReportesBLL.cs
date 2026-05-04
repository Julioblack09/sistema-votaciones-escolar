using ProyectoSistemaElectoralEstudiantil.Datos;
using ProyectoSistemaElectoralEstudiantil.Entidades;
using System;
using System.Data;

namespace ProyectoSistemaElectoralEstudiantil.Negocio
{
    public class ReportesBLL
    {
        private UsuarioDAL usuarioDAL = new UsuarioDAL();
        private VotoDAL votoDAL = new VotoDAL();
        private PlanchaDAL planchaDAL = new PlanchaDAL();

        public int TotalUsuarios()
        {
            // ✅ Usa ObtenerUsuarios() que ya existe en UsuarioDAL
            return usuarioDAL.ObtenerUsuarios().Rows.Count;
        }

        public int TotalVotos()
        {
            return votoDAL.ContarVotos();
        }

        public int TotalVotosNulos()
        {
            return votoDAL.ContarVotosNulos();
        }

        public string ObtenerPlanchaGanadora()
        {
            int idPlancha = votoDAL.ObtenerPlanchaGanadoraId();

            // ✅ Como no tienes ObtenerPorId en PlanchaDAL, usamos GetAll y buscamos
            DataTable dt = planchaDAL.GetAll();
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row["Id"]) == idPlancha)
                {
                    return row["Nombre"].ToString();
                }
            }
            return "Ninguna";
        }

        public DataTable ObtenerParticipantes()
        {
            // ✅ Usa ObtenerUsuarios() que ya existe en UsuarioDAL
            return usuarioDAL.ObtenerUsuarios();
        }
    }
}
