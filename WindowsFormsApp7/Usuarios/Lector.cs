using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class Lector : Usuario
    {
        public Lector()
        {
        }
        public Lector(string nombre, string email, string contra, int dni) : base(nombre, email, contra, dni)
        {

        }
    }
}
