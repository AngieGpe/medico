using System;

namespace ProyectoMedico
{
    public class Doctores
    {
        public int DoctorID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Especialidad { get; set; }
        public string Telefono { get; set; }
        public string NumeroLicencia { get; set; }

    public Doctores() { }

        public Doctores(int doctorID, string nombre, string apellido, string especialidad, string telefono, string numeroLicencia)
        {
            this.DoctorID = doctorID;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Especialidad = especialidad;
            this.Telefono = telefono;
            this.NumeroLicencia = numeroLicencia;
        }
    }
}
