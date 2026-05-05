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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVotacion));
            this.dgvPlanchas = new System.Windows.Forms.DataGridView();
            this.btnVotar = new System.Windows.Forms.Button();
            this.btnVotoNulo = new System.Windows.Forms.Button();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.btnPlanchaA = new System.Windows.Forms.Button();
            this.btnPlanchaC = new System.Windows.Forms.Button();
            this.btnPlanchaB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanchas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlanchas
            // 
            this.dgvPlanchas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanchas.ColumnHeadersHeight = 29;
            this.dgvPlanchas.Location = new System.Drawing.Point(30, 50);
            this.dgvPlanchas.Name = "dgvPlanchas";
            this.dgvPlanchas.ReadOnly = true;
            this.dgvPlanchas.RowHeadersWidth = 51;
            this.dgvPlanchas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanchas.Size = new System.Drawing.Size(500, 200);
            this.dgvPlanchas.TabIndex = 1;
            // 
            // btnVotar
            // 
            this.btnVotar.Location = new System.Drawing.Point(30, 270);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(100, 40);
            this.btnVotar.TabIndex = 2;
            this.btnVotar.Text = "Votar";
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // btnVotoNulo
            // 
            this.btnVotoNulo.Location = new System.Drawing.Point(150, 270);
            this.btnVotoNulo.Name = "btnVotoNulo";
            this.btnVotoNulo.Size = new System.Drawing.Size(100, 40);
            this.btnVotoNulo.TabIndex = 3;
            this.btnVotoNulo.Text = "Voto Nulo";
            this.btnVotoNulo.Click += new System.EventHandler(this.btnVotoNulo_Click);
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Location = new System.Drawing.Point(30, 20);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(356, 16);
            this.lblInstruccion.TabIndex = 0;
            this.lblInstruccion.Text = "Seleccione una plancha y presione Votar, o elija Voto Nulo";
            // 
            // btnPlanchaA
            // 
            this.btnPlanchaA.Location = new System.Drawing.Point(30, 356);
            this.btnPlanchaA.Name = "btnPlanchaA";
            this.btnPlanchaA.Size = new System.Drawing.Size(143, 49);
            this.btnPlanchaA.TabIndex = 4;
            this.btnPlanchaA.Text = "Plancha A";
            this.btnPlanchaA.UseVisualStyleBackColor = true;
            // 
            // btnPlanchaC
            // 
            this.btnPlanchaC.Location = new System.Drawing.Point(461, 356);
            this.btnPlanchaC.Name = "btnPlanchaC";
            this.btnPlanchaC.Size = new System.Drawing.Size(143, 49);
            this.btnPlanchaC.TabIndex = 5;
            this.btnPlanchaC.Text = "Plancha C";
            this.btnPlanchaC.UseVisualStyleBackColor = true;
            // 
            // btnPlanchaB
            // 
            this.btnPlanchaB.Location = new System.Drawing.Point(243, 356);
            this.btnPlanchaB.Name = "btnPlanchaB";
            this.btnPlanchaB.Size = new System.Drawing.Size(143, 49);
            this.btnPlanchaB.TabIndex = 6;
            this.btnPlanchaB.Text = "Plancha B";
            this.btnPlanchaB.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 445);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(243, 445);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(143, 146);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(461, 445);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 146);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // FormVotacion
            // 
            this.ClientSize = new System.Drawing.Size(745, 667);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPlanchaB);
            this.Controls.Add(this.btnPlanchaC);
            this.Controls.Add(this.btnPlanchaA);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.dgvPlanchas);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.btnVotoNulo);
            this.Name = "FormVotacion";
            this.Text = "Votación";
            this.Load += new System.EventHandler(this.FormVotacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanchas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnPlanchaA;
        private System.Windows.Forms.Button btnPlanchaC;
        private System.Windows.Forms.Button btnPlanchaB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
