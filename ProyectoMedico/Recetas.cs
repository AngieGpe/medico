using System;

namespace ProyectoMedico
{
    internal class Recetas
    {
        public int RecetaID { get; set; }
        public int HistoriaID { get; set; }
        public int PacienteID { get; set; }
        public int MedicamentoID { get; set; }
        public string Dosis { get; set; }
        public string Frecuencia { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Notas { get; set; }

        public Recetas() { }

        public Recetas(int recetaID, int historiaID, int pacienteID, int medicamentoID, string dosis,
                       string frecuencia, DateTime fechaInicio, DateTime fechaFin, string notas)
        {
            this.RecetaID = recetaID;
            this.HistoriaID = historiaID;
            this.PacienteID = pacienteID;
            this.MedicamentoID = medicamentoID;
            this.Dosis = dosis;
            this.Frecuencia = frecuencia;
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
            this.Notas = notas;
        }
    }
}

