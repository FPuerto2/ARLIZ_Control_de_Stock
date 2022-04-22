using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocio
{
    public class CN_MetodosGenerales
    {

        public bool Existe(string descripcion, List<string> lista)
        {
            foreach (string articulo in lista)
                if (articulo.ToLower() == descripcion.ToLower())
                    return true;

            return false;
        }
    }
}
