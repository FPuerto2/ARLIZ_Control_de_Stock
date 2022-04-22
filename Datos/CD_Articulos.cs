using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Datos
{
    public class CD_Articulos
    {
        private CD_Conexion conexion = new CD_Conexion();
        
        SQLiteDataReader leer;
        DataTable tabla = new DataTable();
        SQLiteCommand comando = new SQLiteCommand();

        public CD_MetodosGenerales Metodo = new CD_MetodosGenerales();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "SELECT Articulos.Id, Articulos.Descripcion, Clasificaciones.Descripcion," +
                " Articulos.Cantidad, Unidades.Descripcion, Articulos.StockMinimo" +
                " FROM Articulos, Clasificaciones, Unidades" +
                " WHERE Articulos.ClasificacionId = Clasificaciones.Id" +
                " AND Articulos.UnidadId = Unidades.Id";

            leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.CerrarConexion();
            return tabla;
        }

        public List<string> ListaArticulos(string nombreTabla)
        {
            return Metodo.GetList("SELECT Descripcion FROM " + nombreTabla + ";");
        }

        public List<string> ListaElementos(string nombreTabla)
        {            
            return Metodo.GetList("SELECT Descripcion FROM " + nombreTabla + " WHERE ClasificacionId = 2;");
        }


        public void Insertar(string descripcion, string clasificacion, string unidad, string cantidad, string stockMinimo)
        {
            int clasificacionId = Metodo.GetId(clasificacion, "Clasificaciones"), unidadId = Metodo.GetId(unidad, "Unidades");

            cantidad = cantidad.Replace(",", ".");
            stockMinimo = stockMinimo.Replace(",", ".");

            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "insert into Articulos (Descripcion, ClasificacionId, UnidadId, Cantidad, StockMinimo)" +
                " values('" + descripcion + "', " + clasificacionId + ", " + unidadId + ", " + cantidad + ", " + stockMinimo + ")";
            comando.ExecuteNonQuery();

            conexion.CerrarConexion();

        }

        public void Editar(int id, string descripcion, string clasificacion, string unidad, string cantidad, string stockMinimo)
        {
            //UPDATE table_name
            //SET column1 = value1, column2 = value2, ...
            //WHERE condition;

            int clasificacionId = Metodo.GetId(clasificacion, "Clasificaciones"), unidadId = Metodo.GetId(unidad, "Unidades");

            cantidad = cantidad.Replace(",", ".");
            stockMinimo = stockMinimo.Replace(",", ".");


            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "UPDATE Articulos" +
                                    " SET Descripcion = '" + descripcion + "'," +
                                    " ClasificacionId = " + clasificacionId + "," +
                                    " UnidadId = " + unidadId + "," +
                                    " Cantidad = " + cantidad + "," +
                                    " StockMinimo = " + stockMinimo +
                                    " WHERE Id = " + id;

            comando.ExecuteNonQuery();

            conexion.CerrarConexion();
        }

        public void CantidadModificacion(string id, string cantidad)
        {
            cantidad = cantidad.Replace(",", ".");

            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "UPDATE Articulos" +
                                    " SET Cantidad = " + cantidad +
                                    " WHERE Id = " + id;

            comando.ExecuteNonQuery();

            conexion.CerrarConexion();
        }

        public void Eliminar(int Id)
        {
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "DELETE FROM Articulos " +
                " WHERE Id = " + Id;

            comando.ExecuteNonQuery();

            comando.CommandText = "DELETE FROM StocksDeEquipos " +
                " WHERE ArticuloId = " + Id;

            comando.ExecuteNonQuery();

            conexion.CerrarConexion();

        }

        


        public string SiguienteId()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM SQLITE_SEQUENCE WHERE name='Articulos';";
            leer = comando.ExecuteReader();

            tabla = new DataTable();
            tabla.Load(leer);

            int Id = Convert.ToInt32(tabla.Rows[0]["seq"]) + 1;

            conexion.CerrarConexion();
            return Id.ToString();
        }
    }
}
