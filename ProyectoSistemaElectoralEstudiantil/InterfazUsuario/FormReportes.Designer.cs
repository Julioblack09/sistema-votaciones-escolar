using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoSistemaElectoralEstudiantil.InterfazUsuario
{
    partial class FormReportes
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Label lblTotales;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResultados;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.lblTotales = new System.Windows.Forms.Label();
            this.chartResultados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResultados
            // 
            this.dgvResultados.Location = new System.Drawing.Point(30, 30);
            this.dgvResultados.Size = new System.Drawing.Size(400, 200);
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultados.ReadOnly = true;
            // 
            // lblTotales
            // 
            this.lblTotales.Location = new System.Drawing.Point(30, 240);
            this.lblTotales.Size = new System.Drawing.Size(400, 30);
            this.lblTotales.Text = "Totales:";
            // 
            // chartResultados
            // 
            this.chartResultados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();

            chartArea1.Name = "ChartArea1";
            legend1.Name = "Legend1";

            this.chartResultados.ChartAreas.Add(chartArea1);
            this.chartResultados.Legends.Add(legend1);

            this.chartResultados.Location = new System.Drawing.Point(450, 30);
            this.chartResultados.Size = new System.Drawing.Size(300, 240);
            this.chartResultados.TabIndex = 2;
            this.chartResultados.Text = "Resultados";
            // 
            // FormReportes
            // 
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.lblTotales);
            this.Controls.Add(this.chartResultados);
            this.Text = "Panel de Resultados";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResultados)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
