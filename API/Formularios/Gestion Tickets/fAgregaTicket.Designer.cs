namespace API.Formularios.Gestion_Tickets
{
    partial class fAgregaTicket
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
            this.tsAgregaTicket = new System.Windows.Forms.ToolStrip();
            this.tsbCerrarAddTicket = new System.Windows.Forms.ToolStripButton();
            this.tsbGrabarAddTicket = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevoAddTicket = new System.Windows.Forms.ToolStripButton();
            this.tslAgregaTicket = new System.Windows.Forms.ToolStripLabel();
            this.tsbCancelarAddTicket = new System.Windows.Forms.ToolStripButton();
            this.lblUserAtendido = new System.Windows.Forms.Label();
            this.btnBuscarUsuarioAddTicket = new System.Windows.Forms.Button();
            this.txtNombreUsuarioAddTicket = new System.Windows.Forms.TextBox();
            this.lblTituloTicket = new System.Windows.Forms.Label();
            this.txtTituloTicket = new System.Windows.Forms.TextBox();
            this.txtDescripTicket = new System.Windows.Forms.TextBox();
            this.lblDescripTicket = new System.Windows.Forms.Label();
            this.cmbTipoTicket = new System.Windows.Forms.ComboBox();
            this.lblTipoTicket = new System.Windows.Forms.Label();
            this.lblPrioridadTicket = new System.Windows.Forms.Label();
            this.cmbPrioridadTicket = new System.Windows.Forms.ComboBox();
            this.tsAgregaTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsAgregaTicket
            // 
            this.tsAgregaTicket.BackColor = System.Drawing.Color.Transparent;
            this.tsAgregaTicket.BackgroundImage = global::API.Properties.Resources.BarraBotones;
            this.tsAgregaTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsAgregaTicket.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCerrarAddTicket,
            this.tsbGrabarAddTicket,
            this.tsbNuevoAddTicket,
            this.tsbCancelarAddTicket,
            this.tslAgregaTicket});
            this.tsAgregaTicket.Location = new System.Drawing.Point(0, 0);
            this.tsAgregaTicket.Name = "tsAgregaTicket";
            this.tsAgregaTicket.Size = new System.Drawing.Size(653, 25);
            this.tsAgregaTicket.TabIndex = 67;
            this.tsAgregaTicket.Text = "toolStrip1";
            this.tsAgregaTicket.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsAgregaTicket_MouseDown);
            // 
            // tsbCerrarAddTicket
            // 
            this.tsbCerrarAddTicket.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrarAddTicket.AutoSize = false;
            this.tsbCerrarAddTicket.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsbCerrarAddTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbCerrarAddTicket.Image = global::API.Properties.Resources.Cerrar_16;
            this.tsbCerrarAddTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbCerrarAddTicket.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrarAddTicket.Name = "tsbCerrarAddTicket";
            this.tsbCerrarAddTicket.Size = new System.Drawing.Size(70, 22);
            this.tsbCerrarAddTicket.Text = "Cerrar";
            this.tsbCerrarAddTicket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbCerrarAddTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbCerrarAddTicket.Click += new System.EventHandler(this.tsbCerrarAddTicket_Click);
            // 
            // tsbGrabarAddTicket
            // 
            this.tsbGrabarAddTicket.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbGrabarAddTicket.AutoSize = false;
            this.tsbGrabarAddTicket.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsbGrabarAddTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbGrabarAddTicket.Image = global::API.Properties.Resources.Grabar2;
            this.tsbGrabarAddTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbGrabarAddTicket.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGrabarAddTicket.Name = "tsbGrabarAddTicket";
            this.tsbGrabarAddTicket.Size = new System.Drawing.Size(80, 22);
            this.tsbGrabarAddTicket.Text = "Grabar";
            this.tsbGrabarAddTicket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbGrabarAddTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbGrabarAddTicket.Click += new System.EventHandler(this.tsbGrabarAddTicket_Click);
            // 
            // tsbNuevoAddTicket
            // 
            this.tsbNuevoAddTicket.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbNuevoAddTicket.AutoSize = false;
            this.tsbNuevoAddTicket.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsbNuevoAddTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbNuevoAddTicket.Image = global::API.Properties.Resources.Nuevo_18;
            this.tsbNuevoAddTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbNuevoAddTicket.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevoAddTicket.Name = "tsbNuevoAddTicket";
            this.tsbNuevoAddTicket.Size = new System.Drawing.Size(80, 22);
            this.tsbNuevoAddTicket.Text = "Nuevo";
            this.tsbNuevoAddTicket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbNuevoAddTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tslAgregaTicket
            // 
            this.tslAgregaTicket.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tslAgregaTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tslAgregaTicket.Name = "tslAgregaTicket";
            this.tslAgregaTicket.Size = new System.Drawing.Size(105, 22);
            this.tslAgregaTicket.Text = "Agregar Ticket";
            // 
            // tsbCancelarAddTicket
            // 
            this.tsbCancelarAddTicket.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCancelarAddTicket.AutoSize = false;
            this.tsbCancelarAddTicket.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsbCancelarAddTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbCancelarAddTicket.Image = global::API.Properties.Resources.cancel_icon;
            this.tsbCancelarAddTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbCancelarAddTicket.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelarAddTicket.Name = "tsbCancelarAddTicket";
            this.tsbCancelarAddTicket.Size = new System.Drawing.Size(90, 22);
            this.tsbCancelarAddTicket.Text = "Cancelar";
            this.tsbCancelarAddTicket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbCancelarAddTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // lblUserAtendido
            // 
            this.lblUserAtendido.AutoSize = true;
            this.lblUserAtendido.Location = new System.Drawing.Point(37, 50);
            this.lblUserAtendido.Name = "lblUserAtendido";
            this.lblUserAtendido.Size = new System.Drawing.Size(110, 17);
            this.lblUserAtendido.TabIndex = 68;
            this.lblUserAtendido.Text = "Usuario Atendido";
            // 
            // btnBuscarUsuarioAddTicket
            // 
            this.btnBuscarUsuarioAddTicket.Image = global::API.Properties.Resources.Buscar_16;
            this.btnBuscarUsuarioAddTicket.Location = new System.Drawing.Point(153, 46);
            this.btnBuscarUsuarioAddTicket.Name = "btnBuscarUsuarioAddTicket";
            this.btnBuscarUsuarioAddTicket.Size = new System.Drawing.Size(28, 25);
            this.btnBuscarUsuarioAddTicket.TabIndex = 69;
            this.btnBuscarUsuarioAddTicket.UseVisualStyleBackColor = true;
            this.btnBuscarUsuarioAddTicket.Click += new System.EventHandler(this.btnBuscarUsuarioAddTicket_Click);
            // 
            // txtNombreUsuarioAddTicket
            // 
            this.txtNombreUsuarioAddTicket.Enabled = false;
            this.txtNombreUsuarioAddTicket.Location = new System.Drawing.Point(187, 46);
            this.txtNombreUsuarioAddTicket.Name = "txtNombreUsuarioAddTicket";
            this.txtNombreUsuarioAddTicket.Size = new System.Drawing.Size(184, 25);
            this.txtNombreUsuarioAddTicket.TabIndex = 70;
            // 
            // lblTituloTicket
            // 
            this.lblTituloTicket.AutoSize = true;
            this.lblTituloTicket.Location = new System.Drawing.Point(70, 80);
            this.lblTituloTicket.Name = "lblTituloTicket";
            this.lblTituloTicket.Size = new System.Drawing.Size(77, 17);
            this.lblTituloTicket.TabIndex = 71;
            this.lblTituloTicket.Text = "Titulo Ticket";
            // 
            // txtTituloTicket
            // 
            this.txtTituloTicket.Location = new System.Drawing.Point(153, 77);
            this.txtTituloTicket.MaxLength = 20;
            this.txtTituloTicket.Name = "txtTituloTicket";
            this.txtTituloTicket.Size = new System.Drawing.Size(218, 25);
            this.txtTituloTicket.TabIndex = 72;
            // 
            // txtDescripTicket
            // 
            this.txtDescripTicket.Location = new System.Drawing.Point(153, 170);
            this.txtDescripTicket.MaxLength = 255;
            this.txtDescripTicket.Multiline = true;
            this.txtDescripTicket.Name = "txtDescripTicket";
            this.txtDescripTicket.Size = new System.Drawing.Size(388, 146);
            this.txtDescripTicket.TabIndex = 73;
            // 
            // lblDescripTicket
            // 
            this.lblDescripTicket.AutoSize = true;
            this.lblDescripTicket.Location = new System.Drawing.Point(34, 170);
            this.lblDescripTicket.Name = "lblDescripTicket";
            this.lblDescripTicket.Size = new System.Drawing.Size(113, 17);
            this.lblDescripTicket.TabIndex = 74;
            this.lblDescripTicket.Text = "Descripcion Ticket";
            // 
            // cmbTipoTicket
            // 
            this.cmbTipoTicket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTicket.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoTicket.FormattingEnabled = true;
            this.cmbTipoTicket.Location = new System.Drawing.Point(153, 108);
            this.cmbTipoTicket.Name = "cmbTipoTicket";
            this.cmbTipoTicket.Size = new System.Drawing.Size(164, 25);
            this.cmbTipoTicket.TabIndex = 75;
            this.cmbTipoTicket.SelectionChangeCommitted += new System.EventHandler(this.cmbTipoTicket_SelectionChangeCommitted);
            // 
            // lblTipoTicket
            // 
            this.lblTipoTicket.AutoSize = true;
            this.lblTipoTicket.Location = new System.Drawing.Point(76, 111);
            this.lblTipoTicket.Name = "lblTipoTicket";
            this.lblTipoTicket.Size = new System.Drawing.Size(71, 17);
            this.lblTipoTicket.TabIndex = 76;
            this.lblTipoTicket.Text = "Tipo Ticket";
            // 
            // lblPrioridadTicket
            // 
            this.lblPrioridadTicket.AutoSize = true;
            this.lblPrioridadTicket.Location = new System.Drawing.Point(85, 142);
            this.lblPrioridadTicket.Name = "lblPrioridadTicket";
            this.lblPrioridadTicket.Size = new System.Drawing.Size(62, 17);
            this.lblPrioridadTicket.TabIndex = 77;
            this.lblPrioridadTicket.Text = "Prioridad";
            // 
            // cmbPrioridadTicket
            // 
            this.cmbPrioridadTicket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridadTicket.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrioridadTicket.FormattingEnabled = true;
            this.cmbPrioridadTicket.Location = new System.Drawing.Point(153, 139);
            this.cmbPrioridadTicket.Name = "cmbPrioridadTicket";
            this.cmbPrioridadTicket.Size = new System.Drawing.Size(164, 25);
            this.cmbPrioridadTicket.TabIndex = 78;
            this.cmbPrioridadTicket.SelectionChangeCommitted += new System.EventHandler(this.cmbPrioridadTicket_SelectionChangeCommitted);
            // 
            // fAgregaTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 360);
            this.Controls.Add(this.cmbPrioridadTicket);
            this.Controls.Add(this.lblPrioridadTicket);
            this.Controls.Add(this.lblTipoTicket);
            this.Controls.Add(this.cmbTipoTicket);
            this.Controls.Add(this.lblDescripTicket);
            this.Controls.Add(this.txtDescripTicket);
            this.Controls.Add(this.txtTituloTicket);
            this.Controls.Add(this.lblTituloTicket);
            this.Controls.Add(this.txtNombreUsuarioAddTicket);
            this.Controls.Add(this.btnBuscarUsuarioAddTicket);
            this.Controls.Add(this.lblUserAtendido);
            this.Controls.Add(this.tsAgregaTicket);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fAgregaTicket";
            this.Text = "fAgregaTicket";
            this.Load += new System.EventHandler(this.fAgregaTicket_Load);
            this.tsAgregaTicket.ResumeLayout(false);
            this.tsAgregaTicket.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsAgregaTicket;
        private System.Windows.Forms.ToolStripButton tsbCerrarAddTicket;
        private System.Windows.Forms.ToolStripButton tsbGrabarAddTicket;
        private System.Windows.Forms.ToolStripButton tsbNuevoAddTicket;
        private System.Windows.Forms.ToolStripButton tsbCancelarAddTicket;
        private System.Windows.Forms.ToolStripLabel tslAgregaTicket;
        private System.Windows.Forms.Label lblUserAtendido;
        private System.Windows.Forms.Button btnBuscarUsuarioAddTicket;
        private System.Windows.Forms.TextBox txtNombreUsuarioAddTicket;
        private System.Windows.Forms.Label lblTituloTicket;
        private System.Windows.Forms.TextBox txtTituloTicket;
        private System.Windows.Forms.TextBox txtDescripTicket;
        private System.Windows.Forms.Label lblDescripTicket;
        private System.Windows.Forms.ComboBox cmbTipoTicket;
        private System.Windows.Forms.Label lblTipoTicket;
        private System.Windows.Forms.Label lblPrioridadTicket;
        private System.Windows.Forms.ComboBox cmbPrioridadTicket;
    }
}