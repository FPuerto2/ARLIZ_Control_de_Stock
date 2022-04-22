namespace Negocio
{
    partial class frmConsumoRepuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsumoRepuesto));
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRepuesto = new System.Windows.Forms.TextBox();
            this.lblRecordatorio = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnConsumir = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblRepuesto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtId.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtId.Location = new System.Drawing.Point(699, 20);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(91, 26);
            this.txtId.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(643, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 31);
            this.label1.TabIndex = 35;
            this.label1.Text = "ID:";
            // 
            // txtRepuesto
            // 
            this.txtRepuesto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.txtRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtRepuesto.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtRepuesto.Location = new System.Drawing.Point(160, 20);
            this.txtRepuesto.Margin = new System.Windows.Forms.Padding(3, 3, 32, 3);
            this.txtRepuesto.Name = "txtRepuesto";
            this.txtRepuesto.ReadOnly = true;
            this.txtRepuesto.Size = new System.Drawing.Size(448, 26);
            this.txtRepuesto.TabIndex = 34;
            // 
            // lblRecordatorio
            // 
            this.lblRecordatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRecordatorio.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblRecordatorio.Location = new System.Drawing.Point(13, 119);
            this.lblRecordatorio.Name = "lblRecordatorio";
            this.lblRecordatorio.Size = new System.Drawing.Size(777, 45);
            this.lblRecordatorio.TabIndex = 33;
            this.lblRecordatorio.Text = "Recordatorio: La cantidad que se ingrese es la cantidad consumida, que se restara" +
    " de la cantidad del repuesto en el equipo.";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCantidad.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCantidad.Location = new System.Drawing.Point(160, 74);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(391, 26);
            this.txtCantidad.TabIndex = 32;
            // 
            // btnConsumir
            // 
            this.btnConsumir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsumir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnConsumir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(219)))), ((int)(((byte)(127)))));
            this.btnConsumir.FlatAppearance.BorderSize = 2;
            this.btnConsumir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(230)))), ((int)(((byte)(164)))));
            this.btnConsumir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(219)))), ((int)(((byte)(127)))));
            this.btnConsumir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsumir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsumir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsumir.Location = new System.Drawing.Point(557, 64);
            this.btnConsumir.Name = "btnConsumir";
            this.btnConsumir.Size = new System.Drawing.Size(233, 47);
            this.btnConsumir.TabIndex = 31;
            this.btnConsumir.Text = "Registrar Consumo";
            this.btnConsumir.UseVisualStyleBackColor = false;
            this.btnConsumir.Click += new System.EventHandler(this.btnConsumir_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCantidad.Location = new System.Drawing.Point(11, 69);
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
            this.lblRepuesto.Location = new System.Drawing.Point(11, 15);
            this.lblRepuesto.Name = "lblRepuesto";
            this.lblRepuesto.Size = new System.Drawing.Size(146, 31);
            this.lblRepuesto.TabIndex = 30;
            this.lblRepuesto.Text = "Repuesto: ";
            // 
            // frmConsumoRepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(800, 184);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRepuesto);
            this.Controls.Add(this.lblRecordatorio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnConsumir);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblRepuesto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsumoRepuesto";
            this.Text = "frmConsumoRepuesto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRepuesto;
        private System.Windows.Forms.Label lblRecordatorio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnConsumir;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblRepuesto;
    }
}