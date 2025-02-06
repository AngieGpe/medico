using System;

namespace ProyectoMedico
{
    public class Citas
    {
        public int CitaID { get; set; }
        public int DoctorID { get; set; }
        public int PacienteID { get; set; }
        public DateTime FechaCita { get; set; }
        public string HoraCita { get; set; }
        public string Estado { get; set; }
        public string Notas { get; set; }

        public Citas() { }

        public Citas(int citaID, int doctorID, int pacienteID, DateTime fechaCita, string horaCita, string estado, string notas)
        {
            this.CitaID = citaID;
            this.DoctorID = doctorID;
            this.PacienteID = pacienteID;
            this.FechaCita = fechaCita;
            this.HoraCita = horaCita;
            this.Estado = estado;
            this.Notas = notas;
        }
    }
}
