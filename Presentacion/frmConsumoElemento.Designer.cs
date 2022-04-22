namespace Presentacion
{
    partial class frmConsumoElemento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsumoElemento));
            this.lblElemento = new System.Windows.Forms.Label();
            this.cbxElementos = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnRegistrarConsumo = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidadActual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElemento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblElemento.Location = new System.Drawing.Point(12, 10);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(172, 38);
            this.lblElemento.TabIndex = 2;
            this.lblElemento.Text = "Elemento: ";
            // 
            // cbxElementos
            // 
            this.cbxElementos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxElementos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxElementos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxElementos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.cbxElementos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxElementos.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbxElementos.FormattingEnabled = true;
            this.cbxElementos.Location = new System.Drawing.Point(190, 15);
            this.cbxElementos.Name = "cbxElementos";
            this.cbxElementos.Size = new System.Drawing.Size(621, 33);
            this.cbxElementos.TabIndex = 3;
            this.cbxElementos.Text = "Seleccione uno...";
            this.cbxElementos.SelectedIndexChanged += new System.EventHandler(this.cbxElementos_SelectedIndexChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCantidad.Location = new System.Drawing.Point(12, 73);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(165, 38);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad: ";
            // 
            // btnRegistrarConsumo
            // 
            this.btnRegistrarConsumo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarConsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnRegistrarConsumo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(219)))), ((int)(((byte)(127)))));
            this.btnRegistrarConsumo.FlatAppearance.BorderSize = 2;
            this.btnRegistrarConsumo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(230)))), ((int)(((byte)(164)))));
            this.btnRegistrarConsumo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(219)))), ((int)(((byte)(127)))));
            this.btnRegistrarConsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarConsumo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarConsumo.Location = new System.Drawing.Point(598, 71);
            this.btnRegistrarConsumo.Name = "btnRegistrarConsumo";
            this.btnRegistrarConsumo.Size = new System.Drawing.Size(213, 50);
            this.btnRegistrarConsumo.TabIndex = 12;
            this.btnRegistrarConsumo.Text = "Añadir consumo";
            this.btnRegistrarConsumo.UseVisualStyleBackColor = false;
            this.btnRegistrarConsumo.Click += new System.EventHandler(this.btnRegistrarConsumo_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCantidad.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCantidad.Location = new System.Drawing.Point(190, 81);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 3, 32, 3);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(373, 30);
            this.txtCantidad.TabIndex = 13;
            // 
            // lblCantidadActual
            // 
            this.lblCantidadActual.AutoSize = true;
            this.lblCantidadActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadActual.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCantidadActual.Location = new System.Drawing.Point(15, 114);
            this.lblCantidadActual.Name = "lblCantidadActual";
            this.lblCantidadActual.Size = new System.Drawing.Size(146, 24);
            this.lblCantidadActual.TabIndex = 22;
            this.lblCantidadActual.Text = "Cantidad Actual:";
            // 
            // frmConsumoElemento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(823, 153);
            this.Controls.Add(this.lblCantidadActual);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnRegistrarConsumo);
            this.Controls.Add(this.cbxElementos);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblElemento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsumoElemento";
            this.Text = "frmConsumoElemento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblElemento;
        private System.Windows.Forms.ComboBox cbxElementos;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnRegistrarConsumo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidadActual;
    }
}