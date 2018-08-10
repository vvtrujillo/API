namespace API.Formularios
{
    partial class fPlanta
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
            this.dgPlanta = new System.Windows.Forms.DataGridView();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.lblNombEmpresaP = new System.Windows.Forms.Label();
            this.lblNombrePlanta = new System.Windows.Forms.Label();
            this.txtNombrePlanta = new System.Windows.Forms.TextBox();
            this.lblDireccionPlanta = new System.Windows.Forms.Label();
            this.txtDireccionPlanta = new System.Windows.Forms.TextBox();
            this.lblCiudadPlanta = new System.Windows.Forms.Label();
            this.txtCiudadPlanta = new System.Windows.Forms.TextBox();
            this.txtTelefonoPlanta = new System.Windows.Forms.TextBox();
            this.lblTelefonoPlanta = new System.Windows.Forms.Label();
            this.txtEmailPlanta = new System.Windows.Forms.TextBox();
            this.lblEmailPlanta = new System.Windows.Forms.Label();
            this.lblidPlanta = new System.Windows.Forms.Label();
            this.txtIdPlanta = new System.Windows.Forms.TextBox();
            this.tsEmpresa = new System.Windows.Forms.ToolStrip();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbGrabar = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tslEmpresaNombre = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanta)).BeginInit();
            this.tsEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgPlanta
            // 
            this.dgPlanta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlanta.Location = new System.Drawing.Point(12, 243);
            this.dgPlanta.Name = "dgPlanta";
            this.dgPlanta.Size = new System.Drawing.Size(594, 203);
            this.dgPlanta.TabIndex = 0;
            this.dgPlanta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPlanta_CellContentClick);
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(118, 53);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(152, 21);
            this.cmbEmpresa.TabIndex = 1;
            this.cmbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresa_SelectedIndexChanged);
            // 
            // lblNombEmpresaP
            // 
            this.lblNombEmpresaP.AutoSize = true;
            this.lblNombEmpresaP.Location = new System.Drawing.Point(24, 56);
            this.lblNombEmpresaP.Name = "lblNombEmpresaP";
            this.lblNombEmpresaP.Size = new System.Drawing.Size(88, 13);
            this.lblNombEmpresaP.TabIndex = 2;
            this.lblNombEmpresaP.Text = "Nombre Empresa";
            this.lblNombEmpresaP.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNombrePlanta
            // 
            this.lblNombrePlanta.AutoSize = true;
            this.lblNombrePlanta.Location = new System.Drawing.Point(24, 83);
            this.lblNombrePlanta.Name = "lblNombrePlanta";
            this.lblNombrePlanta.Size = new System.Drawing.Size(77, 13);
            this.lblNombrePlanta.TabIndex = 3;
            this.lblNombrePlanta.Text = "Nombre Planta";
            // 
            // txtNombrePlanta
            // 
            this.txtNombrePlanta.Location = new System.Drawing.Point(118, 80);
            this.txtNombrePlanta.Name = "txtNombrePlanta";
            this.txtNombrePlanta.Size = new System.Drawing.Size(178, 20);
            this.txtNombrePlanta.TabIndex = 4;
            // 
            // lblDireccionPlanta
            // 
            this.lblDireccionPlanta.AutoSize = true;
            this.lblDireccionPlanta.Location = new System.Drawing.Point(24, 109);
            this.lblDireccionPlanta.Name = "lblDireccionPlanta";
            this.lblDireccionPlanta.Size = new System.Drawing.Size(52, 13);
            this.lblDireccionPlanta.TabIndex = 5;
            this.lblDireccionPlanta.Text = "Dirección";
            // 
            // txtDireccionPlanta
            // 
            this.txtDireccionPlanta.Location = new System.Drawing.Point(118, 106);
            this.txtDireccionPlanta.Name = "txtDireccionPlanta";
            this.txtDireccionPlanta.Size = new System.Drawing.Size(178, 20);
            this.txtDireccionPlanta.TabIndex = 6;
            // 
            // lblCiudadPlanta
            // 
            this.lblCiudadPlanta.AutoSize = true;
            this.lblCiudadPlanta.Location = new System.Drawing.Point(24, 135);
            this.lblCiudadPlanta.Name = "lblCiudadPlanta";
            this.lblCiudadPlanta.Size = new System.Drawing.Size(40, 13);
            this.lblCiudadPlanta.TabIndex = 7;
            this.lblCiudadPlanta.Text = "Ciudad";
            // 
            // txtCiudadPlanta
            // 
            this.txtCiudadPlanta.Location = new System.Drawing.Point(118, 132);
            this.txtCiudadPlanta.Name = "txtCiudadPlanta";
            this.txtCiudadPlanta.Size = new System.Drawing.Size(178, 20);
            this.txtCiudadPlanta.TabIndex = 8;
            // 
            // txtTelefonoPlanta
            // 
            this.txtTelefonoPlanta.Location = new System.Drawing.Point(118, 158);
            this.txtTelefonoPlanta.Name = "txtTelefonoPlanta";
            this.txtTelefonoPlanta.Size = new System.Drawing.Size(101, 20);
            this.txtTelefonoPlanta.TabIndex = 9;
            // 
            // lblTelefonoPlanta
            // 
            this.lblTelefonoPlanta.AutoSize = true;
            this.lblTelefonoPlanta.Location = new System.Drawing.Point(24, 161);
            this.lblTelefonoPlanta.Name = "lblTelefonoPlanta";
            this.lblTelefonoPlanta.Size = new System.Drawing.Size(49, 13);
            this.lblTelefonoPlanta.TabIndex = 10;
            this.lblTelefonoPlanta.Text = "Teléfono";
            // 
            // txtEmailPlanta
            // 
            this.txtEmailPlanta.Location = new System.Drawing.Point(118, 184);
            this.txtEmailPlanta.Name = "txtEmailPlanta";
            this.txtEmailPlanta.Size = new System.Drawing.Size(101, 20);
            this.txtEmailPlanta.TabIndex = 11;
            // 
            // lblEmailPlanta
            // 
            this.lblEmailPlanta.AutoSize = true;
            this.lblEmailPlanta.Location = new System.Drawing.Point(24, 187);
            this.lblEmailPlanta.Name = "lblEmailPlanta";
            this.lblEmailPlanta.Size = new System.Drawing.Size(32, 13);
            this.lblEmailPlanta.TabIndex = 12;
            this.lblEmailPlanta.Text = "Email";
            // 
            // lblidPlanta
            // 
            this.lblidPlanta.AutoSize = true;
            this.lblidPlanta.Location = new System.Drawing.Point(372, 56);
            this.lblidPlanta.Name = "lblidPlanta";
            this.lblidPlanta.Size = new System.Drawing.Size(45, 13);
            this.lblidPlanta.TabIndex = 13;
            this.lblidPlanta.Text = "idPlanta";
            this.lblidPlanta.Visible = false;
            // 
            // txtIdPlanta
            // 
            this.txtIdPlanta.Location = new System.Drawing.Point(423, 53);
            this.txtIdPlanta.Name = "txtIdPlanta";
            this.txtIdPlanta.Size = new System.Drawing.Size(101, 20);
            this.txtIdPlanta.TabIndex = 14;
            this.txtIdPlanta.Visible = false;
            // 
            // tsEmpresa
            // 
            this.tsEmpresa.BackColor = System.Drawing.Color.Transparent;
            //this.tsEmpresa.BackgroundImage = global::Desarrollo.Properties.Resources.BarraBotones;
            this.tsEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsEmpresa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCerrar,
            this.tsbEliminar,
            this.tsbImprimir,
            this.tsEditar,
            this.tsbGrabar,
            this.tsbNuevo,
            this.tsbCancelar,
            this.tslEmpresaNombre});
            this.tsEmpresa.Location = new System.Drawing.Point(0, 0);
            this.tsEmpresa.Name = "tsEmpresa";
            this.tsEmpresa.Size = new System.Drawing.Size(646, 25);
            this.tsEmpresa.TabIndex = 64;
            this.tsEmpresa.Text = "toolStrip1";
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
            // 
            // tslEmpresaNombre
            // 
            this.tslEmpresaNombre.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tslEmpresaNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tslEmpresaNombre.Name = "tslEmpresaNombre";
            this.tslEmpresaNombre.Size = new System.Drawing.Size(69, 22);
            this.tslEmpresaNombre.Text = "EMPRESA";
            // 
            // fPlanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 460);
            this.Controls.Add(this.tsEmpresa);
            this.Controls.Add(this.txtIdPlanta);
            this.Controls.Add(this.lblidPlanta);
            this.Controls.Add(this.lblEmailPlanta);
            this.Controls.Add(this.txtEmailPlanta);
            this.Controls.Add(this.lblTelefonoPlanta);
            this.Controls.Add(this.txtTelefonoPlanta);
            this.Controls.Add(this.txtCiudadPlanta);
            this.Controls.Add(this.lblCiudadPlanta);
            this.Controls.Add(this.txtDireccionPlanta);
            this.Controls.Add(this.lblDireccionPlanta);
            this.Controls.Add(this.txtNombrePlanta);
            this.Controls.Add(this.lblNombrePlanta);
            this.Controls.Add(this.lblNombEmpresaP);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.dgPlanta);
            this.Name = "fPlanta";
            this.Text = "fPlanta";
            this.Load += new System.EventHandler(this.fPlanta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanta)).EndInit();
            this.tsEmpresa.ResumeLayout(false);
            this.tsEmpresa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPlanta;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Label lblNombEmpresaP;
        private System.Windows.Forms.Label lblNombrePlanta;
        private System.Windows.Forms.TextBox txtNombrePlanta;
        private System.Windows.Forms.Label lblDireccionPlanta;
        private System.Windows.Forms.TextBox txtDireccionPlanta;
        private System.Windows.Forms.Label lblCiudadPlanta;
        private System.Windows.Forms.TextBox txtCiudadPlanta;
        private System.Windows.Forms.TextBox txtTelefonoPlanta;
        private System.Windows.Forms.Label lblTelefonoPlanta;
        private System.Windows.Forms.TextBox txtEmailPlanta;
        private System.Windows.Forms.Label lblEmailPlanta;
        private System.Windows.Forms.Label lblidPlanta;
        private System.Windows.Forms.TextBox txtIdPlanta;
        private System.Windows.Forms.ToolStrip tsEmpresa;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.ToolStripButton tsEditar;
        private System.Windows.Forms.ToolStripButton tsbGrabar;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripLabel tslEmpresaNombre;
    }
}