using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class RegistrarUser : Form
    {

        public RegistrarUser()
        {
            InitializeComponent();
        }

        private void AgregarUsuario(Lector user)
        {
            string ruta = "Usuarios.csv";
            string linea = $"{user.Nombre};{user.Email};{user.Contra};{user.DNI};2\n";
            using (StreamWriter sw = new StreamWriter(ruta, append: true))
            {
                sw.WriteLine(linea);
            }
            Console.WriteLine("El registro se completo con éxito.");
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (txtContra.Text == txtRepetirContra.Text)
            {
                Lector nuevousuario = new Lector(
                    txtNombre.Text,
                    txtEmail.Text,
                    txtContra.Text,
                    Convert.ToInt32(txtDNI.Text)
                );
                AgregarUsuario(nuevousuario);
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, inténtelo de nuevo.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
