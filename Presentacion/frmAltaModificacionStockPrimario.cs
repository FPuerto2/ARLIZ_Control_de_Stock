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
    public partial class frmAltaModificacionStockPrimario : Form
    {
        CN_Articulos objetoCN = new CN_Articulos(); //objeto de comunicacion con la capa negocio
        public bool editarArticulo = false; //ya que se usa el mismo formulario para editar y para añadir, este booleano sirve para identificar esto mismo
        public string articuloAEditar;

        public frmAltaModificacionStockPrimario()
        {
            InitializeComponent();
            
            cbxClasificacion.DataSource = objetoCN.darListaArticulos("Clasificaciones"); //inserta la lista de clasificaciones en el comboBox clasificaciones

            objetoCN = new CN_Articulos(); //se instancia para borrar cualquier valor previo
            cbxUnidad.DataSource = objetoCN.darListaArticulos("Unidades"); //inserta la lista de unidades en el comboBox unidades

            txtId.Text = objetoCN.ObtenerSiguienteId();
        }
        
        
        public void cargarArticuloEditar(System.Windows.Forms.DataGridViewCellCollection celdas)
        {
            //carga los datos del artículo en el formulario

            txtId.Text = celdas[3].Value.ToString();
            articuloAEditar = txtDescripcion.Text = celdas[4].Value.ToString();
            cbxClasificacion.Text = celdas[5].Value.ToString();
            txtCantidad.Text = celdas[6].Value.ToString();
            cbxUnidad.Text = celdas[7].Value.ToString();
            txtStockMinimo.Text = celdas[8].Value.ToString();
            editarArticulo = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objetoCN = new CN_Articulos();
            try
            {
                txtDescripcion.Text = txtDescripcion.Text.Trim();
                
                #region Comprobaciones

                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("No puede dejar el nombre en blanco", "Error");
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

                //si está en modo Editar (es decir que el booleano es verdadero).

                if (editarArticulo)
                {
                    //se llama al método que edita, enviandole los parametros necesarios.

                    
                    if (objetoCN.Metodo.Existe(txtDescripcion.Text, objetoCN.darListaArticulos("Articulos")) == true && txtDescripcion.Text.ToLower() != articuloAEditar.ToLower()) //se comprueba que no exista un articulo con la misma descripcion.
                    {
                        MessageBox.Show("El articulo ya existe.", "Error");
                        return;
                    }

                    objetoCN.EditarArticulo(txtId.Text, txtDescripcion.Text, cbxClasificacion.Text, cbxUnidad.Text, txtCantidad.Text, txtStockMinimo.Text);
                    MessageBox.Show("¡Se editó el " + cbxClasificacion.Text.ToLower() + " correctamente!", "Operación exitosa");
                }

                //si editarArticulo es false, es decir que se está intentando añadir un artículo.

                else
                {                // ANOTACION: ( == -1) es que no existe, ( != -1 ) es que existe.
                    if (objetoCN.Metodo.Existe(txtDescripcion.Text, objetoCN.darListaArticulos("Articulos")) == true) //se comprueba que no exista un articulo con la misma descripcion.
                    {
                        MessageBox.Show("El articulo ya existe.", "Error");
                        return;
                    }

                    //si no existe un articulo con el mismo nombre se llama al metodo que lo añade, enviandole los parametros necesarios.

                    objetoCN.InsertarArticulo(txtDescripcion.Text, cbxClasificacion.Text, cbxUnidad.Text, txtCantidad.Text, txtStockMinimo.Text);

                    MessageBox.Show("¡Se añadió el nuevo " + cbxClasificacion.Text.ToLower() + " correctamente!", "Operacion exitosa");

                }

                this.Close(); //se cierra el formulario.
            }

            catch(Exception ex) //muestra un mensaje de error en una nueva ventana, permitiendo ver detalles.
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
        
    }
}
