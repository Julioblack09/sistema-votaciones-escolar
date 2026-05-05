namespace ProyectoSistemaElectoralEstudiantil.InterfazUsuario
{
    partial class FormUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.Location = new System.Drawing.Point(20, 20);
            this.dgvUsuarios.Size = new System.Drawing.Size(600, 250);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(20, 290);
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 20);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 290);
            this.txtNombre.Size = new System.Drawing.Size(200, 22);
            this.txtNombre.Name = "txtNombre";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Location = new System.Drawing.Point(20, 320);
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(80, 20);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(120, 320);
            this.txtUsuario.Size = new System.Drawing.Size(200, 22);
            this.txtUsuario.Name = "txtUsuario";
            // 
            // lblClave
            // 
            this.lblClave.Location = new System.Drawing.Point(20, 350);
            this.lblClave.Text = "Clave:";
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(80, 20);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(120, 350);
            this.txtClave.Size = new System.Drawing.Size(200, 22);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            // 
            // lblRol
            // 
            this.lblRol.Location = new System.Drawing.Point(20, 380);
            this.lblRol.Text = "Rol:";
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(80, 20);
            // 
            // cmbRol
            // 
            this.cmbRol.Location = new System.Drawing.Point(120, 380);
            this.cmbRol.Size = new System.Drawing.Size(200, 22);
            this.cmbRol.Name = "cmbRol";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(20, 420);
            this.btnAgregar.Size = new System.Drawing.Size(100, 35);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.TabIndex = 1;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(130, 420);
            this.btnEditar.Size = new System.Drawing.Size(100, 35);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(240, 420);
            this.btnEliminar.Size = new System.Drawing.Size(100, 35);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.TabIndex = 3;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(350, 420);
            this.btnRefrescar.Size = new System.Drawing.Size(100, 35);
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.TabIndex = 4;
            // 
            // FormUsuarios
            // 
            this.ClientSize = new System.Drawing.Size(650, 480);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRefrescar);
            this.Name = "FormUsuarios";
            this.Text = "Gestión de Usuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRefrescar;
    }
}
