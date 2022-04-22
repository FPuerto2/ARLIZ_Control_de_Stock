using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocio
{
    public class CN_PlantillaReposicion
    {
        public CN_MetodosGenerales Metodo = new CN_MetodosGenerales();

        CD_PlantillaReposicion objetoCD = new CD_PlantillaReposicion();
        
        public DataTable MostrarPlantilla()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public List<string> darListaRepuestosPlantilla()
        {
            return objetoCD.ListaRepuestos();
        }

        public void AgregarRepuesto(string repuesto, string cantidad)
        {
            objetoCD.Insertar(repuesto, cantidad);
        }


        public void EditarRepuestoPlantilla(string repuesto, string cantidad)
        {
            objetoCD.Editar(repuesto, cantidad);

        }

        public void EliminarRepuesto(string repuesto)
        {
            objetoCD.Eliminar(repuesto);
        }

        public string AplicarReposicion(string equipo)
        {
            return objetoCD.Reponer(equipo);
        }

    }
}
