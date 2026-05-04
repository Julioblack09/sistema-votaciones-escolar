using System;

namespace ProyectoSistemaElectoralEstudiantil.Entidades
{
    public class Voto
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdPlancha { get; set; }
        public int IdVotacion { get; set; }   // ✅ propiedad que faltaba
        public DateTime Fecha { get; set; }
        public bool EsNulo { get; set; }
    }
}
