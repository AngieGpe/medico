using System;
using System.Windows.Forms;

namespace ProyectoMedico
{
    public partial class frmHistorias : Form
    {
        public frmHistorias()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 200;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(btnAtras, "Click para retroceder a menú.");
            toolTip.SetToolTip(btnGuardar, "Click para guardar.");
            toolTip.SetToolTip(btnLimpiar, "Click para limpiar campos.");
            toolTip.SetToolTip(btnEliminar, "Click para eliminar.");
            toolTip.SetToolTip(btnReporte, "Click para visualizar reporte.");
            toolTip.SetToolTip(btnActualizar, "Click para actualizar.");
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
            Application.Exit();
        }

        private void frmHistorias_Load(object sender, EventArgs e)
        {
            this.datosHistoriaTableAdapter.Fill(this.medicoDataSet.DatosHistoria);
            this.datosCitaTableAdapter.Fill(this.medicoDataSet.DatosCita);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una cita para guardar la historia médica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int citaID, pacienteID, doctorID;

            try
            {
                citaID = Convert.ToInt32(dgvCitas.SelectedRows[0].Cells["CitaID"].Value);
                pacienteID = Convert.ToInt32(dgvCitas.SelectedRows[0].Cells["PacienteID"].Value);
                doctorID = Convert.ToInt32(dgvCitas.SelectedRows[0].Cells["DoctorID"].Value);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Asegúrese de que los valores seleccionados tienen el formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (HistoriasMedicasDAL.ExisteCita(citaID))
            {
                MessageBox.Show("Esta cita ya ha sido registrada en el sistema, solo puede actualizarla.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var historia = new Historias
            {
                CitaID = citaID,
                PacienteID = pacienteID,
                DoctorID = doctorID,
                Diagnostico = txtDiagnostico.Text,
                Tratamiento = txtTratamiento.Text,
                FechaHistoria = DateTime.Now,
                Comentarios = txtComentarios.Text
            };

            try
            {
                int result = HistoriasMedicasDAL.GuardarHistoriaMedica(historia);
                if (result > 0)
                {
                    MessageBox.Show("Historia médica guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    RecargarDatos();
                }
                else
                {
                    MessageBox.Show("Hubo un error al guardar la historia médica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvHistorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una historia para actualizarla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int historiaID, citaID, pacienteID, doctorID;

            try
            {
                historiaID = Convert.ToInt32(dgvHistorias.SelectedRows[0].Cells["HistoriaID"].Value);
                citaID = Convert.ToInt32(dgvHistorias.SelectedRows[0].Cells["CitaIDD"].Value);
                pacienteID = Convert.ToInt32(dgvHistorias.SelectedRows[0].Cells["PacienteIDD"].Value);
                doctorID = Convert.ToInt32(dgvHistorias.SelectedRows[0].Cells["DoctorIDD"].Value);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Asegúrese de que los valores seleccionados tienen el formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var historia = new Historias
            {
                HistoriaID = historiaID,
                CitaID = citaID,
                PacienteID = pacienteID,
                DoctorID = doctorID,
                Diagnostico = txtDiagnostico.Text,
                Tratamiento = txtTratamiento.Text,
                FechaHistoria = DateTime.Now,
                Comentarios = txtComentarios.Text
            };

            try
            {
                int result = HistoriasMedicasDAL.ActualizarHistoriaMedica(historia);
                if (result > 0)
                {
                    MessageBox.Show("Historia médica actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    RecargarDatos();
                }
                else
                {
                    MessageBox.Show("Hubo un error al actualizar la historia médica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void RecargarDatos()
        {
            int parametro = Convert.ToInt16(CitaID.ToString());
            this.datosCitaTableAdapter.Fill(this.medicoDataSet.DatosCita);
            this.datosHistoriaTableAdapter.Fill(this.medicoDataSet.DatosHistoria);
        }


        private void btnLimpiar_Click (object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtDiagnostico.Clear();
            txtTratamiento.Clear();
            txtComentarios.Clear();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count > 0 && dgvHistorias.SelectedRows.Count > 0)
            {
                MessageBox.Show("Debe seleccionar solo una fila en una tabla (Historias), no ambas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvHistorias.SelectedRows.Count > 0)
            {
                int historiaID = (int)dgvHistorias.SelectedRows[0].Cells["HistoriaID"].Value;

                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar esta historia médica?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        int result = HistoriasMedicasDAL.EliminarHistoria(historiaID);
                        if (result > 0)
                        {
                            MessageBox.Show("Historia médica eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RecargarDatos();
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error al eliminar la historia médica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHistorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHistorias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHistorias.CurrentRow != null)
            {
                txtDiagnostico.Text = Convert.ToString(dgvHistorias.CurrentRow.Cells["Diagnostico"].Value);
                txtTratamiento.Text = Convert.ToString(dgvHistorias.CurrentRow.Cells["Tratamiento"].Value);
                txtComentarios.Text = Convert.ToString(dgvHistorias.CurrentRow.Cells["Comentarios"].Value);
            }
            else
            {
                txtDiagnostico.Clear();
                txtTratamiento.Clear();
                txtComentarios.Clear();
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReporte2 reporte2 = new frmReporte2();
            if (dgvHistorias.SelectedRows.Count > 0)
            {
                try
                {
                    object historiaIDValue = (int)dgvHistorias.SelectedRows[0].Cells["HistoriaID"].Value;

                    if (historiaIDValue != DBNull.Value)
                    {
                        short citaID = Convert.ToInt16(historiaIDValue);
                        reporte2.textBox1.Text = citaID.ToString();
                    }
                    else
                    {
                        MessageBox.Show("La HistoriaID no tiene un valor válido.");
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
            reporte2.ShowDialog();
            this.Close();
        }

        private void txtComentarios_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
