using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMedico
{
    public class BDHospital
    {
        public static SqlConnection obtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-3NT553Q\\SQLEXPRESS;Initial Catalog=Medico;Integrated Security=True;Encrypt=False");
            conexion.Open();
            return conexion;
        }
    }
}