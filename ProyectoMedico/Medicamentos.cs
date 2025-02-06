using System;

namespace ProyectoMedico
{
    public class Medicamentos
    {
        public int MedicamentoID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Fabricante { get; set; }
        public int Stock { get; set; }

        public Medicamentos() { }

        public Medicamentos(int medicamentoID, string nombre, string descripcion, string fabricante, int stock)
        {
            this.MedicamentoID = medicamentoID;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Fabricante = fabricante;
            this.Stock = stock;
        }
    }
}
