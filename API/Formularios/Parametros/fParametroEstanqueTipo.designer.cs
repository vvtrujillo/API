namespace API.Formularios.Parametros
{
    partial class fParametroEstanqueTipo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripPerfiles = new System.Windows.Forms.ToolStrip();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGrabar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.chbActivo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbDescripcionTipoEstanque = new System.Windows.Forms.MaskedTextBox();
            this.mtbCodigoTipoEstanque = new System.Windows.Forms.MaskedTextBox();
            this.dgTipoEstanque = new System.Windows.Forms.DataGridView();
            this.toolStripPerfiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTipoEstanque)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripPerfiles
            // 
            this.toolStripPerfiles.BackColor = System.Drawing.Color.Transparent;
            this.toolStripPerfiles.BackgroundImage = global::API.Properties.Resources.BarraBotones;
            this.toolStripPerfiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripPerfiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCerrar,
            this.tsbImprimir,
            this.tsbEliminar,
            this.tsbNuevo,
            this.tsbGrabar,
            this.toolStripLabel1});
            this.toolStripPerfiles.Location = new System.Drawing.Point(0, 0);
            this.toolStripPerfiles.Name = "toolStripPerfiles";
            this.toolStripPerfiles.Size = new System.Drawing.Size(573, 25);
            this.toolStripPerfiles.TabIndex = 62;
            this.toolStripPerfiles.Text = "toolStrip1";
            this.toolStripPerfiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolsStripPerfiles_MouseDown);
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
            // tsbImprimir
            // 
            this.tsbImprimir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbImprimir.AutoSize = false;
            this.tsbImprimir.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsbImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImprimir.Name = "tsbImprimir";
            this.tsbImprimir.Size = new System.Drawing.Size(80, 22);
            this.tsbImprimir.Text = "Imprimir";
            this.tsbImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbImprimir.Click += new System.EventHandler(this.tsbImprimir_Click);
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(127, 22);
            this.toolStripLabel1.Text = "ESTANQUE - TIPO";
            this.toolStripLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripLabel1_MouseDown);
            // 
            // chbActivo
            // 
            this.chbActivo.AutoSize = true;
            this.chbActivo.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.chbActivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chbActivo.Location = new System.Drawing.Point(381, 86);
            this.chbActivo.Name = "chbActivo";
            this.chbActivo.Size = new System.Drawing.Size(69, 20);
            this.chbActivo.TabIndex = 3;
            this.chbActivo.Text = "Activo";
            this.chbActivo.UseVisualStyleBackColor = true;
            this.chbActivo.CheckedChanged += new System.EventHandler(this.ChequearCambioEdicion);
            this.chbActivo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chbActivo_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(147, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 71;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(65, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "Código";
            // 
            // mtbDescripcionTipoEstanque
            // 
            this.mtbDescripcionTipoEstanque.Location = new System.Drawing.Point(144, 86);
            this.mtbDescripcionTipoEstanque.Name = "mtbDescripcionTipoEstanque";
            this.mtbDescripcionTipoEstanque.Size = new System.Drawing.Size(231, 20);
            this.mtbDescripcionTipoEstanque.TabIndex = 2;
            this.mtbDescripcionTipoEstanque.TextChanged += new System.EventHandler(this.ChequearCambioEdicion);
            this.mtbDescripcionTipoEstanque.Enter += new System.EventHandler(this.ControlLlegaElFoco);
            this.mtbDescripcionTipoEstanque.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbDescripcionTipoEstanque_KeyDown);
            this.mtbDescripcionTipoEstanque.Leave += new System.EventHandler(this.ControlSeVaElFoco);
            // 
            // mtbCodigoTipoEstanque
            // 
            this.mtbCodigoTipoEstanque.Location = new System.Drawing.Point(65, 86);
            this.mtbCodigoTipoEstanque.Name = "mtbCodigoTipoEstanque";
            this.mtbCodigoTipoEstanque.Size = new System.Drawing.Size(79, 20);
            this.mtbCodigoTipoEstanque.TabIndex = 1;
            this.mtbCodigoTipoEstanque.TextChanged += new System.EventHandler(this.ChequearCambioEdicion);
            this.mtbCodigoTipoEstanque.Enter += new System.EventHandler(this.ControlLlegaElFoco);
            this.mtbCodigoTipoEstanque.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbCodigoTipoEstanque_KeyDown);
            this.mtbCodigoTipoEstanque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCodigoTipoEstanque_KeyPress);
            this.mtbCodigoTipoEstanque.Leave += new System.EventHandler(this.ControlSeVaElFoco);
            // 
            // dgTipoEstanque
            // 
            this.dgTipoEstanque.AllowUserToAddRows = false;
            this.dgTipoEstanque.AllowUserToDeleteRows = false;
            this.dgTipoEstanque.AllowUserToResizeColumns = false;
            this.dgTipoEstanque.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.dgTipoEstanque.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTipoEstanque.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgTipoEstanque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgTipoEstanque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(152)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTipoEstanque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgTipoEstanque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTipoEstanque.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgTipoEstanque.Location = new System.Drawing.Point(65, 112);
            this.dgTipoEstanque.MultiSelect = false;
            this.dgTipoEstanque.Name = "dgTipoEstanque";
            this.dgTipoEstanque.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTipoEstanque.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.dgTipoEstanque.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgTipoEstanque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTipoEstanque.Size = new System.Drawing.Size(430, 241);
            this.dgTipoEstanque.TabIndex = 187;
            this.dgTipoEstanque.TabStop = false;
            this.dgTipoEstanque.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTipoEstanque_CellClick);
            this.dgTipoEstanque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTipoEstanque_CellContentClick);
            // 
            // fParametroEstanqueTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(573, 406);
            this.ControlBox = false;
            this.Controls.Add(this.dgTipoEstanque);
            this.Controls.Add(this.mtbCodigoTipoEstanque);
            this.Controls.Add(this.mtbDescripcionTipoEstanque);
            this.Controls.Add(this.chbActivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStripPerfiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fParametroEstanqueTipo";
            this.Tag = "Control de producción";
            this.Load += new System.EventHandler(this.fParametroTipoEstanque_Load);
            this.Shown += new System.EventHandler(this.fParametroTipoEstanque_Shown);
            this.toolStripPerfiles.ResumeLayout(false);
            this.toolStripPerfiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTipoEstanque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripPerfiles;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGrabar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.CheckBox chbActivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbDescripcionTipoEstanque;
        private System.Windows.Forms.MaskedTextBox mtbCodigoTipoEstanque;
        private System.Windows.Forms.DataGridView dgTipoEstanque;
    }
}