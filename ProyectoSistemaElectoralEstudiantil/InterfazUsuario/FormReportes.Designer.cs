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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.lblTotales = new System.Windows.Forms.Label();
            this.chartResultados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblResultadosdelaVotación = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResultados
            // 
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultados.ColumnHeadersHeight = 29;
            this.dgvResultados.Location = new System.Drawing.Point(27, 62);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersWidth = 51;
            this.dgvResultados.Size = new System.Drawing.Size(381, 204);
            this.dgvResultados.TabIndex = 0;
            // 
            // lblTotales
            // 
            this.lblTotales.Location = new System.Drawing.Point(25, 278);
            this.lblTotales.Name = "lblTotales";
            this.lblTotales.Size = new System.Drawing.Size(400, 30);
            this.lblTotales.TabIndex = 1;
            this.lblTotales.Text = "Totales:";
            // 
            // chartResultados
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResultados.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartResultados.Legends.Add(legend1);
            this.chartResultados.Location = new System.Drawing.Point(431, 62);
            this.chartResultados.Name = "chartResultados";
            this.chartResultados.Size = new System.Drawing.Size(498, 246);
            this.chartResultados.TabIndex = 2;
            this.chartResultados.Text = "Resultados";
            // 
            // lblResultadosdelaVotación
            // 
            this.lblResultadosdelaVotación.AutoSize = true;
            this.lblResultadosdelaVotación.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadosdelaVotación.Location = new System.Drawing.Point(27, 24);
            this.lblResultadosdelaVotación.Name = "lblResultadosdelaVotación";
            this.lblResultadosdelaVotación.Size = new System.Drawing.Size(188, 20);
            this.lblResultadosdelaVotación.TabIndex = 3;
            this.lblResultadosdelaVotación.Text = "Resultados de la Votación";
            // 
            // FormReportes
            // 
            this.ClientSize = new System.Drawing.Size(970, 449);
            this.Controls.Add(this.lblResultadosdelaVotación);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.lblTotales);
            this.Controls.Add(this.chartResultados);
            this.Name = "FormReportes";
            this.Text = "Panel de Resultados";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblResultadosdelaVotación;
    }
}

