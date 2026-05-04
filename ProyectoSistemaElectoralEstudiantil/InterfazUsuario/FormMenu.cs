using ProyectoSistemaElectoralEstudiantil.Entidades;
using ProyectoSistemaElectoralEstudiantil.Datos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoSistemaElectoralEstudiantil.InterfazUsuario
{
    public partial class FormMenu : Form
    {
        private Usuario usuarioActual;

        // Constructor que recibe el usuario desde el login
        public FormMenu(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            // Mensaje de bienvenida
            lblBienvenida.Text = $"Bienvenido {usuarioActual.Nombre} ({usuarioActual.Rol})";

            // Color según rol
            lblBienvenida.ForeColor = usuarioActual.Rol == "Admin" ? Color.Red : Color.Blue;

            // Control de roles
            if (usuarioActual.Rol != "Admin")
            {
                btnUsuarios.Enabled = false;
                btnPlanchas.Enabled = false;
            }
        }

        // 🚪 Cerrar sesión
        private void btnCerrarsesion_Click(object sender, EventArgs e)
        {
            Application.Restart(); // Reinicia la app y vuelve al login
        }

        // 📋 Datos Generales
        private void btnDatos_Click(object sender, EventArgs e)
        {
            FormDatosGenerales frm = new FormDatosGenerales();
            frm.ShowDialog();
        }

        // 🪪 Planchas
        private void btnPlanchas_Click(object sender, EventArgs e)
        {
            FormPlanchas frm = new FormPlanchas();
            frm.ShowDialog();
        }

        // 👥 Usuarios
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios frm = new FormUsuarios();
            frm.ShowDialog();
        }

        // 📊 Panel de Resultados
        private void btnPanel_Click(object sender, EventArgs e)
        {
            if (usuarioActual.Rol == "Votante" && usuarioActual.VecesQueHaVotado == 0)
            {
                MessageBox.Show("Debes votar antes de poder ver los resultados.");
                return;
            }

            FormReportes frm = new FormReportes();
            frm.ShowDialog();
        }

        // 🗳️ Votaciones
        private void btnVotaciones_Click(object sender, EventArgs e)
        {
            FormVotacion frm = new FormVotacion(usuarioActual);
            frm.ShowDialog();

            // Refrescar usuario después de votar
            UsuarioDAL dal = new UsuarioDAL();
            usuarioActual = dal.ObtenerUsuarioPorId(usuarioActual.Id);
        }
    }
}


