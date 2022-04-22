namespace Presentacion
{
    partial class frmReposicionPlantillaStockSec
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAniadir = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblRepuesto = new System.Windows.Forms.Label();
            this.cbxRepuestos = new System.Windows.Forms.ComboBox();
            this.grdPlantilla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdPlantilla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAniadir
            // 
            this.btnAniadir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAniadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnAniadir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(211)))), ((int)(((byte)(243)))));
            this.btnAniadir.FlatAppearance.BorderSize = 2;
            this.btnAniadir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            this.btnAniadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(211)))), ((int)(((byte)(243)))));
            this.btnAniadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAniadir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAniadir.Location = new System.Drawing.Point(638, 64);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(134, 39);
            this.btnAniadir.TabIndex = 18;
            this.btnAniadir.Text = "Añadir";
            this.btnAniadir.UseVisualStyleBackColor = false;
            this.btnAniadir.Click += new System.EventHandler(this.btnAniadir_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCantidad.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCantidad.Location = new System.Drawing.Point(156, 72);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(111, 26);
            this.txtCantidad.TabIndex = 17;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCantidad.Location = new System.Drawing.Point(12, 67);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(138, 31);
            this.lblCantidad.TabIndex = 16;
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
            this.lblRepuesto.TabIndex = 14;
            this.lblRepuesto.Text = "Repuesto: ";
            // 
            // cbxRepuestos
            // 
            this.cbxRepuestos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxRepuestos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxRepuestos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxRepuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.cbxRepuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxRepuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRepuestos.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbxRepuestos.FormattingEnabled = true;
            this.cbxRepuestos.Location = new System.Drawing.Point(156, 9);
            this.cbxRepuestos.Name = "cbxRepuestos";
            this.cbxRepuestos.Size = new System.Drawing.Size(616, 33);
            this.cbxRepuestos.TabIndex = 49;
            this.cbxRepuestos.Text = "Seleccione uno...";
            // 
            // grdPlantilla
            // 
            this.grdPlantilla.AllowUserToAddRows = false;
            this.grdPlantilla.AllowUserToDeleteRows = false;
            this.grdPlantilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPlantilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPlantilla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.grdPlantilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPlantilla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPlantilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdPlantilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPlantilla.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdPlantilla.EnableHeadersVisualStyles = false;
            this.grdPlantilla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(211)))), ((int)(((byte)(243)))));
            this.grdPlantilla.Location = new System.Drawing.Point(12, 109);
            this.grdPlantilla.Name = "grdPlantilla";
            this.grdPlantilla.ReadOnly = true;
            this.grdPlantilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPlantilla.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdPlantilla.RowHeadersWidth = 20;
            this.grdPlantilla.RowTemplate.Height = 24;
            this.grdPlantilla.Size = new System.Drawing.Size(760, 294);
            this.grdPlantilla.TabIndex = 50;
            this.grdPlantilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPlantilla_CellContentClick);
            // 
            // frmReposicionPlantillaStockSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(785, 415);
            this.Controls.Add(this.grdPlantilla);
            this.Controls.Add(this.cbxRepuestos);
            this.Controls.Add(this.btnAniadir);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblRepuesto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReposicionPlantillaStockSec";
            this.Text = "frmReposicionPlantillaStockSec";
            ((System.ComponentModel.ISupportInitialize)(this.grdPlantilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAniadir;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblRepuesto;
        private System.Windows.Forms.ComboBox cbxRepuestos;
        private System.Windows.Forms.DataGridView grdPlantilla;
    }
}