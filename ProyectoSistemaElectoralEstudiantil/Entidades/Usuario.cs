namespace ProyectoSistemaElectoralEstudiantil.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
        public int VecesQueHaVotado { get; set; }
    }
}

