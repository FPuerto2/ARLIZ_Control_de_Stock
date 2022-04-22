using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Datos
{
    public class CD_StockEquipos
    {
        private CD_Conexion conexion = new CD_Conexion();

        SQLiteDataReader leer;
        DataTable tabla = new DataTable();
        SQLiteCommand comando = new SQLiteCommand();
        public CD_MetodosGenerales Metodo = new CD_MetodosGenerales();

        public DataTable Mostrar(string descripcionEquipo)
        {
            int EquipoId = Metodo.GetId(descripcionEquipo, "EquiposDeTrabajo");
            
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "SELECT Articulos.Id, Articulos.Descripcion, StocksDeEquipos.Cantidad, Unidades.Descripcion, StocksDeEquipos.StockMinimo" +
                " FROM Articulos, Unidades, StocksDeEquipos" +
                " WHERE Articulos.UnidadId = Unidades.Id" +
                " AND Articulos.id = StocksDeEquipos.ArticuloId" +
                " AND StocksDeEquipos.EquipoId = " + EquipoId;

            leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.CerrarConexion();
            return tabla;
        }
        public void Reponer(string repuestoId, string nuevaCantidadStockSecundario, string nuevaCantidadStockPrimario, string nombreEquipo)
        {
            nuevaCantidadStockSecundario = nuevaCantidadStockSecundario.Replace(",", ".");
            int EquipoId = Metodo.GetId(nombreEquipo, "EquiposDeTrabajo");

            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "UPDATE StocksDeEquipos" +
                                    " SET Cantidad = " + nuevaCantidadStockSecundario +
                                    " WHERE ArticuloId = " + repuestoId +
                                    " AND EquipoId = " + EquipoId;

            comando.ExecuteNonQuery();
            
            comando.CommandText = "UPDATE Articulos" +
                                    " SET Cantidad = " + nuevaCantidadStockPrimario +
                                    " WHERE Id = " + repuestoId;

            comando.ExecuteNonQuery();


            conexion.CerrarConexion();

        }


        public List<string> ListaRepuestos(string nombreTabla)
        {
            return Metodo.GetList("SELECT Descripcion FROM " + nombreTabla + " " +
                "WHERE ClasificacionId  = 1;");
        }


        public List<string> ListaRepuestosPorEquipo(string equipo)
        {
            int equipoId = Metodo.GetId(equipo, "EquiposDeTrabajo");

            return Metodo.GetList("SELECT Articulos.Descripcion, ArticuloId" +
                " FROM  Articulos, StocksDeEquipos" +
                " WHERE Articulos.Id = StocksDeEquipos.ArticuloId" +
                " AND EquipoId = " + equipoId);
        }

        public void Insertar(string equipo, string descripcion, string cantidad, string stockMinimo, string nuevaCantidadStockPrimario)
        {
            int equipoId = Metodo.GetId(equipo, "EquiposDeTrabajo");
            int repuestoId = Metodo.GetId(descripcion, "Articulos");

            nuevaCantidadStockPrimario = nuevaCantidadStockPrimario.Replace(",", ".");
            cantidad = cantidad.Replace(",", ".");
            stockMinimo = stockMinimo.Replace(",", ".");

            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "insert into StocksDeEquipos (EquipoId, ArticuloId, Cantidad, StockMinimo)" +
                " values(" + equipoId + ", '" + repuestoId + "', " + cantidad + ", " + stockMinimo + ")";

            comando.ExecuteNonQuery();

            comando.CommandText = "UPDATE Articulos" +
                                      " SET Cantidad = " + nuevaCantidadStockPrimario +
                                      " WHERE Id = " + repuestoId;

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }


        public void Consumir(string equipo ,string id, string cantidad)
        {
            cantidad = cantidad.Replace(",", ".");

            int equipoId = Metodo.GetId(equipo, "EquiposDeTrabajo");

            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "UPDATE StocksDeEquipos" +
                                    " SET Cantidad = " + cantidad +
                                    " WHERE ArticuloId = " + id +
                                    " AND EquipoId = " + equipoId;

            comando.ExecuteNonQuery();

            conexion.CerrarConexion();
        }



        public void Eliminar(int repuestoId, string equipo, string nuevaCantidadStockPrimario)
        {
            nuevaCantidadStockPrimario = nuevaCantidadStockPrimario.Replace(",", ".");
            int equipoId = Metodo.GetId(equipo, "EquiposDeTrabajo");

            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "DELETE FROM StocksDeEquipos" +
                " WHERE ArticuloId = " + repuestoId +
                " AND EquipoId = " + equipoId;

            comando.ExecuteNonQuery();


            comando.CommandText = "UPDATE Articulos" +
                                      " SET Cantidad = " + nuevaCantidadStockPrimario +
                                      " WHERE Id = " + repuestoId;

            comando.ExecuteNonQuery();

            conexion.CerrarConexion();

        }

    }
}
