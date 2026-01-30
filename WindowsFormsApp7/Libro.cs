using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class Libro
    {
		private string _titulo;
		public string Titulo
		{
			get { return _titulo; }
			set { _titulo = value; }
		}

		private string _autor;
		public string Autor
		{
			get { return _autor; }
			set { _autor = value; }
		}

		private long _iSBN;
		public long ISBN
		{
			get { return _iSBN; }
			set { _iSBN = value; }
		}

		private int _año;
		public int Año
		{
			get { return _año; }
			set { _año = value; }
		}

        public Libro()
        {
        }

        public Libro(string titulo, string autor, long isbn, int año)
        {
			Titulo = titulo;
			Autor = autor;
			ISBN = isbn;
			Año = año;
        }
    }
}
