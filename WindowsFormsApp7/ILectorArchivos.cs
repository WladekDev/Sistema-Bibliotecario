using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public interface ILectorArchivos
    {
        //Todavia no implementado
        void Abrir(string rutaArchivo);
        string LeerLinea();
        bool FinArchivo();
        void Cerrar();
    }
}
