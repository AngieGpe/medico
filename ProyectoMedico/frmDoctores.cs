using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoMedico
{
    public partial class frmDoctores : Form
    {
        public frmDoctores()
        {
            InitializeComponent();
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            this.txtLicencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLicencia_KeyPress);
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 200;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(btnAtras, "Click para regresar a menú.");
            toolTip.SetToolTip(btnGuardar, "Click para guardar.");
            toolTip.SetToolTip(btnLimpiar, "Click para limpiar campos.");
            toolTip.SetToolTip(btnEliminar, "Click para eliminar.");
            toolTip.SetToolTip(btnActualizar, "Click para actualizar.");
            toolTip.SetToolTip(btnBuscar, "Click para buscar.");
        }

        private void frmDoctores_Load(object sender, EventArgs e)
        {
            this.doctoresTableAdapter.Fill(this.medicoDataSet1.Doctores);
            dgvDoctores.AllowUserToAddRows = false;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtLicencia.Text) ||
                cmbEspecialidad.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos deben estar llenos.");
                return false;
            }
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text;
            DataTable doctores = DoctoresDAL.BuscarDoctorPorNombre(nombre);
            dgvDoctores.DataSource = doctores;
            if (doctores.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró ningún doctor con ese nombre.");
            }
            this.doctoresTableAdapter.Fill(this.medicoDataSet1.Doctores);
        }

        private void dgvDoctores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDoctores.CurrentRow != null)
            {
                txtNombre.Text = Convert.ToString(dgvDoctores.CurrentRow.Cells["Nombre"].Value);
                txtApellido.Text = Convert.ToString(dgvDoctores.CurrentRow.Cells["Apellido"].Value);
                cmbEspecialidad.SelectedItem = Convert.ToString(dgvDoctores.CurrentRow.Cells["Especialidad"].Value);
                txtTelefono.Text = Convert.ToString(dgvDoctores.CurrentRow.Cells["Telefono"].Value);
                txtLicencia.Text = Convert.ToString(dgvDoctores.CurrentRow.Cells["Licencia"].Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDoctores.SelectedRows.Count > 0)
            {
                try
                {
                    int doctorID = (int)dgvDoctores.SelectedRows[0].Cells[0].Value;
                    int result = DoctoresDAL.EliminarDoctor(doctorID);

                    if (result > 0)
                    {
                        MessageBox.Show("Doctor eliminado");
                        this.doctoresTableAdapter.Fill(this.medicoDataSet1.Doctores);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el doctor. Asegúrate de que el registro existe.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el doctor: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Debes elegir un registro de doctor");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            string numeroLicencia = txtLicencia.Text;

            if (DoctoresDAL.ExisteLicencia(numeroLicencia))
            {
                MessageBox.Show("El número de licencia ya está registrado. Por favor, verifica los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Doctores doctor = new Doctores
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Especialidad = cmbEspecialidad.SelectedItem.ToString(),
                Telefono = txtTelefono.Text,
                NumeroLicencia = numeroLicencia
            };

            int result = DoctoresDAL.AgregarDoctor(doctor);

            if (result > 0)
            {
                MessageBox.Show("Éxito al guardar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.doctoresTableAdapter.Fill(this.medicoDataSet1.Doctores);
            }
            else
            {
                MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvDoctores.SelectedRows.Count > 0)
            {
                if (!ValidarCampos()) return;

                int doctorID = (int)dgvDoctores.SelectedRows[0].Cells[0].Value;
                string numeroLicencia = txtLicencia.Text;

                if (DoctoresDAL.ExisteLicencia(numeroLicencia, doctorID))
                {
                    MessageBox.Show("El número de licencia ya está registrado por otro doctor. Por favor, verifica los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Doctores doctor = new Doctores
                {
                    DoctorID = doctorID,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Especialidad = cmbEspecialidad.SelectedItem.ToString(),
                    Telefono = txtTelefono.Text,
                    NumeroLicencia = numeroLicencia
                };

                int result = DoctoresDAL.ActualizarDoctor(doctor);

                if (result > 0)
                {
                    MessageBox.Show("Éxito al actualizar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.doctoresTableAdapter.Fill(this.medicoDataSet1.Doctores);
                }
                else
                {
                    MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un doctor para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtLicencia.Clear();
            cmbEspecialidad.SelectedIndex = -1;
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 || txtTelefono.Text.Length >= 10 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void txtLicencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 || txtLicencia.Text.Length >= 10 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
