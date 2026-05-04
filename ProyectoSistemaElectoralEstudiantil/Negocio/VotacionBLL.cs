using ProyectoSistemaElectoralEstudiantil.Datos;
using ProyectoSistemaElectoralEstudiantil.Entidades;
using System;

namespace ProyectoSistemaElectoralEstudiantil.Negocio
{
    public class VotacionBLL
    {
        private VotoDAL votoDAL = new VotoDAL();

        // Registrar un voto
        public void RegistrarVoto(int idUsuario, int idPlancha, bool esNulo = false)
        {
            Voto voto = new Voto
            {
                IdUsuario = idUsuario,
                IdPlancha = idPlancha,
                Fecha = DateTime.Now,
                EsNulo = esNulo
            };

            votoDAL.InsertarVoto(voto);
        }

        // Contar votos totales
        public int ContarVotos()
        {
            return votoDAL.ContarVotos();
        }

        // Contar votos nulos
        public int ContarVotosNulos()
        {
            return votoDAL.ContarVotosNulos();
        }

        // Obtener ID de la plancha ganadora
        public int ObtenerPlanchaGanadoraId()
        {
            return votoDAL.ObtenerPlanchaGanadoraId();
        }
    }
}


