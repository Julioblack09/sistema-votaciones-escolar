using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ProyectoSistemaElectoralEstudiantil.Datos;

namespace ProyectoSistemaElectoralEstudiantil.InterfazUsuario
{
    public partial class FormUsuarios : Form
    {
        UsuarioDAL dal = new UsuarioDAL();

        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();

            // Configuración del ComboBox Rol
            cmbRol.Items.Add("Admin");
            cmbRol.Items.Add("Votante");
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Font = new Font("Segoe UI", 10);
            cmbRol.BackColor = Color.White;

            // Estilo del DataGridView compacto
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.DefaultCellStyle.BackColor = Color.White;
            dgvUsuarios.DefaultCellStyle.ForeColor = Color.Black;
            dgvUsuarios.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dgvUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(21, 101, 192);
            dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvUsuarios.EnableHeadersVisualStyles = false;

            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUsuarios.RowTemplate.Height = 22;

            // Estilo de labels
            lblNombre.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblNombre.ForeColor = Color.Black;
            lblUsuario.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblUsuario.ForeColor = Color.Black;
            lblClave.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblClave.ForeColor = Color.Black;
            lblRol.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblRol.ForeColor = Color.Black;

            // Estilo de TextBox
            txtNombre.Font = new Font("Segoe UI", 10);
            txtNombre.BackColor = Color.White;
            txtUsuario.Font = new Font("Segoe UI", 10);
            txtUsuario.BackColor = Color.White;
            txtClave.Font = new Font("Segoe UI", 10);
            txtClave.BackColor = Color.White;

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

            btnRefrescar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnRefrescar.BackColor = Color.FromArgb(66, 66, 66);
            btnRefrescar.ForeColor = Color.White;
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


