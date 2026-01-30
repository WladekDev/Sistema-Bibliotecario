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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        public Usuario Autenticado { get; private set; }

        List<Usuario> usuarios = new List<Usuario>();


        string dato = "usuarios.csv";
        

        private void login_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(dato, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                string linea = sr.ReadLine();
                while (linea != null)
                {
                    string[] datos = linea.Split(';');
                    if (datos[4] == "1")
                    {
                        Administrador admin = new Administrador(datos[0], datos[1], datos[2], Convert.ToInt32(datos[3]));
                        usuarios.Add(admin);
                    }
                    else if (datos[4] == "2")
                    {
                        Lector lector = new Lector(datos[0], datos[1], datos[2], Convert.ToInt32(datos[3]));
                        usuarios.Add(lector);
                    }
                    linea = sr.ReadLine();
                }
            }
            fs.Close();  
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtContra.Text;

            bool login = false;

            foreach (var usuario in usuarios)
            {
                if (usuario.IniciarSesion(user, pass))
                {
                    login = true;
                    Autenticado = usuario;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
            }
            if (login == false)
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                txtUser.Clear();
                txtContra.Clear();
                txtUser.Focus();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarUser registrar = new RegistrarUser();
            registrar.Show();
        }
    }
}
