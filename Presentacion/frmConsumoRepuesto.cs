using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public partial class frmConsumoRepuesto : Form
    {

        CN_StockEquipos objetoCN = new CN_StockEquipos();

        public string cantidadActual;
        public string equipo;

        public frmConsumoRepuesto()
        {
            InitializeComponent();
        }

        public void CargarDatos(System.Windows.Forms.DataGridViewCellCollection celdas, string nombreEquipo)
        {
            equipo = nombreEquipo;
            txtId.Text = celdas[3].Value.ToString();
            txtRepuesto.Text = celdas[4].Value.ToString();
            cantidadActual = celdas[5].Value.ToString();
        }

        private void btnConsumir_Click(object sender, EventArgs e)
        {

            objetoCN = new CN_StockEquipos();
            try
            {
                #region Comprobacion
                if (Convert.ToSingle(txtCantidad.Text) < 0)
                {
                    MessageBox.Show("No se puede ingresar una cantidad negativa", "Error");
                    return;
                }
                #endregion
                
                if (objetoCN.ConsumirRepuesto(equipo, txtRepuesto.Text, cantidadActual.ToString(), txtCantidad.Text.Replace(".", ",")) == true)
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
