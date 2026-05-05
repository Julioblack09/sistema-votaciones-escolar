using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ProyectoSistemaElectoralEstudiantil.Datos;

namespace ProyectoSistemaElectoralEstudiantil.InterfazUsuario
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            ReportesDAL dal = new ReportesDAL();
            DataTable resultados = dal.ObtenerResultados();

            // Mostrar resultados en el DataGridView
            dgvResultados.DataSource = resultados;

            // Estilo del DataGridView en tamaño normal
            dgvResultados.BackgroundColor = Color.White;
            dgvResultados.DefaultCellStyle.BackColor = Color.White;
            dgvResultados.DefaultCellStyle.ForeColor = Color.Black;
            dgvResultados.DefaultCellStyle.Font = new Font("Segoe UI", 10); // fuente estándar

            dgvResultados.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgvResultados.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(21, 101, 192);
            dgvResultados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvResultados.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvResultados.EnableHeadersVisualStyles = false;

            // Ajustes de tamaño automático
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvResultados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvResultados.RowTemplate.Height = 22;

            // Calcular totales
            int totalVotos = 0;
            foreach (DataRow row in resultados.Rows)
            {
                totalVotos += Convert.ToInt32(row["TotalVotos"]);
            }

            // Label de totales
            lblTotales.Text = $"Total de votos emitidos: {totalVotos}";
            lblTotales.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblTotales.ForeColor = Color.Black;

            // Configurar gráfico circular
            chartResultados.Series.Clear();
            chartResultados.BackColor = Color.White;
            chartResultados.ChartAreas[0].BackColor = Color.White;
            chartResultados.Legends[0].Font = new Font("Segoe UI", 10);
            chartResultados.Legends[0].Docking = Docking.Right;

            Series serie = new Series("Resultados")
            {
                ChartType = SeriesChartType.Pie,
                ChartArea = "ChartArea1",
                Legend = "Legend1"
            };

            // Colores consistentes con las planchas
            Color[] colores = {
                Color.FromArgb(46, 125, 50),  // Verde A
                Color.FromArgb(21, 101, 192), // Azul B
                Color.FromArgb(239, 108, 0)   // Naranja C
            };

            int i = 0;
            foreach (DataRow row in resultados.Rows)
            {
                string plancha = row["Plancha"].ToString();
                int votos = Convert.ToInt32(row["TotalVotos"]);

                int index = serie.Points.AddXY(plancha, votos);
                DataPoint punto = serie.Points[index];
                punto.Color = colores[i % colores.Length];
                punto.Label = $"{plancha}: {votos} votos";
                i++;
            }

            chartResultados.Series.Add(serie);
        }
    }
}
