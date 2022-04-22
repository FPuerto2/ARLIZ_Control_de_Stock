namespace Presentacion
{
    partial class frmEditarRepuestoPlantilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarRepuestoPlantilla));
            this.txtRepuesto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblRepuesto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRepuesto
            // 
            this.txtRepuesto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.txtRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtRepuesto.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtRepuesto.Location = new System.Drawing.Point(161, 14);
            this.txtRepuesto.Margin = new System.Windows.Forms.Padding(3, 3, 32, 3);
            this.txtRepuesto.Name = "txtRepuesto";
            this.txtRepuesto.ReadOnly = true;
            this.txtRepuesto.Size = new System.Drawing.Size(630, 26);
            this.txtRepuesto.TabIndex = 34;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCantidad.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCantidad.Location = new System.Drawing.Point(161, 68);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 3, 32, 3);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(391, 26);
            this.txtCantidad.TabIndex = 32;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(219)))), ((int)(((byte)(127)))));
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(230)))), ((int)(((byte)(164)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(219)))), ((int)(((byte)(127)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(587, 57);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(204, 45);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCantidad.Location = new System.Drawing.Point(12, 63);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(138, 31);
            this.lblCantidad.TabIndex = 29;
            this.lblCantidad.Text = "Cantidad: ";
            // 
            // lblRepuesto
            // 
            this.lblRepuesto.AutoSize = true;
            this.lblRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblRepuesto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRepuesto.Location = new System.Drawing.Point(12, 9);
            this.lblRepuesto.Name = "lblRepuesto";
            this.lblRepuesto.Size = new System.Drawing.Size(146, 31);
            this.lblRepuesto.TabIndex = 30;
            this.lblRepuesto.Text = "Repuesto: ";
            // 
            // frmEditarRepuestoPlantilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(800, 116);
            this.Controls.Add(this.txtRepuesto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblRepuesto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditarRepuestoPlantilla";
            this.Text = "EditarRepuestoPlantilla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRepuesto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblRepuesto;
    }
}