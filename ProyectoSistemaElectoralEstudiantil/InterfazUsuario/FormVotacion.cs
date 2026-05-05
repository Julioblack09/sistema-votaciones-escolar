using ProyectoSistemaElectoralEstudiantil.Datos;
using ProyectoSistemaElectoralEstudiantil.Entidades;
using ProyectoSistemaElectoralEstudiantil.Negocio;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProyectoSistemaElectoralEstudiantil.InterfazUsuario
{
    public partial class FormVotacion : Form
    {
        private Usuario usuarioActual;
        private int planchaSeleccionada = -1; // Id de la plancha seleccionada

        public FormVotacion(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void FormVotacion_Load(object sender, EventArgs e)
        {
            // Fondo claro
            this.BackColor = Color.FromArgb(245, 245, 245);

            // Instrucción
            lblInstruccion.Text = "Seleccione una plancha y presione Votar, o elija Voto Nulo";
            lblInstruccion.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblInstruccion.ForeColor = Color.Black;

            // Cargar datos en el DataGridView
            PlanchaDAL dal = new PlanchaDAL();
            dgvPlanchas.DataSource = dal.GetAll();

            // Estilo del DataGridView compacto
            dgvPlanchas.BackgroundColor = Color.White;
            dgvPlanchas.DefaultCellStyle.BackColor = Color.White;
            dgvPlanchas.DefaultCellStyle.ForeColor = Color.Black;
            dgvPlanchas.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dgvPlanchas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgvPlanchas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(21, 101, 192);
            dgvPlanchas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPlanchas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvPlanchas.EnableHeadersVisualStyles = false;

            dgvPlanchas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPlanchas.RowTemplate.Height = 22;

            // Estilo de botones visuales
            AplicarEstiloBoton(btnPlanchaA, Color.FromArgb(46, 125, 50));   // Verde
            AplicarEstiloBoton(btnPlanchaB, Color.FromArgb(21, 101, 192));  // Azul
            AplicarEstiloBoton(btnPlanchaC, Color.FromArgb(239, 108, 0));   // Naranja

            // Estilo de botones de acción
            AplicarEstiloBoton(btnVotar, Color.FromArgb(46, 125, 50));      // Verde
            AplicarEstiloBoton(btnVotoNulo, Color.FromArgb(66, 66, 66));    // Gris
        }

        private void btnPlanchaA_Click(object sender, EventArgs e)
        {
            planchaSeleccionada = 1;
            dgvPlanchas.ClearSelection();
            SeleccionarFilaPorId(planchaSeleccionada);
        }

        private void btnPlanchaB_Click(object sender, EventArgs e)
        {
            planchaSeleccionada = 2;
            dgvPlanchas.ClearSelection();
            SeleccionarFilaPorId(planchaSeleccionada);
        }

        private void btnPlanchaC_Click(object sender, EventArgs e)
        {
            planchaSeleccionada = 3;
            dgvPlanchas.ClearSelection();
            SeleccionarFilaPorId(planchaSeleccionada);
        }

        private void SeleccionarFilaPorId(int id)
        {
            foreach (DataGridViewRow row in dgvPlanchas.Rows)
            {
                if (Convert.ToInt32(row.Cells["Id"].Value) == id)
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            int planchaId;

            if (planchaSeleccionada > 0)
            {
                planchaId = planchaSeleccionada;
            }
            else if (dgvPlanchas.CurrentRow != null)
            {
                planchaId = Convert.ToInt32(dgvPlanchas.CurrentRow.Cells["Id"].Value);
            }
            else
            {
                MessageBox.Show("Seleccione una plancha antes de votar.");
                return;
            }

            VotacionBLL bll = new VotacionBLL();
            try
            {
                bll.RegistrarVoto(usuarioActual.Id, planchaId);
                usuarioActual.VecesQueHaVotado++;
                MessageBox.Show("✅ ¡Voto registrado con éxito!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el voto: {ex.Message}");
            }
        }

        private void btnVotoNulo_Click(object sender, EventArgs e)
        {
            VotacionBLL bll = new VotacionBLL();

            try
            {
                bll.RegistrarVoto(usuarioActual.Id, 0, true);
                usuarioActual.VecesQueHaVotado++;
                MessageBox.Show("⚠️ Voto nulo registrado.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el voto: {ex.Message}");
            }
        }

        private void AplicarEstiloBoton(Button boton, Color colorFondo)
        {
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderColor = colorFondo;
            boton.FlatAppearance.BorderSize = 2;
            boton.BackColor = colorFondo;
            boton.ForeColor = Color.White;
            boton.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            RedondearBoton(boton, 8);

            boton.MouseEnter += (s, e) =>
            {
                boton.BackColor = ControlPaint.Dark(colorFondo);
            };
            boton.MouseLeave += (s, e) =>
            {
                boton.BackColor = colorFondo;
            };
        }

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



