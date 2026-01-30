using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public interface IIniciarSesion
    {
        bool IniciarSesion(string email, string contra);
    }
}
