namespace Presentacion
{
    partial class frmAltaModificacionStockPrimario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaModificacionStockPrimario));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.cbxClasificacion = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxUnidad = new System.Windows.Forms.ComboBox();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btnGuardar.Location = new System.Drawing.Point(451, 136);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(337, 39);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDescripcion.Location = new System.Drawing.Point(143, 14);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 3, 32, 3);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(485, 26);
            this.txtDescripcion.TabIndex = 23;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl2.Location = new System.Drawing.Point(12, 93);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(138, 31);
            this.lbl2.TabIndex = 22;
            this.lbl2.Text = "Cantidad: ";
            // 
            // cbxClasificacion
            // 
            this.cbxClasificacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxClasificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.cbxClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClasificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxClasificacion.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbxClasificacion.FormattingEnabled = true;
            this.cbxClasificacion.Location = new System.Drawing.Point(100, 53);
            this.cbxClasificacion.Name = "cbxClasificacion";
            this.cbxClasificacion.Size = new System.Drawing.Size(688, 28);
            this.cbxClasificacion.TabIndex = 21;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl1.Location = new System.Drawing.Point(12, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(125, 31);
            this.lbl1.TabIndex = 20;
            this.lbl1.Text = "Nombre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(641, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtId.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtId.Location = new System.Drawing.Point(697, 14);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(91, 26);
            this.txtId.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 31);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tipo: ";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCantidad.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCantidad.Location = new System.Drawing.Point(156, 100);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(236, 26);
            this.txtCantidad.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(398, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 31);
            this.label3.TabIndex = 29;
            this.label3.Text = "Unidad:";
            // 
            // cbxUnidad
            // 
            this.cbxUnidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxUnidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxUnidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxUnidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.cbxUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxUnidad.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbxUnidad.FormattingEnabled = true;
            this.cbxUnidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxUnidad.Location = new System.Drawing.Point(512, 98);
            this.cbxUnidad.Name = "cbxUnidad";
            this.cbxUnidad.Size = new System.Drawing.Size(276, 28);
            this.cbxUnidad.TabIndex = 30;
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStockMinimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.txtStockMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStockMinimo.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtStockMinimo.Location = new System.Drawing.Point(209, 144);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(236, 26);
            this.txtStockMinimo.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 31);
            this.label4.TabIndex = 31;
            this.label4.Text = "Stock Mínimo: ";
            // 
            // frmAltaModificacionStockPrimario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(800, 190);
            this.Controls.Add(this.cbxClasificacion);
            this.Controls.Add(this.txtStockMinimo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxUnidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAltaModificacionStockPrimario";
            this.Text = "Nuevo Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ComboBox cbxClasificacion;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxUnidad;
        private System.Windows.Forms.TextBox txtStockMinimo;
        private System.Windows.Forms.Label label4;
    }
}