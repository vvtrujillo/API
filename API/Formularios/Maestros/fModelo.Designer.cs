namespace API.Formularios.Maestros
{
    partial class fModelo
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
            this.tsModelo = new System.Windows.Forms.ToolStrip();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbGrabar = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tslModelo = new System.Windows.Forms.ToolStripLabel();
            this.tsActualiza = new System.Windows.Forms.ToolStripButton();
            this.cmbMarcaModelo = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtNombreModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.dgModelo = new System.Windows.Forms.DataGridView();
            this.tsModelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // tsModelo
            // 
            this.tsModelo.BackColor = System.Drawing.Color.Transparent;
            this.tsModelo.BackgroundImage = global::API.Properties.Resources.BarraBotones;
            this.tsModelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsModelo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCerrar,
            this.tsbEliminar,
            this.tsEditar,
            this.tsbGrabar,
            this.tsbNuevo,
            this.tsbCancelar,
            this.tslModelo,
            this.tsActualiza});
            this.tsModelo.Location = new System.Drawing.Point(0, 0);
            this.tsModelo.Name = "tsModelo";
            this.tsModelo.Size = new System.Drawing.Size(677, 25);
            this.tsModelo.TabIndex = 101;
            this.tsModelo.Text = "toolStrip1";
            this.tsModelo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsModelo_MouseDown);
            // 
            // tsbCerrar
            // 
            this.tsbCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrar.AutoSize = false;
            this.tsbCerrar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsbCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.tsbEliminar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsbEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(80, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbEliminar.Visible = false;
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // tsEditar
            // 
            this.tsEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsEditar.AutoSize = false;
            this.tsEditar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.tsbCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(80, 22);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // tslModelo
            // 
            this.tslModelo.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tslModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tslModelo.Name = "tslModelo";
            this.tslModelo.Size = new System.Drawing.Size(63, 22);
            this.tslModelo.Text = "MODELO";
            // 
            // tsActualiza
            // 
            this.tsActualiza.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsActualiza.AutoSize = false;
            this.tsActualiza.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsActualiza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsActualiza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsActualiza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsActualiza.Name = "tsActualiza";
            this.tsActualiza.Size = new System.Drawing.Size(80, 22);
            this.tsActualiza.Text = "Actualizar";
            this.tsActualiza.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsActualiza.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsActualiza.Visible = false;
            this.tsActualiza.Click += new System.EventHandler(this.tsActualiza_Click);
            // 
            // cmbMarcaModelo
            // 
            this.cmbMarcaModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarcaModelo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarcaModelo.FormattingEnabled = true;
            this.cmbMarcaModelo.Location = new System.Drawing.Point(112, 43);
            this.cmbMarcaModelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbMarcaModelo.Name = "cmbMarcaModelo";
            this.cmbMarcaModelo.Size = new System.Drawing.Size(150, 25);
            this.cmbMarcaModelo.TabIndex = 102;
            this.cmbMarcaModelo.SelectionChangeCommitted += new System.EventHandler(this.cmbMarcaModelo_SelectionChangeCommitted);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(65, 46);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 17);
            this.lblMarca.TabIndex = 103;
            this.lblMarca.Text = "Marca";
            // 
            // txtNombreModelo
            // 
            this.txtNombreModelo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreModelo.Location = new System.Drawing.Point(112, 75);
            this.txtNombreModelo.Name = "txtNombreModelo";
            this.txtNombreModelo.Size = new System.Drawing.Size(238, 25);
            this.txtNombreModelo.TabIndex = 104;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(56, 78);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(54, 17);
            this.lblModelo.TabIndex = 105;
            this.lblModelo.Text = "Modelo";
            // 
            // dgModelo
            // 
            this.dgModelo.AllowUserToAddRows = false;
            this.dgModelo.AllowUserToDeleteRows = false;
            this.dgModelo.AllowUserToResizeColumns = false;
            this.dgModelo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.dgModelo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgModelo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgModelo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgModelo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(152)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgModelo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgModelo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgModelo.Location = new System.Drawing.Point(59, 107);
            this.dgModelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgModelo.MultiSelect = false;
            this.dgModelo.Name = "dgModelo";
            this.dgModelo.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.dgModelo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgModelo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgModelo.Size = new System.Drawing.Size(424, 234);
            this.dgModelo.TabIndex = 189;
            this.dgModelo.TabStop = false;
            this.dgModelo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgModelo_CellContentClick);
            // 
            // fModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 354);
            this.Controls.Add(this.dgModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtNombreModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cmbMarcaModelo);
            this.Controls.Add(this.tsModelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fModelo";
            this.Text = "fModelo";
            this.Load += new System.EventHandler(this.fModelo_Load);
            this.tsModelo.ResumeLayout(false);
            this.tsModelo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgModelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsModelo;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsEditar;
        private System.Windows.Forms.ToolStripButton tsbGrabar;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripLabel tslModelo;
        private System.Windows.Forms.ComboBox cmbMarcaModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtNombreModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.DataGridView dgModelo;
        private System.Windows.Forms.ToolStripButton tsActualiza;
    }
}