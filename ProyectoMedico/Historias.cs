using System;

namespace ProyectoMedico
{
    public class Historias
    {
        public int HistoriaID { get; set; }
        public int PacienteID { get; set; }
        public int DoctorID { get; set; }
        public int CitaID { get; set; }
        public DateTime FechaHistoria { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Comentarios { get; set; }

        public Historias() { }

        public Historias(int historiaID, int pacienteID, int doctorID, int citaID, DateTime fechaHistoria, string diagnostico, string tratamiento, string comentarios)
        {
            this.HistoriaID = historiaID;
            this.PacienteID = pacienteID;
            this.DoctorID = doctorID;
            this.CitaID = citaID;
            this.FechaHistoria = fechaHistoria;
            this.Diagnostico = diagnostico;
            this.Tratamiento = tratamiento;
            this.Comentarios = comentarios;
        }
    }
}

