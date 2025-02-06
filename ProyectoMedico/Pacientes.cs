using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMedico
{
    public class Pacientes
    {
        public int PacienteID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public char Género { get; set; }
        public string Teléfono { get; set; }

        public Pacientes() { }

        public Pacientes(int pacienteID, string nombre, string apellido, DateTime fechaNacimiento, char genero, string telefono)
        {
            this.PacienteID = pacienteID;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaDeNacimiento = fechaNacimiento;
            this.Género = genero;
            this.Teléfono = telefono;
        }
    }
}
