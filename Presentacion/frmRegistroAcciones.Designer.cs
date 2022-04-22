namespace Presentacion
{
    partial class frmRegistroAcciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtRegistroAcciones = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.lblTitle.Size = new System.Drawing.Size(823, 87);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Registro de Acciones";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRegistroAcciones
            // 
            this.txtRegistroAcciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegistroAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.txtRegistroAcciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegistroAcciones.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtRegistroAcciones.Location = new System.Drawing.Point(8, 103);
            this.txtRegistroAcciones.Multiline = true;
            this.txtRegistroAcciones.Name = "txtRegistroAcciones";
            this.txtRegistroAcciones.ReadOnly = true;
            this.txtRegistroAcciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRegistroAcciones.Size = new System.Drawing.Size(803, 545);
            this.txtRegistroAcciones.TabIndex = 10;
            // 
            // frmRegistroAcciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(823, 660);
            this.Controls.Add(this.txtRegistroAcciones);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroAcciones";
            this.Text = "frmRegistroAuditoria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtRegistroAcciones;
    }
}