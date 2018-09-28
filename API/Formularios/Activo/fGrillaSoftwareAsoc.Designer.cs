namespace API.Formularios.Activo
{
    partial class fGrillaSoftwareAsoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgListaSoftwareDisp = new System.Windows.Forms.DataGridView();
            this.sel_sw = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nombre_sw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant_sw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_licencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_lic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_sw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant_disp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsAsociaSwGrilla = new System.Windows.Forms.ToolStrip();
            this.tsbCerrarAsoSwGrilla = new System.Windows.Forms.ToolStripButton();
            this.tsbGrabarAsocSwGrilla = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelarAsocSwGrilla = new System.Windows.Forms.ToolStripButton();
            this.tslAsociaActivo = new System.Windows.Forms.ToolStripLabel();
            this.lblFiltroNombreSw = new System.Windows.Forms.Label();
            this.txtFiltroNombreSw = new System.Windows.Forms.TextBox();
            this.txtNumLicGrillaSW = new System.Windows.Forms.TextBox();
            this.lblNumLicGrillaSW = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaSoftwareDisp)).BeginInit();
            this.tsAsociaSwGrilla.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgListaSoftwareDisp
            // 
            this.dgListaSoftwareDisp.AllowUserToAddRows = false;
            this.dgListaSoftwareDisp.AllowUserToDeleteRows = false;
            this.dgListaSoftwareDisp.AllowUserToResizeColumns = false;
            this.dgListaSoftwareDisp.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.dgListaSoftwareDisp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgListaSoftwareDisp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgListaSoftwareDisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgListaSoftwareDisp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(152)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgListaSoftwareDisp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgListaSoftwareDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaSoftwareDisp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sel_sw,
            this.nombre_sw,
            this.cant_sw,
            this.no_licencia,
            this.tipo_lic,
            this.descripcion_sw,
            this.cant_disp,
            this.id_activo});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgListaSoftwareDisp.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgListaSoftwareDisp.Location = new System.Drawing.Point(14, 99);
            this.dgListaSoftwareDisp.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgListaSoftwareDisp.MultiSelect = false;
            this.dgListaSoftwareDisp.Name = "dgListaSoftwareDisp";
            this.dgListaSoftwareDisp.ReadOnly = true;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.dgListaSoftwareDisp.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgListaSoftwareDisp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListaSoftwareDisp.Size = new System.Drawing.Size(1084, 350);
            this.dgListaSoftwareDisp.TabIndex = 191;
            this.dgListaSoftwareDisp.TabStop = false;
            this.dgListaSoftwareDisp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaSoftwareDisp_CellContentClick);
            // 
            // sel_sw
            // 
            this.sel_sw.HeaderText = "Sel";
            this.sel_sw.Name = "sel_sw";
            this.sel_sw.ReadOnly = true;
            // 
            // nombre_sw
            // 
            this.nombre_sw.HeaderText = "Nombre Software";
            this.nombre_sw.Name = "nombre_sw";
            this.nombre_sw.ReadOnly = true;
            // 
            // cant_sw
            // 
            this.cant_sw.HeaderText = "Cantidad";
            this.cant_sw.Name = "cant_sw";
            this.cant_sw.ReadOnly = true;
            // 
            // no_licencia
            // 
            this.no_licencia.HeaderText = "Número Licencia";
            this.no_licencia.Name = "no_licencia";
            this.no_licencia.ReadOnly = true;
            // 
            // tipo_lic
            // 
            this.tipo_lic.HeaderText = "Tipo Licencia";
            this.tipo_lic.Name = "tipo_lic";
            this.tipo_lic.ReadOnly = true;
            // 
            // descripcion_sw
            // 
            this.descripcion_sw.HeaderText = "Descripcion";
            this.descripcion_sw.Name = "descripcion_sw";
            this.descripcion_sw.ReadOnly = true;
            // 
            // cant_disp
            // 
            this.cant_disp.HeaderText = "Disponibles";
            this.cant_disp.Name = "cant_disp";
            this.cant_disp.ReadOnly = true;
            // 
            // id_activo
            // 
            this.id_activo.HeaderText = "idActivo";
            this.id_activo.Name = "id_activo";
            this.id_activo.ReadOnly = true;
            // 
            // tsAsociaSwGrilla
            // 
            this.tsAsociaSwGrilla.BackColor = System.Drawing.Color.Transparent;
            this.tsAsociaSwGrilla.BackgroundImage = global::API.Properties.Resources.BarraBotones;
            this.tsAsociaSwGrilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsAsociaSwGrilla.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCerrarAsoSwGrilla,
            this.tsbGrabarAsocSwGrilla,
            this.tsbCancelarAsocSwGrilla,
            this.tslAsociaActivo});
            this.tsAsociaSwGrilla.Location = new System.Drawing.Point(0, 0);
            this.tsAsociaSwGrilla.Name = "tsAsociaSwGrilla";
            this.tsAsociaSwGrilla.Size = new System.Drawing.Size(1113, 25);
            this.tsAsociaSwGrilla.TabIndex = 194;
            this.tsAsociaSwGrilla.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsAsociaSwGrilla_MouseDown);
            // 
            // tsbCerrarAsoSwGrilla
            // 
            this.tsbCerrarAsoSwGrilla.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrarAsoSwGrilla.AutoSize = false;
            this.tsbCerrarAsoSwGrilla.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsbCerrarAsoSwGrilla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbCerrarAsoSwGrilla.Image = global::API.Properties.Resources.Cerrar_16;
            this.tsbCerrarAsoSwGrilla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbCerrarAsoSwGrilla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrarAsoSwGrilla.Name = "tsbCerrarAsoSwGrilla";
            this.tsbCerrarAsoSwGrilla.Size = new System.Drawing.Size(70, 22);
            this.tsbCerrarAsoSwGrilla.Text = "Cerrar";
            this.tsbCerrarAsoSwGrilla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbCerrarAsoSwGrilla.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbCerrarAsoSwGrilla.Click += new System.EventHandler(this.tsbCerrarAsoSwGrilla_Click);
            // 
            // tsbGrabarAsocSwGrilla
            // 
            this.tsbGrabarAsocSwGrilla.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbGrabarAsocSwGrilla.AutoSize = false;
            this.tsbGrabarAsocSwGrilla.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsbGrabarAsocSwGrilla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbGrabarAsocSwGrilla.Image = global::API.Properties.Resources.Grabar2;
            this.tsbGrabarAsocSwGrilla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbGrabarAsocSwGrilla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGrabarAsocSwGrilla.Name = "tsbGrabarAsocSwGrilla";
            this.tsbGrabarAsocSwGrilla.Size = new System.Drawing.Size(80, 22);
            this.tsbGrabarAsocSwGrilla.Text = "Grabar";
            this.tsbGrabarAsocSwGrilla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbGrabarAsocSwGrilla.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbGrabarAsocSwGrilla.Click += new System.EventHandler(this.tsbGrabarAsocSwGrilla_Click);
            // 
            // tsbCancelarAsocSwGrilla
            // 
            this.tsbCancelarAsocSwGrilla.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCancelarAsocSwGrilla.AutoSize = false;
            this.tsbCancelarAsocSwGrilla.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsbCancelarAsocSwGrilla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbCancelarAsocSwGrilla.Image = global::API.Properties.Resources.cancel_icon;
            this.tsbCancelarAsocSwGrilla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbCancelarAsocSwGrilla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelarAsocSwGrilla.Name = "tsbCancelarAsocSwGrilla";
            this.tsbCancelarAsocSwGrilla.Size = new System.Drawing.Size(90, 22);
            this.tsbCancelarAsocSwGrilla.Text = "Cancelar";
            this.tsbCancelarAsocSwGrilla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbCancelarAsocSwGrilla.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tslAsociaActivo
            // 
            this.tslAsociaActivo.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tslAsociaActivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tslAsociaActivo.Name = "tslAsociaActivo";
            this.tslAsociaActivo.Size = new System.Drawing.Size(121, 22);
            this.tslAsociaActivo.Text = "Asociar Software";
            // 
            // lblFiltroNombreSw
            // 
            this.lblFiltroNombreSw.AutoSize = true;
            this.lblFiltroNombreSw.Location = new System.Drawing.Point(12, 46);
            this.lblFiltroNombreSw.Name = "lblFiltroNombreSw";
            this.lblFiltroNombreSw.Size = new System.Drawing.Size(112, 17);
            this.lblFiltroNombreSw.TabIndex = 193;
            this.lblFiltroNombreSw.Text = "Nombre Software";
            // 
            // txtFiltroNombreSw
            // 
            this.txtFiltroNombreSw.Location = new System.Drawing.Point(14, 66);
            this.txtFiltroNombreSw.Name = "txtFiltroNombreSw";
            this.txtFiltroNombreSw.Size = new System.Drawing.Size(170, 25);
            this.txtFiltroNombreSw.TabIndex = 192;
            this.txtFiltroNombreSw.TextChanged += new System.EventHandler(this.txtFiltroNombreSw_TextChanged);
            // 
            // txtNumLicGrillaSW
            // 
            this.txtNumLicGrillaSW.Location = new System.Drawing.Point(190, 66);
            this.txtNumLicGrillaSW.Name = "txtNumLicGrillaSW";
            this.txtNumLicGrillaSW.Size = new System.Drawing.Size(170, 25);
            this.txtNumLicGrillaSW.TabIndex = 195;
            this.txtNumLicGrillaSW.TextChanged += new System.EventHandler(this.txtNumLicGrillaSW_TextChanged);
            // 
            // lblNumLicGrillaSW
            // 
            this.lblNumLicGrillaSW.AutoSize = true;
            this.lblNumLicGrillaSW.Location = new System.Drawing.Point(187, 46);
            this.lblNumLicGrillaSW.Name = "lblNumLicGrillaSW";
            this.lblNumLicGrillaSW.Size = new System.Drawing.Size(105, 17);
            this.lblNumLicGrillaSW.TabIndex = 196;
            this.lblNumLicGrillaSW.Text = "Número Licencia";
            // 
            // fGrillaSoftwareAsoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 468);
            this.Controls.Add(this.lblNumLicGrillaSW);
            this.Controls.Add(this.txtNumLicGrillaSW);
            this.Controls.Add(this.tsAsociaSwGrilla);
            this.Controls.Add(this.lblFiltroNombreSw);
            this.Controls.Add(this.txtFiltroNombreSw);
            this.Controls.Add(this.dgListaSoftwareDisp);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fGrillaSoftwareAsoc";
            this.Text = "Software Disponible";
            this.Load += new System.EventHandler(this.fGrillaSoftwareAsoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaSoftwareDisp)).EndInit();
            this.tsAsociaSwGrilla.ResumeLayout(false);
            this.tsAsociaSwGrilla.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListaSoftwareDisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn idActivo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sel_sw;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_sw;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant_sw;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_licencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_lic;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_sw;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant_disp;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_activo;
        private System.Windows.Forms.ToolStrip tsAsociaSwGrilla;
        private System.Windows.Forms.ToolStripButton tsbCerrarAsoSwGrilla;
        private System.Windows.Forms.ToolStripButton tsbGrabarAsocSwGrilla;
        private System.Windows.Forms.ToolStripButton tsbCancelarAsocSwGrilla;
        private System.Windows.Forms.ToolStripLabel tslAsociaActivo;
        private System.Windows.Forms.Label lblFiltroNombreSw;
        private System.Windows.Forms.TextBox txtFiltroNombreSw;
        private System.Windows.Forms.TextBox txtNumLicGrillaSW;
        private System.Windows.Forms.Label lblNumLicGrillaSW;
    }
}