using ProyectoSistemaElectoralEstudiantil.Negocio;
using System;
using System.Windows.Forms;

namespace ProyectoSistemaElectoralEstudiantil.InterfazUsuario
{
    public partial class FormPlanchas : Form
    {
        public FormPlanchas()
        {
            InitializeComponent();
        }

        private void FormPlanchas_Load(object sender, EventArgs e)
        {
            CargarPlanchas();

            // Opcional: configurar el DataGridView
            dgvPlanchas.ReadOnly = true;
            dgvPlanchas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlanchas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarPlanchas()
        {
            PlanchaBLL bll = new PlanchaBLL();
            dgvPlanchas.DataSource = bll.ObtenerPlanchas();

            // Ajustar encabezados si existen las columnas
            if (dgvPlanchas.Columns["Id"] != null)
                dgvPlanchas.Columns["Id"].HeaderText = "Código";
            if (dgvPlanchas.Columns["Nombre"] != null)
                dgvPlanchas.Columns["Nombre"].HeaderText = "Nombre de la Plancha";
            if (dgvPlanchas.Columns["Descripcion"] != null)
                dgvPlanchas.Columns["Descripcion"].HeaderText = "Descripción";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre para la plancha.");
                return;
            }

            PlanchaBLL bll = new PlanchaBLL();
            bll.InsertarPlancha(txtNombre.Text, txtDescripcion.Text);

            MessageBox.Show("✅ Plancha agregada correctamente.");
            CargarPlanchas();
            LimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPlanchas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una plancha para editar.");
                return;
            }

            int id = Convert.ToInt32(dgvPlanchas.CurrentRow.Cells["Id"].Value);

            PlanchaBLL bll = new PlanchaBLL();
            bll.EditarPlancha(id, txtNombre.Text, txtDescripcion.Text);

            MessageBox.Show("✏️ Plancha editada correctamente.");
            CargarPlanchas();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPlanchas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una plancha para eliminar.");
                return;
            }

            int id = Convert.ToInt32(dgvPlanchas.CurrentRow.Cells["Id"].Value);

            PlanchaBLL bll = new PlanchaBLL();
            bll.EliminarPlancha(id);

            MessageBox.Show("🗑️ Plancha eliminada correctamente.");
            CargarPlanchas();
            LimpiarCampos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
        }
    }
}

