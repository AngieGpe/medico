using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoMedico
{
    public partial class frmRecetas : Form
    {
        public frmRecetas()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 200;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(btAtras, "Click para retroceder a menú.");
            toolTip.SetToolTip(btnGuardar, "Click para guardar.");
            toolTip.SetToolTip(btnLimpiar, "Click para limpiar campos.");
            toolTip.SetToolTip(btnEliminar, "Click para eliminar.");
            toolTip.SetToolTip(btnReporte, "Click para visualizar reporte.");
            toolTip.SetToolTip(btnActualizar, "Click para actualizar.");
        }

        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-3NT553Q\\SQLEXPRESS;Initial Catalog=Medico;Integrated Security=True;Encrypt=False");

        private void btAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMedicamentos medicamentos = new frmMedicamentos();
            medicamentos.ShowDialog();
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void frmRecetas_Load(object sender, EventArgs e)
        {
            this.datosRecetaTableAdapter.Fill(this.medicoDataSet.DatosReceta);
            this.datosHistoriaTableAdapter.Fill(this.medicoDataSet.DatosHistoria);
            cmbFrecuencia.SelectedIndex = 0;
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now.AddDays(1);

            try
            {
                conexion.Open();
                string consulta = "select * from Medicamentos";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                var medicamentosList = new List<KeyValuePair<int, string>>();

                while (lector.Read())
                {
                    medicamentosList.Add(new KeyValuePair<int, string>(
                        lector.GetInt32(0),
                        lector.GetString(1)
                    ));
                }

                if (medicamentosList.Count > 0)
                {
                    cmbDosis.DataSource = medicamentosList;
                    cmbDosis.DisplayMember = "Value";
                    cmbDosis.ValueMember = "Key";
                    cmbDosis.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No se encontraron medicamentos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar medicamentos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void dgvReceta_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReceta.SelectedRows.Count > 0)
            {
                try
                {
                    int recetaID = (int)dgvReceta.CurrentRow.Cells["RecetaID"].Value;

                    if (dgvHistoria.CurrentRow != null)
                    {
                        int historiaID = (int)dgvHistoria.CurrentRow.Cells["HistoriaIDD"].Value;

                        foreach (DataGridViewRow row in dgvHistoria.Rows)
                        {
                            if ((int)row.Cells["HistoriaIDD"].Value == historiaID)
                            {
                                row.Selected = true;
                                break;
                            }
                        }
                    }

                    txtNotas.Text = Convert.ToString(dgvReceta.CurrentRow.Cells["Notas"].Value);
                    cmbDosis.SelectedItem = Convert.ToString(dgvReceta.CurrentRow.Cells["Dosis"].Value);
                    cmbFrecuencia.SelectedItem = Convert.ToString(dgvReceta.CurrentRow.Cells["Frecuencia"].Value);
                    dtpFechaInicio.Value = Convert.ToDateTime(dgvReceta.CurrentRow.Cells["FechaInicio"].Value);
                    dtpFechaFin.Value = Convert.ToDateTime(dgvReceta.CurrentRow.Cells["FechaFin"].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error seleccionando fila: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHistoria.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un historial de paciente para guardar la receta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int pacienteID = Convert.ToInt32(dgvHistoria.SelectedRows[0].Cells["PacienteIDD"].Value);
                int historiaID = Convert.ToInt32(dgvHistoria.SelectedRows[0].Cells["HistoriaIDD"].Value);

                conexion.Open();
                string checkQuery = "SELECT COUNT(*) FROM Recetas WHERE PacienteID = @PacienteID AND HistoriaID = @HistoriaID";
                SqlCommand checkCommand = new SqlCommand(checkQuery, conexion);
                checkCommand.Parameters.AddWithValue("@PacienteID", pacienteID);
                checkCommand.Parameters.AddWithValue("@HistoriaID", historiaID);
                int count = (int)checkCommand.ExecuteScalar();
                conexion.Close();

                if (count > 0)
                {
                    MessageBox.Show("Ya existe una receta para este paciente y historial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int medicamentoID = (int)cmbDosis.SelectedValue;
                int stock = MedicamentosDAL.ObtenerStock(medicamentoID);

                if (stock <= 0)
                {
                    MessageBox.Show("No hay suficiente stock del medicamento seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string dosis = cmbDosis.SelectedItem.ToString();
                string frecuencia = cmbFrecuencia.SelectedItem.ToString();
                DateTime fechaInicio = dtpFechaInicio.Value;
                DateTime fechaFin = dtpFechaFin.Value;
                string notas = txtNotas.Text;

                Recetas nuevaReceta = new Recetas
                {
                    PacienteID = pacienteID,
                    HistoriaID = historiaID,
                    MedicamentoID = medicamentoID,
                    Dosis = dosis,
                    Frecuencia = frecuencia,
                    FechaInicio = fechaInicio,
                    FechaFin = fechaFin,
                    Notas = notas
                };

                int result = RecetasDAL.GuardarReceta(nuevaReceta);

                if (result > 0)
                {
                    Medicamentos medicamento = new Medicamentos
                    {
                        MedicamentoID = medicamentoID,
                        Stock = stock - 1
                    };

                    int updateResult = MedicamentosDAL.ActualizarStock(medicamento);

                    if (updateResult > 0)
                    {
                        MessageBox.Show("Receta guardada exitosamente y stock actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RecargarDatos();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al actualizar el stock del medicamento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hubo un error al guardar la receta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReceta.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una receta para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int pacienteID = Convert.ToInt32(dgvHistoria.SelectedRows[0].Cells["PacienteIDD"].Value);
                int recetaID = Convert.ToInt32(dgvReceta.CurrentRow.Cells["RecetaID"].Value);
                int historiaID = Convert.ToInt32(dgvHistoria.SelectedRows[0].Cells["HistoriaIDD"].Value);
                string dosis = cmbDosis.SelectedItem.ToString();
                int medicamentoID = (int)cmbDosis.SelectedValue;
                string frecuencia = cmbFrecuencia.SelectedItem.ToString();
                DateTime fechaInicio = dtpFechaInicio.Value;
                DateTime fechaFin = dtpFechaFin.Value;
                string notas = txtNotas.Text;

                Recetas recetaActualizada = new Recetas
                {
                    RecetaID = recetaID,
                    HistoriaID = historiaID,
                    PacienteID = pacienteID,
                    MedicamentoID = medicamentoID,
                    Dosis = dosis,
                    Frecuencia = frecuencia,
                    FechaInicio = fechaInicio,
                    FechaFin = fechaFin,
                    Notas = notas
                };

                int result = RecetasDAL.ActualizarReceta(recetaActualizada);

                if (result > 0)
                {
                    int stock = MedicamentosDAL.ObtenerStock(medicamentoID);

                    Medicamentos medicamento = new Medicamentos
                    {
                        MedicamentoID = medicamentoID,
                        Stock = stock - 1
                    };

                    int updateResult = MedicamentosDAL.ActualizarMedicamento(medicamento);

                    if (updateResult > 0)
                    {
                        MessageBox.Show("Receta actualizada exitosamente y stock actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RecargarDatos();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al actualizar el stock del medicamento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hubo un error al actualizar la receta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReceta.SelectedRows.Count > 0)
                {
                    int recetaID = Convert.ToInt32(dgvReceta.SelectedRows[0].Cells["RecetaID"].Value);

                    var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar esta receta?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        int result = RecetasDAL.EliminarReceta(recetaID);

                        if (result > 0)
                        {
                            MessageBox.Show("Receta eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RecargarDatos();
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error al eliminar la receta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una receta para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            cmbDosis.SelectedIndex = 0;
            cmbFrecuencia.SelectedIndex = 0;
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now.AddDays(1);
            txtNotas.Clear();
        }

        private void RecargarDatos()
        {
            this.datosRecetaTableAdapter.Fill(this.medicoDataSet.DatosReceta);
            this.datosHistoriaTableAdapter.Fill(this.medicoDataSet.DatosHistoria);
        }
        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaFin.Value < dtpFechaInicio.Value)
            {
                MessageBox.Show("La fecha de fin no puede ser anterior a la fecha de inicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaFin.Value = dtpFechaInicio.Value.AddDays(1);
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReporte3 reporte3 = new frmReporte3();
            if (dgvReceta.SelectedRows.Count > 0)
            {
                try
                {
                    object recetaIDValue = (int)dgvReceta.SelectedRows[0].Cells["RecetaID"].Value;

                    if (recetaIDValue != DBNull.Value)
                    {
                        short citaID = Convert.ToInt16(recetaIDValue);
                        reporte3.textBox1.Text = citaID.ToString();
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
            reporte3.ShowDialog();
            this.Close();
        }
    }
}
