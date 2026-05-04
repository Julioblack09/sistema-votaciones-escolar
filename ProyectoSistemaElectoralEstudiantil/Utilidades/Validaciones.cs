namespace ProyectoSistemaElectoralEstudiantil.Utilidades
{
    public static class Validaciones
    {
        public static bool EsTextoValido(string texto)
        {
            return !string.IsNullOrWhiteSpace(texto);
        }

        public static bool EsNumeroValido(string numero)
        {
            return int.TryParse(numero, out _);
        }
    }
}
