using ProyectoSistemaElectoralEstudiantil.Negocio;
using System;
using System.Drawing;
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

            // Estilo del DataGridView más compacto
            dgvParticipantes.BackgroundColor = Color.White;
            dgvParticipantes.DefaultCellStyle.BackColor = Color.White;
            dgvParticipantes.DefaultCellStyle.ForeColor = Color.Black;
            dgvParticipantes.DefaultCellStyle.Font = new Font("Segoe UI", 9); // más pequeño

            dgvParticipantes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgvParticipantes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(21, 101, 192);
            dgvParticipantes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvParticipantes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvParticipantes.EnableHeadersVisualStyles = false;

            // Ajustes de tamaño
            dgvParticipantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvParticipantes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvParticipantes.RowTemplate.Height = 22; // filas más compactas
        }

    }
}

