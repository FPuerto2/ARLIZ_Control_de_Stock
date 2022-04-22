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
    public partial class frmReposicionElegirEquipo : Form
    {
        CN_Equipos objetoCN_Equipos = new CN_Equipos();
        CN_PlantillaReposicion objetoCN_Plantilla = new CN_PlantillaReposicion();


        public frmReposicionElegirEquipo()
        {
            InitializeComponent();

            cbxEquipo.DataSource = objetoCN_Equipos.darListaEquipos("EquiposDeTrabajo"); //inserta la lista de clasificaciones en el comboBox clasificaciones


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string reposicion = objetoCN_Plantilla.AplicarReposicion(cbxEquipo.Text);

                MessageBox.Show(reposicion, "Reposición Exitosa");
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
