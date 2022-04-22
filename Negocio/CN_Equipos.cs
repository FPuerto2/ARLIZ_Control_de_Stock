using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocio
{
    public class CN_Equipos
    {
        private CD_Equipos objetoCD = new CD_Equipos();
        public CN_MetodosGenerales Metodo = new CN_MetodosGenerales();

        public List<string> darListaEquipos(string nombreTabla)
        {
            return objetoCD.ListaEquipos(nombreTabla);
        }

        public void CambiarNombreEquipo(string nuevoNombre, string nombreAnterior)
        {
            objetoCD.CambiarNombre(nuevoNombre, nombreAnterior);
        }

        public void InsertarEquipo(string nombreEquipo)
        {
            objetoCD.Insertar(nombreEquipo);
        }

        public void BorrarEquipo(string nombreEquipo)
        {
            objetoCD.Borrar(nombreEquipo);
        }
    }
}
