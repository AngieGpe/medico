namespace ProyectoMedico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btDoctores = new System.Windows.Forms.Button();
            this.btAsignacion = new System.Windows.Forms.Button();
            this.btHistorial = new System.Windows.Forms.Button();
            this.btRecetas = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btPacientes = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btDoctores
            // 
            this.btDoctores.BackColor = System.Drawing.Color.White;
            this.btDoctores.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoctores.Location = new System.Drawing.Point(137, 61);
            this.btDoctores.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btDoctores.Name = "btDoctores";
            this.btDoctores.Size = new System.Drawing.Size(116, 107);
            this.btDoctores.TabIndex = 1;
            this.btDoctores.Text = "🧑‍⚕️";
            this.btDoctores.UseVisualStyleBackColor = false;
            this.btDoctores.Click += new System.EventHandler(this.btDoctores_Click);
            // 
            // btAsignacion
            // 
            this.btAsignacion.BackColor = System.Drawing.Color.White;
            this.btAsignacion.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAsignacion.Location = new System.Drawing.Point(261, 61);
            this.btAsignacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btAsignacion.Name = "btAsignacion";
            this.btAsignacion.Size = new System.Drawing.Size(116, 107);
            this.btAsignacion.TabIndex = 2;
            this.btAsignacion.Text = "📅";
            this.btAsignacion.UseVisualStyleBackColor = false;
            this.btAsignacion.Click += new System.EventHandler(this.btAsignacion_Click);
            // 
            // btHistorial
            // 
            this.btHistorial.BackColor = System.Drawing.Color.White;
            this.btHistorial.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHistorial.Location = new System.Drawing.Point(385, 61);
            this.btHistorial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btHistorial.Name = "btHistorial";
            this.btHistorial.Size = new System.Drawing.Size(116, 107);
            this.btHistorial.TabIndex = 5;
            this.btHistorial.Text = "📃";
            this.btHistorial.UseVisualStyleBackColor = false;
            this.btHistorial.Click += new System.EventHandler(this.button1_Click);
            // 
            // btRecetas
            // 
            this.btRecetas.BackColor = System.Drawing.Color.White;
            this.btRecetas.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRecetas.Location = new System.Drawing.Point(509, 61);
            this.btRecetas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btRecetas.Name = "btRecetas";
            this.btRecetas.Size = new System.Drawing.Size(116, 107);
            this.btRecetas.TabIndex = 6;
            this.btRecetas.Text = "📒";
            this.btRecetas.UseVisualStyleBackColor = false;
            this.btRecetas.Click += new System.EventHandler(this.btRecetas_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.Color.White;
            this.btSalir.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(7, 12);
            this.btSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(50, 37);
            this.btSalir.TabIndex = 4;
            this.btSalir.Text = "🔙";
            this.btSalir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btSalir);
            this.groupBox1.Location = new System.Drawing.Point(-3, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 59);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Menú";
            // 
            // btPacientes
            // 
            this.btPacientes.BackColor = System.Drawing.Color.White;
            this.btPacientes.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPacientes.Location = new System.Drawing.Point(13, 61);
            this.btPacientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btPacientes.Name = "btPacientes";
            this.btPacientes.Size = new System.Drawing.Size(116, 107);
            this.btPacientes.TabIndex = 0;
            this.btPacientes.Text = "🙋‍♂️";
            this.btPacientes.UseVisualStyleBackColor = false;
            this.btPacientes.Click += new System.EventHandler(this.btPacientes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(638, 179);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btRecetas);
            this.Controls.Add(this.btHistorial);
            this.Controls.Add(this.btAsignacion);
            this.Controls.Add(this.btDoctores);
            this.Controls.Add(this.btPacientes);
            this.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Administrador de consultorio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPacientes;
        private System.Windows.Forms.Button btDoctores;
        private System.Windows.Forms.Button btAsignacion;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btHistorial;
        private System.Windows.Forms.Button btRecetas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

