using ProyectoSistemaElectoralEstudiantil.Negocio;
using System;
using System.Windows.Forms;

namespace ProyectoSistemaElectoralEstudiantil.InterfazUsuario
{
    public partial class FormDatosGenerales : Form
    {
        public FormDatosGenerales()
        {
            InitializeComponent();
        }

        private void FormDatosGenerales_Load(object sender, EventArgs e)
        {
            ReportesBLL reportes = new ReportesBLL();

            int totalUsuarios = reportes.TotalUsuarios();
            int totalVotos = reportes.TotalVotos();
            int votosNulos = reportes.TotalVotosNulos();
            string planchaGanadora = reportes.ObtenerPlanchaGanadora();

            lblTotalUsuarios.Text = $"Total de usuarios: {totalUsuarios}";
            lblTotalVotos.Text = $"Total de votos: {totalVotos}";
            lblVotosNulos.Text = $"Votos nulos: {votosNulos}";

            double participacion = totalUsuarios > 0 ? (double)totalVotos / totalUsuarios * 100 : 0;
            lblParticipacion.Text = $"Participación: {participacion:F2}%";

            lblPlanchaGanadora.Text = $"Plancha ganadora: {planchaGanadora}";

            dgvParticipantes.DataSource = reportes.ObtenerParticipantes();
        }
    }
}

