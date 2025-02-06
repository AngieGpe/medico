namespace ProyectoMedico
{
    partial class frmRecetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecetas));
            this.btAtras = new System.Windows.Forms.Button();
            this.dgvHistoria = new System.Windows.Forms.DataGridView();
            this.HistoriaIDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHistoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacienteNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacienteIDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datosHistoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicoDataSet = new ProyectoMedico.MedicoDataSet();
            this.datosHistoriaTableAdapter = new ProyectoMedico.MedicoDataSetTableAdapters.DatosHistoriaTableAdapter();
            this.dgvReceta = new System.Windows.Forms.DataGridView();
            this.HistoriaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecetaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicamentoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frecuencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datosRecetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDosis = new System.Windows.Forms.ComboBox();
            this.medicamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicoDataSet1 = new ProyectoMedico.MedicoDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFrecuencia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNotas = new System.Windows.Forms.RichTextBox();
            this.medicamentosTableAdapter = new ProyectoMedico.MedicoDataSetTableAdapters.MedicamentosTableAdapter();
            this.datosRecetaTableAdapter = new ProyectoMedico.MedicoDataSetTableAdapters.DatosRecetaTableAdapter();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.fKRecetasMedicamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recetasTableAdapter = new ProyectoMedico.MedicoDataSetTableAdapters.RecetasTableAdapter();
            this.btnReporte = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosHistoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosRecetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRecetasMedicamentosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAtras
            // 
            this.btAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtras.Location = new System.Drawing.Point(71, 17);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(50, 36);
            this.btAtras.TabIndex = 0;
            this.btAtras.Text = "🔙";
            this.btAtras.UseVisualStyleBackColor = true;
            this.btAtras.Click += new System.EventHandler(this.btAtras_Click);
            // 
            // dgvHistoria
            // 
            this.dgvHistoria.AllowUserToAddRows = false;
            this.dgvHistoria.AllowUserToDeleteRows = false;
            this.dgvHistoria.AutoGenerateColumns = false;
            this.dgvHistoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HistoriaIDD,
            this.FechaHistoria,
            this.PacienteNombre,
            this.PacienteIDD});
            this.dgvHistoria.DataSource = this.datosHistoriaBindingSource;
            this.dgvHistoria.Location = new System.Drawing.Point(12, 64);
            this.dgvHistoria.Name = "dgvHistoria";
            this.dgvHistoria.ReadOnly = true;
            this.dgvHistoria.Size = new System.Drawing.Size(445, 150);
            this.dgvHistoria.TabIndex = 1;
            // 
            // HistoriaIDD
            // 
            this.HistoriaIDD.DataPropertyName = "HistoriaID";
            this.HistoriaIDD.HeaderText = "HistoriaID";
            this.HistoriaIDD.Name = "HistoriaIDD";
            this.HistoriaIDD.ReadOnly = true;
            // 
            // FechaHistoria
            // 
            this.FechaHistoria.DataPropertyName = "FechaHistoria";
            this.FechaHistoria.HeaderText = "FechaHistoria";
            this.FechaHistoria.Name = "FechaHistoria";
            this.FechaHistoria.ReadOnly = true;
            // 
            // PacienteNombre
            // 
            this.PacienteNombre.DataPropertyName = "PacienteNombre";
            this.PacienteNombre.HeaderText = "PacienteNombre";
            this.PacienteNombre.Name = "PacienteNombre";
            this.PacienteNombre.ReadOnly = true;
            // 
            // PacienteIDD
            // 
            this.PacienteIDD.DataPropertyName = "PacienteID";
            this.PacienteIDD.HeaderText = "PacienteID";
            this.PacienteIDD.Name = "PacienteIDD";
            this.PacienteIDD.ReadOnly = true;
            // 
            // datosHistoriaBindingSource
            // 
            this.datosHistoriaBindingSource.DataMember = "DatosHistoria";
            this.datosHistoriaBindingSource.DataSource = this.medicoDataSet;
            // 
            // medicoDataSet
            // 
            this.medicoDataSet.DataSetName = "MedicoDataSet";
            this.medicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosHistoriaTableAdapter
            // 
            this.datosHistoriaTableAdapter.ClearBeforeFill = true;
            // 
            // dgvReceta
            // 
            this.dgvReceta.AllowUserToAddRows = false;
            this.dgvReceta.AllowUserToDeleteRows = false;
            this.dgvReceta.AutoGenerateColumns = false;
            this.dgvReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HistoriaID,
            this.RecetaID,
            this.PacienteID,
            this.NombrePaciente,
            this.MedicamentoID,
            this.Nombre,
            this.Stock,
            this.Dosis,
            this.Frecuencia,
            this.FechaInicio,
            this.FechaFin,
            this.Notas});
            this.dgvReceta.DataSource = this.datosRecetaBindingSource;
            this.dgvReceta.Location = new System.Drawing.Point(12, 235);
            this.dgvReceta.Name = "dgvReceta";
            this.dgvReceta.ReadOnly = true;
            this.dgvReceta.Size = new System.Drawing.Size(866, 150);
            this.dgvReceta.TabIndex = 2;
            this.dgvReceta.SelectionChanged += new System.EventHandler(this.dgvReceta_SelectionChanged);
            // 
            // HistoriaID
            // 
            this.HistoriaID.DataPropertyName = "HistoriaID";
            this.HistoriaID.HeaderText = "HistoriaID";
            this.HistoriaID.Name = "HistoriaID";
            this.HistoriaID.ReadOnly = true;
            this.HistoriaID.Width = 5;
            // 
            // RecetaID
            // 
            this.RecetaID.DataPropertyName = "RecetaID";
            this.RecetaID.HeaderText = "RecetaID";
            this.RecetaID.Name = "RecetaID";
            this.RecetaID.ReadOnly = true;
            // 
            // PacienteID
            // 
            this.PacienteID.DataPropertyName = "PacienteID";
            this.PacienteID.HeaderText = "PacienteID";
            this.PacienteID.Name = "PacienteID";
            this.PacienteID.ReadOnly = true;
            this.PacienteID.Width = 5;
            // 
            // NombrePaciente
            // 
            this.NombrePaciente.DataPropertyName = "NombrePaciente";
            this.NombrePaciente.HeaderText = "NombrePaciente";
            this.NombrePaciente.Name = "NombrePaciente";
            this.NombrePaciente.ReadOnly = true;
            // 
            // MedicamentoID
            // 
            this.MedicamentoID.DataPropertyName = "MedicamentoID";
            this.MedicamentoID.HeaderText = "MedicamentoID";
            this.MedicamentoID.Name = "MedicamentoID";
            this.MedicamentoID.ReadOnly = true;
            this.MedicamentoID.Width = 5;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 100;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 5;
            // 
            // Dosis
            // 
            this.Dosis.DataPropertyName = "Dosis";
            this.Dosis.HeaderText = "Dosis";
            this.Dosis.Name = "Dosis";
            this.Dosis.ReadOnly = true;
            // 
            // Frecuencia
            // 
            this.Frecuencia.DataPropertyName = "Frecuencia";
            this.Frecuencia.HeaderText = "Frecuencia";
            this.Frecuencia.Name = "Frecuencia";
            this.Frecuencia.ReadOnly = true;
            // 
            // FechaInicio
            // 
            this.FechaInicio.DataPropertyName = "FechaInicio";
            this.FechaInicio.HeaderText = "FechaInicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // FechaFin
            // 
            this.FechaFin.DataPropertyName = "FechaFin";
            this.FechaFin.HeaderText = "FechaFin";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            // 
            // Notas
            // 
            this.Notas.DataPropertyName = "Notas";
            this.Notas.HeaderText = "Notas";
            this.Notas.Name = "Notas";
            this.Notas.ReadOnly = true;
            // 
            // datosRecetaBindingSource
            // 
            this.datosRecetaBindingSource.DataMember = "DatosReceta";
            this.datosRecetaBindingSource.DataSource = this.medicoDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(557, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modificar medicamentos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Menú de medicamentos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dosis:";
            // 
            // cmbDosis
            // 
            this.cmbDosis.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.medicamentosBindingSource, "Stock", true));
            this.cmbDosis.FormattingEnabled = true;
            this.cmbDosis.Location = new System.Drawing.Point(81, 403);
            this.cmbDosis.Name = "cmbDosis";
            this.cmbDosis.Size = new System.Drawing.Size(121, 21);
            this.cmbDosis.TabIndex = 6;
            // 
            // medicamentosBindingSource
            // 
            this.medicamentosBindingSource.DataMember = "Medicamentos";
            this.medicamentosBindingSource.DataSource = this.medicoDataSet1;
            // 
            // medicoDataSet1
            // 
            this.medicoDataSet1.DataSetName = "MedicoDataSet";
            this.medicoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Frecuencia:";
            // 
            // cmbFrecuencia
            // 
            this.cmbFrecuencia.FormattingEnabled = true;
            this.cmbFrecuencia.Items.AddRange(new object[] {
            "Cada 6 hrs",
            "Cada 8 hrs",
            "Cada 12 hrs"});
            this.cmbFrecuencia.Location = new System.Drawing.Point(81, 435);
            this.cmbFrecuencia.Name = "cmbFrecuencia";
            this.cmbFrecuencia.Size = new System.Drawing.Size(121, 21);
            this.cmbFrecuencia.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha de Inicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha de Fin:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(322, 403);
            this.dtpFechaInicio.MaxDate = new System.DateTime(2025, 1, 31, 0, 0, 0, 0);
            this.dtpFechaInicio.MinDate = new System.DateTime(2024, 11, 22, 0, 0, 0, 0);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 11;
            this.dtpFechaInicio.Value = new System.DateTime(2024, 11, 22, 0, 0, 0, 0);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(322, 435);
            this.dtpFechaFin.MaxDate = new System.DateTime(2025, 1, 31, 0, 0, 0, 0);
            this.dtpFechaFin.MinDate = new System.DateTime(2024, 11, 22, 0, 0, 0, 0);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 12;
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechaFin_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(543, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Notas:";
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(587, 399);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(178, 56);
            this.txtNotas.TabIndex = 14;
            this.txtNotas.Text = "";
            // 
            // medicamentosTableAdapter
            // 
            this.medicamentosTableAdapter.ClearBeforeFill = true;
            // 
            // datosRecetaTableAdapter
            // 
            this.datosRecetaTableAdapter.ClearBeforeFill = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(720, 468);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(45, 45);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "🧹";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(641, 468);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(45, 45);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "➕";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(562, 468);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(45, 45);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "🔄";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(480, 468);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(45, 45);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "➖";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // fKRecetasMedicamentosBindingSource
            // 
            this.fKRecetasMedicamentosBindingSource.DataMember = "FK_Recetas_Medicamentos";
            this.fKRecetasMedicamentosBindingSource.DataSource = this.medicamentosBindingSource;
            // 
            // recetasTableAdapter
            // 
            this.recetasTableAdapter.ClearBeforeFill = true;
            // 
            // btnReporte
            // 
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(833, 468);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(45, 45);
            this.btnReporte.TabIndex = 19;
            this.btnReporte.Text = "📄";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btAtras);
            this.groupBox1.Location = new System.Drawing.Point(-59, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1045, 63);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(469, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 29);
            this.label7.TabIndex = 23;
            this.label7.Text = "Recetas";
            // 
            // frmRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(898, 525);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbFrecuencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDosis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReceta);
            this.Controls.Add(this.dgvHistoria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecetas";
            this.Text = "Gestión de recetas";
            this.Load += new System.EventHandler(this.frmRecetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosHistoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosRecetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRecetasMedicamentosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.DataGridView dgvHistoria;
        private MedicoDataSet medicoDataSet;
        private System.Windows.Forms.BindingSource datosHistoriaBindingSource;
        private MedicoDataSetTableAdapters.DatosHistoriaTableAdapter datosHistoriaTableAdapter;
        private System.Windows.Forms.DataGridView dgvReceta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDosis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFrecuencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtNotas;
        private MedicoDataSet medicoDataSet1;
        private System.Windows.Forms.BindingSource medicamentosBindingSource;
        private MedicoDataSetTableAdapters.MedicamentosTableAdapter medicamentosTableAdapter;
        private System.Windows.Forms.BindingSource datosRecetaBindingSource;
        private MedicoDataSetTableAdapters.DatosRecetaTableAdapter datosRecetaTableAdapter;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoriaIDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHistoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteIDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoriaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecetaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicamentoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frecuencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notas;
        private System.Windows.Forms.BindingSource fKRecetasMedicamentosBindingSource;
        private MedicoDataSetTableAdapters.RecetasTableAdapter recetasTableAdapter;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}