namespace ProyectoSistemaElectoralEstudiantil.InterfazUsuario
{
    partial class FormDatosGenerales
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTotalUsuarios = new System.Windows.Forms.Label();
            this.lblTotalVotos = new System.Windows.Forms.Label();
            this.lblVotosNulos = new System.Windows.Forms.Label();
            this.lblParticipacion = new System.Windows.Forms.Label();
            this.lblPlanchaGanadora = new System.Windows.Forms.Label();
            this.dgvParticipantes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalUsuarios
            // 
            this.lblTotalUsuarios.AutoSize = true;
            this.lblTotalUsuarios.Location = new System.Drawing.Point(30, 20);
            this.lblTotalUsuarios.Name = "lblTotalUsuarios";
            this.lblTotalUsuarios.Size = new System.Drawing.Size(100, 20);
            this.lblTotalUsuarios.TabIndex = 0;
            this.lblTotalUsuarios.Text = "Total usuarios:";
            // 
            // lblTotalVotos
            // 
            this.lblTotalVotos.AutoSize = true;
            this.lblTotalVotos.Location = new System.Drawing.Point(30, 50);
            this.lblTotalVotos.Name = "lblTotalVotos";
            this.lblTotalVotos.Size = new System.Drawing.Size(85, 20);
            this.lblTotalVotos.TabIndex = 1;
            this.lblTotalVotos.Text = "Total votos:";
            // 
            // lblVotosNulos
            // 
            this.lblVotosNulos.AutoSize = true;
            this.lblVotosNulos.Location = new System.Drawing.Point(30, 80);
            this.lblVotosNulos.Name = "lblVotosNulos";
            this.lblVotosNulos.Size = new System.Drawing.Size(90, 20);
            this.lblVotosNulos.TabIndex = 2;
            this.lblVotosNulos.Text = "Votos nulos:";
            // 
            // lblParticipacion
            // 
            this.lblParticipacion.AutoSize = true;
            this.lblParticipacion.Location = new System.Drawing.Point(30, 110);
            this.lblParticipacion.Name = "lblParticipacion";
            this.lblParticipacion.Size = new System.Drawing.Size(95, 20);
            this.lblParticipacion.TabIndex = 3;
            this.lblParticipacion.Text = "Participación:";
            // 
            // lblPlanchaGanadora
            // 
            this.lblPlanchaGanadora.AutoSize = true;
            this.lblPlanchaGanadora.Location = new System.Drawing.Point(30, 140);
            this.lblPlanchaGanadora.Name = "lblPlanchaGanadora";
            this.lblPlanchaGanadora.Size = new System.Drawing.Size(130, 20);
            this.lblPlanchaGanadora.TabIndex = 4;
            this.lblPlanchaGanadora.Text = "Plancha ganadora:";
            // 
            // dgvParticipantes
            // 
            this.dgvParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipantes.Location = new System.Drawing.Point(30, 180);
            this.dgvParticipantes.Name = "dgvParticipantes";
            this.dgvParticipantes.RowHeadersWidth = 62;
            this.dgvParticipantes.RowTemplate.Height = 28;
            this.dgvParticipantes.Size = new System.Drawing.Size(600, 250);
            this.dgvParticipantes.TabIndex = 5;
            // 
            // FormDatosGenerales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 460);
            this.Controls.Add(this.dgvParticipantes);
            this.Controls.Add(this.lblPlanchaGanadora);
            this.Controls.Add(this.lblParticipacion);
            this.Controls.Add(this.lblVotosNulos);
            this.Controls.Add(this.lblTotalVotos);
            this.Controls.Add(this.lblTotalUsuarios);
            this.Name = "FormDatosGenerales";
            this.Text = "Datos Generales";
            this.Load += new System.EventHandler(this.FormDatosGenerales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTotalUsuarios;
        private System.Windows.Forms.Label lblTotalVotos;
        private System.Windows.Forms.Label lblVotosNulos;
        private System.Windows.Forms.Label lblParticipacion;
        private System.Windows.Forms.Label lblPlanchaGanadora;
        private System.Windows.Forms.DataGridView dgvParticipantes;
    }
}
