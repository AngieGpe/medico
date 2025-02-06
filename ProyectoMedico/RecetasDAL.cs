using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ProyectoMedico
{
    internal class RecetasDAL
    {
        public static int GuardarReceta(Recetas receta)
        {
            int result = 0;
            string query = "INSERT INTO Recetas (HistoriaID, PacienteID, MedicamentoID, Dosis, Frecuencia, FechaInicio, FechaFin, Notas) " +
                           "VALUES (@HistoriaID, @PacienteID, @MedicamentoID, @Dosis, @Frecuencia, @FechaInicio, @FechaFin, @Notas)";

            using (SqlConnection connection = BDHospital.obtenerConexion())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@HistoriaID", receta.HistoriaID);
                    command.Parameters.AddWithValue("@PacienteID", receta.PacienteID);
                    command.Parameters.AddWithValue("@MedicamentoID", receta.MedicamentoID);
                    command.Parameters.AddWithValue("@Dosis", receta.Dosis);
                    command.Parameters.AddWithValue("@Frecuencia", receta.Frecuencia);
                    command.Parameters.AddWithValue("@FechaInicio", receta.FechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", receta.FechaFin);
                    command.Parameters.AddWithValue("@Notas", receta.Notas);

                    result = command.ExecuteNonQuery();
                }
                connection.Close();
            }

            return result;
        }

        public static int ActualizarReceta(Recetas receta)
        {
            int result = 0;
            string query = "UPDATE Recetas SET Dosis = @Dosis, Frecuencia = @Frecuencia, FechaInicio = @FechaInicio, " +
                           "FechaFin = @FechaFin, Notas = @Notas, MedicamentoID = @MedicamentoID, PacienteID = @PacienteID " +
                           "WHERE RecetaID = @RecetaID";

            using (SqlConnection connection = BDHospital.obtenerConexion())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RecetaID", receta.RecetaID);
                    command.Parameters.AddWithValue("@HistoriaID", receta.HistoriaID);
                    command.Parameters.AddWithValue("@PacienteID", receta.PacienteID);
                    command.Parameters.AddWithValue("@MedicamentoID", receta.MedicamentoID);
                    command.Parameters.AddWithValue("@Dosis", receta.Dosis);
                    command.Parameters.AddWithValue("@Frecuencia", receta.Frecuencia);
                    command.Parameters.AddWithValue("@FechaInicio", receta.FechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", receta.FechaFin);
                    command.Parameters.AddWithValue("@Notas", receta.Notas);

                    result = command.ExecuteNonQuery();
                }
            }

            return result;
        }

        public static int EliminarReceta(int recetaID)
        {
            int result = 0;
            string query = "DELETE FROM Recetas WHERE RecetaID = @RecetaID";

            using (SqlConnection connection = BDHospital.obtenerConexion())
            {

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RecetaID", recetaID);

                    result = command.ExecuteNonQuery();
                }
            }

            return result;
        }
    }
}
