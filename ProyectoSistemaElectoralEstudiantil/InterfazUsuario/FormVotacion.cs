using ProyectoSistemaElectoralEstudiantil.Datos;
using ProyectoSistemaElectoralEstudiantil.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoSistemaElectoralEstudiantil.InterfazUsuario
{
    public partial class FormVotacion : Form
    {
        private Usuario usuarioActual;
        private int votacionId = 1; // Ejemplo: ID de la votación activa

        public FormVotacion(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void FormVotacion_Load(object sender, EventArgs e)
        {
            // Cargar las planchas desde la BD
            PlanchaDAL dal = new PlanchaDAL();
            List<Plancha> planchas = dal.GetAll();

            dgvPlanchas.DataSource = planchas;
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (dgvPlanchas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una plancha antes de votar.");
                return;
            }

            int planchaId = (int)dgvPlanchas.CurrentRow.Cells["Id"].Value;

            VotoDAL dal = new VotoDAL();
            try
            {
                dal.InsertarVoto(usuarioActual.Id, planchaId, votacionId);
                MessageBox.Show("¡Voto registrado con éxito!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al votar: " + ex.Message);
            }
        }

        private void btnVotoNulo_Click(object sender, EventArgs e)
        {
            VotoDAL dal = new VotoDAL();
            try
            {
                dal.InsertarVoto(usuarioActual.Id, null, votacionId);
                MessageBox.Show("¡Voto nulo registrado!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al votar: " + ex.Message);
            }
        }
    }
}
