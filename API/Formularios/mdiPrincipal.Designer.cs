namespace API.Formularios
{
    partial class mdiPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiPrincipal));
            this.sstPrincipal = new System.Windows.Forms.StatusStrip();
            this.Proceso = new System.Windows.Forms.ToolStripStatusLabel();
            this.BarraProgreso = new System.Windows.Forms.ToolStripProgressBar();
            this.Version = new System.Windows.Forms.ToolStripStatusLabel();
            this.Usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.Perfil = new System.Windows.Forms.ToolStripStatusLabel();
            this.EstacionDeTrabajo = new System.Windows.Forms.ToolStripStatusLabel();
            this.Servidor = new System.Windows.Forms.ToolStripStatusLabel();
            this.BaseDeDatos = new System.Windows.Forms.ToolStripStatusLabel();
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmParametros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmActivos = new System.Windows.Forms.ToolStripMenuItem();
            this.activoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asociarActivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBuscaxUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBusquedas = new System.Windows.Forms.ToolStripMenuItem();
            this.tslItemBusqueda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBusqActxUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMaestros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.modeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tslUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tslArea = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAuditoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAuditoria = new System.Windows.Forms.ToolStripMenuItem();
            this.finToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmActualizacionDeControles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalirSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListadoHardware = new System.Windows.Forms.ToolStripMenuItem();
            this.sstPrincipal.SuspendLayout();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // sstPrincipal
            // 
            this.sstPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Proceso,
            this.BarraProgreso,
            this.Version,
            this.Usuario,
            this.Perfil,
            this.EstacionDeTrabajo,
            this.Servidor,
            this.BaseDeDatos});
            this.sstPrincipal.Location = new System.Drawing.Point(0, 533);
            this.sstPrincipal.Name = "sstPrincipal";
            this.sstPrincipal.Size = new System.Drawing.Size(1159, 33);
            this.sstPrincipal.TabIndex = 21;
            this.sstPrincipal.Text = "statusStrip1";
            // 
            // Proceso
            // 
            this.Proceso.AutoSize = false;
            this.Proceso.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.Proceso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proceso.Name = "Proceso";
            this.Proceso.Size = new System.Drawing.Size(400, 28);
            this.Proceso.Text = "proceso";
            this.Proceso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BarraProgreso
            // 
            this.BarraProgreso.AutoSize = false;
            this.BarraProgreso.Name = "BarraProgreso";
            this.BarraProgreso.Size = new System.Drawing.Size(150, 27);
            // 
            // Version
            // 
            this.Version.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.Version.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(49, 28);
            this.Version.Text = "versión";
            // 
            // Usuario
            // 
            this.Usuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.Usuario.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(50, 28);
            this.Usuario.Text = "usuario";
            // 
            // Perfil
            // 
            this.Perfil.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.Perfil.Name = "Perfil";
            this.Perfil.Size = new System.Drawing.Size(38, 28);
            this.Perfil.Text = "Perfil";
            // 
            // EstacionDeTrabajo
            // 
            this.EstacionDeTrabajo.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.EstacionDeTrabajo.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.EstacionDeTrabajo.Name = "EstacionDeTrabajo";
            this.EstacionDeTrabajo.Size = new System.Drawing.Size(55, 28);
            this.EstacionDeTrabajo.Text = "estación";
            // 
            // Servidor
            // 
            this.Servidor.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.Servidor.Name = "Servidor";
            this.Servidor.Size = new System.Drawing.Size(54, 28);
            this.Servidor.Text = "Servidor";
            this.Servidor.Visible = false;
            // 
            // BaseDeDatos
            // 
            this.BaseDeDatos.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.BaseDeDatos.Name = "BaseDeDatos";
            this.BaseDeDatos.Size = new System.Drawing.Size(79, 28);
            this.BaseDeDatos.Text = "BaseDeDatos";
            this.BaseDeDatos.Visible = false;
            // 
            // msPrincipal
            // 
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmParametros,
            this.tsmActivos,
            this.tsmBusquedas,
            this.tsmMaestros,
            this.tsmAuditoria,
            this.finToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(1159, 24);
            this.msPrincipal.TabIndex = 23;
            this.msPrincipal.Text = "Menú principal del Sistema de Gestión Integrado";
            // 
            // tsmParametros
            // 
            this.tsmParametros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmConfiguracion});
            this.tsmParametros.Name = "tsmParametros";
            this.tsmParametros.Size = new System.Drawing.Size(79, 20);
            this.tsmParametros.Tag = "-";
            this.tsmParametros.Text = "Parámetros";
            // 
            // tsmConfiguracion
            // 
            this.tsmConfiguracion.Name = "tsmConfiguracion";
            this.tsmConfiguracion.Size = new System.Drawing.Size(150, 22);
            this.tsmConfiguracion.Tag = "fConfiguracion";
            this.tsmConfiguracion.Text = "Configuración";
            this.tsmConfiguracion.Click += new System.EventHandler(this.tsmConfiguracion_Click);
            // 
            // tsmActivos
            // 
            this.tsmActivos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activoToolStripMenuItem,
            this.asociarActivoToolStripMenuItem,
            this.tsmBuscaxUsuario});
            this.tsmActivos.Name = "tsmActivos";
            this.tsmActivos.Size = new System.Drawing.Size(53, 20);
            this.tsmActivos.Tag = "-";
            this.tsmActivos.Text = "Activo";
            // 
            // activoToolStripMenuItem
            // 
            this.activoToolStripMenuItem.Name = "activoToolStripMenuItem";
            this.activoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.activoToolStripMenuItem.Tag = "fActivo";
            this.activoToolStripMenuItem.Text = "Activo";
            this.activoToolStripMenuItem.Click += new System.EventHandler(this.activoToolStripMenuItem_Click);
            // 
            // asociarActivoToolStripMenuItem
            // 
            this.asociarActivoToolStripMenuItem.Name = "asociarActivoToolStripMenuItem";
            this.asociarActivoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.asociarActivoToolStripMenuItem.Tag = "fAsociaActivo";
            this.asociarActivoToolStripMenuItem.Text = "Asociar Activo";
            this.asociarActivoToolStripMenuItem.Click += new System.EventHandler(this.asociarActivoToolStripMenuItem_Click);
            // 
            // tsmBuscaxUsuario
            // 
            this.tsmBuscaxUsuario.Name = "tsmBuscaxUsuario";
            this.tsmBuscaxUsuario.Size = new System.Drawing.Size(190, 22);
            this.tsmBuscaxUsuario.Tag = "fBusquedaActivos";
            this.tsmBuscaxUsuario.Text = "Búsqueda por Usuario";
            this.tsmBuscaxUsuario.Click += new System.EventHandler(this.tsmBuscaxUsuario_Click);
            // 
            // tsmBusquedas
            // 
            this.tsmBusquedas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslItemBusqueda,
            this.tsmBusqActxUsuario,
            this.tsmListadoHardware});
            this.tsmBusquedas.Name = "tsmBusquedas";
            this.tsmBusquedas.Size = new System.Drawing.Size(76, 20);
            this.tsmBusquedas.Tag = "-";
            this.tsmBusquedas.Text = "Búsquedas";
            // 
            // tslItemBusqueda
            // 
            this.tslItemBusqueda.Name = "tslItemBusqueda";
            this.tslItemBusqueda.Size = new System.Drawing.Size(226, 22);
            this.tslItemBusqueda.Tag = "fBusqueda";
            this.tslItemBusqueda.Text = "Búsqueda";
            this.tslItemBusqueda.Click += new System.EventHandler(this.tslItemBusqueda_Click);
            // 
            // tsmBusqActxUsuario
            // 
            this.tsmBusqActxUsuario.Name = "tsmBusqActxUsuario";
            this.tsmBusqActxUsuario.Size = new System.Drawing.Size(226, 22);
            this.tsmBusqActxUsuario.Tag = "fBusquedaActivos";
            this.tsmBusqActxUsuario.Text = "Búsqueda Activo por usuario";
            this.tsmBusqActxUsuario.Click += new System.EventHandler(this.tsmBusqActxUsuario_Click);
            // 
            // tsmMaestros
            // 
            this.tsmMaestros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMarca,
            this.modeloToolStripMenuItem,
            this.tslUsuario,
            this.tslArea});
            this.tsmMaestros.Name = "tsmMaestros";
            this.tsmMaestros.Size = new System.Drawing.Size(67, 20);
            this.tsmMaestros.Tag = "-";
            this.tsmMaestros.Text = "Maestros";
            // 
            // tsmMarca
            // 
            this.tsmMarca.Name = "tsmMarca";
            this.tsmMarca.Size = new System.Drawing.Size(115, 22);
            this.tsmMarca.Tag = "fMarca";
            this.tsmMarca.Text = "Marca";
            this.tsmMarca.Click += new System.EventHandler(this.tsmMarca_Click_1);
            // 
            // modeloToolStripMenuItem
            // 
            this.modeloToolStripMenuItem.Name = "modeloToolStripMenuItem";
            this.modeloToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.modeloToolStripMenuItem.Tag = "fModelo";
            this.modeloToolStripMenuItem.Text = "Modelo";
            this.modeloToolStripMenuItem.Click += new System.EventHandler(this.modeloToolStripMenuItem_Click);
            // 
            // tslUsuario
            // 
            this.tslUsuario.Name = "tslUsuario";
            this.tslUsuario.Size = new System.Drawing.Size(115, 22);
            this.tslUsuario.Tag = "fUsuario";
            this.tslUsuario.Text = "Usuario";
            this.tslUsuario.Click += new System.EventHandler(this.tslUsuario_Click);
            // 
            // tslArea
            // 
            this.tslArea.Name = "tslArea";
            this.tslArea.Size = new System.Drawing.Size(115, 22);
            this.tslArea.Tag = "fArea";
            this.tslArea.Text = "Área";
            this.tslArea.Click += new System.EventHandler(this.tslArea_Click);
            // 
            // tsmAuditoria
            // 
            this.tsmAuditoria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAuditoria});
            this.tsmAuditoria.Name = "tsmAuditoria";
            this.tsmAuditoria.Size = new System.Drawing.Size(68, 20);
            this.tsmAuditoria.Tag = "-";
            this.tsmAuditoria.Text = "Auditoría";
            // 
            // tsAuditoria
            // 
            this.tsAuditoria.Name = "tsAuditoria";
            this.tsAuditoria.Size = new System.Drawing.Size(123, 22);
            this.tsAuditoria.Tag = "fAuditoria";
            this.tsAuditoria.Text = "Auditoría";
            this.tsAuditoria.Click += new System.EventHandler(this.tsAuditoria_Click);
            // 
            // finToolStripMenuItem
            // 
            this.finToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAcercaDe,
            this.tsmActualizacionDeControles,
            this.toolStripSeparator1,
            this.tsmCerrarSesion,
            this.tsmSalirSistema});
            this.finToolStripMenuItem.Name = "finToolStripMenuItem";
            this.finToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.finToolStripMenuItem.Tag = "-";
            this.finToolStripMenuItem.Text = "Fin";
            // 
            // tsmAcercaDe
            // 
            this.tsmAcercaDe.Name = "tsmAcercaDe";
            this.tsmAcercaDe.Size = new System.Drawing.Size(213, 22);
            this.tsmAcercaDe.Tag = "-";
            this.tsmAcercaDe.Text = "Acerca de";
            this.tsmAcercaDe.Click += new System.EventHandler(this.tsmAcercaDe_Click);
            // 
            // tsmActualizacionDeControles
            // 
            this.tsmActualizacionDeControles.Name = "tsmActualizacionDeControles";
            this.tsmActualizacionDeControles.Size = new System.Drawing.Size(213, 22);
            this.tsmActualizacionDeControles.Tag = "fActualizaControlAcceso";
            this.tsmActualizacionDeControles.Text = "Actualizacion de controles";
            this.tsmActualizacionDeControles.Click += new System.EventHandler(this.tsmActualizacionDeControles_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // tsmCerrarSesion
            // 
            this.tsmCerrarSesion.Name = "tsmCerrarSesion";
            this.tsmCerrarSesion.Size = new System.Drawing.Size(213, 22);
            this.tsmCerrarSesion.Tag = "-";
            this.tsmCerrarSesion.Text = "Cerrar sesión";
            this.tsmCerrarSesion.Click += new System.EventHandler(this.tsmCerrarSesion_Click);
            // 
            // tsmSalirSistema
            // 
            this.tsmSalirSistema.Name = "tsmSalirSistema";
            this.tsmSalirSistema.Size = new System.Drawing.Size(213, 22);
            this.tsmSalirSistema.Tag = "-";
            this.tsmSalirSistema.Text = "Salir del sistema";
            this.tsmSalirSistema.Click += new System.EventHandler(this.tsmSalirSistema_Click);
            // 
            // tsmListadoHardware
            // 
            this.tsmListadoHardware.Name = "tsmListadoHardware";
            this.tsmListadoHardware.Size = new System.Drawing.Size(226, 22);
            this.tsmListadoHardware.Text = "Listado de Hardware";
            this.tsmListadoHardware.Click += new System.EventHandler(this.tsmListadoHardware_Click);
            // 
            // mdiPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1159, 566);
            this.Controls.Add(this.sstPrincipal);
            this.Controls.Add(this.msPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msPrincipal;
            this.Name = "mdiPrincipal";
            this.Text = "Administración plataforma informática";
            this.Load += new System.EventHandler(this.mdiPrincipal_Load);
            this.Shown += new System.EventHandler(this.mdiPrincipal_Shown);
            this.sstPrincipal.ResumeLayout(false);
            this.sstPrincipal.PerformLayout();
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip sstPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel Proceso;
        private System.Windows.Forms.ToolStripProgressBar BarraProgreso;
        private System.Windows.Forms.ToolStripStatusLabel Version;
        private System.Windows.Forms.ToolStripStatusLabel Usuario;
        private System.Windows.Forms.ToolStripStatusLabel Perfil;
        private System.Windows.Forms.ToolStripStatusLabel EstacionDeTrabajo;
        private System.Windows.Forms.ToolStripStatusLabel Servidor;
        private System.Windows.Forms.ToolStripStatusLabel BaseDeDatos;
        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmParametros;
        private System.Windows.Forms.ToolStripMenuItem finToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem tsmCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmSalirSistema;
        private System.Windows.Forms.ToolStripMenuItem tsmActualizacionDeControles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmConfiguracion;
        private System.Windows.Forms.ToolStripMenuItem tsmMaestros;
        private System.Windows.Forms.ToolStripMenuItem tsmMarca;
        private System.Windows.Forms.ToolStripMenuItem tsmActivos;
        private System.Windows.Forms.ToolStripMenuItem tslArea;
        private System.Windows.Forms.ToolStripMenuItem tslUsuario;
        private System.Windows.Forms.ToolStripMenuItem modeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asociarActivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmBuscaxUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmAuditoria;
        private System.Windows.Forms.ToolStripMenuItem tsAuditoria;
        private System.Windows.Forms.ToolStripMenuItem tsmBusquedas;
        private System.Windows.Forms.ToolStripMenuItem tslItemBusqueda;
        private System.Windows.Forms.ToolStripMenuItem tsmBusqActxUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmListadoHardware;
    }
}



