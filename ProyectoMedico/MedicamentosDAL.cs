using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoMedico
{
    public class MedicamentosDAL
    {
        private static string connectionString = "Data Source=DESKTOP-3NT553Q\\SQLEXPRESS;Initial Catalog=Medico;Integrated Security=True;Encrypt=False";

        public static int GuardarMedicamento(Medicamentos medicamento)
        {
            int retorna = 0;

            string query = "INSERT INTO Medicamentos (Nombre, Descripcion, Fabricante, Stock) " +
                           "VALUES (@Nombre, @Descripcion, @Fabricante, @Stock)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = medicamento.Nombre;
                    comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = medicamento.Descripcion;
                    comando.Parameters.Add("@Fabricante", SqlDbType.NVarChar).Value = medicamento.Fabricante;
                    comando.Parameters.Add("@Stock", SqlDbType.Int).Value = medicamento.Stock;

                    conexion.Open();
                    retorna = comando.ExecuteNonQuery();
                }
            }

            return retorna;
        }

        public static int ActualizarStock(Medicamentos medicamento)
        {
            int retorna = 0;

            string query = "UPDATE Medicamentos SET Stock = @Stock WHERE MedicamentoID = @MedicamentoID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand(query, connection))
                {
                    comando.Parameters.Add("@MedicamentoID", SqlDbType.Int).Value = medicamento.MedicamentoID;
                    comando.Parameters.Add("@Stock", SqlDbType.Int).Value = medicamento.Stock;

                    connection.Open();
                    retorna = comando.ExecuteNonQuery();
                }
            }

            return retorna;
        }

        public static int ActualizarMedicamento(Medicamentos medicamento)
        {
            int retorna = 0;

            string query = "UPDATE Medicamentos SET Nombre = @Nombre, Descripcion = @Descripcion, " +
                           "Fabricante = @Fabricante, Stock = @Stock WHERE MedicamentoID = @MedicamentoID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand(query, connection))
                {
                    comando.Parameters.Add("@MedicamentoID", SqlDbType.Int).Value = medicamento.MedicamentoID;
                    comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 255).Value = medicamento.Nombre;
                    comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 1000).Value = medicamento.Descripcion;
                    comando.Parameters.Add("@Fabricante", SqlDbType.NVarChar, 255).Value = medicamento.Fabricante;
                    comando.Parameters.Add("@Stock", SqlDbType.Int).Value = medicamento.Stock;

                    connection.Open();
                    retorna = comando.ExecuteNonQuery();
                }
            }

            return retorna;
        }

        public static int EliminarMedicamento(int medicamentoID)
        {
            int result = 0;

            string query = "DELETE FROM Medicamentos WHERE MedicamentoID = @MedicamentoID";

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var comando = new SqlCommand(query, connection))
                    {
                        comando.Parameters.Add("@MedicamentoID", SqlDbType.Int).Value = medicamentoID;

                        connection.Open();
                        result = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return result;
        }

        public static int ObtenerStock(int medicamentoID)
        {
            int stock = 0;

            string query = "SELECT Stock FROM Medicamentos WHERE MedicamentoID = @MedicamentoID";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add("@MedicamentoID", SqlDbType.Int).Value = medicamentoID;

                        conexion.Open();
                        object result = comando.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            stock = Convert.ToInt32(result);
                        }
                        else
                        {
                            throw new Exception("El medicamento no existe o no tiene stock disponible.");
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Ocurrió un error en la base de datos al obtener el stock: " + sqlEx.Message, sqlEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al obtener el stock: " + ex.Message, ex);
            }

            return stock;
        }
    }
}