using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocio
{
    public class CN_Articulos
    {
        private CD_Articulos objetoCD = new CD_Articulos();
        public CN_MetodosGenerales Metodo = new CN_MetodosGenerales();

        public DataTable MostrarArticulos()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public List<string> darListaArticulos(string nombreTabla)
        {
            return objetoCD.ListaArticulos(nombreTabla);
        }

        public List<string> darListaElementos(string nombreTabla)
        {
            return objetoCD.ListaElementos(nombreTabla);
        }

        public void InsertarArticulo(string descripcion, string clasificacion, string unidad, string cantidad, string stockMinimo)
        {
            objetoCD.Insertar(descripcion, clasificacion, unidad, cantidad, stockMinimo);
        }

        public void EditarArticulo(string id, string descripcion, string clasificacion, string unidad, string cantidad, string stockMinimo)
        {
            objetoCD.Editar(Convert.ToInt32(id), descripcion, clasificacion, unidad, cantidad, stockMinimo);

        }

        public void ReponerArticulo(string Id, string cantidadActual, string cantidadIngresada)
        {

            objetoCD.CantidadModificacion(Id, (Convert.ToSingle(cantidadActual) + Convert.ToSingle(cantidadIngresada)).ToString());
        }

        public bool ConsumirElemento(string descripcion, string cantidadActual, string cantidadIngresada)
        {
            int articuloId = objetoCD.Metodo.GetId(descripcion, "Articulos");

            float nuevaCantidad = Convert.ToSingle(cantidadActual) - Convert.ToSingle(cantidadIngresada);

            if (nuevaCantidad < 0)
                return false;

            else
                objetoCD.CantidadModificacion(articuloId.ToString(), (nuevaCantidad).ToString());

            return true;

        }

        public string ObtenerSiguienteId()
        {
            return objetoCD.SiguienteId();
        }

        public void EliminarArticulo(int id)
        {
            objetoCD.Eliminar(id);
        }

        public string ArticuloCantidad(string articulo)
        {
            return objetoCD.Metodo.GetCantidadArticulo(articulo);
        }

    }
}
