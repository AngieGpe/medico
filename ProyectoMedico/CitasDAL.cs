using System;
using System.Data.SqlClient;

namespace ProyectoMedico
{
    internal class CitasDAL
    {
        private static string connectionString = "Data Source=DESKTOP-3NT553Q\\SQLEXPRESS;Initial Catalog=Medico;Integrated Security=True;Encrypt=False";

        private static bool DoctorTieneCitaMismoTiempo(int doctorID, int pacienteID, DateTime fecha, string hora, int? citaID = null)
        {
            bool exists = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Citas WHERE DoctorID = @DoctorID AND PacienteID = @PacienteID " +
                               "AND FechaCita = @FechaCita AND HoraCita = @HoraCita";
                if (citaID.HasValue)
                {
                    query += " AND CitaID != @CitaID";
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DoctorID", doctorID);
                    command.Parameters.AddWithValue("@PacienteID", pacienteID);
                    command.Parameters.AddWithValue("@FechaCita", fecha);
                    command.Parameters.AddWithValue("@HoraCita", hora);
                    if (citaID.HasValue)
                    {
                        command.Parameters.AddWithValue("@CitaID", citaID.Value);
                    }

                    connection.Open();
                    exists = (int)command.ExecuteScalar() > 0;
                }
            }

            return exists;
        }

        public static int AgregarCita(Citas cita)
        {
            if (DoctorTieneCitaMismoTiempo(cita.DoctorID, cita.PacienteID, cita.FechaCita, cita.HoraCita))
            {
                return -1;
            }

            int result = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Citas (DoctorID, PacienteID, FechaCita, HoraCita, Estado, Notas) " +
                               "VALUES (@DoctorID, @PacienteID, @FechaCita, @HoraCita, @Estado, @Notas)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DoctorID", cita.DoctorID);
                    command.Parameters.AddWithValue("@PacienteID", cita.PacienteID);
                    command.Parameters.AddWithValue("@FechaCita", cita.FechaCita);
                    command.Parameters.AddWithValue("@HoraCita", cita.HoraCita);
                    command.Parameters.AddWithValue("@Estado", cita.Estado);
                    command.Parameters.AddWithValue("@Notas", cita.Notas);

                    connection.Open();
                    result = command.ExecuteNonQuery();
                }
            }

            return result;
        }

        public static int ActualizarCita(Citas cita)
        {
            if (DoctorTieneCitaMismoTiempo(cita.DoctorID, cita.PacienteID, cita.FechaCita, cita.HoraCita, cita.CitaID))
            {
                return -1;
            }

            int result = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Citas SET DoctorID = @DoctorID, PacienteID = @PacienteID, FechaCita = @FechaCita, HoraCita = @HoraCita, Estado = @Estado, Notas = @Notas " +
                               "WHERE CitaID = @CitaID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CitaID", cita.CitaID);
                    command.Parameters.AddWithValue("@DoctorID", cita.DoctorID);
                    command.Parameters.AddWithValue("@PacienteID", cita.PacienteID);
                    command.Parameters.AddWithValue("@FechaCita", cita.FechaCita);
                    command.Parameters.AddWithValue("@HoraCita", cita.HoraCita);
                    command.Parameters.AddWithValue("@Estado", cita.Estado);
                    command.Parameters.AddWithValue("@Notas", cita.Notas);

                    connection.Open();
                    result = command.ExecuteNonQuery();
                }
            }

            return result;
        }

        public static int EliminarCita(int citaID)
        {
            int result = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Citas WHERE CitaID = @CitaID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CitaID", citaID);

                    connection.Open();
                    result = command.ExecuteNonQuery();
                }
            }

            return result;
        }
    }
}
