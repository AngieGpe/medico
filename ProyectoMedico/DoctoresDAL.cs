using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoMedico
{
    public class DoctoresDAL
    {
        public static int AgregarDoctor(Doctores doctores)
        {
            int retorna = 0;

            using (SqlConnection conexion = BDHospital.obtenerConexion())
            {
                string query = "INSERT INTO doctores (Nombre, Apellido, Especialidad, Telefono, NumeroLicencia) " +
                               "VALUES (@Nombre, @Apellido, @Especialidad, @Telefono, @NumeroLicencia)";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", doctores.Nombre);
                    comando.Parameters.AddWithValue("@Apellido", doctores.Apellido);
                    comando.Parameters.AddWithValue("@Especialidad", doctores.Especialidad);
                    comando.Parameters.AddWithValue("@Telefono", doctores.Telefono);
                    comando.Parameters.AddWithValue("@NumeroLicencia", doctores.NumeroLicencia);

                    retorna = comando.ExecuteNonQuery();
                }
            }
            return retorna;
        }

        public static bool ExisteLicencia(string numeroLicencia, int? doctorID = null)
        {
            bool existe = false;

            string query = "SELECT COUNT(*) FROM Doctores WHERE NumeroLicencia = @NumeroLicencia";
            if (doctorID.HasValue)
            {
                query += " AND DoctorID != @DoctorID";
            }

            using (SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-3NT553Q\\SQLEXPRESS;Initial Catalog=Medico;Integrated Security=True;Encrypt=False"))
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@NumeroLicencia", numeroLicencia);
                        if (doctorID.HasValue)
                        {
                            comando.Parameters.AddWithValue("@DoctorID", doctorID.Value);
                        }

                        int count = (int)comando.ExecuteScalar();
                        existe = count > 0;
                    }
                }
                finally
                {
                    if (conexion.State != System.Data.ConnectionState.Closed)
                    {
                        conexion.Close();
                    }
                }
            }

            return existe;
        }


        public static int ActualizarDoctor(Doctores doctores)
        {
            int retorna = 0;

            string connectionString = "Data Source=DESKTOP-3NT553Q\\SQLEXPRESS;Initial Catalog=Medico;Integrated Security=True;Encrypt=False";
            string query = "UPDATE doctores SET Nombre = @Nombre, Apellido = @Apellido, Especialidad = @Especialidad, " +
                           "Telefono = @Telefono, NumeroLicencia = @NumeroLicencia WHERE DoctorID = @DoctorID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand(query, connection))
                {
                    comando.Parameters.AddWithValue("@DoctorID", doctores.DoctorID);
                    comando.Parameters.AddWithValue("@Nombre", doctores.Nombre);
                    comando.Parameters.AddWithValue("@Apellido", doctores.Apellido);
                    comando.Parameters.AddWithValue("@Especialidad", doctores.Especialidad);
                    comando.Parameters.AddWithValue("@Telefono", doctores.Telefono);
                    comando.Parameters.AddWithValue("@NumeroLicencia", doctores.NumeroLicencia);

                    connection.Open();
                    retorna = comando.ExecuteNonQuery();
                }
            }

            return retorna;
        }

        public static int EliminarDoctor(int doctorID)
        {
            int result = 0;

            try
            {
                using (var connection = new SqlConnection("Data Source=DESKTOP-3NT553Q\\SQLEXPRESS;Initial Catalog=Medico;Integrated Security=True;Encrypt=False"))
                {
                    string query = "DELETE FROM doctores WHERE DoctorID = @DoctorID";
                    using (var comando = new SqlCommand(query, connection))
                    {
                        comando.Parameters.AddWithValue("@DoctorID", doctorID);

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

        public static DataTable BuscarDoctorPorNombre(string nombre)
        {
            string connectionString = "Data Source=DESKTOP-3NT553Q\\SQLEXPRESS;Initial Catalog=Medico;Integrated Security=True;Encrypt=False;";
            string query = "SELECT * FROM doctores WHERE Nombre LIKE @Nombre";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                return dataTable;
            }
        }
    }
}
