namespace API.Formularios.Maestros
{
    partial class fMarca
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.dgMarca = new System.Windows.Forms.DataGridView();
            this.Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsMarca = new System.Windows.Forms.ToolStrip();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbGrabar = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tslMarca = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgMarca)).BeginInit();
            this.tsMarca.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(99, 38);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 17);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(150, 35);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(157, 25);
            this.txtMarca.TabIndex = 1;
            // 
            // dgMarca
            // 
            this.dgMarca.AllowUserToAddRows = false;
            this.dgMarca.AllowUserToDeleteRows = false;
            this.dgMarca.AllowUserToResizeColumns = false;
            this.dgMarca.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.dgMarca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgMarca.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgMarca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgMarca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(152)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMarca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMarca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sel,
            this.id_Marca,
            this.Nombre_Marca});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMarca.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgMarca.Location = new System.Drawing.Point(102, 74);
            this.dgMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgMarca.MultiSelect = false;
            this.dgMarca.Name = "dgMarca";
            this.dgMarca.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.dgMarca.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMarca.Size = new System.Drawing.Size(376, 312);
            this.dgMarca.TabIndex = 190;
            this.dgMarca.TabStop = false;
            this.dgMarca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMarca_CellContentClick);
            // 
            // Sel
            // 
            this.Sel.HeaderText = "Selección";
            this.Sel.Name = "Sel";
            this.Sel.ReadOnly = true;
            // 
            // id_Marca
            // 
            this.id_Marca.HeaderText = "id Marca";
            this.id_Marca.Name = "id_Marca";
            this.id_Marca.ReadOnly = true;
            this.id_Marca.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_Marca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Nombre_Marca
            // 
            this.Nombre_Marca.HeaderText = "nombre marca";
            this.Nombre_Marca.Name = "Nombre_Marca";
            this.Nombre_Marca.ReadOnly = true;
            // 
            // tsMarca
            // 
            this.tsMarca.BackColor = System.Drawing.Color.Transparent;
            this.tsMarca.BackgroundImage = global::API.Properties.Resources.BarraBotones;
            this.tsMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsMarca.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCerrar,
            this.tsbEliminar,
            this.tsEditar,
            this.tsbGrabar,
            this.tsbNuevo,
            this.tsbCancelar,
            this.tslMarca});
            this.tsMarca.Location = new System.Drawing.Point(0, 0);
            this.tsMarca.Name = "tsMarca";
            this.tsMarca.Size = new System.Drawing.Size(599, 25);
            this.tsMarca.TabIndex = 65;
            this.tsMarca.Text = "toolStrip1";
            this.tsMarca.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsMarca_MouseDown);
            // 
            // tsbCerrar
            // 
            this.tsbCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrar.AutoSize = false;
            this.tsbCerrar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsbCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbCerrar.Image = global::API.Properties.Resources.Cerrar_16;
            this.tsbCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrar.Name = "tsbCerrar";
            this.tsbCerrar.Size = new System.Drawing.Size(70, 22);
            this.tsbCerrar.Text = "Cerrar";
            this.tsbCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbCerrar.Click += new System.EventHandler(this.tsbCerrar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbEliminar.AutoSize = false;
            this.tsbEliminar.Enabled = false;
            this.tsbEliminar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsbEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(80, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // tsEditar
            // 
            this.tsEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsEditar.AutoSize = false;
            this.tsEditar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsEditar.Image = global::API.Properties.Resources.Modificar;
            this.tsEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEditar.Name = "tsEditar";
            this.tsEditar.Size = new System.Drawing.Size(80, 22);
            this.tsEditar.Text = "Editar";
            this.tsEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsEditar.Click += new System.EventHandler(this.tsEditar_Click);
            // 
            // tsbGrabar
            // 
            this.tsbGrabar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbGrabar.AutoSize = false;
            this.tsbGrabar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsbGrabar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbGrabar.Image = global::API.Properties.Resources.Grabar2;
            this.tsbGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGrabar.Name = "tsbGrabar";
            this.tsbGrabar.Size = new System.Drawing.Size(80, 22);
            this.tsbGrabar.Text = "Grabar";
            this.tsbGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbGrabar.Click += new System.EventHandler(this.tsbGrabar_Click);
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbNuevo.AutoSize = false;
            this.tsbNuevo.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsbNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbNuevo.Image = global::API.Properties.Resources.Nuevo_18;
            this.tsbNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(80, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCancelar.AutoSize = false;
            this.tsbCancelar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsbCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbCancelar.Image = global::API.Properties.Resources.cancel_icon;
            this.tsbCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(90, 22);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tslMarca
            // 
            this.tslMarca.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tslMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tslMarca.Name = "tslMarca";
            this.tslMarca.Size = new System.Drawing.Size(54, 22);
            this.tslMarca.Text = "MARCA";
            // 
            // fMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 399);
            this.Controls.Add(this.dgMarca);
            this.Controls.Add(this.tsMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fMarca";
            this.Text = "fMarca";
            this.Load += new System.EventHandler(this.fMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMarca)).EndInit();
            this.tsMarca.ResumeLayout(false);
            this.tsMarca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.ToolStrip tsMarca;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsEditar;
        private System.Windows.Forms.ToolStripButton tsbGrabar;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripLabel tslMarca;
        private System.Windows.Forms.DataGridView dgMarca;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Marca;
    }
}