namespace ProyectoMedico
{
    partial class frmReporte2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporte2));
            this.datosHistoria1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicoDataSet = new ProyectoMedico.MedicoDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.datosHistoria1TableAdapter = new ProyectoMedico.MedicoDataSetTableAdapters.DatosHistoria1TableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datosHistoria1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // datosHistoria1BindingSource
            // 
            this.datosHistoria1BindingSource.DataMember = "DatosHistoria1";
            this.datosHistoria1BindingSource.DataSource = this.medicoDataSet;
            // 
            // medicoDataSet
            // 
            this.medicoDataSet.DataSetName = "MedicoDataSet";
            this.medicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.datosHistoria1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoMedico.Reporte2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // datosHistoria1TableAdapter
            // 
            this.datosHistoria1TableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmReporte2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporte2";
            this.Text = "Reporte sobre historia médica";
            this.Load += new System.EventHandler(this.frmReporte2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosHistoria1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource datosHistoria1BindingSource;
        private MedicoDataSet medicoDataSet;
        private MedicoDataSetTableAdapters.DatosHistoria1TableAdapter datosHistoria1TableAdapter;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1;
    }
}