namespace ProyectoMedico
{
    partial class frmCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCitas));
            this.btAtras = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.PacienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicoDataSet = new ProyectoMedico.MedicoDataSet();
            this.dgvDoctores = new System.Windows.Forms.DataGridView();
            this.DoctorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.CitaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datosCitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtNotas = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pacientesTableAdapter = new ProyectoMedico.MedicoDataSetTableAdapters.PacientesTableAdapter();
            this.tableAdapterManager = new ProyectoMedico.MedicoDataSetTableAdapters.TableAdapterManager();
            this.doctoresTableAdapter = new ProyectoMedico.MedicoDataSetTableAdapters.DoctoresTableAdapter();
            this.datosCitaTableAdapter = new ProyectoMedico.MedicoDataSetTableAdapters.DatosCitaTableAdapter();
            this.btnReporte = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosCitaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAtras
            // 
            this.btAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtras.Location = new System.Drawing.Point(6, 19);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(50, 36);
            this.btAtras.TabIndex = 0;
            this.btAtras.Text = "🔙";
            this.btAtras.UseVisualStyleBackColor = true;
            this.btAtras.Click += new System.EventHandler(this.btAtras_Click);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AutoGenerateColumns = false;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PacienteID,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn});
            this.dgvPacientes.DataSource = this.pacientesBindingSource;
            this.dgvPacientes.Location = new System.Drawing.Point(12, 80);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(343, 150);
            this.dgvPacientes.TabIndex = 1;
            // 
            // PacienteID
            // 
            this.PacienteID.DataPropertyName = "PacienteID";
            this.PacienteID.HeaderText = "PacienteID";
            this.PacienteID.Name = "PacienteID";
            this.PacienteID.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.medicoDataSet;
            // 
            // medicoDataSet
            // 
            this.medicoDataSet.DataSetName = "MedicoDataSet";
            this.medicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvDoctores
            // 
            this.dgvDoctores.AutoGenerateColumns = false;
            this.dgvDoctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DoctorID,
            this.nombreDataGridViewTextBoxColumn1,
            this.apellidoDataGridViewTextBoxColumn1,
            this.especialidadDataGridViewTextBoxColumn});
            this.dgvDoctores.DataSource = this.doctoresBindingSource;
            this.dgvDoctores.Location = new System.Drawing.Point(383, 80);
            this.dgvDoctores.Name = "dgvDoctores";
            this.dgvDoctores.Size = new System.Drawing.Size(443, 150);
            this.dgvDoctores.TabIndex = 2;
            // 
            // DoctorID
            // 
            this.DoctorID.DataPropertyName = "DoctorID";
            this.DoctorID.HeaderText = "DoctorID";
            this.DoctorID.Name = "DoctorID";
            this.DoctorID.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            // 
            // apellidoDataGridViewTextBoxColumn1
            // 
            this.apellidoDataGridViewTextBoxColumn1.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn1.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn1.Name = "apellidoDataGridViewTextBoxColumn1";
            // 
            // especialidadDataGridViewTextBoxColumn
            // 
            this.especialidadDataGridViewTextBoxColumn.DataPropertyName = "Especialidad";
            this.especialidadDataGridViewTextBoxColumn.HeaderText = "Especialidad";
            this.especialidadDataGridViewTextBoxColumn.Name = "especialidadDataGridViewTextBoxColumn";
            // 
            // doctoresBindingSource
            // 
            this.doctoresBindingSource.DataMember = "Doctores";
            this.doctoresBindingSource.DataSource = this.medicoDataSet;
            // 
            // dgvCitas
            // 
            this.dgvCitas.AutoGenerateColumns = false;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CitaID,
            this.FechaCita,
            this.HoraCita,
            this.nombreDataGridViewTextBoxColumn2,
            this.expr1DataGridViewTextBoxColumn,
            this.Estado,
            this.Notas});
            this.dgvCitas.DataSource = this.datosCitaBindingSource;
            this.dgvCitas.Location = new System.Drawing.Point(12, 251);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.Size = new System.Drawing.Size(745, 150);
            this.dgvCitas.TabIndex = 3;
            this.dgvCitas.SelectionChanged += new System.EventHandler(this.dgvCitas_SelectionChanged);
            // 
            // CitaID
            // 
            this.CitaID.DataPropertyName = "CitaID";
            this.CitaID.HeaderText = "CitaID";
            this.CitaID.Name = "CitaID";
            this.CitaID.ReadOnly = true;
            // 
            // FechaCita
            // 
            this.FechaCita.DataPropertyName = "FechaCita";
            this.FechaCita.HeaderText = "FechaCita";
            this.FechaCita.Name = "FechaCita";
            // 
            // HoraCita
            // 
            this.HoraCita.DataPropertyName = "HoraCita";
            this.HoraCita.HeaderText = "HoraCita";
            this.HoraCita.Name = "HoraCita";
            // 
            // nombreDataGridViewTextBoxColumn2
            // 
            this.nombreDataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn2.HeaderText = "NombrePaciente";
            this.nombreDataGridViewTextBoxColumn2.Name = "nombreDataGridViewTextBoxColumn2";
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "NombreDoctor";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Notas
            // 
            this.Notas.DataPropertyName = "Notas";
            this.Notas.HeaderText = "Notas";
            this.Notas.Name = "Notas";
            // 
            // datosCitaBindingSource
            // 
            this.datosCitaBindingSource.DataMember = "DatosCita";
            this.datosCitaBindingSource.DataSource = this.medicoDataSet;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(101, 440);
            this.dtpFecha.MaxDate = new System.DateTime(2025, 12, 10, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(2024, 12, 10, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 4;
            this.dtpFecha.Value = new System.DateTime(2024, 12, 10, 0, 0, 0, 0);
            // 
            // cmbHora
            // 
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "9:00AM",
            "10:00AM",
            "11:00AM",
            "12:00PM",
            "1:00PM",
            "2:00PM",
            "3:00PM",
            "4:00PM",
            "5:00PM",
            "6:00PM",
            "7:00PM",
            "8:00PM"});
            this.cmbHora.Location = new System.Drawing.Point(101, 486);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(200, 21);
            this.cmbHora.TabIndex = 5;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "1ra Cita",
            "Cita de rutina"});
            this.cmbEstado.Location = new System.Drawing.Point(461, 438);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(200, 21);
            this.cmbEstado.TabIndex = 6;
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(461, 481);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(200, 96);
            this.txtNotas.TabIndex = 7;
            this.txtNotas.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha de la cita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hora de la cita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Estado de la cita";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Notas";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(92, 532);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(45, 45);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "➕";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(177, 532);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(45, 45);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "🔄";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(15, 532);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(45, 45);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "🧹";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(256, 532);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(45, 45);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "➖";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CitasTableAdapter = null;
            this.tableAdapterManager.DoctoresTableAdapter = this.doctoresTableAdapter;
            this.tableAdapterManager.HistoriasMedicasTableAdapter = null;
            this.tableAdapterManager.MedicamentosTableAdapter = null;
            this.tableAdapterManager.PacientesTableAdapter = this.pacientesTableAdapter;
            this.tableAdapterManager.RecetasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoMedico.MedicoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // doctoresTableAdapter
            // 
            this.doctoresTableAdapter.ClearBeforeFill = true;
            // 
            // datosCitaTableAdapter
            // 
            this.datosCitaTableAdapter.ClearBeforeFill = true;
            // 
            // btnReporte
            // 
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(712, 532);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(45, 45);
            this.btnReporte.TabIndex = 16;
            this.btnReporte.Text = "📄";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btAtras);
            this.groupBox1.Location = new System.Drawing.Point(1, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 67);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(383, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 29);
            this.label7.TabIndex = 21;
            this.label7.Text = "Citas";
            // 
            // frmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(838, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.dgvCitas);
            this.Controls.Add(this.dgvDoctores);
            this.Controls.Add(this.dgvPacientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCitas";
            this.Text = "Asignación de citas";
            this.Load += new System.EventHandler(this.frmCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosCitaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.DataGridView dgvDoctores;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.RichTextBox txtNotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private MedicoDataSet medicoDataSet;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private MedicoDataSetTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private MedicoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MedicoDataSetTableAdapters.DoctoresTableAdapter doctoresTableAdapter;
        private System.Windows.Forms.BindingSource doctoresBindingSource;
        private System.Windows.Forms.BindingSource datosCitaBindingSource;
        private MedicoDataSetTableAdapters.DatosCitaTableAdapter datosCitaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn CitaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notas;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}