using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocio
{
    public class CN_StockEquipos
    {
        private CD_StockEquipos objetoCD = new CD_StockEquipos();
        public CN_MetodosGenerales Metodo = new CN_MetodosGenerales();

        public DataTable MostrarStockPorEquipo(string descripcionEquipo)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar(descripcionEquipo);
            return tabla;
        }


        public List<string> darListaRepuestos(string nombreTabla)
        {
            return objetoCD.ListaRepuestos(nombreTabla);
        }


        public bool ReponerStockSecundario(string repuestoId, string descripcionRepuesto, string cantidadActual, string cantidadIngresada, string nombreEquipo)
        {
            string cantidadActualStockPrimario = objetoCD.Metodo.GetCantidadArticulo(descripcionRepuesto);

            float nuevaCantidadStockPrimario = Convert.ToSingle(cantidadActualStockPrimario) - Convert.ToSingle(cantidadIngresada);
            float nuevaCantidadStockSecundario = Convert.ToSingle(cantidadActual) + Convert.ToSingle(cantidadIngresada);

            if (nuevaCantidadStockPrimario < 0)
                return false;

            else
                objetoCD.Reponer(repuestoId, nuevaCantidadStockSecundario.ToString(), nuevaCantidadStockPrimario.ToString(), nombreEquipo);

            return true;
        }

        public bool InsertarRepuesto(string equipo, string descripcionRepuesto, string cantidad, string stockMinimo)
        {
            string cantidadActualStockPrimario = objetoCD.Metodo.GetCantidadArticulo(descripcionRepuesto);

            float nuevaCantidadStockPrimario = Convert.ToSingle(cantidadActualStockPrimario) - Convert.ToSingle(cantidad);

            if (nuevaCantidadStockPrimario < 0)
                return false;

            else
                objetoCD.Insertar(equipo, descripcionRepuesto, cantidad, stockMinimo, nuevaCantidadStockPrimario.ToString());

            return true;
        }

        public void EliminarArticulo(int repuestoId, string nombreEquipo, string cantidad, string descripcionRepuesto)
        {
            string cantidadActualStockPrimario = objetoCD.Metodo.GetCantidadArticulo(descripcionRepuesto);

            float nuevaCantidadStockPrimario = Convert.ToSingle(cantidadActualStockPrimario) + Convert.ToSingle(cantidad);

            objetoCD.Eliminar(repuestoId, nombreEquipo, nuevaCantidadStockPrimario.ToString());
        }

        public List<string> darListaRepuestosPorEquipos(string equipo)
        {
            return objetoCD.ListaRepuestosPorEquipo(equipo);
        }

        public int ObtenerId(string nombreArticulo)
        {
            return objetoCD.Metodo.GetId(nombreArticulo, "Articulos");
        }

        public bool ConsumirRepuesto(string equipo, string descripcion, string cantidadActual, string cantidadIngresada)
        {
            int articuloId = objetoCD.Metodo.GetId(descripcion, "Articulos");

            float nuevaCantidad = Convert.ToSingle(cantidadActual) - Convert.ToSingle(cantidadIngresada);

            if (nuevaCantidad < 0)
                return false;

            else
                objetoCD.Consumir(equipo, articuloId.ToString(), (nuevaCantidad).ToString());

            return true;

        }


    }

}
