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
            this.dgvParticipantes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPlanchaGanadora = new System.Windows.Forms.Label();
            this.lblParticipacion = new System.Windows.Forms.Label();
            this.lblVotosNulos = new System.Windows.Forms.Label();
            this.lblTotalVotos = new System.Windows.Forms.Label();
            this.lblTotalUsuarios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvParticipantes
            // 
            this.dgvParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipantes.Location = new System.Drawing.Point(16, 260);
            this.dgvParticipantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvParticipantes.Name = "dgvParticipantes";
            this.dgvParticipantes.RowHeadersWidth = 62;
            this.dgvParticipantes.RowTemplate.Height = 28;
            this.dgvParticipantes.Size = new System.Drawing.Size(533, 200);
            this.dgvParticipantes.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Datos Generales del Proceso Electoral";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPlanchaGanadora);
            this.groupBox1.Controls.Add(this.lblParticipacion);
            this.groupBox1.Controls.Add(this.lblVotosNulos);
            this.groupBox1.Controls.Add(this.lblTotalVotos);
            this.groupBox1.Controls.Add(this.lblTotalUsuarios);
            this.groupBox1.Location = new System.Drawing.Point(16, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 160);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lblPlanchaGanadora
            // 
            this.lblPlanchaGanadora.AutoSize = true;
            this.lblPlanchaGanadora.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanchaGanadora.Location = new System.Drawing.Point(14, 115);
            this.lblPlanchaGanadora.Name = "lblPlanchaGanadora";
            this.lblPlanchaGanadora.Size = new System.Drawing.Size(120, 17);
            this.lblPlanchaGanadora.TabIndex = 9;
            this.lblPlanchaGanadora.Text = "Plancha ganadora:";
            // 
            // lblParticipacion
            // 
            this.lblParticipacion.AutoSize = true;
            this.lblParticipacion.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipacion.Location = new System.Drawing.Point(14, 91);
            this.lblParticipacion.Name = "lblParticipacion";
            this.lblParticipacion.Size = new System.Drawing.Size(88, 17);
            this.lblParticipacion.TabIndex = 8;
            this.lblParticipacion.Text = "Participación:";
            // 
            // lblVotosNulos
            // 
            this.lblVotosNulos.AutoSize = true;
            this.lblVotosNulos.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVotosNulos.Location = new System.Drawing.Point(14, 67);
            this.lblVotosNulos.Name = "lblVotosNulos";
            this.lblVotosNulos.Size = new System.Drawing.Size(82, 17);
            this.lblVotosNulos.TabIndex = 7;
            this.lblVotosNulos.Text = "Votos nulos:";
            // 
            // lblTotalVotos
            // 
            this.lblTotalVotos.AutoSize = true;
            this.lblTotalVotos.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVotos.Location = new System.Drawing.Point(14, 43);
            this.lblTotalVotos.Name = "lblTotalVotos";
            this.lblTotalVotos.Size = new System.Drawing.Size(78, 17);
            this.lblTotalVotos.TabIndex = 6;
            this.lblTotalVotos.Text = "Total votos:";
            // 
            // lblTotalUsuarios
            // 
            this.lblTotalUsuarios.AutoSize = true;
            this.lblTotalUsuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsuarios.Location = new System.Drawing.Point(14, 19);
            this.lblTotalUsuarios.Name = "lblTotalUsuarios";
            this.lblTotalUsuarios.Size = new System.Drawing.Size(95, 17);
            this.lblTotalUsuarios.TabIndex = 5;
            this.lblTotalUsuarios.Text = "Total usuarios:";
            // 
            // FormDatosGenerales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 494);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvParticipantes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDatosGenerales";
            this.Text = "Datos Generales";
            this.Load += new System.EventHandler(this.FormDatosGenerales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvParticipantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPlanchaGanadora;
        private System.Windows.Forms.Label lblParticipacion;
        private System.Windows.Forms.Label lblVotosNulos;
        private System.Windows.Forms.Label lblTotalVotos;
        private System.Windows.Forms.Label lblTotalUsuarios;
    }
}
