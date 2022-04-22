using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Datos
{
    public class CD_MetodosGenerales
    {

        private CD_Conexion conexion = new CD_Conexion();

        SQLiteDataReader leer;
        DataTable tabla = new DataTable();
        SQLiteCommand comando = new SQLiteCommand();

        public List<string> GetList(string comandoText)
        {
            tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = comandoText;

            leer = comando.ExecuteReader();
            tabla.Load(leer);

            List<string> itemsTabla = new List<string>();

            for (int i = 0; i < tabla.Rows.Count; i++)
                itemsTabla.Add(tabla.Rows[i]["Descripcion"].ToString());

            conexion.CerrarConexion();

            return itemsTabla;
        }

        public int GetId(string descripcionItem, string nombreTabla)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT Id FROM " + nombreTabla + " WHERE Descripcion = '" + descripcionItem + "'";
            leer = comando.ExecuteReader();

            tabla = new DataTable();
            tabla.Load(leer);

            int Id = Convert.ToInt32(tabla.Rows[0]["Id"]);

            conexion.CerrarConexion();
            return Id;
        }


        public string GetCantidadArticulo(string articulo)
        {
            int articuloId = GetId(articulo, "Articulos");
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "SELECT Cantidad FROM Articulos WHERE Id = '" + articuloId + "'";
            leer = comando.ExecuteReader();

            DataTable tablaGId = new DataTable();
            tablaGId.Load(leer);

            string cantidad = tablaGId.Rows[0]["Cantidad"].ToString();

            conexion.CerrarConexion();
            return cantidad;
        }

    }
}
