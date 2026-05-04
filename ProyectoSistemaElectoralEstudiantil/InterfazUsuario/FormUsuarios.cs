using System;
using System.Data;
using System.Windows.Forms;
using ProyectoSistemaElectoralEstudiantil.Datos;

namespace ProyectoSistemaElectoralEstudiantil.InterfazUsuario
{
    public partial class FormUsuarios : Form
    {
        UsuarioDAL dal = new UsuarioDAL();  // corregido: singular

        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            cmbRol.Items.Add("Admin");
            cmbRol.Items.Add("Votante");
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = dal.ObtenerUsuarios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dal.InsertarUsuario(txtNombre.Text, txtUsuario.Text, txtClave.Text, cmbRol.Text);
            CargarUsuarios();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["Id"].Value);
                dal.EditarUsuario(id, txtNombre.Text, txtUsuario.Text, txtClave.Text, cmbRol.Text);
                CargarUsuarios();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["Id"].Value);
                dal.EliminarUsuario(id);
                CargarUsuarios();
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }
    }
}

