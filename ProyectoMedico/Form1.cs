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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 200; 
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(btPacientes, "Click para añadir pacientes.");
            toolTip.SetToolTip(btDoctores, "Click para añadir doctores.");
            toolTip.SetToolTip(btAsignacion, "Click para gestionar cita.");
            toolTip.SetToolTip(btHistorial, "Click para gestionar historia.");
            toolTip.SetToolTip(btRecetas, "Click para gestionar receta.");
            toolTip.SetToolTip(btSalir, "Click para cerrar sesión.");
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();
        }

        private void btPacientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPacientes pacientes = new frmPacientes();
            pacientes.ShowDialog();
            this.Close();
        }

        private void btDoctores_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDoctores doctores = new frmDoctores();
            doctores.ShowDialog();
            this.Close();
        }

        private void btAsignacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCitas citas = new frmCitas();
            citas.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHistorias historias = new frmHistorias();
            historias.ShowDialog();
            this.Close();
        }

        private void btRecetas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRecetas recetas = new frmRecetas();
            recetas.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
