namespace Presentacion
{
    partial class frmReposicionAutomatica
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
            this.btnReposicionAutomatica = new System.Windows.Forms.Button();
            this.btnEditarPlantilla = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReposicionAutomatica
            // 
            this.btnReposicionAutomatica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReposicionAutomatica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnReposicionAutomatica.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(219)))), ((int)(((byte)(127)))));
            this.btnReposicionAutomatica.FlatAppearance.BorderSize = 2;
            this.btnReposicionAutomatica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(230)))), ((int)(((byte)(164)))));
            this.btnReposicionAutomatica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(219)))), ((int)(((byte)(127)))));
            this.btnReposicionAutomatica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReposicionAutomatica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReposicionAutomatica.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReposicionAutomatica.Location = new System.Drawing.Point(3, 3);
            this.btnReposicionAutomatica.Name = "btnReposicionAutomatica";
            this.btnReposicionAutomatica.Size = new System.Drawing.Size(395, 77);
            this.btnReposicionAutomatica.TabIndex = 13;
            this.btnReposicionAutomatica.Text = "Reposicion Automatica de Stock Secundario";
            this.btnReposicionAutomatica.UseVisualStyleBackColor = false;
            this.btnReposicionAutomatica.Click += new System.EventHandler(this.btnReposicionAutomatica_Click);
            // 
            // btnEditarPlantilla
            // 
            this.btnEditarPlantilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarPlantilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnEditarPlantilla.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(211)))), ((int)(((byte)(243)))));
            this.btnEditarPlantilla.FlatAppearance.BorderSize = 2;
            this.btnEditarPlantilla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            this.btnEditarPlantilla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(211)))), ((int)(((byte)(243)))));
            this.btnEditarPlantilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPlantilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPlantilla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarPlantilla.Location = new System.Drawing.Point(404, 3);
            this.btnEditarPlantilla.Name = "btnEditarPlantilla";
            this.btnEditarPlantilla.Size = new System.Drawing.Size(396, 77);
            this.btnEditarPlantilla.TabIndex = 14;
            this.btnEditarPlantilla.Text = "Editar plantilla de reposición de Stock Secundario";
            this.btnEditarPlantilla.UseVisualStyleBackColor = false;
            this.btnEditarPlantilla.Click += new System.EventHandler(this.btnEditarPlantilla_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.pnlContainer.Location = new System.Drawing.Point(8, 101);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(803, 547);
            this.pnlContainer.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnReposicionAutomatica, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEditarPlantilla, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(803, 83);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // frmReposicionAutomatica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(823, 660);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReposicionAutomatica";
            this.Text = "frmReposicion";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReposicionAutomatica;
        private System.Windows.Forms.Button btnEditarPlantilla;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}