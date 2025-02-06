using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMedico
{
    public partial class frmReporte1 : Form
    {
        public frmReporte1()
        {
            InitializeComponent();
        }

        private void frmReporte1_Load(object sender, EventArgs e)
        {
            int parametro;

            if (!int.TryParse(textBox1.Text, out parametro))
            {
                MessageBox.Show("El valor ingresado no es un número válido. Por favor ingrese un número entero.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (parametro == 0)
            {
                MessageBox.Show("El parámetro no puede ser cero. Por favor ingrese un valor válido.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.datosCita1TableAdapter.Fill(this.medicoDataSet.DatosCita1, parametro);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCitas citas = new frmCitas();
            citas.ShowDialog();
            this.Close();
        }
    }
}
