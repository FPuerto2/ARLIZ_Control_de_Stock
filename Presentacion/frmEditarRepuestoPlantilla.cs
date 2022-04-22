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
    public partial class frmEditarRepuestoPlantilla : Form
    {
        CN_PlantillaReposicion objetoCN_Plantilla = new CN_PlantillaReposicion();

        public void cargarRepuestoEditar(System.Windows.Forms.DataGridViewCellCollection celdas)
        {
            txtRepuesto.Text = celdas[2].Value.ToString();
            txtCantidad.Text = celdas[3].Value.ToString();
        }

        public frmEditarRepuestoPlantilla()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            objetoCN_Plantilla = new CN_PlantillaReposicion();
            try
            {

                #region Comprobaciones

                if (Convert.ToSingle(txtCantidad.Text) < 0)
                {
                    MessageBox.Show("No se puede ingresar una cantidad negativa", "Error");
                    return;
                }
                
                #endregion

                //si está en modo Editar (es decir que el booleano es verdadero).
                
                
                objetoCN_Plantilla.EditarRepuestoPlantilla(txtRepuesto.Text, txtCantidad.Text);
                MessageBox.Show("¡Se editó el repuesto correctamente!", "Operación exitosa");
                

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
    }
}
