using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class frmStockSecundario : Form
    {
        CN_StockEquipos objetoCN_StockPorEquipos = new CN_StockEquipos();

        CN_Equipos objetoCN_Equipos = new CN_Equipos();

        
        public frmStockSecundario()
        {
            InitializeComponent();

            //objetoCN_Equipos = new CN_Equipos();

            cbxEquipos.DataSource = objetoCN_Equipos.darListaEquipos("EquiposDeTrabajo").OrderBy(o => o).ToList(); //ordenar alfabéticamente
            cbxEquipos.IntegralHeight = false;

            CargarTabla();
            CrearBotones();
        }


        private void CargarTabla()
        {
            objetoCN_StockPorEquipos = new CN_StockEquipos();            //se crea un objeto de la capa de negocios dentro de este método para que, cuando se salga de el, se borren los datos y así no se concatenen.
            grdArticulosXEquipo.DataSource = objetoCN_StockPorEquipos.MostrarStockPorEquipo(cbxEquipos.Text);                  //inserta la datatable creada en datos, en el DataGridView.



            //redefine el nombre de algunas columnas que, o le faltan tildes o tienen un nombre incorrecto (obtenido de la base de datos)
        }

        public void CrearBotones()
        {
            //define estilos del boton reponer

            DataGridViewButtonColumn consumo_col = new DataGridViewButtonColumn();
            consumo_col.UseColumnTextForButtonValue = true;
            consumo_col.Text = "Consumir";
            consumo_col.FlatStyle = FlatStyle.Popup;

            grdArticulosXEquipo.Columns.Add(consumo_col); //agrega el boton reponer

            //define mas estilos del boton reponer

            
            System.Windows.Forms.DataGridViewCellStyle consumoCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            consumoCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            consumoCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            consumoCellStyle.ForeColor = System.Drawing.Color.Black;
            consumoCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(131)))), ((int)(((byte)(255))))); ;
            consumoCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            consumo_col.DefaultCellStyle = consumoCellStyle; //se añaden esos ultimos estilos al boton anteriormente agregado


            //define estilos del boton reponer

            DataGridViewButtonColumn reponer_col = new DataGridViewButtonColumn();
            reponer_col.UseColumnTextForButtonValue = true;
            reponer_col.Text = "Reponer";
            reponer_col.FlatStyle = FlatStyle.Popup;

            grdArticulosXEquipo.Columns.Add(reponer_col); //agrega el boton reponer

            //define mas estilos del boton reponer

            System.Windows.Forms.DataGridViewCellStyle reponerCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            reponerCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            reponerCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            reponerCellStyle.ForeColor = System.Drawing.Color.Black;
            reponerCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            reponerCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            reponer_col.DefaultCellStyle = reponerCellStyle; //se añaden esos ultimos estilos al boton anteriormente agregado

            //define estilos del boton eliminar

            DataGridViewButtonColumn eliminar_col = new DataGridViewButtonColumn();
            eliminar_col.UseColumnTextForButtonValue = true;
            eliminar_col.Text = "Eliminar";
            eliminar_col.FlatStyle = FlatStyle.Popup;

            grdArticulosXEquipo.Columns.Add(eliminar_col); //agrega el boton eliminar

            //define mas estilos del boton eliminar

            System.Windows.Forms.DataGridViewCellStyle eliminarCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            eliminarCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            eliminarCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            eliminarCellStyle.ForeColor = System.Drawing.Color.Black;
            eliminarCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            eliminarCellStyle.SelectionForeColor = System.Drawing.Color.Black;


            eliminar_col.DefaultCellStyle = eliminarCellStyle; //se añaden esos ultimos estilos al boton anteriormente agredado

            //redefine el nombre de algunas columnas que, o le faltan tildes o tienen un nombre incorrecto (obtenido de la base de datos)

            grdArticulosXEquipo.Columns[1].HeaderText = "Descripción";
            grdArticulosXEquipo.Columns[3].HeaderText = "Unidad";
            grdArticulosXEquipo.Columns[4].HeaderText = "Stock Mínimo";
        }
        
        private void cbxEquipos_SelectedIndexChanged(object sender, EventArgs e) //cuando se selecciona un nuevo equipo en el comboBox
        {
            CargarTabla();
        }

        private void grdArticulosXEquipo_CellContentClick(object sender, DataGridViewCellEventArgs e) //este metodo se llama cuando se hace click en algún boton de la tabla
        {

            if (grdArticulosXEquipo.Columns[e.ColumnIndex].Index == 0) //verifica si es el de Consum, por su columna.
            {
                frmConsumoRepuesto consumo = new frmConsumoRepuesto();
                consumo.Text = "Consumo de Repuesto";
                consumo.CargarDatos(grdArticulosXEquipo.CurrentRow.Cells, cbxEquipos.Text);
                consumo.ShowDialog();
                CargarTabla();
            }

            if (grdArticulosXEquipo.Columns[e.ColumnIndex].Index == 1) //verifica si es el de reponer, por su columna.
            {
                frmReposicion reponer = new frmReposicion(); //instancia el formulario de reposición.
                reponer.Text = "Reponer del inventario";
                reponer.nombreEquipo = cbxEquipos.Text;
                reponer.reponerStockSecundario = true; //esta variable (del formulario frmReposicion) sirve para identificar si la reposicion se está tratando de hacer desde el stock secundario o desde el primario 
                reponer.CargarArticuloReponer(grdArticulosXEquipo.CurrentRow.Cells, "Repuesto"); //llama al metodo que llena el formulario, mandánodole los datos del artículo a editar.
                reponer.ShowDialog();
                CargarTabla();
            }
            
            if (grdArticulosXEquipo.Columns[e.ColumnIndex].Index == 2) //verifica si es el de eliminar, por su columna
            {

                DialogResult dialogResult = MessageBox.Show("¿Esta seguro que quiere eliminar el articulo?\n\nEsta acción devolvera la cantidad del repuesto en este equipo al almacenamiento principal.", "Aviso", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    objetoCN_StockPorEquipos.EliminarArticulo(Convert.ToInt32(grdArticulosXEquipo.CurrentRow.Cells[3].Value), cbxEquipos.Text, grdArticulosXEquipo.CurrentRow.Cells[5].Value.ToString(), grdArticulosXEquipo.CurrentRow.Cells[4].Value.ToString()); //metodo eliminar enviando el id del articulo y el nombre del equipo
                    MessageBox.Show("Articulo eliminado correctamente.", "Operación exitosa");
                }
                else
                    return;

                CargarTabla();
            }
        }

        private void btnSumarRepuesto_Click(object sender, EventArgs e)
        {
            frmAgregarRepuestoaStockSecundario AgregarRepuestoaStockSecundario = new frmAgregarRepuestoaStockSecundario(); //instancia el formulario de reposición.
            AgregarRepuestoaStockSecundario.EnvioEquipo(cbxEquipos.Text);
            AgregarRepuestoaStockSecundario.ShowDialog();
            CargarTabla();

        }

        private void btnNuevoEquipo_Click(object sender, EventArgs e)
        {

            frmCambiarNombreEquipo editarEquipo = new frmCambiarNombreEquipo();

            editarEquipo.Text = "Nuevo Equipo";
            editarEquipo.cambiarNombre = false;
            editarEquipo.ShowDialog();
            cbxEquipos.DataSource = objetoCN_Equipos.darListaEquipos("EquiposDeTrabajo").OrderBy(o => o).ToList(); //ordenar alfabéticamente
            CargarTabla();
        }

        private void btnCambiarNombre_Click(object sender, EventArgs e)
        {
            frmCambiarNombreEquipo editarEquipo = new frmCambiarNombreEquipo(); //instancia el formulario de reposición.
            editarEquipo.EnvioEquipo(cbxEquipos.Text);
            editarEquipo.Text = "Cambiar Nombre";
            editarEquipo.cambiarNombre = true;
            editarEquipo.ShowDialog();
            cbxEquipos.DataSource = objetoCN_Equipos.darListaEquipos("EquiposDeTrabajo").OrderBy(o => o).ToList(); //ordenar alfabéticamente
            CargarTabla();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(objetoCN_Equipos.darListaEquipos("EquiposDeTrabajo").Count > 1)
            {
                for (int i = 0; i < grdArticulosXEquipo.RowCount; i++)
                    objetoCN_StockPorEquipos.EliminarArticulo(Convert.ToInt32(grdArticulosXEquipo.Rows[i].Cells[2].Value), cbxEquipos.Text, grdArticulosXEquipo.Rows[i].Cells[4].Value.ToString(), grdArticulosXEquipo.Rows[i].Cells[3].Value.ToString()); //metodo eliminar enviando el id del articulo y el nombre del equipo

                objetoCN_Equipos.BorrarEquipo(cbxEquipos.Text);
                cbxEquipos.DataSource = objetoCN_Equipos.darListaEquipos("EquiposDeTrabajo").OrderBy(o => o).ToList(); //ordenar alfabéticamente

            }
            else
                MessageBox.Show("Tiene que exisitir al menos un Equipo de Trabajo", "Operación Denegada");



        }
    }
}
