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
    public partial class frmReporte3 : Form
    {
        public frmReporte3()
        {
            InitializeComponent();
        }

        private void frmReporte3_Load(object sender, EventArgs e)
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

            this.datosReceta1TableAdapter.Fill(this.medicoDataSet.DatosReceta1, parametro);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRecetas recetas = new frmRecetas();
            recetas.ShowDialog();
            this.Close();
        }
    }
}
