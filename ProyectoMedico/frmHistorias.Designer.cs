namespace ProyectoMedico
{
    partial class frmHistorias
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorias));
            this.btnAtras = new System.Windows.Forms.Button();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.CitaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datosCitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicoDataSet = new ProyectoMedico.MedicoDataSet();
            this.datosCitaTableAdapter = new ProyectoMedico.MedicoDataSetTableAdapters.DatosCitaTableAdapter();
            this.dgvHistorias = new System.Windows.Forms.DataGridView();
            this.HistoriaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CitaIDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHistoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorIDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacienteIDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datosHistoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosHistoriaTableAdapter = new ProyectoMedico.MedicoDataSetTableAdapters.DatosHistoriaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.RichTextBox();
            this.txtTratamiento = new System.Windows.Forms.RichTextBox();
            this.txtComentarios = new System.Windows.Forms.RichTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosCitaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosHistoriaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(48, 17);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(50, 36);
            this.btnAtras.TabIndex = 0;
            this.btnAtras.Text = "🔙";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // dgvCitas
            // 
            this.dgvCitas.AllowUserToAddRows = false;
            this.dgvCitas.AllowUserToDeleteRows = false;
            this.dgvCitas.AutoGenerateColumns = false;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CitaID,
            this.fechaCitaDataGridViewTextBoxColumn,
            this.horaCitaDataGridViewTextBoxColumn,
            this.PacienteID,
            this.nombreDataGridViewTextBoxColumn,
            this.DoctorID,
            this.expr1DataGridViewTextBoxColumn});
            this.dgvCitas.DataSource = this.datosCitaBindingSource;
            this.dgvCitas.Location = new System.Drawing.Point(13, 75);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.ReadOnly = true;
            this.dgvCitas.Size = new System.Drawing.Size(553, 150);
            this.dgvCitas.TabIndex = 1;
            // 
            // CitaID
            // 
            this.CitaID.DataPropertyName = "CitaID";
            this.CitaID.HeaderText = "CitaID";
            this.CitaID.Name = "CitaID";
            this.CitaID.ReadOnly = true;
            // 
            // fechaCitaDataGridViewTextBoxColumn
            // 
            this.fechaCitaDataGridViewTextBoxColumn.DataPropertyName = "FechaCita";
            this.fechaCitaDataGridViewTextBoxColumn.HeaderText = "FechaCita";
            this.fechaCitaDataGridViewTextBoxColumn.Name = "fechaCitaDataGridViewTextBoxColumn";
            this.fechaCitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaCitaDataGridViewTextBoxColumn
            // 
            this.horaCitaDataGridViewTextBoxColumn.DataPropertyName = "HoraCita";
            this.horaCitaDataGridViewTextBoxColumn.HeaderText = "HoraCita";
            this.horaCitaDataGridViewTextBoxColumn.Name = "horaCitaDataGridViewTextBoxColumn";
            this.horaCitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PacienteID
            // 
            this.PacienteID.DataPropertyName = "PacienteID";
            this.PacienteID.HeaderText = "PacienteID";
            this.PacienteID.Name = "PacienteID";
            this.PacienteID.ReadOnly = true;
            this.PacienteID.Width = 5;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "NombrePaciente";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DoctorID
            // 
            this.DoctorID.DataPropertyName = "DoctorID";
            this.DoctorID.HeaderText = "DoctorID";
            this.DoctorID.Name = "DoctorID";
            this.DoctorID.ReadOnly = true;
            this.DoctorID.Width = 5;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "NombreDoctor";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datosCitaBindingSource
            // 
            this.datosCitaBindingSource.DataMember = "DatosCita";
            this.datosCitaBindingSource.DataSource = this.medicoDataSet;
            // 
            // medicoDataSet
            // 
            this.medicoDataSet.DataSetName = "MedicoDataSet";
            this.medicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosCitaTableAdapter
            // 
            this.datosCitaTableAdapter.ClearBeforeFill = true;
            // 
            // dgvHistorias
            // 
            this.dgvHistorias.AllowUserToAddRows = false;
            this.dgvHistorias.AllowUserToDeleteRows = false;
            this.dgvHistorias.AutoGenerateColumns = false;
            this.dgvHistorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HistoriaID,
            this.CitaIDD,
            this.fechaHistoriaDataGridViewTextBoxColumn,
            this.DoctorIDD,
            this.doctorNombreDataGridViewTextBoxColumn,
            this.PacienteIDD,
            this.pacienteNombreDataGridViewTextBoxColumn,
            this.Diagnostico,
            this.Tratamiento,
            this.Comentarios});
            this.dgvHistorias.DataSource = this.datosHistoriaBindingSource;
            this.dgvHistorias.Location = new System.Drawing.Point(13, 241);
            this.dgvHistorias.Name = "dgvHistorias";
            this.dgvHistorias.ReadOnly = true;
            this.dgvHistorias.Size = new System.Drawing.Size(763, 150);
            this.dgvHistorias.TabIndex = 2;
            this.dgvHistorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorias_CellContentClick);
            this.dgvHistorias.SelectionChanged += new System.EventHandler(this.dgvHistorias_SelectionChanged);
            // 
            // HistoriaID
            // 
            this.HistoriaID.DataPropertyName = "HistoriaID";
            this.HistoriaID.HeaderText = "HistoriaID";
            this.HistoriaID.Name = "HistoriaID";
            this.HistoriaID.ReadOnly = true;
            // 
            // CitaIDD
            // 
            this.CitaIDD.DataPropertyName = "CitaID";
            this.CitaIDD.HeaderText = "CitaID";
            this.CitaIDD.Name = "CitaIDD";
            this.CitaIDD.ReadOnly = true;
            this.CitaIDD.Width = 5;
            // 
            // fechaHistoriaDataGridViewTextBoxColumn
            // 
            this.fechaHistoriaDataGridViewTextBoxColumn.DataPropertyName = "FechaHistoria";
            this.fechaHistoriaDataGridViewTextBoxColumn.HeaderText = "FechaHistoria";
            this.fechaHistoriaDataGridViewTextBoxColumn.Name = "fechaHistoriaDataGridViewTextBoxColumn";
            this.fechaHistoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DoctorIDD
            // 
            this.DoctorIDD.DataPropertyName = "DoctorID";
            this.DoctorIDD.HeaderText = "DoctorID";
            this.DoctorIDD.Name = "DoctorIDD";
            this.DoctorIDD.ReadOnly = true;
            this.DoctorIDD.Width = 5;
            // 
            // doctorNombreDataGridViewTextBoxColumn
            // 
            this.doctorNombreDataGridViewTextBoxColumn.DataPropertyName = "DoctorNombre";
            this.doctorNombreDataGridViewTextBoxColumn.HeaderText = "DoctorNombre";
            this.doctorNombreDataGridViewTextBoxColumn.Name = "doctorNombreDataGridViewTextBoxColumn";
            this.doctorNombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PacienteIDD
            // 
            this.PacienteIDD.DataPropertyName = "PacienteID";
            this.PacienteIDD.HeaderText = "PacienteID";
            this.PacienteIDD.Name = "PacienteIDD";
            this.PacienteIDD.ReadOnly = true;
            this.PacienteIDD.Width = 5;
            // 
            // pacienteNombreDataGridViewTextBoxColumn
            // 
            this.pacienteNombreDataGridViewTextBoxColumn.DataPropertyName = "PacienteNombre";
            this.pacienteNombreDataGridViewTextBoxColumn.HeaderText = "PacienteNombre";
            this.pacienteNombreDataGridViewTextBoxColumn.Name = "pacienteNombreDataGridViewTextBoxColumn";
            this.pacienteNombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Diagnostico
            // 
            this.Diagnostico.DataPropertyName = "Diagnostico";
            this.Diagnostico.HeaderText = "Diagnostico";
            this.Diagnostico.Name = "Diagnostico";
            this.Diagnostico.ReadOnly = true;
            // 
            // Tratamiento
            // 
            this.Tratamiento.DataPropertyName = "Tratamiento";
            this.Tratamiento.HeaderText = "Tratamiento";
            this.Tratamiento.Name = "Tratamiento";
            this.Tratamiento.ReadOnly = true;
            // 
            // Comentarios
            // 
            this.Comentarios.DataPropertyName = "Comentarios";
            this.Comentarios.HeaderText = "Comentarios";
            this.Comentarios.Name = "Comentarios";
            this.Comentarios.ReadOnly = true;
            // 
            // datosHistoriaBindingSource
            // 
            this.datosHistoriaBindingSource.DataMember = "DatosHistoria";
            this.datosHistoriaBindingSource.DataSource = this.medicoDataSet;
            // 
            // datosHistoriaTableAdapter
            // 
            this.datosHistoriaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Diagnostico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tratamiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Comentarios:";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(81, 397);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(131, 47);
            this.txtDiagnostico.TabIndex = 6;
            this.txtDiagnostico.Text = "";
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.Location = new System.Drawing.Point(287, 397);
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Size = new System.Drawing.Size(131, 47);
            this.txtTratamiento.TabIndex = 7;
            this.txtTratamiento.Text = "";
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(495, 397);
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(131, 47);
            this.txtComentarios.TabIndex = 8;
            this.txtComentarios.Text = "";
            this.txtComentarios.TextChanged += new System.EventHandler(this.txtComentarios_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(81, 450);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(45, 45);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "➕";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(151, 450);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(45, 45);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "🔄";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 450);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(45, 45);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "🧹";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(221, 450);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(45, 45);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "➖";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnReporte
            // 
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(731, 450);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(45, 45);
            this.btnReporte.TabIndex = 13;
            this.btnReporte.Text = "📄";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnAtras);
            this.groupBox1.Location = new System.Drawing.Point(-36, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 64);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(365, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "Historias";
            // 
            // frmHistorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(788, 504);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.txtTratamiento);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHistorias);
            this.Controls.Add(this.dgvCitas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHistorias";
            this.Text = "Asignación de historias";
            this.Load += new System.EventHandler(this.frmHistorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosCitaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosHistoriaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridView dgvCitas;
        private MedicoDataSet medicoDataSet;
        private System.Windows.Forms.BindingSource datosCitaBindingSource;
        private MedicoDataSetTableAdapters.DatosCitaTableAdapter datosCitaTableAdapter;
        private System.Windows.Forms.DataGridView dgvHistorias;
        private System.Windows.Forms.BindingSource datosHistoriaBindingSource;
        private MedicoDataSetTableAdapters.DatosHistoriaTableAdapter datosHistoriaTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtDiagnostico;
        private System.Windows.Forms.RichTextBox txtTratamiento;
        private System.Windows.Forms.RichTextBox txtComentarios;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CitaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoriaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CitaIDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHistoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorIDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteIDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentarios;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}