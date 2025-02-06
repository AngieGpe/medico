using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMedico
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 200;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(btnSalir, "Click para cerrar el programa.");
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Inicio de sesión exitoso.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool AuthenticateUser(string username, string password)
        {

            const string validUsername = "admin";
            const string validPassword = "1234";

            return username == validUsername && password == validPassword;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
