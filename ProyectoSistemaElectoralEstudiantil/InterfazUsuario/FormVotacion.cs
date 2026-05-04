using ProyectoSistemaElectoralEstudiantil.Datos;
using ProyectoSistemaElectoralEstudiantil.Entidades;
using ProyectoSistemaElectoralEstudiantil.Negocio;
using System;
using System.Windows.Forms;

namespace ProyectoSistemaElectoralEstudiantil.InterfazUsuario
{
    public partial class FormVotacion : Form
    {
        private Usuario usuarioActual;

        public FormVotacion(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void FormVotacion_Load(object sender, EventArgs e)
        {
            PlanchaDAL dal = new PlanchaDAL();
            dgvPlanchas.DataSource = dal.GetAll();
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (dgvPlanchas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una plancha antes de votar.");
                return;
            }

            int planchaId = Convert.ToInt32(dgvPlanchas.CurrentRow.Cells["Id"].Value);
            VotacionBLL bll = new VotacionBLL();

            try
            {
                bll.RegistrarVoto(usuarioActual.Id, planchaId);
                usuarioActual.VecesQueHaVotado++;
                MessageBox.Show("✅ ¡Voto registrado con éxito!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el voto: {ex.Message}");
            }
        }

        private void btnVotoNulo_Click(object sender, EventArgs e)
        {
            VotacionBLL bll = new VotacionBLL();

            try
            {
                bll.RegistrarVoto(usuarioActual.Id, 0, true); // voto nulo
                usuarioActual.VecesQueHaVotado++;
                MessageBox.Show("⚠️ Voto nulo registrado.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el voto: {ex.Message}");
            }
        }
    }
}

