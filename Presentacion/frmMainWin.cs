using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class frmMainWin : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public frmMainWin()
        {
            InitializeComponent();
        }

        private void frmMainWin_Load(object sender, EventArgs e)
        {
            btnInicio_Click(null, e);
            btnWinMaximize_Click(null, e);
        }

        private void btnWinClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWinRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnWinRestore.Visible = false;
            btnWinMaximize.Visible = true;
        }

        private void btnWinMaximize_Click(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            btnWinMaximize.Visible = false;
            btnWinRestore.Visible = true;
        }

        private void btnWinMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void AbrirFormHija(object formHija)
        {
            if (this.pnlContainer.Controls.Count > 0)
                this.pnlContainer.Controls.RemoveAt(0);
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContainer.Controls.Add(fh);
            this.pnlContainer.Tag = fh;
            fh.Show();
        }
        
            

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmInicio());
        }
        
        private void btnStckPrmr_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmStockPrimario());

        }

        private void btnStckScndr_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmStockSecundario());

        }

        private void btnAuditLog_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmRegistroAcciones());

        }
        
        private void btnConfig_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmConfiguracion());

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmAyuda());

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMainWin_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                return;
            btnWinRestore.Visible = false;
            btnWinMaximize.Visible = true;
        }

        private void pnlTitleBar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                btnWinRestore_Click(sender, e);

            else
                btnWinMaximize_Click(sender, e);
        }

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRpscn_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmReposicionAutomatica());

        }
    }
}
