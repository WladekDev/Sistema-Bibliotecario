using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Hidden : Form
    {
        public Hidden()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.Opacity = 0;
            this.Load += (s, e) => login_Load();
        }

        private void login_Load()
        {
            while (true)
            {
                login Login = new login();
                if (Login.ShowDialog() == DialogResult.OK)
                {
                    Usuario usuario = Login.Autenticado;
                    Form1 form = new Form1(usuario);
                    form.ShowDialog();
                }
                else
                {
                    this.Close();
                    break;
                }
            }
        }
    }
}
