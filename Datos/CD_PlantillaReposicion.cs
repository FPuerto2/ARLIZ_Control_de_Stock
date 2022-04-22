using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Datos
{
    public class CD_PlantillaReposicion
    {
        private CD_Conexion conexion = new CD_Conexion();

        SQLiteDataReader leer;
        DataTable tabla = new DataTable();
        SQLiteCommand comando = new SQLiteCommand();
        CD_MetodosGenerales Metodo = new CD_MetodosGenerales();


        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "SELECT * FROM PlantillaReposicion";

            leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.CerrarConexion();
            return tabla;
        }


        public List<string> ListaRepuestos()
        {
            return Metodo.GetList("SELECT Descripcion FROM PlantillaReposicion");
        }

        public void Insertar(string repuesto, string cantidad)
        {
            cantidad = cantidad.Replace(",", ".");

            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "insert into PlantillaReposicion (Descripcion, Cantidad)" +
                " values('" + repuesto + "', " + cantidad + ")";
            comando.ExecuteNonQuery();

            conexion.CerrarConexion();
        }

        public void Editar(string repuesto, string cantidad)
        {
            cantidad = cantidad.Replace(",", ".");

            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "UPDATE PlantillaReposicion" +
                                    " SET Cantidad = " + cantidad +
                                    " WHERE Descripcion = '" + repuesto + "'";
            comando.ExecuteNonQuery();

            conexion.CerrarConexion();

        }

        public void Eliminar(string repuesto)
        {
            
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "DELETE FROM PlantillaReposicion" +
                " WHERE Descripcion = '" + repuesto + "'";

            comando.ExecuteNonQuery();

            conexion.CerrarConexion();

        }
        public string Reponer(string equipo)
        {
            string Mensaje = "Se ha aplicado la reposicion a los siguientes repuestos:\n";
            
            int equipoId = Metodo.GetId(equipo, "EquiposDeTrabajo");

            string consultaArticulosDelEquipo = "SELECT Articulos.Descripcion" +
                " FROM Articulos, StocksDeEquipos" +
                " WHERE Articulos.Id = ArticuloId" +
                " AND EquipoId = " + equipoId;

            List<string> articulosDelEquipo = Metodo.GetList(consultaArticulosDelEquipo);

            List<string> plantilla = Metodo.GetList("SELECT Descripcion FROM PlantillaReposicion");

            
            foreach(string repuesto in plantilla)
            {
                int repuestoId = Metodo.GetId(repuesto, "Articulos");

                if(articulosDelEquipo.IndexOf(repuesto) == -1) //cuando no existe el repuesto en el equipo determinado, se crea con valores 0.
                {
                    comando.Connection = conexion.AbrirConexion();

                    comando.CommandText = "INSERT INTO StocksDeEquipos " +
                        "VALUES(" + equipoId +", " + repuestoId + ", 0, 0)";

                    comando.ExecuteNonQuery();

                    conexion.CerrarConexion();
                }
                
                //Se aplica la reposicion al repuesto y se descuenta la cantidad del stock primario.

                comando.Connection = conexion.AbrirConexion();

                comando.CommandText = "SELECT Cantidad FROM StocksDeEquipos WHERE ArticuloId = " + repuestoId + " AND EquipoId = " + equipoId;
                leer = comando.ExecuteReader();
                tabla.Load(leer);

                string cantidadRepuestoEquipo = tabla.Rows[0]["Cantidad"].ToString();

                tabla = new DataTable();

                comando.CommandText = "SELECT Cantidad FROM PlantillaReposicion WHERE Descripcion = '" + repuesto + "'";
                leer = comando.ExecuteReader();
                tabla.Load(leer);

                string cantidadRepuestoPlantilla = tabla.Rows[0]["Cantidad"].ToString();

                tabla = new DataTable();

                float diferenciaDeCantidad = Convert.ToSingle(cantidadRepuestoPlantilla) - Convert.ToSingle(cantidadRepuestoEquipo);

                if (diferenciaDeCantidad > 0)
                {
                    cantidadRepuestoPlantilla = cantidadRepuestoPlantilla.Replace(",", ".");

                    cantidadRepuestoEquipo = cantidadRepuestoEquipo.Replace(",", ".");

                    string cantidadActualStockPrimario = Metodo.GetCantidadArticulo(repuesto);
                    string NuevaCantidadStockPrimario = (Convert.ToSingle(cantidadActualStockPrimario) - diferenciaDeCantidad).ToString();

                    NuevaCantidadStockPrimario = NuevaCantidadStockPrimario.Replace(",", ".");



                    comando.CommandText = "UPDATE StocksDeEquipos" +
                                            " SET Cantidad = " + cantidadRepuestoPlantilla +
                                            " WHERE EquipoId = " + equipoId +
                                            " AND ArticuloId = " + repuestoId;
                    comando.ExecuteNonQuery();


                    comando.CommandText = "UPDATE Articulos" +
                                            " SET Cantidad = " + NuevaCantidadStockPrimario +
                                            " WHERE Id = " + repuestoId;
                    comando.ExecuteNonQuery();



                    Mensaje += "\n- Repuesto: " + repuesto + ", se le sumó " + diferenciaDeCantidad;
                }

                conexion.CerrarConexion();
            }
            if(Mensaje == "Se ha aplicado la reposicion a los siguientes repuestos:\n")
            {
                Mensaje = "No se realizó Reposición a ningun repuesto. Esto ocurre porque el equipo ya cumplia con las cantidades especificadas en la plantilla.";
            }

            return Mensaje;
        }

    }
}
