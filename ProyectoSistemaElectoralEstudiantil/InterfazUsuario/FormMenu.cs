using System;
using System.Windows.Forms;
using ProyectoSistemaElectoralEstudiantil.Entidades;
using System.Drawing; // Para cambiar colores del label

namespace ProyectoSistemaElectoralEstudiantil.InterfazUsuario
{
    public partial class FormMenu : Form
    {
        private Usuario usuarioActual;

        // 🔹 Constructor que recibe el usuario desde el login
        public FormMenu(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            // Mostrar bienvenida en el label
            lblBienvenida.Text = $"Bienvenido {usuarioActual.Nombre} ({usuarioActual.Rol})";

            // Opcional: cambiar color según rol
            if (usuarioActual.Rol == "Admin")
                lblBienvenida.ForeColor = Color.Red;
            else
                lblBienvenida.ForeColor = Color.Blue;

            // 🔐 Control de roles
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
            MessageBox.Show("Módulo de Datos Generales");
        }

        // 🪪 Planchas
        private void btnPlanchas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo de Planchas");
        }

        // 👥 Usuarios
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo de Usuarios");
        }

        // 📊 Panel / Resultados
        private void btnPanel_Click(object sender, EventArgs e)
        {
            FormReportes reportes = new FormReportes();
            reportes.ShowDialog();
        }

        // 🗳️ Votaciones
        private void btnVotaciones_Click(object sender, EventArgs e)
        {
            FormVotacion votacion = new FormVotacion(usuarioActual);
            votacion.ShowDialog();
        }
    }
}

