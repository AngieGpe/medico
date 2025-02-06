using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoMedico
{
    public partial class frmMedicamentos : Form
    {
        public frmMedicamentos()
        {
            InitializeComponent();
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            ToolTip toolTip = new ToolTip
            {
                AutoPopDelay = 5000,
                InitialDelay = 500,
                ReshowDelay = 200,
                ShowAlways = true
            };
            toolTip.SetToolTip(btnAtras, "Click para regresar a recetas.");
            toolTip.SetToolTip(btnGuardar, "Click para guardar.");
            toolTip.SetToolTip(btnLimpiar, "Click para limpiar campos.");
            toolTip.SetToolTip(btnEliminar, "Click para eliminar.");
            toolTip.SetToolTip(btnActualizar, "Click para actualizar.");
        }

        private void frmMedicamentos_Load(object sender, EventArgs e)
        {
            this.medicamentosTableAdapter.Fill(this.medicoDataSet.Medicamentos);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRecetas recetas = new frmRecetas();
            recetas.ShowDialog();
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtStock.Clear();
            cmbFabricante.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                string descripcion = txtDescripcion.Text.Trim();
                string fabricante = cmbFabricante.SelectedItem.ToString().Trim();
                int stock = 0;

                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(fabricante))
                {
                    MessageBox.Show("Todos los campos deben ser llenados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtStock.Text, out stock) || stock <= 1 || stock >= 1000)
                {
                    MessageBox.Show("El stock debe ser un número mayor a 1 y menor a 999.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Medicamentos medicamento = new Medicamentos
                {
                    Nombre = nombre,
                    Descripcion = descripcion,
                    Fabricante = fabricante,
                    Stock = stock
                };

                int result = MedicamentosDAL.GuardarMedicamento(medicamento);

                if (result > 0)
                {
                    MessageBox.Show("Medicamento guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarDatos();
                }
                else
                {
                    MessageBox.Show("Hubo un error al guardar el medicamento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvMedicamentos.SelectedRows.Count > 0)
            {
                try
                {
                    int medicamentoID = (int)dgvMedicamentos.SelectedRows[0].Cells["MedicamentoID"].Value;
                    string nombre = txtNombre.Text.Trim();
                    string descripcion = txtDescripcion.Text.Trim();
                    string fabricante = cmbFabricante.SelectedItem?.ToString().Trim();
                    string stockText = txtStock.Text.Trim();
                    int stock = 0;

                    if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(fabricante))
                    {
                        MessageBox.Show("Todos los campos deben ser llenados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (string.IsNullOrEmpty(stockText) || !int.TryParse(stockText, out stock))
                    {
                        MessageBox.Show("Por favor ingrese un número válido para el stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (stock <= 1 || stock >= 999)
                    {
                        MessageBox.Show("El stock debe ser un número mayor a 1 y menor a 999.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Medicamentos medicamento = new Medicamentos
                    {
                        MedicamentoID = medicamentoID,
                        Nombre = nombre,
                        Descripcion = descripcion,
                        Fabricante = fabricante,
                        Stock = stock
                    };

                    int result = MedicamentosDAL.ActualizarMedicamento(medicamento);

                    if (result > 0)
                    {
                        MessageBox.Show("Medicamento actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RecargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al actualizar el medicamento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un medicamento para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMedicamentos.SelectedRows.Count > 0)
            {
                int medicamentoID = (int)dgvMedicamentos.SelectedRows[0].Cells["MedicamentoID"].Value;

                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este medicamento?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        int result = MedicamentosDAL.EliminarMedicamento(medicamentoID);

                        if (result > 0)
                        {
                            MessageBox.Show("Medicamento eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RecargarDatos();
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error al eliminar el medicamento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Debe seleccionar un medicamento para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RecargarDatos()
        {
            this.medicamentosTableAdapter.Fill(this.medicoDataSet.Medicamentos);
        }

        private void dgvMedicamentos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMedicamentos.CurrentRow != null)
            {
                txtNombre.Text = Convert.ToString(dgvMedicamentos.CurrentRow.Cells["Nombre"].Value);
                txtDescripcion.Text = Convert.ToString(dgvMedicamentos.CurrentRow.Cells["Descripcion"].Value);
                cmbFabricante.SelectedItem = Convert.ToString(dgvMedicamentos.CurrentRow.Cells["Fabricante"].Value);
                txtStock.Text = Convert.ToString(dgvMedicamentos.CurrentRow.Cells["Stock"].Value);
            }
        }
        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 || txtStock.Text.Length >= 3 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
