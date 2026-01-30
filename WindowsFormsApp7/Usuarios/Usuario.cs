using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
	public abstract class Usuario : IABMusuario, IIniciarSesion
	{
		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private string _email;

		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}

		private string _contra;

		public string Contra
		{
			get { return _contra; }
			set { _contra = value; }
		}

		private int _dni;

		public int DNI
		{
			get { return _dni; }
			set { _dni = value; }
		}

		protected Usuario()
		{

		}

		protected Usuario(string nombre, string email, string contra, int dni)
		{
			Nombre = nombre;
			Email = email;
			Contra = contra;
			DNI = dni;
		}

		public bool Agregar(string nombre, string email, string contra, int dni)
		{
			return Nombre == nombre && Email == email && Contra == contra && DNI == dni;
		}

		public bool Modificar(string nombre, string email, string contra, int dni)
		{
			if (Nombre == nombre && Email == email && Contra == contra && DNI == dni)
			{
				Nombre = nombre;
				Email = email;
				Contra = contra;
				DNI = dni;
				return true;
			}
			return false;
		}

		public bool Eliminar(string nombre, string email, string contra, int dni)
		{
			if (Nombre == nombre && Email == email && Contra == contra && DNI == dni)
			{
				Nombre = null;
				Email = null;
				Contra = null;
				DNI = 0;
				return true;
			}
			return false;
		}

		public bool IniciarSesion(string email, string contra)
		{
			return Email == email && Contra == contra;
		}
    }
}
