using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public interface IABMusuario
    {
        bool Agregar(string nombre, string email, string contra, int dni);
        bool Modificar(string nombre, string email, string contra, int dni);
        bool Eliminar(string nombre, string email, string contra, int dni);
    }
}
