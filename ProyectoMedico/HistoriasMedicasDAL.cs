using System;
using System.Data.SqlClient;

namespace ProyectoMedico
{
    internal class HistoriasMedicasDAL
    {
        private static string connectionString = "Data Source=DESKTOP-3NT553Q\\SQLEXPRESS;Initial Catalog=Medico;Integrated Security=True;Encrypt=False";

        public static int GuardarHistoriaMedica(Historias historia)
        {
            int result = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO HistoriasMedicas (PacienteID, DoctorID, CitaID, FechaHistoria, Diagnostico, Tratamiento, Comentarios) " +
                               "VALUES (@PacienteID, @DoctorID, @CitaID, @FechaHistoria, @Diagnostico, @Tratamiento, @Comentarios)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PacienteID", historia.PacienteID);
                    command.Parameters.AddWithValue("@DoctorID", historia.DoctorID);
                    command.Parameters.AddWithValue("@CitaID", historia.CitaID);
                    command.Parameters.AddWithValue("@FechaHistoria", historia.FechaHistoria);
                    command.Parameters.AddWithValue("@Diagnostico", historia.Diagnostico);
                    command.Parameters.AddWithValue("@Tratamiento", historia.Tratamiento);
                    command.Parameters.AddWithValue("@Comentarios", historia.Comentarios);

                    connection.Open();
                    result = command.ExecuteNonQuery();
                }
            }

            return result;
        }

        public static int ActualizarHistoriaMedica(Historias historia)
        {
            int result = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE HistoriasMedicas SET PacienteID = @PacienteID, DoctorID = @DoctorID, CitaID = @CitaID, FechaHistoria = @FechaHistoria, " +
                               "Diagnostico = @Diagnostico, Tratamiento = @Tratamiento, Comentarios = @Comentarios WHERE HistoriaID = @HistoriaID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@HistoriaID", historia.HistoriaID);
                    command.Parameters.AddWithValue("@PacienteID", historia.PacienteID);
                    command.Parameters.AddWithValue("@DoctorID", historia.DoctorID);
                    command.Parameters.AddWithValue("@CitaID", historia.CitaID);
                    command.Parameters.AddWithValue("@FechaHistoria", historia.FechaHistoria);
                    command.Parameters.AddWithValue("@Diagnostico", historia.Diagnostico);
                    command.Parameters.AddWithValue("@Tratamiento", historia.Tratamiento);
                    command.Parameters.AddWithValue("@Comentarios", historia.Comentarios);

                    connection.Open();
                    result = command.ExecuteNonQuery();
                }
            }

            return result;
        }

        public static int EliminarHistoria(int historiaID)
        {
            int result = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM HistoriasMedicas WHERE HistoriaID = @HistoriaID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@HistoriaID", historiaID);

                    connection.Open();
                    result = command.ExecuteNonQuery();
                }
            }

            return result;
        }
        public static bool ExisteCita(int citaID)
        {
            bool exists = false;
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM HistoriasMedicas WHERE CitaID = @CitaID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CitaID", citaID);

                try
                {
                    connection.Open();
                    int count = (int)cmd.ExecuteScalar();
                    exists = count > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error checking if Cita exists: " + ex.Message);
                }
            }
            return exists;
        }

    }
}
