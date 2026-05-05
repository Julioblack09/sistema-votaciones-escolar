namespace ProyectoSistemaElectoralEstudiantil.InterfazUsuario
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.btnVotaciones = new System.Windows.Forms.Button();
            this.btnPanel = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnPlanchas = new System.Windows.Forms.Button();
            this.btnDatos = new System.Windows.Forms.Button();
            this.btnCerrarsesion = new System.Windows.Forms.Button();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVotaciones
            // 
            this.btnVotaciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVotaciones.Location = new System.Drawing.Point(69, 143);
            this.btnVotaciones.Name = "btnVotaciones";
            this.btnVotaciones.Size = new System.Drawing.Size(148, 95);
            this.btnVotaciones.TabIndex = 0;
            this.btnVotaciones.Text = "Votaciones";
            this.btnVotaciones.UseVisualStyleBackColor = true;
            this.btnVotaciones.Click += new System.EventHandler(this.btnVotaciones_Click);
            // 
            // btnPanel
            // 
            this.btnPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanel.Location = new System.Drawing.Point(264, 143);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(148, 95);
            this.btnPanel.TabIndex = 1;
            this.btnPanel.Text = "Panel de Resultados";
            this.btnPanel.UseVisualStyleBackColor = true;
            this.btnPanel.Click += new System.EventHandler(this.btnPanel_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(457, 143);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(148, 95);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnPlanchas
            // 
            this.btnPlanchas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanchas.Location = new System.Drawing.Point(69, 283);
            this.btnPlanchas.Name = "btnPlanchas";
            this.btnPlanchas.Size = new System.Drawing.Size(148, 95);
            this.btnPlanchas.TabIndex = 3;
            this.btnPlanchas.Text = "Planchas Electorales";
            this.btnPlanchas.UseVisualStyleBackColor = true;
            this.btnPlanchas.Click += new System.EventHandler(this.btnPlanchas_Click);
            // 
            // btnDatos
            // 
            this.btnDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatos.Location = new System.Drawing.Point(264, 283);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(148, 95);
            this.btnDatos.TabIndex = 4;
            this.btnDatos.Text = "Datos Generales";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // btnCerrarsesion
            // 
            this.btnCerrarsesion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarsesion.Location = new System.Drawing.Point(457, 283);
            this.btnCerrarsesion.Name = "btnCerrarsesion";
            this.btnCerrarsesion.Size = new System.Drawing.Size(148, 95);
            this.btnCerrarsesion.TabIndex = 5;
            this.btnCerrarsesion.Text = "Cerrar sesión";
            this.btnCerrarsesion.UseVisualStyleBackColor = true;
            this.btnCerrarsesion.Click += new System.EventHandler(this.btnCerrarsesion_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(65, 30);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(0, 23);
            this.lblBienvenida.TabIndex = 6;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 474);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.btnCerrarsesion);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.btnPlanchas);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.btnVotaciones);
            this.Name = "FormMenu";
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVotaciones;
        private System.Windows.Forms.Button btnPanel;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnPlanchas;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.Button btnCerrarsesion;
        private System.Windows.Forms.Label lblBienvenida;
    }
}
