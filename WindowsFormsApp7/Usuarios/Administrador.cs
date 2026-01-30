using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class Administrador : Usuario
    {

		private int _idadmin;

		public int IdAdmin
		{
			get { return _idadmin; }
			set { _idadmin = value; }
		}

		public Administrador()
		{

		}

        public Administrador(string nombre, string email, string contra, int dni) : base(nombre, email, contra, dni)
        {
            
        }

    }
}
