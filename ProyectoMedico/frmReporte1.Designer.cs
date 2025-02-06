namespace ProyectoMedico
{
    partial class frmReporte1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporte1));
            this.datosCita1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicoDataSet = new ProyectoMedico.MedicoDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.datosCitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosCitaTableAdapter = new ProyectoMedico.MedicoDataSetTableAdapters.DatosCitaTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.datosCita1TableAdapter = new ProyectoMedico.MedicoDataSetTableAdapters.DatosCita1TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datosCita1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosCitaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datosCita1BindingSource
            // 
            this.datosCita1BindingSource.DataMember = "DatosCita1";
            this.datosCita1BindingSource.DataSource = this.medicoDataSet;
            // 
            // medicoDataSet
            // 
            this.medicoDataSet.DataSetName = "MedicoDataSet";
            this.medicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.datosCita1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoMedico.Reporte.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // datosCitaBindingSource
            // 
            this.datosCitaBindingSource.DataMember = "DatosCita";
            this.datosCitaBindingSource.DataSource = this.medicoDataSet;
            // 
            // datosCitaTableAdapter
            // 
            this.datosCitaTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // datosCita1TableAdapter
            // 
            this.datosCita1TableAdapter.ClearBeforeFill = true;
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
            // frmReporte1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporte1";
            this.Text = "Reporte sobre citas";
            this.Load += new System.EventHandler(this.frmReporte1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosCita1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosCitaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MedicoDataSet medicoDataSet;
        private System.Windows.Forms.BindingSource datosCitaBindingSource;
        private MedicoDataSetTableAdapters.DatosCitaTableAdapter datosCitaTableAdapter;
        private System.Windows.Forms.BindingSource datosCita1BindingSource;
        public System.Windows.Forms.TextBox textBox1;
        private MedicoDataSetTableAdapters.DatosCita1TableAdapter datosCita1TableAdapter;
        private System.Windows.Forms.Button button1;
    }
}