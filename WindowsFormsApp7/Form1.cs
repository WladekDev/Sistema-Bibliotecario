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
    public partial class Form1 : Form
    {

        private Usuario usuarioLogin;
        public Form1(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogin = usuario;
            ActualizarMenu();
            CargarLibros();
            GestionLibrosDGV.ReadOnly = true;
            BuscarTituloDGV.ReadOnly = true;
        }

        public void ActualizarMenu()
        {
            if (usuarioLogin is Administrador)
            {
                GestionLibrosTSM.Visible = true;
                ConsultaLibrosTSM.Visible = true;
                GestionUsuariosTSM.Visible = true;

                BuscarTituloGB.Visible = false;
                GestionLibrosGB.Visible = false;
            }
            else if (usuarioLogin is Lector)
            {
                GestionLibrosTSM.Visible = false;
                ConsultaLibrosTSM.Visible = true;
                GestionUsuariosTSM.Visible = false;

                BuscarTituloGB.Visible = false;
                GestionLibrosGB.Visible = false;
            }
        }


        List<Libro> libros = new List<Libro>();
        string dato = "libros.csv";

        private void CargarLibros()
        {
            using (StreamReader sr = new StreamReader(dato))
            {
                string linea = sr.ReadLine();
                while (linea != null)
                {
                    string[] datos = linea.Split(';');
                    if (long.TryParse(datos[2], out long isbn) && int.TryParse(datos[3], out int año))
                    {
                        Libro libro = new Libro(datos[0], datos[1], isbn, año);
                        libros.Add(libro);
                    }
                    linea = sr.ReadLine();
                }
            }
        }

        private void ActualizarGrilla()
        {
            BuscarTituloDGV.DataSource = null;
            BuscarTituloDGV.AutoGenerateColumns = false;

            BuscarTituloDGV.Columns.Clear();

            BuscarTituloDGV.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Titulo",
                HeaderText = "Título"
            });

            BuscarTituloDGV.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Autor",
                HeaderText = "Autor"
            });

            BuscarTituloDGV.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ISBN",
                HeaderText = "ISBN"
            });

            BuscarTituloDGV.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Año",
                HeaderText = "Año de lanzamiento",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "d" }
            });
        }

        private void unloginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscarLibroPorTítuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarTituloGB.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscado = txtBuscar.Text;

            ActualizarGrilla();

            foreach (Libro libro in libros)
            {
                if (libro.Titulo == buscado)
                {
                    BuscarTituloDGV.DataSource = null;
                    BuscarTituloDGV.DataSource = new List<Libro> { libro };
                    break;
                }
            }
        }

        private void btnBuscarAutor_Click(object sender, EventArgs e)
        {
            string buscado2 = txtBuscarAutor.Text;

            ActualizarGrilla();

            foreach (Libro libro2 in libros)
            {
                if (libro2.Autor == buscado2)
                {
                    BuscarTituloDGV.DataSource = null;
                    BuscarTituloDGV.DataSource = new List<Libro> { libro2 };
                    break;
                }
            }
        }

        private void buscarLibroPorTítuloToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            BuscarTituloGB.Visible = false;
        }

        private void GestionLibrosTSM_Click(object sender, EventArgs e)
        {
            GestionLibrosGB.Visible = true;
            ActualizarGrilla();
            GestionLibrosDGV.DataSource = null;
            GestionLibrosDGV.DataSource = libros;
        }

        private void btnSalirGestion_Click(object sender, EventArgs e)
        {
            GestionLibrosGB.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(dato, append: true))
            {
                Libro nuevo = new Libro(txtTitulo.Text, txtAutor.Text, Convert.ToInt64(txtISBN.Text), Convert.ToInt32(txtAño.Text));
                libros.Add(nuevo);
                sw.WriteLine($"{nuevo.Titulo};{nuevo.Autor};{nuevo.ISBN};{nuevo.Año}");
            }
            GestionLibrosDGV.DataSource = null;
            GestionLibrosDGV.DataSource = libros;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Libro seleccionado = (Libro)GestionLibrosDGV.CurrentRow.DataBoundItem;
            libros.Remove(seleccionado);

            using (StreamWriter sw = new StreamWriter(dato))
            {
                foreach (var libro in libros)
                {
                    sw.WriteLine($"{libro.Titulo};{libro.Autor};{libro.ISBN};{libro.Año}");
                }
            }

            GestionLibrosDGV.DataSource = null;
            GestionLibrosDGV.DataSource = libros;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = GestionLibrosDGV.CurrentRow.Index;

            if (int.TryParse(txtISBN.Text, out int isbn) && int.TryParse(txtAño.Text, out int año))
            {
                Libro editar = new Libro(txtTitulo.Text, txtAutor.Text, isbn, año);
                libros[indice] = editar;
            }
            GestionLibrosDGV.DataSource = null;
            GestionLibrosDGV.DataSource = libros;
            using (StreamWriter sw = new StreamWriter(dato))
            {
                foreach (var libro in libros)
                {
                    sw.WriteLine($"{libro.Titulo};{libro.Autor};{libro.ISBN};{libro.Año}");
                }
            }
        }

        private void btnSalirBuscar_Click(object sender, EventArgs e)
        {
            BuscarTituloGB.Visible = false;
        }
    }
}
