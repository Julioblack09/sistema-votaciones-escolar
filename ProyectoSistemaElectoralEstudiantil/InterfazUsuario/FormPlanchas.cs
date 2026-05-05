using ProyectoSistemaElectoralEstudiantil.Negocio;
using System;
using System.Drawing;
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

            // Configuración del DataGridView compacto
            dgvPlanchas.ReadOnly = true;
            dgvPlanchas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlanchas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPlanchas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPlanchas.RowTemplate.Height = 22;

            dgvPlanchas.BackgroundColor = Color.White;
            dgvPlanchas.DefaultCellStyle.BackColor = Color.White;
            dgvPlanchas.DefaultCellStyle.ForeColor = Color.Black;
            dgvPlanchas.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dgvPlanchas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgvPlanchas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(21, 101, 192);
            dgvPlanchas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPlanchas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvPlanchas.EnableHeadersVisualStyles = false;

            // Estilo de labels
            lblNombre.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblNombre.ForeColor = Color.Black;
            lblDescripcion.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblDescripcion.ForeColor = Color.Black;

            // Estilo de TextBox
            txtNombre.Font = new Font("Segoe UI", 10);
            txtNombre.BackColor = Color.White;
            txtDescripcion.Font = new Font("Segoe UI", 10);
            txtDescripcion.BackColor = Color.White;

            // Estilo de botones
            btnAgregar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnAgregar.BackColor = Color.FromArgb(46, 125, 50);
            btnAgregar.ForeColor = Color.White;

            btnEditar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnEditar.BackColor = Color.FromArgb(21, 101, 192);
            btnEditar.ForeColor = Color.White;

            btnEliminar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnEliminar.BackColor = Color.FromArgb(198, 40, 40);
            btnEliminar.ForeColor = Color.White;

            btnCerrar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnCerrar.BackColor = Color.FromArgb(66, 66, 66);
            btnCerrar.ForeColor = Color.White;
        }

        private void CargarPlanchas()
        {
            PlanchaBLL bll = new PlanchaBLL();
            dgvPlanchas.DataSource = bll.ObtenerPlanchas();

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

