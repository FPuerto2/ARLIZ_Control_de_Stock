namespace Presentacion
{
    partial class frmStockPrimario
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
            this.grdArticulos = new System.Windows.Forms.DataGridView();
            this.btnAniadir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.Layout2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnConsumo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulos)).BeginInit();
            this.Layout2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdArticulos
            // 
            this.grdArticulos.AllowUserToAddRows = false;
            this.grdArticulos.AllowUserToDeleteRows = false;
            this.grdArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdArticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.grdArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdArticulos.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdArticulos.EnableHeadersVisualStyles = false;
            this.grdArticulos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(211)))), ((int)(((byte)(243)))));
            this.grdArticulos.Location = new System.Drawing.Point(12, 78);
            this.grdArticulos.Name = "grdArticulos";
            this.grdArticulos.ReadOnly = true;
            this.grdArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdArticulos.RowHeadersWidth = 20;
            this.grdArticulos.RowTemplate.Height = 24;
            this.grdArticulos.Size = new System.Drawing.Size(799, 570);
            this.grdArticulos.TabIndex = 1;
            this.grdArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdArticulos_CellContentClick);
            // 
            // btnAniadir
            // 
            this.btnAniadir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAniadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnAniadir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(219)))), ((int)(((byte)(127)))));
            this.btnAniadir.FlatAppearance.BorderSize = 2;
            this.btnAniadir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(230)))), ((int)(((byte)(164)))));
            this.btnAniadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(219)))), ((int)(((byte)(127)))));
            this.btnAniadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAniadir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAniadir.Location = new System.Drawing.Point(3, 3);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(333, 50);
            this.btnAniadir.TabIndex = 2;
            this.btnAniadir.Text = "Añadir";
            this.btnAniadir.UseVisualStyleBackColor = false;
            this.btnAniadir.Click += new System.EventHandler(this.btnAniadir_Click);
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
            this.btnActualizar.Location = new System.Drawing.Point(681, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(115, 50);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Layout2
            // 
            this.Layout2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Layout2.ColumnCount = 3;
            this.Layout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
            this.Layout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
            this.Layout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Layout2.Controls.Add(this.btnConsumo, 1, 0);
            this.Layout2.Controls.Add(this.btnAniadir, 0, 0);
            this.Layout2.Controls.Add(this.btnActualizar, 2, 0);
            this.Layout2.Location = new System.Drawing.Point(12, 12);
            this.Layout2.Name = "Layout2";
            this.Layout2.RowCount = 1;
            this.Layout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout2.Size = new System.Drawing.Size(799, 56);
            this.Layout2.TabIndex = 25;
            // 
            // btnConsumo
            // 
            this.btnConsumo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsumo.BackColor = System.Drawing.Color.Transparent;
            this.btnConsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsumo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(244)))));
            this.btnConsumo.FlatAppearance.BorderSize = 2;
            this.btnConsumo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.btnConsumo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(244)))));
            this.btnConsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsumo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsumo.Location = new System.Drawing.Point(342, 3);
            this.btnConsumo.Name = "btnConsumo";
            this.btnConsumo.Size = new System.Drawing.Size(333, 50);
            this.btnConsumo.TabIndex = 6;
            this.btnConsumo.Text = "Consumo de Elemento";
            this.btnConsumo.UseVisualStyleBackColor = false;
            this.btnConsumo.Click += new System.EventHandler(this.btnConsumo_Click);
            // 
            // frmStockPrimario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(823, 660);
            this.Controls.Add(this.Layout2);
            this.Controls.Add(this.grdArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStockPrimario";
            this.Text = "frmStockPrimario";
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulos)).EndInit();
            this.Layout2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdArticulos;
        private System.Windows.Forms.Button btnAniadir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TableLayoutPanel Layout2;
        private System.Windows.Forms.Button btnConsumo;
    }
}