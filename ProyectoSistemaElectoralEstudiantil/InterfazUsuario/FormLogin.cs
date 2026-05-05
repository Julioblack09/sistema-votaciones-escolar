using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ProyectoSistemaElectoralEstudiantil.Negocio;
using ProyectoSistemaElectoralEstudiantil.Entidades;

namespace ProyectoSistemaElectoralEstudiantil.InterfazUsuario
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Ocultar caracteres de la contraseña
            txtPassword.UseSystemPasswordChar = true;

            // Aplicar estilo al botón Login
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(46, 125, 50); // Verde institucional
            btnLogin.FlatAppearance.BorderSize = 2;
            btnLogin.BackColor = Color.FromArgb(46, 125, 50);
            btnLogin.ForeColor = Color.White;

            // Bordes redondeados al botón
            RedondearBoton(btnLogin, 10);

            // Bordes personalizados al TextBox de matrícula
            PersonalizarTextBox(txtMatricula, Color.FromArgb(189, 189, 189));
            PersonalizarTextBox(txtPassword, Color.FromArgb(189, 189, 189));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatricula.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            UsuarioBLL bll = new UsuarioBLL();

            var usuario = bll.Login(
                txtMatricula.Text.Trim(),
                txtPassword.Text.Trim()
            );

            if (usuario != null)
            {
                // ✅ Pasar el usuario al menú
                FormMenu menu = new FormMenu(usuario);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
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

        // Método para personalizar bordes de TextBox
        private void PersonalizarTextBox(TextBox txt, Color bordeColor)
        {
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.BackColor = Color.White;
            txt.ForeColor = Color.Black;

            // Dibujar borde externo
            txt.Paint += (s, e) =>
            {
                using (Pen p = new Pen(bordeColor, 2))
                {
                    Rectangle rect = new Rectangle(0, 0, txt.Width - 1, txt.Height - 1);
                    e.Graphics.DrawRectangle(p, rect);
                }
            };
        }
    }
}


