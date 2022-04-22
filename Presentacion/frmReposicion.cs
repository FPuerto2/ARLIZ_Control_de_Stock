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
    public partial class frmReposicion : Form
    {
        CN_Articulos objetoCN = new CN_Articulos(); //objeto de comunicacion con la capa de negocio

        public string nombreEquipo;
        public string cantidadActual;
        public bool reponerStockSecundario = false; //esta variable sirve para identificar si la reposicion se está tratando de hacer desde el stock secundario o desde el primario


        public frmReposicion()
        {
            InitializeComponent();
        }

        public void CargarArticuloReponer(System.Windows.Forms.DataGridViewCellCollection celdas, string tipo)
        {
            lblArticulo.Text = tipo;

            if(reponerStockSecundario == true)
            {
                txtId.Text = celdas[3].Value.ToString();
                txtArticulo.Text = celdas[4].Value.ToString();
                cantidadActual = celdas[5].Value.ToString();
                return;
            }
            txtId.Text = celdas[3].Value.ToString();
            txtArticulo.Text = celdas[4].Value.ToString();
            cantidadActual = celdas[6].Value.ToString();
        }

        private void btnReponer_Click(object sender, EventArgs e)
        {
            objetoCN = new CN_Articulos();
            try
            {
                #region Comprobacion
                if (Convert.ToSingle(txtCantidad.Text) < 0)
                {
                    MessageBox.Show("No se puede ingresar una cantidad negativa", "Error");
                    return;
                }
                #endregion

                if (objetoCN.Metodo.Existe(txtArticulo.Text, objetoCN.darListaArticulos("Articulos")) == false)
                {
                    MessageBox.Show("El Articulo no existe.", "Error");
                    return;
                }

                if(reponerStockSecundario == true)
                {
                    CN_StockEquipos objetoCN_StockEquipos = new CN_StockEquipos();

                    if(objetoCN_StockEquipos.ReponerStockSecundario(txtId.Text, txtArticulo.Text, cantidadActual, txtCantidad.Text.Replace(".", ","), nombreEquipo) == true)
                        MessageBox.Show("¡Consumo Registrado Exitosamente!", "Operacion exitosa");

                    else
                        MessageBox.Show("El consumo que esta intentando registrar es mayor a la cantidad almacenada en su inventario.", "Error");
                }

                else
                {
                    objetoCN.ReponerArticulo(txtId.Text, cantidadActual, txtCantidad.Text.Replace(".", ","));
                    MessageBox.Show("¡Se repuso el articulo correctamente!", "Operación exitosa");
                }

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
