namespace ProyectoSistemaElectoralEstudiantil.Entidades
{
    public class Candidato
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IdPlancha { get; set; } // Relación con la plancha
    }
}

