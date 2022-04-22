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
    public partial class frmReposicionPlantillaStockSec : Form
    {

        CN_StockEquipos objetoCN_StockPorEquipos = new CN_StockEquipos();

        CN_Equipos objetoCN_Equipos = new CN_Equipos();

        CN_PlantillaReposicion objetoCN_Plantilla = new CN_PlantillaReposicion();
        
        public frmReposicionPlantillaStockSec()
        {
            InitializeComponent();
            cbxRepuestos.DataSource = objetoCN_StockPorEquipos.darListaRepuestos("Articulos");
            CargarTabla();
            CrearBotones();
        }


        public void CrearBotones()
        {
            
            //define estilos del boton editar

            DataGridViewButtonColumn editar_col = new DataGridViewButtonColumn();
            editar_col.UseColumnTextForButtonValue = true;
            editar_col.Text = "Editar";
            editar_col.FlatStyle = FlatStyle.Popup;

            grdPlantilla.Columns.Add(editar_col); //agrega el boton editar

            //define mas estilos del boton editar

            System.Windows.Forms.DataGridViewCellStyle editarCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            editarCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            editarCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(211)))), ((int)(((byte)(243)))));
            editarCellStyle.ForeColor = System.Drawing.Color.Black;
            editarCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(211)))), ((int)(((byte)(243)))));
            editarCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            editar_col.DefaultCellStyle = editarCellStyle; //se añaden esos ultimos estilos al boton anteriormente agregado
            editar_col.Width = 50;
            //define estilos del boton eliminar

            DataGridViewButtonColumn eliminar_col = new DataGridViewButtonColumn();
            eliminar_col.UseColumnTextForButtonValue = true;
            eliminar_col.Text = "Eliminar";
            eliminar_col.FlatStyle = FlatStyle.Popup;


            grdPlantilla.Columns.Add(eliminar_col); //agrega el boton eliminar

            //define mas estilos del boton eliminar

            System.Windows.Forms.DataGridViewCellStyle eliminarCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            eliminarCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            eliminarCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            eliminarCellStyle.ForeColor = System.Drawing.Color.Black;
            eliminarCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            eliminarCellStyle.SelectionForeColor = System.Drawing.Color.Black;


            eliminar_col.DefaultCellStyle = eliminarCellStyle; //se añaden esos ultimos estilos al boton anteriormente agredado
            eliminar_col.Width = 50;
            //redefine el nombre de algunas columnas que, o le faltan tildes o tienen un nombre incorrecto (obtenido de la base de datos)
            
        }


        private void CargarTabla()
        {
            objetoCN_Plantilla = new CN_PlantillaReposicion(); //se crea un objeto de la capa de negocios dentro de este método para que, cuando se salga de el, se borren los datos y así no se concatenen.
            grdPlantilla.DataSource = objetoCN_Plantilla.MostrarPlantilla(); //inserta la datatable creada en datos, en el DataGridView.
        }



        private void btnAniadir_Click(object sender, EventArgs e)
        {

            objetoCN_StockPorEquipos = new CN_StockEquipos();
            try
            {
                #region Comprobaciones
                
                if (objetoCN_StockPorEquipos.Metodo.Existe(cbxRepuestos.Text, objetoCN_StockPorEquipos.darListaRepuestos("Articulos")) == false)
                {
                    MessageBox.Show("El repuesto no existe en el almacenamiento principal.", "Error");
                    return;
                }
                
                if (Convert.ToSingle(txtCantidad.Text) < 0)
                {
                    MessageBox.Show("No se puede ingresar una cantidad negativa", "Error");
                    return;
                }
                
                if (objetoCN_Plantilla.Metodo.Existe(cbxRepuestos.Text, objetoCN_Plantilla.darListaRepuestosPlantilla()) == true)
                {
                    MessageBox.Show("El Articulo ya se encuentra en la plantilla.", "Error");
                    return;
                }

                #endregion

                objetoCN_Plantilla.AgregarRepuesto(cbxRepuestos.Text, txtCantidad.Text);

                CargarTabla();
            }

            catch (Exception ex) //muestra un mensaje de error en una nueva ventana, permitiendo ver detalles.
            {
                var dialogTypeName = "System.Windows.Forms.PropertyGridInternal.GridErrorDlg";
                var dialogType = typeof(Form).Assembly.GetType(dialogTypeName);


                // Create dialog instance.
                var dialog = (Form)Activator.CreateInstance(dialogType, new PropertyGrid());

                var aceptBtn = dialog.Controls.Find("okBtn", true);
                aceptBtn[0].Visible = false;

                var cancelBtn = dialog.Controls.Find("cancelBtn", true);
                cancelBtn[0].Text = "Aceptar";

                // Populate relevant properties on the dialog instance.
                dialog.Text = "Ha ocurrido un error.";
                dialogType.GetProperty("Details").SetValue(dialog, ex.ToString(), null);
                dialogType.GetProperty("Message").SetValue(dialog, "Ha ocurrido un error, revisa los datos ingresados.", null);

                // Display dialog.
                var result = dialog.ShowDialog();
            }
        }

        private void grdPlantilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (grdPlantilla.Columns[e.ColumnIndex].Index == 0) //verifica si es el de editar por su columna.
            {
                frmEditarRepuestoPlantilla editar = new frmEditarRepuestoPlantilla(); //instancia el formulario alta de articulo.
                editar.cargarRepuestoEditar(grdPlantilla.CurrentRow.Cells); //llama al metodo que llena el formulario, mandánodole los datos del artículo a editar.
                editar.ShowDialog();
                CargarTabla();
            }

            if (grdPlantilla.Columns[e.ColumnIndex].Index == 1) //verifica si es el de eliminar por su columna
            {

                DialogResult dialogResult = MessageBox.Show("¿Esta seguro que quiere eliminar el articulo?", "Aviso", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    objetoCN_Plantilla.EliminarRepuesto(grdPlantilla.CurrentRow.Cells[2].Value.ToString()); //metodo eliminar enviando el id
                    MessageBox.Show("Articulo eliminado correctamente.", "Operación exitosa");
                }
                else
                    return;

                CargarTabla();
            }
        }
    }
}
