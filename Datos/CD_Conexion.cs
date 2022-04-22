using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
namespace Datos
{

    public class CD_Conexion
    {
        public SQLiteConnection sql_con = new SQLiteConnection("Data Source=DB_ESTEF-2.db;Version=3;New=False;Compress=True;");

        public SQLiteConnection AbrirConexion()
        {
            if (sql_con.State == ConnectionState.Closed)
                sql_con.Open();
            return sql_con;
        }

        public SQLiteConnection CerrarConexion()
        {
            if (sql_con.State == ConnectionState.Open)
                sql_con.Close();
            return sql_con;
        }


    }
}
