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
    public partial class frmReposicionAutomatica : Form
    {
        CN_PlantillaReposicion objetoCN_Plantilla = new CN_PlantillaReposicion();

        public frmReposicionAutomatica()
        {
            InitializeComponent();
        }
        private void AbrirFormHija(object formHija)
        {
            if (pnlContainer.Controls.Count > 0)
                pnlContainer.Controls.RemoveAt(0);
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(fh);
            pnlContainer.Tag = fh;
            fh.Show();
        }

        private void btnEditarPlantilla_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmReposicionPlantillaStockSec());
        }

        private void btnReposicionAutomatica_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmReposicionElegirEquipo());
        }
    }
}
