namespace API.Formularios.Parametros
{
    partial class fConfiguracion
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblServidorMaestro = new System.Windows.Forms.Label();
            this.txtServidorMaestro = new System.Windows.Forms.TextBox();
            this.lblBaseEntidades = new System.Windows.Forms.Label();
            this.txtBaseEntidades = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblServidorCentral = new System.Windows.Forms.Label();
            this.txtServidorCentral = new System.Windows.Forms.TextBox();
            this.lblBaseCentral = new System.Windows.Forms.Label();
            this.txtBaseCentral = new System.Windows.Forms.TextBox();
            this.tsConfiguracion = new System.Windows.Forms.ToolStrip();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.tsbGrabar = new System.Windows.Forms.ToolStripButton();
            this.lblTitulo = new System.Windows.Forms.ToolStripLabel();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tsConfiguracion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServidorMaestro
            // 
            this.lblServidorMaestro.AutoSize = true;
            this.lblServidorMaestro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServidorMaestro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblServidorMaestro.Location = new System.Drawing.Point(37, 30);
            this.lblServidorMaestro.Margin = new System.Windows.Forms.Padding(0);
            this.lblServidorMaestro.Name = "lblServidorMaestro";
            this.lblServidorMaestro.Size = new System.Drawing.Size(60, 17);
            this.lblServidorMaestro.TabIndex = 50;
            this.lblServidorMaestro.Text = "Servidor:";
            this.lblServidorMaestro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtServidorMaestro
            // 
            this.txtServidorMaestro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtServidorMaestro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtServidorMaestro.Location = new System.Drawing.Point(100, 27);
            this.txtServidorMaestro.MaxLength = 200;
            this.txtServidorMaestro.Name = "txtServidorMaestro";
            this.txtServidorMaestro.Size = new System.Drawing.Size(279, 25);
            this.txtServidorMaestro.TabIndex = 0;
            this.txtServidorMaestro.Enter += new System.EventHandler(this.ControlLlegaELFoco);
            this.txtServidorMaestro.Leave += new System.EventHandler(this.ControlSeVaELFoco);
            // 
            // lblBaseEntidades
            // 
            this.lblBaseEntidades.AutoSize = true;
            this.lblBaseEntidades.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseEntidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBaseEntidades.Location = new System.Drawing.Point(3, 61);
            this.lblBaseEntidades.Margin = new System.Windows.Forms.Padding(0);
            this.lblBaseEntidades.Name = "lblBaseEntidades";
            this.lblBaseEntidades.Size = new System.Drawing.Size(94, 17);
            this.lblBaseEntidades.TabIndex = 52;
            this.lblBaseEntidades.Text = "Base de datos:";
            this.lblBaseEntidades.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBaseEntidades
            // 
            this.txtBaseEntidades.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBaseEntidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBaseEntidades.Location = new System.Drawing.Point(100, 58);
            this.txtBaseEntidades.MaxLength = 200;
            this.txtBaseEntidades.Name = "txtBaseEntidades";
            this.txtBaseEntidades.Size = new System.Drawing.Size(279, 25);
            this.txtBaseEntidades.TabIndex = 1;
            this.txtBaseEntidades.Enter += new System.EventHandler(this.ControlLlegaELFoco);
            this.txtBaseEntidades.Leave += new System.EventHandler(this.ControlSeVaELFoco);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblServidorMaestro);
            this.groupBox2.Controls.Add(this.txtServidorMaestro);
            this.groupBox2.Controls.Add(this.lblBaseEntidades);
            this.groupBox2.Controls.Add(this.txtBaseEntidades);
            this.groupBox2.Location = new System.Drawing.Point(6, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 100);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Maestro entidades";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Location = new System.Drawing.Point(12, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(645, 321);
            this.groupBox5.TabIndex = 80;
            this.groupBox5.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblServidorCentral);
            this.groupBox1.Controls.Add(this.txtServidorCentral);
            this.groupBox1.Controls.Add(this.lblBaseCentral);
            this.groupBox1.Controls.Add(this.txtBaseCentral);
            this.groupBox1.Location = new System.Drawing.Point(6, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 100);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Central";
            // 
            // lblServidorCentral
            // 
            this.lblServidorCentral.AutoSize = true;
            this.lblServidorCentral.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServidorCentral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblServidorCentral.Location = new System.Drawing.Point(37, 30);
            this.lblServidorCentral.Margin = new System.Windows.Forms.Padding(0);
            this.lblServidorCentral.Name = "lblServidorCentral";
            this.lblServidorCentral.Size = new System.Drawing.Size(60, 17);
            this.lblServidorCentral.TabIndex = 50;
            this.lblServidorCentral.Text = "Servidor:";
            this.lblServidorCentral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtServidorCentral
            // 
            this.txtServidorCentral.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtServidorCentral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtServidorCentral.Location = new System.Drawing.Point(100, 27);
            this.txtServidorCentral.MaxLength = 200;
            this.txtServidorCentral.Name = "txtServidorCentral";
            this.txtServidorCentral.Size = new System.Drawing.Size(279, 25);
            this.txtServidorCentral.TabIndex = 0;
            // 
            // lblBaseCentral
            // 
            this.lblBaseCentral.AutoSize = true;
            this.lblBaseCentral.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseCentral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBaseCentral.Location = new System.Drawing.Point(3, 61);
            this.lblBaseCentral.Margin = new System.Windows.Forms.Padding(0);
            this.lblBaseCentral.Name = "lblBaseCentral";
            this.lblBaseCentral.Size = new System.Drawing.Size(94, 17);
            this.lblBaseCentral.TabIndex = 52;
            this.lblBaseCentral.Text = "Base de datos:";
            this.lblBaseCentral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBaseCentral
            // 
            this.txtBaseCentral.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBaseCentral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBaseCentral.Location = new System.Drawing.Point(100, 58);
            this.txtBaseCentral.MaxLength = 200;
            this.txtBaseCentral.Name = "txtBaseCentral";
            this.txtBaseCentral.Size = new System.Drawing.Size(279, 25);
            this.txtBaseCentral.TabIndex = 1;
            // 
            // tsConfiguracion
            // 
            this.tsConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(198)))), ((int)(((byte)(205)))));
            this.tsConfiguracion.BackgroundImage = global::API.Properties.Resources.BarraBotones;
            this.tsConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsConfiguracion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCerrar,
            this.tsbGrabar,
            this.lblTitulo});
            this.tsConfiguracion.Location = new System.Drawing.Point(0, 0);
            this.tsConfiguracion.Name = "tsConfiguracion";
            this.tsConfiguracion.Size = new System.Drawing.Size(669, 25);
            this.tsConfiguracion.TabIndex = 68;
            this.tsConfiguracion.Text = "toolStrip1";
            this.tsConfiguracion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsConfiguracion_MouseDown);
            // 
            // tsbCerrar
            // 
            this.tsbCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tsbCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrar.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsbCerrar.Name = "tsbCerrar";
            this.tsbCerrar.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsbCerrar.Size = new System.Drawing.Size(59, 25);
            this.tsbCerrar.Text = "Cerrar";
            this.tsbCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbCerrar.Click += new System.EventHandler(this.tsbCerrar_Click);
            // 
            // tsbGrabar
            // 
            this.tsbGrabar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbGrabar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tsbGrabar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGrabar.Margin = new System.Windows.Forms.Padding(0);
            this.tsbGrabar.Name = "tsbGrabar";
            this.tsbGrabar.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsbGrabar.Size = new System.Drawing.Size(63, 25);
            this.tsbGrabar.Text = "Grabar";
            this.tsbGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbGrabar.Click += new System.EventHandler(this.tsbGrabar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(108, 22);
            this.lblTitulo.Text = "Configuración";
            // 
            // fConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(230)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(669, 361);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.tsConfiguracion);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(230)))), ((int)(((byte)(231)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fConfiguracion";
            this.ShowIcon = false;
            this.Tag = "Configuración";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.fConfiguracion_Load);
            this.Shown += new System.EventHandler(this.fConfiguracion_Shown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tsConfiguracion.ResumeLayout(false);
            this.tsConfiguracion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lblServidorMaestro;
        private System.Windows.Forms.TextBox txtServidorMaestro;
        private System.Windows.Forms.Label lblBaseEntidades;
        private System.Windows.Forms.TextBox txtBaseEntidades;
        private System.Windows.Forms.ToolStrip tsConfiguracion;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.ToolStripButton tsbGrabar;
        private System.Windows.Forms.ToolStripLabel lblTitulo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblServidorCentral;
        private System.Windows.Forms.TextBox txtServidorCentral;
        private System.Windows.Forms.Label lblBaseCentral;
        private System.Windows.Forms.TextBox txtBaseCentral;
    }
}