namespace API.Formularios.Busquedas
{
    partial class fBusqueda
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
            this.txtCodLicenciaBusq = new System.Windows.Forms.TextBox();
            this.lblCodLicencia = new System.Windows.Forms.Label();
            this.dgListaSoftwareDisp = new System.Windows.Forms.DataGridView();
            this.cod_licencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_licencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_sw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrip_sw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant_disp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsBusqSwDisp = new System.Windows.Forms.ToolStrip();
            this.tsbCerrarBusqSwDisp = new System.Windows.Forms.ToolStripButton();
            this.tsLimpiarListSwDisp = new System.Windows.Forms.ToolStripButton();
            this.tslBusquedaActxUsuario = new System.Windows.Forms.ToolStripLabel();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaSoftwareDisp)).BeginInit();
            this.tsBusqSwDisp.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodLicenciaBusq
            // 
            this.txtCodLicenciaBusq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodLicenciaBusq.Location = new System.Drawing.Point(134, 39);
            this.txtCodLicenciaBusq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodLicenciaBusq.Name = "txtCodLicenciaBusq";
            this.txtCodLicenciaBusq.Size = new System.Drawing.Size(75, 25);
            this.txtCodLicenciaBusq.TabIndex = 5;
            // 
            // lblCodLicencia
            // 
            this.lblCodLicencia.AutoSize = true;
            this.lblCodLicencia.Location = new System.Drawing.Point(30, 43);
            this.lblCodLicencia.Name = "lblCodLicencia";
            this.lblCodLicencia.Size = new System.Drawing.Size(100, 17);
            this.lblCodLicencia.TabIndex = 6;
            this.lblCodLicencia.Text = "Codigo Licencia";
            // 
            // dgListaSoftwareDisp
            // 
            this.dgListaSoftwareDisp.AllowUserToAddRows = false;
            this.dgListaSoftwareDisp.AllowUserToDeleteRows = false;
            this.dgListaSoftwareDisp.AllowUserToResizeColumns = false;
            this.dgListaSoftwareDisp.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.dgListaSoftwareDisp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgListaSoftwareDisp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgListaSoftwareDisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgListaSoftwareDisp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(152)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgListaSoftwareDisp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgListaSoftwareDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaSoftwareDisp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_licencia,
            this.tipo_licencia,
            this.nombre_sw,
            this.descrip_sw,
            this.cant_disp});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgListaSoftwareDisp.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgListaSoftwareDisp.Location = new System.Drawing.Point(12, 144);
            this.dgListaSoftwareDisp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgListaSoftwareDisp.MultiSelect = false;
            this.dgListaSoftwareDisp.Name = "dgListaSoftwareDisp";
            this.dgListaSoftwareDisp.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.dgListaSoftwareDisp.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgListaSoftwareDisp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListaSoftwareDisp.Size = new System.Drawing.Size(797, 187);
            this.dgListaSoftwareDisp.TabIndex = 191;
            this.dgListaSoftwareDisp.TabStop = false;
            // 
            // cod_licencia
            // 
            this.cod_licencia.HeaderText = "Código Licencia";
            this.cod_licencia.Name = "cod_licencia";
            this.cod_licencia.ReadOnly = true;
            // 
            // tipo_licencia
            // 
            this.tipo_licencia.HeaderText = "Tipo Licencia";
            this.tipo_licencia.Name = "tipo_licencia";
            this.tipo_licencia.ReadOnly = true;
            // 
            // nombre_sw
            // 
            this.nombre_sw.HeaderText = "Nombre";
            this.nombre_sw.Name = "nombre_sw";
            this.nombre_sw.ReadOnly = true;
            // 
            // descrip_sw
            // 
            this.descrip_sw.HeaderText = "Descripción";
            this.descrip_sw.Name = "descrip_sw";
            this.descrip_sw.ReadOnly = true;
            // 
            // cant_disp
            // 
            this.cant_disp.HeaderText = "Cantidad Disponible";
            this.cant_disp.Name = "cant_disp";
            this.cant_disp.ReadOnly = true;
            // 
            // tsBusqSwDisp
            // 
            this.tsBusqSwDisp.BackColor = System.Drawing.Color.Transparent;
            this.tsBusqSwDisp.BackgroundImage = global::API.Properties.Resources.BarraBotones;
            this.tsBusqSwDisp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsBusqSwDisp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCerrarBusqSwDisp,
            this.tsLimpiarListSwDisp,
            this.tslBusquedaActxUsuario});
            this.tsBusqSwDisp.Location = new System.Drawing.Point(0, 0);
            this.tsBusqSwDisp.Name = "tsBusqSwDisp";
            this.tsBusqSwDisp.Size = new System.Drawing.Size(821, 25);
            this.tsBusqSwDisp.TabIndex = 194;
            this.tsBusqSwDisp.Text = "toolStrip1";
            this.tsBusqSwDisp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsBusqSwDisp_MouseDown);
            // 
            // tsbCerrarBusqSwDisp
            // 
            this.tsbCerrarBusqSwDisp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrarBusqSwDisp.AutoSize = false;
            this.tsbCerrarBusqSwDisp.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsbCerrarBusqSwDisp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbCerrarBusqSwDisp.Image = global::API.Properties.Resources.Cerrar_16;
            this.tsbCerrarBusqSwDisp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbCerrarBusqSwDisp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrarBusqSwDisp.Name = "tsbCerrarBusqSwDisp";
            this.tsbCerrarBusqSwDisp.Size = new System.Drawing.Size(70, 22);
            this.tsbCerrarBusqSwDisp.Text = "Cerrar";
            this.tsbCerrarBusqSwDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbCerrarBusqSwDisp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbCerrarBusqSwDisp.Click += new System.EventHandler(this.tsbCerrarBusqSwDisp_Click);
            // 
            // tsLimpiarListSwDisp
            // 
            this.tsLimpiarListSwDisp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsLimpiarListSwDisp.AutoSize = false;
            this.tsLimpiarListSwDisp.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsLimpiarListSwDisp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsLimpiarListSwDisp.Image = global::API.Properties.Resources.if_Wide_brush_131923;
            this.tsLimpiarListSwDisp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsLimpiarListSwDisp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLimpiarListSwDisp.Name = "tsLimpiarListSwDisp";
            this.tsLimpiarListSwDisp.Size = new System.Drawing.Size(90, 22);
            this.tsLimpiarListSwDisp.Text = "Limpiar";
            this.tsLimpiarListSwDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsLimpiarListSwDisp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsLimpiarListSwDisp.Click += new System.EventHandler(this.tsLimpiarListSwDisp_Click);
            // 
            // tslBusquedaActxUsuario
            // 
            this.tslBusquedaActxUsuario.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tslBusquedaActxUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tslBusquedaActxUsuario.Name = "tslBusquedaActxUsuario";
            this.tslBusquedaActxUsuario.Size = new System.Drawing.Size(71, 22);
            this.tslBusquedaActxUsuario.Text = "Búsqueda";
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Image = global::API.Properties.Resources.Buscar_16;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(215, 39);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(30, 25);
            this.btnBuscarUsuario.TabIndex = 7;
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // fBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 344);
            this.Controls.Add(this.tsBusqSwDisp);
            this.Controls.Add(this.dgListaSoftwareDisp);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.lblCodLicencia);
            this.Controls.Add(this.txtCodLicenciaBusq);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fBusqueda";
            this.Tag = "fBusqueda";
            this.Text = "fBusqueda";
            this.Load += new System.EventHandler(this.fBusqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaSoftwareDisp)).EndInit();
            this.tsBusqSwDisp.ResumeLayout(false);
            this.tsBusqSwDisp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodLicenciaBusq;
        private System.Windows.Forms.Label lblCodLicencia;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.DataGridView dgListaSoftwareDisp;
        private System.Windows.Forms.ToolStrip tsBusqSwDisp;
        private System.Windows.Forms.ToolStripButton tsbCerrarBusqSwDisp;
        private System.Windows.Forms.ToolStripLabel tslBusquedaActxUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_licencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_licencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_sw;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrip_sw;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant_disp;
        private System.Windows.Forms.ToolStripButton tsLimpiarListSwDisp;
    }
}