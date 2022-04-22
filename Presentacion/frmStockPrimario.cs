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
    public partial class frmStockPrimario : Form
    {
        CN_Articulos objetoCN = new CN_Articulos(); //objeto de comunicación con la capa de negocio.

        private void CargarTabla() 
        {
            CN_Articulos objeto = new CN_Articulos(); //se crea un objeto de la capa de negocios dentro de este método para que, cuando se salga de el, se borren los datos y así no se concatenen.
            grdArticulos.DataSource = objeto.MostrarArticulos(); //inserta la datatable creada en datos, en el DataGridView.
        }

        public void CrearBotones()
        {

            //define estilos del boton editar

            DataGridViewButtonColumn reponer_col = new DataGridViewButtonColumn();
            reponer_col.UseColumnTextForButtonValue = true;
            reponer_col.Text = "Reponer";
            reponer_col.FlatStyle = FlatStyle.Popup;

            grdArticulos.Columns.Add(reponer_col); //agrega el boton reponer

            //define mas estilos del boton reponer

            System.Windows.Forms.DataGridViewCellStyle reponerCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            reponerCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            reponerCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            reponerCellStyle.ForeColor = System.Drawing.Color.Black;
            reponerCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            reponerCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            reponer_col.DefaultCellStyle = reponerCellStyle; //se añaden esos ultimos estilos al boton anteriormente agregado

            //define estilos del boton editar

            DataGridViewButtonColumn editar_col = new DataGridViewButtonColumn();
            editar_col.UseColumnTextForButtonValue = true;
            editar_col.Text = "Editar";
            editar_col.FlatStyle = FlatStyle.Popup;

            grdArticulos.Columns.Add(editar_col); //agrega el boton editar

            //define mas estilos del boton editar

            System.Windows.Forms.DataGridViewCellStyle editarCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            editarCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            editarCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(211)))), ((int)(((byte)(243)))));
            editarCellStyle.ForeColor = System.Drawing.Color.Black;
            editarCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(211)))), ((int)(((byte)(243)))));
            editarCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            editar_col.DefaultCellStyle = editarCellStyle; //se añaden esos ultimos estilos al boton anteriormente agregado

            //define estilos del boton eliminar

            DataGridViewButtonColumn eliminar_col = new DataGridViewButtonColumn();
            eliminar_col.UseColumnTextForButtonValue = true;
            eliminar_col.Text = "Eliminar";
            eliminar_col.FlatStyle = FlatStyle.Popup;

            grdArticulos.Columns.Add(eliminar_col); //agrega el boton eliminar

            //define mas estilos del boton eliminar

            System.Windows.Forms.DataGridViewCellStyle eliminarCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            eliminarCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            eliminarCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            eliminarCellStyle.ForeColor = System.Drawing.Color.Black;
            eliminarCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            eliminarCellStyle.SelectionForeColor = System.Drawing.Color.Black;


            eliminar_col.DefaultCellStyle = eliminarCellStyle; //se añaden esos ultimos estilos al boton anteriormente agredado

            //redefine el nombre de algunas columnas que, o le faltan tildes o tienen un nombre incorrecto (obtenido de la base de datos)

            grdArticulos.Columns[1].HeaderText = "Descripción";
            grdArticulos.Columns[2].HeaderText = "Clasificación";
            grdArticulos.Columns[4].HeaderText = "Unidad";
            grdArticulos.Columns[5].HeaderText = "Stock Mínimo";
        }

        public frmStockPrimario()
        {
            InitializeComponent();
            CargarTabla();
            CrearBotones();
        }

        private void btnAniadir_Click(object sender, EventArgs e)
        {
            frmAltaModificacionStockPrimario aniadir = new frmAltaModificacionStockPrimario();
            aniadir.editarArticulo = false;
            aniadir.Text = "Nuevo Articulo";

            aniadir.ShowDialog();
            CargarTabla(); //recarga la tabla con los nuevos datos
        }

        private void grdArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e) //cuando se presiona en los botones editar o eliminar.
        {
            if (grdArticulos.Columns[e.ColumnIndex].Index == 0) //verifica si es el de editar por su columna.
            {
                frmReposicion reponer = new frmReposicion(); //instancia el formulario alta de articulo.
                reponer.CargarArticuloReponer(grdArticulos.CurrentRow.Cells, "Articulo"); //llama al metodo que llena el formulario, mandánodole los datos del artículo a editar.
                reponer.Text = "Reponer Articulo";
                reponer.ShowDialog();
                CargarTabla();
            }

            if (grdArticulos.Columns[e.ColumnIndex].Index == 1) //verifica si es el de editar por su columna.
            {
                frmAltaModificacionStockPrimario editar = new frmAltaModificacionStockPrimario(); //instancia el formulario alta de articulo.
                editar.cargarArticuloEditar(grdArticulos.CurrentRow.Cells); //llama al metodo que llena el formulario, mandánodole los datos del artículo a editar.
                editar.editarArticulo = true;
                editar.Text = "Editar Articulo";
                editar.ShowDialog();
                CargarTabla();
            }

            if (grdArticulos.Columns[e.ColumnIndex].Index == 2) //verifica si es el de eliminar por su columna
            {

                DialogResult dialogResult = MessageBox.Show("¿Esta seguro que quiere eliminar el articulo?", "Aviso", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    objetoCN.EliminarArticulo(Convert.ToInt32(grdArticulos.CurrentRow.Cells[3].Value)); //metodo eliminar enviando el id
                    MessageBox.Show("Articulo eliminado correctamente.", "Operación exitosa");
                }
                else
                    return;

                CargarTabla();
            }
        }

        private void btnReponer_Click(object sender, EventArgs e)
        {
            Form reponer = new frmReposicion();
            reponer.ShowDialog();
            CargarTabla(); //recarga la tabla con los nuevos datos
        }
        

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnConsumo_Click(object sender, EventArgs e)
        {
            frmConsumoElemento consumo = new frmConsumoElemento();
            consumo.ShowDialog();
            CargarTabla();
        }
    }
}
