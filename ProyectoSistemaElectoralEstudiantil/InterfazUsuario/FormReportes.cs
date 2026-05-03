using System;
using System.Data;
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

            dgvResultados.DataSource = resultados;

            // Calcular totales
            int totalVotos = 0;
            foreach (DataRow row in resultados.Rows)
            {
                totalVotos += Convert.ToInt32(row["TotalVotos"]);
            }
            lblTotales.Text = $"Total de votos emitidos: {totalVotos}";

            // Configurar gráfico circular
            chartResultados.Series.Clear();
            Series serie = new Series("Resultados");
            serie.ChartType = SeriesChartType.Pie;
            serie.ChartArea = "ChartArea1";   // ✅ asignar área
            serie.Legend = "Legend1";         // ✅ asignar leyenda

            foreach (DataRow row in resultados.Rows)
            {
                string plancha = row["Plancha"].ToString();
                int votos = Convert.ToInt32(row["TotalVotos"]);
                serie.Points.AddXY(plancha, votos);
            }

            chartResultados.Series.Add(serie);

        }
    }
}

