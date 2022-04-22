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
    public partial class frmCambiarNombreEquipo : Form
    {
        CN_Equipos objetoCN_Equipos = new CN_Equipos();
        public string NombreEquipo;
        public bool cambiarNombre = false;

        public frmCambiarNombreEquipo()
        {
            InitializeComponent();
        }
        
        public void EnvioEquipo(string equipo)
        {
            NombreEquipo = txtNombreEquipo.Text = equipo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objetoCN_Equipos = new CN_Equipos();
            try
            {

                txtNombreEquipo.Text = txtNombreEquipo.Text.Trim();

                if (string.IsNullOrWhiteSpace(txtNombreEquipo.Text))
                {
                    MessageBox.Show("No puede dejar el nombre en blanco", "Error");
                    return;
                }

                if (cambiarNombre)
                {
                    if (objetoCN_Equipos.Metodo.Existe(txtNombreEquipo.Text, objetoCN_Equipos.darListaEquipos("EquiposDeTrabajo")) == true && txtNombreEquipo.Text.ToLower() != NombreEquipo.ToLower()) //se comprueba que no exista un articulo con la misma descripcion.
                    {
                        MessageBox.Show("El articulo ya existe.", "Error");
                        return;
                    }

                    objetoCN_Equipos.CambiarNombreEquipo(txtNombreEquipo.Text, NombreEquipo);

                    MessageBox.Show("¡Se cambio el nombre correctamente!", "Operación exitosa");
                }

                //si cambiarNombre es false, es decir que se está intentando añadir un Equipo.

                else
                {                // ANOTACION: ( == -1) es que no existe, ( != -1 ) es que existe.
                    if (objetoCN_Equipos.Metodo.Existe(txtNombreEquipo.Text, objetoCN_Equipos.darListaEquipos("EquiposDeTrabajo")) == true) //se comprueba que no exista un articulo con la misma descripcion.
                    {
                        MessageBox.Show("El Equipo ya existe.", "Error");
                        return;
                    }

                    //si no existe un articulo con el mismo nombre se llama al metodo que lo añade, enviandole los parametros necesarios.

                    objetoCN_Equipos.InsertarEquipo(txtNombreEquipo.Text);

                    MessageBox.Show("¡Se creó el nuevo equipo correctamente!", "Operacion exitosa");

                }
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
