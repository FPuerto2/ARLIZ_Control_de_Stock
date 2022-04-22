namespace Presentacion
{
    partial class frmStockSecundario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCambiarNombre = new System.Windows.Forms.Button();
            this.btnNuevoEquipo = new System.Windows.Forms.Button();
            this.cbxEquipos = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.Layout2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSumarRepuesto = new System.Windows.Forms.Button();
            this.Layout1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.grdArticulosXEquipo = new System.Windows.Forms.DataGridView();
            this.Layout2.SuspendLayout();
            this.Layout1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulosXEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCambiarNombre
            // 
            this.btnCambiarNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCambiarNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnCambiarNombre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCambiarNombre.FlatAppearance.BorderSize = 2;
            this.btnCambiarNombre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.btnCambiarNombre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCambiarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCambiarNombre.Location = new System.Drawing.Point(600, 3);
            this.btnCambiarNombre.Name = "btnCambiarNombre";
            this.btnCambiarNombre.Size = new System.Drawing.Size(196, 47);
            this.btnCambiarNombre.TabIndex = 9;
            this.btnCambiarNombre.Text = "Cambiar Nombre";
            this.btnCambiarNombre.UseVisualStyleBackColor = false;
            this.btnCambiarNombre.Click += new System.EventHandler(this.btnCambiarNombre_Click);
            // 
            // btnNuevoEquipo
            // 
            this.btnNuevoEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnNuevoEquipo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(219)))), ((int)(((byte)(127)))));
            this.btnNuevoEquipo.FlatAppearance.BorderSize = 2;
            this.btnNuevoEquipo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(230)))), ((int)(((byte)(164)))));
            this.btnNuevoEquipo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(219)))), ((int)(((byte)(127)))));
            this.btnNuevoEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEquipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoEquipo.Location = new System.Drawing.Point(3, 3);
            this.btnNuevoEquipo.Name = "btnNuevoEquipo";
            this.btnNuevoEquipo.Size = new System.Drawing.Size(169, 47);
            this.btnNuevoEquipo.TabIndex = 19;
            this.btnNuevoEquipo.Text = "Nuevo equipo";
            this.btnNuevoEquipo.UseVisualStyleBackColor = false;
            this.btnNuevoEquipo.Click += new System.EventHandler(this.btnNuevoEquipo_Click);
            // 
            // cbxEquipos
            // 
            this.cbxEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxEquipos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxEquipos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxEquipos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.cbxEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cbxEquipos.ForeColor = System.Drawing.Color.White;
            this.cbxEquipos.FormattingEnabled = true;
            this.cbxEquipos.Location = new System.Drawing.Point(281, 3);
            this.cbxEquipos.Name = "cbxEquipos";
            this.cbxEquipos.Size = new System.Drawing.Size(313, 46);
            this.cbxEquipos.TabIndex = 20;
            this.cbxEquipos.SelectedIndexChanged += new System.EventHandler(this.cbxEquipos_SelectedIndexChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(163)))), ((int)(((byte)(185)))));
            this.btnActualizar.FlatAppearance.BorderSize = 2;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(200)))), ((int)(((byte)(217)))));
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(163)))), ((int)(((byte)(185)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.Location = new System.Drawing.Point(682, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(114, 50);
            this.btnActualizar.TabIndex = 22;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // Layout2
            // 
            this.Layout2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Layout2.ColumnCount = 2;
            this.Layout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.Layout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Layout2.Controls.Add(this.btnActualizar, 1, 0);
            this.Layout2.Controls.Add(this.btnSumarRepuesto, 0, 0);
            this.Layout2.Location = new System.Drawing.Point(12, 64);
            this.Layout2.Name = "Layout2";
            this.Layout2.RowCount = 1;
            this.Layout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.Layout2.Size = new System.Drawing.Size(799, 56);
            this.Layout2.TabIndex = 23;
            // 
            // btnSumarRepuesto
            // 
            this.btnSumarRepuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSumarRepuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnSumarRepuesto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(219)))), ((int)(((byte)(127)))));
            this.btnSumarRepuesto.FlatAppearance.BorderSize = 2;
            this.btnSumarRepuesto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(230)))), ((int)(((byte)(164)))));
            this.btnSumarRepuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(219)))), ((int)(((byte)(127)))));
            this.btnSumarRepuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSumarRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumarRepuesto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSumarRepuesto.Location = new System.Drawing.Point(3, 3);
            this.btnSumarRepuesto.Name = "btnSumarRepuesto";
            this.btnSumarRepuesto.Size = new System.Drawing.Size(673, 50);
            this.btnSumarRepuesto.TabIndex = 26;
            this.btnSumarRepuesto.Text = "Agregar Repuesto del Inventario";
            this.btnSumarRepuesto.UseVisualStyleBackColor = false;
            this.btnSumarRepuesto.Click += new System.EventHandler(this.btnSumarRepuesto_Click);
            // 
            // Layout1
            // 
            this.Layout1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Layout1.ColumnCount = 4;
            this.Layout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.Layout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.Layout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.Layout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Layout1.Controls.Add(this.btnBorrar, 1, 0);
            this.Layout1.Controls.Add(this.btnNuevoEquipo, 0, 0);
            this.Layout1.Controls.Add(this.cbxEquipos, 2, 0);
            this.Layout1.Controls.Add(this.btnCambiarNombre, 3, 0);
            this.Layout1.Location = new System.Drawing.Point(12, 5);
            this.Layout1.Name = "Layout1";
            this.Layout1.RowCount = 1;
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout1.Size = new System.Drawing.Size(799, 53);
            this.Layout1.TabIndex = 24;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btnBorrar.FlatAppearance.BorderSize = 2;
            this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(123)))), ((int)(((byte)(134)))));
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBorrar.Location = new System.Drawing.Point(178, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(97, 47);
            this.btnBorrar.TabIndex = 26;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // grdArticulosXEquipo
            // 
            this.grdArticulosXEquipo.AllowUserToAddRows = false;
            this.grdArticulosXEquipo.AllowUserToDeleteRows = false;
            this.grdArticulosXEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdArticulosXEquipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdArticulosXEquipo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.grdArticulosXEquipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdArticulosXEquipo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdArticulosXEquipo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdArticulosXEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdArticulosXEquipo.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdArticulosXEquipo.EnableHeadersVisualStyles = false;
            this.grdArticulosXEquipo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(211)))), ((int)(((byte)(243)))));
            this.grdArticulosXEquipo.Location = new System.Drawing.Point(12, 126);
            this.grdArticulosXEquipo.Name = "grdArticulosXEquipo";
            this.grdArticulosXEquipo.ReadOnly = true;
            this.grdArticulosXEquipo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdArticulosXEquipo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdArticulosXEquipo.RowHeadersWidth = 20;
            this.grdArticulosXEquipo.RowTemplate.Height = 24;
            this.grdArticulosXEquipo.Size = new System.Drawing.Size(799, 522);
            this.grdArticulosXEquipo.TabIndex = 25;
            this.grdArticulosXEquipo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdArticulosXEquipo_CellContentClick);
            // 
            // frmStockSecundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(823, 660);
            this.Controls.Add(this.grdArticulosXEquipo);
            this.Controls.Add(this.Layout1);
            this.Controls.Add(this.Layout2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStockSecundario";
            this.Text = "frmStockSecundario";
            this.Layout2.ResumeLayout(false);
            this.Layout1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulosXEquipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCambiarNombre;
        private System.Windows.Forms.Button btnNuevoEquipo;
        private System.Windows.Forms.ComboBox cbxEquipos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TableLayoutPanel Layout2;
        private System.Windows.Forms.TableLayoutPanel Layout1;
        private System.Windows.Forms.DataGridView grdArticulosXEquipo;
        private System.Windows.Forms.Button btnSumarRepuesto;
        private System.Windows.Forms.Button btnBorrar;
    }
}