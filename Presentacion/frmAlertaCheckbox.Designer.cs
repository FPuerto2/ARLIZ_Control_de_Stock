namespace Presentacion
{
    partial class frmAlertaCheckbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlertaCheckbox));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnWinClose = new System.Windows.Forms.Button();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkNoMostrarDeNuevo = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(10, 10);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(417, 20);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseDown);
            // 
            // btnWinClose
            // 
            this.btnWinClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWinClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWinClose.FlatAppearance.BorderSize = 0;
            this.btnWinClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWinClose.Image = ((System.Drawing.Image)(resources.GetObject("btnWinClose.Image")));
            this.btnWinClose.Location = new System.Drawing.Point(435, 0);
            this.btnWinClose.Margin = new System.Windows.Forms.Padding(80);
            this.btnWinClose.Name = "btnWinClose";
            this.btnWinClose.Size = new System.Drawing.Size(65, 40);
            this.btnWinClose.TabIndex = 10;
            this.btnWinClose.Text = " ";
            this.btnWinClose.UseVisualStyleBackColor = true;
            this.btnWinClose.Click += new System.EventHandler(this.btnWinClose_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pnlTitleBar.Controls.Add(this.btnWinClose);
            this.pnlTitleBar.Controls.Add(this.lblTitulo);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(500, 40);
            this.pnlTitleBar.TabIndex = 3;
            this.pnlTitleBar.Tag = "";
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoEllipsis = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTexto.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblTexto.Location = new System.Drawing.Point(10, 49);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(475, 102);
            this.lblTexto.TabIndex = 2;
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.chkNoMostrarDeNuevo);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 45);
            this.panel1.TabIndex = 4;
            // 
            // chkNoMostrarDeNuevo
            // 
            this.chkNoMostrarDeNuevo.AutoSize = true;
            this.chkNoMostrarDeNuevo.ForeColor = System.Drawing.Color.Gainsboro;
            this.chkNoMostrarDeNuevo.Location = new System.Drawing.Point(14, 13);
            this.chkNoMostrarDeNuevo.Name = "chkNoMostrarDeNuevo";
            this.chkNoMostrarDeNuevo.Size = new System.Drawing.Size(154, 21);
            this.chkNoMostrarDeNuevo.TabIndex = 1;
            this.chkNoMostrarDeNuevo.Text = "No volver a mostrar";
            this.chkNoMostrarDeNuevo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(391, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(291, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmAlertaCheckbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.lblTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlertaCheckbox";
            this.Text = "frmAlertaCheckbox";
            this.TopMost = true;
            this.pnlTitleBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnWinClose;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkNoMostrarDeNuevo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}