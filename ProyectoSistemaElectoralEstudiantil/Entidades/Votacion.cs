using System;

namespace ProyectoSistemaElectoralEstudiantil.Entidades
{
    public class Votacion
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdPlancha { get; set; }
        public DateTime Fecha { get; set; }
    }
}
