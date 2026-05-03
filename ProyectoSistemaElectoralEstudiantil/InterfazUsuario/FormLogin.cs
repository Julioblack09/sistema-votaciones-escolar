using System;
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
    }
}

