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
    public partial class frmAgregarRepuestoaStockSecundario : Form
    {

        CN_StockEquipos objetoCN_StockPorEquipos = new CN_StockEquipos();

        CN_Equipos objetoCN_Equipos = new CN_Equipos();

        public bool editarArticulo = false; //ya que se usa el mismo formulario para editar y para añadir, este booleano sirve para identificar esto mismo
        public string articuloAEditar;

        public frmAgregarRepuestoaStockSecundario()
        {
            InitializeComponent();
            
            cbxEquipo.DataSource = objetoCN_Equipos.darListaEquipos("EquiposDeTrabajo"); //inserta la lista de clasificaciones en el comboBox clasificaciones

            cbxDescripcion.DataSource = objetoCN_StockPorEquipos.darListaRepuestos("Articulos"); //inserta la lista de unidades en el comboBox unidades

            cbxDescripcion.IntegralHeight = cbxEquipo.IntegralHeight = false;
        }

        public void EnvioEquipo(string equipo)
        {
            cbxEquipo.Text = equipo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            objetoCN_StockPorEquipos = new CN_StockEquipos();
            try
            {
                cbxEquipo.Text = cbxEquipo.Text.Trim();

                #region Comprobaciones
                if (objetoCN_Equipos.Metodo.Existe(cbxEquipo.Text, objetoCN_Equipos.darListaEquipos("EquiposDeTrabajo")) == false)
                {
                    MessageBox.Show("El Equipo no existe.", "Error");
                    return;
                }

                if (objetoCN_StockPorEquipos.Metodo.Existe(cbxDescripcion.Text, objetoCN_StockPorEquipos.darListaRepuestos("Articulos")) == false)
                {
                    MessageBox.Show("El repuesto no existe en el almacenamiento principal.", "Error");
                    return;
                }

                if (objetoCN_StockPorEquipos.Metodo.Existe(cbxDescripcion.Text, objetoCN_StockPorEquipos.darListaRepuestosPorEquipos(cbxEquipo.Text)) == true) //se comprueba que no exista un articulo con la misma descripcion.
                {
                    MessageBox.Show("El repuesto ya se encuentra en el Equipo.", "Error");
                    return;
                }

                if (Convert.ToSingle(txtCantidad.Text) < 0)
                {
                    MessageBox.Show("No se puede ingresar una cantidad negativa", "Error");
                    return;
                }

                if (Convert.ToSingle(txtStockMinimo.Text) < 0)
                {
                    MessageBox.Show("No se puede ingresar un stock mínimo negativo", "Error");
                    return;
                }
                

                #endregion

                //si editarArticulo es false, es decir que se está intentando añadir un artículo.


                //si no existe un articulo con el mismo nombre se llama al metodo que lo añade, enviandole los parametros necesarios.
               
                bool insertado = objetoCN_StockPorEquipos.InsertarRepuesto(cbxEquipo.Text, cbxDescripcion.Text, txtCantidad.Text, txtStockMinimo.Text);
                
                if(insertado == false)
                {
                    MessageBox.Show("La cantidad que se esta intentando registrar es mayor a la cantidad almacenada en su inventario", "Error");
                    return;
                }

                MessageBox.Show("¡Se agregó el repuesto correctamente!", "Operacion exitosa");

                this.Close(); //se cierra el formulario.
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

        private void cbxDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtId.Text = objetoCN_StockPorEquipos.ObtenerId(cbxDescripcion.Text).ToString();
        }
    }
}

