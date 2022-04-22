namespace Presentacion
{
    partial class frmReposicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReposicion));
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnReponer = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecordatorio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCantidad.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCantidad.Location = new System.Drawing.Point(161, 70);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 3, 32, 3);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(391, 26);
            this.txtCantidad.TabIndex = 18;
            // 
            // btnReponer
            // 
            this.btnReponer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReponer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnReponer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(219)))), ((int)(((byte)(127)))));
            this.btnReponer.FlatAppearance.BorderSize = 2;
            this.btnReponer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(230)))), ((int)(((byte)(164)))));
            this.btnReponer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(219)))), ((int)(((byte)(127)))));
            this.btnReponer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReponer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReponer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReponer.Location = new System.Drawing.Point(587, 70);
            this.btnReponer.Name = "btnReponer";
            this.btnReponer.Size = new System.Drawing.Size(204, 67);
            this.btnReponer.TabIndex = 17;
            this.btnReponer.Text = "Reponer";
            this.btnReponer.UseVisualStyleBackColor = false;
            this.btnReponer.Click += new System.EventHandler(this.btnReponer_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCantidad.Location = new System.Drawing.Point(12, 65);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(138, 31);
            this.lblCantidad.TabIndex = 14;
            this.lblCantidad.Text = "Cantidad: ";
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblArticulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblArticulo.Location = new System.Drawing.Point(12, 11);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(120, 31);
            this.lblArticulo.TabIndex = 15;
            this.lblArticulo.Text = "Articulo: ";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.txtArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtArticulo.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtArticulo.Location = new System.Drawing.Point(161, 16);
            this.txtArticulo.Margin = new System.Windows.Forms.Padding(3, 3, 32, 3);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.ReadOnly = true;
            this.txtArticulo.Size = new System.Drawing.Size(448, 26);
            this.txtArticulo.TabIndex = 23;
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtId.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtId.Location = new System.Drawing.Point(700, 16);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(91, 26);
            this.txtId.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(644, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID:";
            // 
            // lblRecordatorio
            // 
            this.lblRecordatorio.AutoSize = true;
            this.lblRecordatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRecordatorio.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblRecordatorio.Location = new System.Drawing.Point(14, 120);
            this.lblRecordatorio.Name = "lblRecordatorio";
            this.lblRecordatorio.Size = new System.Drawing.Size(487, 20);
            this.lblRecordatorio.TabIndex = 22;
            this.lblRecordatorio.Text = "Recordatorio: La cantidad que se ingrese se sumara a la actual.";
            // 
            // frmReposicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(803, 149);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArticulo);
            this.Controls.Add(this.lblRecordatorio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnReponer);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReposicion";
            this.Text = "frmReponerStockPrimario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnReponer;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecordatorio;
    }
}