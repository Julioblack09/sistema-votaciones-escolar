namespace ProyectoSistemaElectoralEstudiantil.InterfazUsuario
{
    partial class FormVotacion
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPlanchas;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.Button btnVotoNulo;
        private System.Windows.Forms.Label lblInstruccion;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvPlanchas = new System.Windows.Forms.DataGridView();
            this.btnVotar = new System.Windows.Forms.Button();
            this.btnVotoNulo = new System.Windows.Forms.Button();
            this.lblInstruccion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanchas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Location = new System.Drawing.Point(30, 20);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(350, 16);
            this.lblInstruccion.Text = "Seleccione una plancha y presione Votar, o elija Voto Nulo";
            // 
            // dgvPlanchas
            // 
            this.dgvPlanchas.Location = new System.Drawing.Point(30, 50);
            this.dgvPlanchas.Size = new System.Drawing.Size(500, 200);
            this.dgvPlanchas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanchas.ReadOnly = true;
            this.dgvPlanchas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnVotar
            // 
            this.btnVotar.Location = new System.Drawing.Point(30, 270);
            this.btnVotar.Size = new System.Drawing.Size(100, 40);
            this.btnVotar.Text = "Votar";
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // btnVotoNulo
            // 
            this.btnVotoNulo.Location = new System.Drawing.Point(150, 270);
            this.btnVotoNulo.Size = new System.Drawing.Size(100, 40);
            this.btnVotoNulo.Text = "Voto Nulo";
            this.btnVotoNulo.Click += new System.EventHandler(this.btnVotoNulo_Click);
            // 
            // FormVotacion
            // 
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.dgvPlanchas);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.btnVotoNulo);
            this.Text = "Votación";
            this.Load += new System.EventHandler(this.FormVotacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanchas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
