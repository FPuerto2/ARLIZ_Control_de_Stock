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
    public partial class frmConsumoElemento : Form
    {
        CN_Articulos objetoCN = new CN_Articulos();
        public string cantidadActual;

        public frmConsumoElemento()
        {
            InitializeComponent();
            CN_Articulos objetoCN = new CN_Articulos();
            cbxElementos.DataSource = objetoCN.darListaElementos("Articulos").OrderBy(o => o).ToList(); //ordenar alfabéticamente
            cbxElementos.IntegralHeight = false; //se deshabilita este booleano para que, al introducir nuevos valores al comboBox, este los limite, dandole un desplazamiento.
        }

        private void cbxElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cantidadActual = objetoCN.ArticuloCantidad(cbxElementos.Text);
            lblCantidadActual.Text = "Cantidad Actual: " + cantidadActual;

        }

        private void btnRegistrarConsumo_Click(object sender, EventArgs e)
        {
            objetoCN = new CN_Articulos();
            try
            {
                cbxElementos.Text = cbxElementos.Text.Trim();
                
                #region Comprobacion
                if (Convert.ToSingle(txtCantidad.Text) < 0)
                {
                    MessageBox.Show("No se puede ingresar una cantidad negativa", "Error");
                    return;
                }
                #endregion

                if (objetoCN.Metodo.Existe(cbxElementos.Text, objetoCN.darListaArticulos("Articulos")) == false)
                {
                    MessageBox.Show("El Articulo no existe.", "Error");
                    return;
                }

                if (objetoCN.ConsumirElemento(cbxElementos.Text, cantidadActual.ToString(), txtCantidad.Text.Replace(".", ",")) == true)
                    MessageBox.Show("¡Consumo Registrado Exitosamente!", "Operacion exitosa");
                else
                    MessageBox.Show("El consumo que esta intentando registrar es mayor a la cantidad almacenada en su inventario.", "Error");


                this.Close();
            }

            catch (Exception ex)
            {
                var dialogTypeName = "System.Windows.Forms.PropertyGridInternal.GridErrorDlg";
                var dialogType = typeof(Form).Assembly.GetType(dialogTypeName);

                // Create dialog instance.
                var dialog = (Form)Activator.CreateInstance(dialogType, new PropertyGrid());

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
