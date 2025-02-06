using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMedico
{
    public class PacientesDAL
    {
        public static int AgregarPacientes(Pacientes pacientes)
        {
            int retorna = 0;

            using (SqlConnection conexion = BDHospital.obtenerConexion())
            {
                string query = "INSERT INTO pacientes (Nombre, Apellido, FechaDeNacimiento, Género, Teléfono) " +
                               "VALUES (@Nombre, @Apellido, @FechaDeNacimiento, @Genero, @Telefono)";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", pacientes.Nombre);
                    comando.Parameters.AddWithValue("@Apellido", pacientes.Apellido);
                    comando.Parameters.AddWithValue("@FechaDeNacimiento", pacientes.FechaDeNacimiento);
                    comando.Parameters.AddWithValue("@Genero", pacientes.Género);
                    comando.Parameters.AddWithValue("@Telefono", pacientes.Teléfono);

                    retorna = comando.ExecuteNonQuery();
                }
            }
            return retorna;
        }

        public static int ActualizarPacientes(Pacientes pacientes)
        {
            int retorna = 0;

            string connectionString = "Data Source=DESKTOP-3NT553Q\\SQLEXPRESS;Initial Catalog=Medico;Integrated Security=True;Encrypt=False";
            string query = "UPDATE pacientes SET Nombre = @Nombre, Apellido = @Apellido, FechaDeNacimiento = @FechaDeNacimiento, " +
                           "Género = @Genero, Teléfono = @Telefono WHERE PacienteID = @PacienteID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand(query, connection))
                {
                    comando.Parameters.AddWithValue("@PacienteID", pacientes.PacienteID);
                    comando.Parameters.AddWithValue("@Nombre", pacientes.Nombre);
                    comando.Parameters.AddWithValue("@Apellido", pacientes.Apellido);
                    comando.Parameters.AddWithValue("@FechaDeNacimiento", pacientes.FechaDeNacimiento);
                    comando.Parameters.AddWithValue("@Genero", pacientes.Género.ToString()[0]);
                    comando.Parameters.AddWithValue("@Telefono", pacientes.Teléfono);
                    connection.Open();
                    retorna = comando.ExecuteNonQuery();
                }
            }

            return retorna;
        }

        public int EliminarPaciente(int pacienteID)
        {
            int result = 0;
            try
            {
                using (var connection = new SqlConnection("Data Source=DESKTOP-3NT553Q\\SQLEXPRESS;Initial Catalog=Medico;Integrated Security=True;Encrypt=False"))
                {
                    string query = "DELETE FROM Pacientes WHERE PacienteID = @PacienteID";
                    using (var comando = new SqlCommand(query, connection))
                    {
                        comando.Parameters.AddWithValue("@PacienteID", pacienteID);

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
        public static DataTable BuscarPacientePorNombre(string nombre)
        {
            string connectionString = "Data Source=DESKTOP-3NT553Q\\SQLEXPRESS;Initial Catalog=Medico;Integrated Security=True;Encrypt=False;";
            string query = "SELECT * FROM pacientes WHERE Nombre LIKE @Nombre";

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
