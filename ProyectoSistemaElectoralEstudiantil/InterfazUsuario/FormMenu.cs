using ProyectoSistemaElectoralEstudiantil.Entidades;
using ProyectoSistemaElectoralEstudiantil.Datos;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            // Fondo neutro
            this.BackColor = Color.FromArgb(245, 245, 245); // Gris claro

            // Mensaje de bienvenida
            lblBienvenida.Text = $"Bienvenido {usuarioActual.Nombre} ({usuarioActual.Rol})";
            lblBienvenida.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblBienvenida.ForeColor = usuarioActual.Rol == "Admin" ? Color.Red : Color.FromArgb(26, 35, 126);

            // Control de roles
            if (usuarioActual.Rol != "Admin")
            {
                btnUsuarios.Enabled = false;
                btnPlanchas.Enabled = false;
            }

            // Aplicar colores según función
            AplicarEstiloBoton(btnVotaciones, Color.FromArgb(46, 125, 50));   // Verde
            AplicarEstiloBoton(btnPanel, Color.FromArgb(21, 101, 192));       // Azul
            AplicarEstiloBoton(btnUsuarios, Color.FromArgb(239, 108, 0));     // Naranja
            AplicarEstiloBoton(btnPlanchas, Color.FromArgb(106, 27, 154));    // Morado
            AplicarEstiloBoton(btnDatos, Color.FromArgb(66, 66, 66));         // Gris
            AplicarEstiloBoton(btnCerrarsesion, Color.FromArgb(198, 40, 40)); // Rojo
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

        // Método para aplicar estilo uniforme a botones
        private void AplicarEstiloBoton(Button boton, Color colorFondo)
        {
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderColor = colorFondo;
            boton.FlatAppearance.BorderSize = 2;
            boton.BackColor = colorFondo;
            boton.ForeColor = Color.White;
            boton.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            // Bordes redondeados
            RedondearBoton(boton, 10);

            // Hover dinámico
            boton.MouseEnter += (s, e) =>
            {
                boton.BackColor = ControlPaint.Dark(colorFondo);
            };
            boton.MouseLeave += (s, e) =>
            {
                boton.BackColor = colorFondo;
            };
        }

        // Método para redondear botones
        private void RedondearBoton(Button boton, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
            path.AddArc(new Rectangle(boton.Width - radio, 0, radio, radio), 270, 90);
            path.AddArc(new Rectangle(boton.Width - radio, boton.Height - radio, radio, radio), 0, 90);
            path.AddArc(new Rectangle(0, boton.Height - radio, radio, radio), 90, 90);
            path.CloseFigure();
            boton.Region = new Region(path);
        }
    }
}

