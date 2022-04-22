namespace Presentacion
{
    partial class frmMainWin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainWin));
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnWinRestore = new System.Windows.Forms.Button();
            this.btnWinMaximize = new System.Windows.Forms.Button();
            this.btnWinClose = new System.Windows.Forms.Button();
            this.btnWinMinimize = new System.Windows.Forms.Button();
            this.btnStckPrmr = new System.Windows.Forms.Button();
            this.btnStckScndr = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlAsideMenu = new System.Windows.Forms.Panel();
            this.btnRpscn = new System.Windows.Forms.Button();
            this.btnAuditLog = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTitleBar.SuspendLayout();
            this.pnlAsideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pnlTitleBar.Controls.Add(this.btnWinRestore);
            this.pnlTitleBar.Controls.Add(this.btnWinMaximize);
            this.pnlTitleBar.Controls.Add(this.btnWinClose);
            this.pnlTitleBar.Controls.Add(this.btnWinMinimize);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1200, 40);
            this.pnlTitleBar.TabIndex = 0;
            this.pnlTitleBar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDoubleClick);
            this.pnlTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            // 
            // btnWinRestore
            // 
            this.btnWinRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWinRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWinRestore.FlatAppearance.BorderSize = 0;
            this.btnWinRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWinRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnWinRestore.Image")));
            this.btnWinRestore.Location = new System.Drawing.Point(1070, 0);
            this.btnWinRestore.Margin = new System.Windows.Forms.Padding(0);
            this.btnWinRestore.Name = "btnWinRestore";
            this.btnWinRestore.Size = new System.Drawing.Size(65, 40);
            this.btnWinRestore.TabIndex = 9;
            this.btnWinRestore.Text = " ";
            this.btnWinRestore.UseVisualStyleBackColor = true;
            this.btnWinRestore.Visible = false;
            this.btnWinRestore.Click += new System.EventHandler(this.btnWinRestore_Click);
            // 
            // btnWinMaximize
            // 
            this.btnWinMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWinMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWinMaximize.FlatAppearance.BorderSize = 0;
            this.btnWinMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWinMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnWinMaximize.Image")));
            this.btnWinMaximize.Location = new System.Drawing.Point(1070, 0);
            this.btnWinMaximize.Margin = new System.Windows.Forms.Padding(80);
            this.btnWinMaximize.Name = "btnWinMaximize";
            this.btnWinMaximize.Size = new System.Drawing.Size(65, 40);
            this.btnWinMaximize.TabIndex = 6;
            this.btnWinMaximize.UseVisualStyleBackColor = true;
            this.btnWinMaximize.Click += new System.EventHandler(this.btnWinMaximize_Click);
            // 
            // btnWinClose
            // 
            this.btnWinClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWinClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWinClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnWinClose.FlatAppearance.BorderSize = 0;
            this.btnWinClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnWinClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnWinClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWinClose.Image = ((System.Drawing.Image)(resources.GetObject("btnWinClose.Image")));
            this.btnWinClose.Location = new System.Drawing.Point(1135, 0);
            this.btnWinClose.Margin = new System.Windows.Forms.Padding(80);
            this.btnWinClose.Name = "btnWinClose";
            this.btnWinClose.Size = new System.Drawing.Size(65, 40);
            this.btnWinClose.TabIndex = 10;
            this.btnWinClose.Text = " ";
            this.btnWinClose.UseVisualStyleBackColor = true;
            this.btnWinClose.Click += new System.EventHandler(this.btnWinClose_Click);
            // 
            // btnWinMinimize
            // 
            this.btnWinMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWinMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWinMinimize.FlatAppearance.BorderSize = 0;
            this.btnWinMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWinMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnWinMinimize.Image")));
            this.btnWinMinimize.Location = new System.Drawing.Point(1005, 0);
            this.btnWinMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnWinMinimize.Name = "btnWinMinimize";
            this.btnWinMinimize.Size = new System.Drawing.Size(65, 40);
            this.btnWinMinimize.TabIndex = 7;
            this.btnWinMinimize.Text = " ";
            this.btnWinMinimize.UseVisualStyleBackColor = true;
            this.btnWinMinimize.Click += new System.EventHandler(this.btnWinMinimize_Click);
            // 
            // btnStckPrmr
            // 
            this.btnStckPrmr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStckPrmr.BackColor = System.Drawing.Color.Transparent;
            this.btnStckPrmr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStckPrmr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(244)))));
            this.btnStckPrmr.FlatAppearance.BorderSize = 2;
            this.btnStckPrmr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.btnStckPrmr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(244)))));
            this.btnStckPrmr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStckPrmr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStckPrmr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStckPrmr.Location = new System.Drawing.Point(6, 354);
            this.btnStckPrmr.Margin = new System.Windows.Forms.Padding(3, 3, 3, 13);
            this.btnStckPrmr.Name = "btnStckPrmr";
            this.btnStckPrmr.Size = new System.Drawing.Size(365, 50);
            this.btnStckPrmr.TabIndex = 0;
            this.btnStckPrmr.Text = "Stock Primario";
            this.btnStckPrmr.UseVisualStyleBackColor = false;
            this.btnStckPrmr.Click += new System.EventHandler(this.btnStckPrmr_Click);
            // 
            // btnStckScndr
            // 
            this.btnStckScndr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStckScndr.BackColor = System.Drawing.Color.Transparent;
            this.btnStckScndr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStckScndr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(244)))));
            this.btnStckScndr.FlatAppearance.BorderSize = 2;
            this.btnStckScndr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.btnStckScndr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(244)))));
            this.btnStckScndr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStckScndr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStckScndr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStckScndr.Location = new System.Drawing.Point(6, 420);
            this.btnStckScndr.Margin = new System.Windows.Forms.Padding(3, 3, 3, 13);
            this.btnStckScndr.Name = "btnStckScndr";
            this.btnStckScndr.Size = new System.Drawing.Size(365, 50);
            this.btnStckScndr.TabIndex = 1;
            this.btnStckScndr.Text = "Stock Secundario";
            this.btnStckScndr.UseVisualStyleBackColor = false;
            this.btnStckScndr.Click += new System.EventHandler(this.btnStckScndr_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnConfig.FlatAppearance.BorderSize = 2;
            this.btnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(113)))));
            this.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfig.Location = new System.Drawing.Point(6, 552);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(3, 3, 3, 13);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(365, 40);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.Text = "Configuración";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Visible = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAyuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyuda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(163)))), ((int)(((byte)(185)))));
            this.btnAyuda.FlatAppearance.BorderSize = 2;
            this.btnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(200)))), ((int)(((byte)(217)))));
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(163)))), ((int)(((byte)(185)))));
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAyuda.Location = new System.Drawing.Point(6, 552);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(3, 3, 3, 13);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(91, 40);
            this.btnAyuda.TabIndex = 4;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Visible = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(6, 608);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 3, 3, 13);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(365, 40);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlAsideMenu
            // 
            this.pnlAsideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.pnlAsideMenu.Controls.Add(this.pictureBox1);
            this.pnlAsideMenu.Controls.Add(this.btnRpscn);
            this.pnlAsideMenu.Controls.Add(this.btnSalir);
            this.pnlAsideMenu.Controls.Add(this.btnAyuda);
            this.pnlAsideMenu.Controls.Add(this.btnConfig);
            this.pnlAsideMenu.Controls.Add(this.btnAuditLog);
            this.pnlAsideMenu.Controls.Add(this.btnStckScndr);
            this.pnlAsideMenu.Controls.Add(this.btnStckPrmr);
            this.pnlAsideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAsideMenu.Location = new System.Drawing.Point(0, 40);
            this.pnlAsideMenu.Name = "pnlAsideMenu";
            this.pnlAsideMenu.Size = new System.Drawing.Size(377, 660);
            this.pnlAsideMenu.TabIndex = 1;
            // 
            // btnRpscn
            // 
            this.btnRpscn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRpscn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(244)))));
            this.btnRpscn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRpscn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(244)))));
            this.btnRpscn.FlatAppearance.BorderSize = 0;
            this.btnRpscn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(160)))), ((int)(((byte)(249)))));
            this.btnRpscn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.btnRpscn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRpscn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRpscn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRpscn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRpscn.Location = new System.Drawing.Point(6, 288);
            this.btnRpscn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 13);
            this.btnRpscn.Name = "btnRpscn";
            this.btnRpscn.Size = new System.Drawing.Size(365, 50);
            this.btnRpscn.TabIndex = 9;
            this.btnRpscn.Text = "Reposición Automática";
            this.btnRpscn.UseVisualStyleBackColor = false;
            this.btnRpscn.Click += new System.EventHandler(this.btnRpscn_Click);
            // 
            // btnAuditLog
            // 
            this.btnAuditLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAuditLog.BackColor = System.Drawing.Color.Transparent;
            this.btnAuditLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAuditLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(244)))));
            this.btnAuditLog.FlatAppearance.BorderSize = 2;
            this.btnAuditLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.btnAuditLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(244)))));
            this.btnAuditLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuditLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuditLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAuditLog.Location = new System.Drawing.Point(6, 486);
            this.btnAuditLog.Margin = new System.Windows.Forms.Padding(3, 3, 3, 13);
            this.btnAuditLog.Name = "btnAuditLog";
            this.btnAuditLog.Size = new System.Drawing.Size(365, 50);
            this.btnAuditLog.TabIndex = 2;
            this.btnAuditLog.Text = "Registro de Acciones";
            this.btnAuditLog.UseVisualStyleBackColor = false;
            this.btnAuditLog.Visible = false;
            this.btnAuditLog.Click += new System.EventHandler(this.btnAuditLog_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(377, 40);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(823, 660);
            this.pnlContainer.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10, 10, 15, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlAsideMenu);
            this.Controls.Add(this.pnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainWin";
            this.Text = "ARLIZ- Control De Inventario";
            this.Load += new System.EventHandler(this.frmMainWin_Load);
            this.Resize += new System.EventHandler(this.frmMainWin_Resize);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlAsideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Button btnWinMaximize;
        private System.Windows.Forms.Button btnWinClose;
        private System.Windows.Forms.Button btnWinRestore;
        private System.Windows.Forms.Button btnWinMinimize;
        private System.Windows.Forms.Button btnStckPrmr;
        private System.Windows.Forms.Button btnStckScndr;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlAsideMenu;
        private System.Windows.Forms.Button btnRpscn;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnAuditLog;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

