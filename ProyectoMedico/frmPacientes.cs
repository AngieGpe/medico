using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProyectoMedico
{
    public partial class frmPacientes : Form
    {
        public frmPacientes()
        {
            InitializeComponent();
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 200;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(btnGuardar, "Click para guardar.");
            toolTip.SetToolTip(btnLimpiar, "Click para limpiar campos.");
            toolTip.SetToolTip(btnEliminar, "Click para eliminar.");
            toolTip.SetToolTip(btnAtras, "Click para regresar a menú.");
            toolTip.SetToolTip(btnActualizar, "Click para actualizar.");
            toolTip.SetToolTip(btnBuscar, "Click para buscar.");
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            this.pacientesTableAdapter.Fill(this.medicoDataSet1.Pacientes);
            dgvPacientes.AllowUserToAddRows = false;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                cmbGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos deben estar llenos.");
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            Pacientes pacientes = new Pacientes
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                FechaDeNacimiento = dtpNacimiento.Value,
                Género = cmbGenero.SelectedIndex == 0 ? 'M' : 'F',
                Teléfono = txtTelefono.Text
            };

            int result = PacientesDAL.AgregarPacientes(pacientes);

            if (result > 0)
            {
                MessageBox.Show("Éxito al guardar");
                this.pacientesTableAdapter.Fill(this.medicoDataSet1.Pacientes);
            }
            else
            {
                MessageBox.Show("Error al guardar");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                if (!ValidarCampos()) return;

                int pacienteID = (int)dgvPacientes.SelectedRows[0].Cells[0].Value;
                Pacientes pacientes = new Pacientes
                {
                    PacienteID = pacienteID,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    FechaDeNacimiento = dtpNacimiento.Value,
                    Género = cmbGenero.SelectedIndex == 0 ? 'M' : 'F',
                    Teléfono = txtTelefono.Text
                };

                int result = PacientesDAL.ActualizarPacientes(pacientes);

                if (result > 0)
                {
                    MessageBox.Show("Éxito al actualizar");
                    this.pacientesTableAdapter.Fill(this.medicoDataSet1.Pacientes);
                }
                else
                {
                    MessageBox.Show("Error al actualizar");
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un paciente para actualizar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                try
                {
                    int pacienteID = (int)dgvPacientes.SelectedRows[0].Cells[0].Value;
                    PacientesDAL pacientes = new PacientesDAL();
                    int result = pacientes.EliminarPaciente(pacienteID);

                    if (result > 0)
                    {
                        MessageBox.Show("Paciente eliminado");
                        this.pacientesTableAdapter.Fill(this.medicoDataSet1.Pacientes);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el paciente. Asegúrate de que el registro existe.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el paciente: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Debes elegir un registro de paciente");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text;

            DataTable pacientes = PacientesDAL.BuscarPacientePorNombre(nombre);

            dgvPacientes.DataSource = pacientes;

            if (pacientes.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró ningún paciente con ese nombre.");
            }
        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvPacientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow != null)
            {
                txtNombre.Text = Convert.ToString(dgvPacientes.CurrentRow.Cells["Nombre"].Value);
                txtApellido.Text = Convert.ToString(dgvPacientes.CurrentRow.Cells["Apellido"].Value);
                dtpNacimiento.Value = Convert.ToDateTime(dgvPacientes.CurrentRow.Cells["FechaDeNacimiento"].Value);
                string genero = Convert.ToString(dgvPacientes.CurrentRow.Cells["Género"].Value);
                cmbGenero.SelectedIndex = genero == "M" ? 0 : 1;

                txtTelefono.Text = Convert.ToString(dgvPacientes.CurrentRow.Cells["Teléfono"].Value);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            dtpNacimiento.Value = DateTime.Now;
            cmbGenero.SelectedIndex = -1;
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 || txtTelefono.Text.Length >= 10 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
