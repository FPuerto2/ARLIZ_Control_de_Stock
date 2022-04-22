using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Datos
{
    public class CD_Equipos
    {
        private CD_Conexion conexion = new CD_Conexion();

        //SQLiteDataReader leer;
        DataTable tabla = new DataTable();
        SQLiteCommand comando = new SQLiteCommand();
        public CD_MetodosGenerales Metodo = new CD_MetodosGenerales();


        public List<string> ListaEquipos(string nombreTabla)
        {
            return Metodo.GetList("SELECT Descripcion FROM " + nombreTabla + ";");
        }

        public void CambiarNombre(string nuevoNombre, string nombreAnterior)
        {
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "UPDATE EquiposDeTrabajo" +
                                    " SET Descripcion = '" + nuevoNombre + "'" +
                                    " WHERE Descripcion = '" + nombreAnterior + "'";

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void Insertar(string nombre)
        {
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "insert into EquiposDeTrabajo (Descripcion)" +
                " values('" + nombre + "')";
            comando.ExecuteNonQuery();

            conexion.CerrarConexion();
        }

        public void Borrar(string nombre)
        {
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "DELETE FROM EquiposDeTrabajo" +
                " WHERE Descripcion = '" + nombre + "'";
            comando.ExecuteNonQuery();

            conexion.CerrarConexion();
        }

    }
}
