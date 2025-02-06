using System.Windows.Forms;
using System;

namespace ProyectoMedico
{
    public partial class frmCitas : Form
    {

        public frmCitas()
        {
            InitializeComponent();
            dgvPacientes.AllowUserToAddRows = false;
            dgvDoctores.AllowUserToAddRows = false;
            dgvCitas.AllowUserToAddRows = false;
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 200;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(btnGuardar, "Click para guardar.");
            toolTip.SetToolTip(btnLimpiar, "Click para limpiar campos.");
            toolTip.SetToolTip(btnEliminar, "Click para eliminar.");
            toolTip.SetToolTip(btAtras, "Click para regresar a menú.");
            toolTip.SetToolTip(btnActualizar, "Click para actualizar.");
            toolTip.SetToolTip(btnReporte, "Click para visualizar reporte.");
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
            Application.Exit();
        }

        private bool ValidarCampos()
        {
            if (dgvPacientes.SelectedRows.Count == 0 ||
                dgvDoctores.SelectedRows.Count == 0 ||
                string.IsNullOrWhiteSpace(cmbHora.Text) ||
                cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos deben estar llenos.");
                return false;
            }
            return true;
        }

        private void frmCitas_Load(object sender, EventArgs e)
        {
            this.datosCitaTableAdapter.Fill(this.medicoDataSet.DatosCita);
            this.doctoresTableAdapter.Fill(this.medicoDataSet.Doctores);
            this.pacientesTableAdapter.Fill(this.medicoDataSet.Pacientes);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtpFecha.Value = new DateTime(2024, 12, 10);
            cmbHora.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            txtNotas.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            int pacienteID = (int)dgvPacientes.SelectedRows[0].Cells["PacienteID"].Value;
            int doctorID = (int)dgvDoctores.SelectedRows[0].Cells["DoctorID"].Value;

            Citas cita = new Citas
            {
                PacienteID = pacienteID,
                DoctorID = doctorID,
                FechaCita = dtpFecha.Value,
                HoraCita = cmbHora.SelectedItem.ToString(),
                Estado = cmbEstado.SelectedItem.ToString(),
                Notas = txtNotas.Text
            };
            
            int result = CitasDAL.AgregarCita(cita);

            if (result == -1)
            {
                MessageBox.Show("Este doctor ya tiene una cita programada en esta fecha y hora.");
            }
            else if (result > 0)
            {
                MessageBox.Show("Cita guardada correctamente.");
                RecargarDatos();
            }
            else
            {
                MessageBox.Show("Error al guardar la cita.");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count > 0)
            {
                if (!ValidarCampos()) return;

                int citaID = (int)dgvCitas.SelectedRows[0].Cells["CitaID"].Value;
                int pacienteID = (int)dgvPacientes.SelectedRows[0].Cells["PacienteID"].Value;
                int doctorID = (int)dgvDoctores.SelectedRows[0].Cells["DoctorID"].Value;

                Citas cita = new Citas
                {
                    CitaID = citaID,
                    PacienteID = pacienteID,
                    DoctorID = doctorID,
                    FechaCita = dtpFecha.Value,
                    HoraCita = cmbHora.SelectedItem.ToString(),
                    Estado = cmbEstado.SelectedItem.ToString(),
                    Notas = txtNotas.Text
                };

                int result = CitasDAL.ActualizarCita(cita);

                if (result == -1)
                {
                    MessageBox.Show("Este doctor ya tiene una cita programada en esta fecha y hora.");
                }
                else if (result > 0)
                {
                    MessageBox.Show("Cita actualizada correctamente.");
                    RecargarDatos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la cita.");
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una cita para actualizar.");
            }
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count > 0)
            {
                try
                {
                    int citaID = (int)dgvCitas.SelectedRows[0].Cells["CitaID"].Value;
                    int result = CitasDAL.EliminarCita(citaID);

                    if (result > 0)
                    {
                        MessageBox.Show("Cita eliminada correctamente.");
                        RecargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la cita. Asegúrate de que el registro existe.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la cita: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una cita para eliminar.");
            }
        }

        private void dgvCitas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCitas.CurrentRow != null)
            {
                int citaID = (int)dgvCitas.CurrentRow.Cells["CitaID"].Value;

                if (dgvPacientes.CurrentRow != null)
                {
                    int pacienteID = (int)dgvPacientes.CurrentRow.Cells["PacienteID"].Value;

                    foreach (DataGridViewRow row in dgvPacientes.Rows)
                    {
                        if ((int)row.Cells["PacienteID"].Value == pacienteID)
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }

                if (dgvDoctores.CurrentRow != null)
                {
                    int doctorID = (int)dgvDoctores.CurrentRow.Cells["DoctorID"].Value;

                    foreach (DataGridViewRow row in dgvDoctores.Rows)
                    {
                        if ((int)row.Cells["DoctorID"].Value == doctorID)
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }

                txtNotas.Text = Convert.ToString(dgvCitas.CurrentRow.Cells["Notas"].Value);
                dtpFecha.Value = Convert.ToDateTime(dgvCitas.CurrentRow.Cells["FechaCita"].Value);
                cmbHora.SelectedItem = Convert.ToString(dgvCitas.CurrentRow.Cells["HoraCita"].Value);
                cmbEstado.SelectedItem = Convert.ToString(dgvCitas.CurrentRow.Cells["Estado"].Value);
            }
        }

        private void RecargarDatos()
        {
            this.datosCitaTableAdapter.Fill(this.medicoDataSet.DatosCita);
            this.doctoresTableAdapter.Fill(this.medicoDataSet.Doctores);
            this.pacientesTableAdapter.Fill(this.medicoDataSet.Pacientes);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReporte1 reporte1 = new frmReporte1();
            if (dgvCitas.SelectedRows.Count > 0)
            {
                try
                {
                    object citaIDValue = dgvCitas.CurrentRow.Cells["CitaID"].Value;

                    if (citaIDValue != DBNull.Value)
                    {
                        short citaID = Convert.ToInt16(citaIDValue);
                        reporte1.textBox1.Text = citaID.ToString();
                    }
                    else
                    {
                        MessageBox.Show("La CitaID no tiene un valor válido.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al seleccionar la cita: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una cita para visualizar.");
            }
            reporte1.ShowDialog();
            this.Close();
        }
    }
}
