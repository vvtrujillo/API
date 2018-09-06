using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using API.Fin;
using API.Formularios.Parametros;
using API.Formularios.Maestros;
using API.Formularios.Activo;
using API.Formularios.Auditoria;
using API.Formularios.Busquedas;



namespace API.Formularios
{
    public partial class mdiPrincipal : Form
    {
        //Declaraciones para mover el formulario desde el panel del titulo
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //Fin declaraciones para mover el formulario

        clMSC.clMSC Rutinas = new clMSC.clMSC();

        public Color cColorFondoConFoco = Color.White;
        public Color cColorFondoSinFoco = Color.FromArgb(208, 216, 217);
        public string cConexionSQLMaestro = string.Empty;
        public string cConexionSQLCentral = string.Empty;


        public mdiPrincipal()
        {
            InitializeComponent();
        }

        private void IniciarSistema()
        {
            sstPrincipal.Items["Proceso"].Text = "Sistema ...";
            sstPrincipal.Items["Version"].Text = "Versión: " + Properties.Settings.Default.VersionSistema;
            sstPrincipal.Items["Usuario"].Text = Properties.Settings.Default.Nombre + " / " + Properties.Settings.Default.Login;
            sstPrincipal.Items["Perfil"].Text = "Perfil: " + Properties.Settings.Default.Perfil;
            sstPrincipal.Items["EstacionDeTrabajo"].Text = "Estación de trabajo: " + System.Environment.MachineName;
            sstPrincipal.Items["Servidor"].Text = "Servidor: " + Properties.Settings.Default.ServidorSQLCentral;
            sstPrincipal.Items["BaseDeDatos"].Text = "Base de datos: " + Properties.Settings.Default.BaseSQLCentral;            

            //cConexionSQLMaestro = "server=" + Properties.Settings.Default.ServidorSQLMaestroEntidades + ";Integrated security=false;database=" + Properties.Settings.Default.BaseSQLMaestroEntidades + ";User=sa;Password=molinera";
            cConexionSQLCentral = "server=" + Properties.Settings.Default.ServidorSQLCentral + ";Integrated security=false;database=" + Properties.Settings.Default.BaseSQLCentral + ";User=sa;Password=molinera";
            cConexionSQLMaestro = "server=" + Properties.Settings.Default.ServidorSQLMaestroEntidades + ";Integrated security=false;database=" + Properties.Settings.Default.BaseSQLMaestroEntidades + ";User=cmsc;Password=CMSC_Sql2017";

            Properties.Settings.Default.Save();

            Rutinas.AplicarAccesoAMenuPrincipal(ref msPrincipal, Properties.Settings.Default.PrivilegioAccesoMenu);
        }



        private void mdiPrincipal_Load(object sender, EventArgs e)
        {
            IniciarSistema();
        }
        private void mdiPrincipal_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void tsmSalirSistema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void tsmCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            foreach (Form a in this.MdiChildren)
            {
                a.Close();
            }
            System.Diagnostics.Process.Start(@Properties.Settings.Default.RutaProgramaAcceso);
            this.Close();
        }       
        private void tsmConfiguracion_Click(object sender, EventArgs e)
        {
            if (!Rutinas.ChequearFormularioActivo(this, "fConfiguracion", sstPrincipal))
            {
                fConfiguracion fAux = new fConfiguracion();
                sstPrincipal.Items["Proceso"].Text = "Configuración";
                Rutinas.AplicarAccesoAFuncionalidad(fAux, Properties.Settings.Default.PrivilegioAccesoFuncionalidad);
                fAux.FormularioPadre = this;
                fAux.ConexionCentral = cConexionSQLCentral;                    
                fAux.StartPosition = FormStartPosition.CenterScreen;
                fAux.AutoScaleMode = AutoScaleMode.None;
                fAux.MdiParent = this;
                fAux.Show();
                fAux.Focus();
            }
        }
        private void tsmActualizacionDeControles_Click(object sender, EventArgs e)
        {
            if(!Rutinas.ChequearFormularioActivo(this, "fActualizaControlAcceso",sstPrincipal))
            {
                fActualizaControlAcceso fAux = new fActualizaControlAcceso();
                sstPrincipal.Items["Proceso"].Text = "Actualización de controles";
                fAux.FormularioPadre = this;
                Rutinas.AplicarAccesoAFuncionalidad(fAux, Properties.Settings.Default.PrivilegioAccesoFuncionalidad);
                fAux.MdiParent = this;
                fAux.StartPosition = FormStartPosition.CenterScreen;
                fAux.TopLevel = false;
                fAux.AutoScaleMode = AutoScaleMode.None;
                fAux.Show();
                fAux.Focus();
            }
        }
        private void tsmAcercaDe_Click(object sender, EventArgs e)
        {
            if (!Rutinas.ChequearFormularioActivo(this, "fAcercaDe", sstPrincipal))
            {
                fAcercaDe fAux = new fAcercaDe();
                sstPrincipal.Items["Proceso"].Text = "Acerca de";
                Rutinas.AplicarAccesoAFuncionalidad(fAux, Properties.Settings.Default.PrivilegioAccesoFuncionalidad);
                fAux.FormularioPadre = this;
                fAux.MdiParent = this;
                fAux.StartPosition = FormStartPosition.CenterScreen;
                fAux.TopLevel = false;
                fAux.AutoScaleMode = AutoScaleMode.None;
                fAux.Show();
                fAux.Focus();
            }
        }
        
        private void tsmEmpresa_Click(object sender, EventArgs e)
        {
            Empresa faux = new Empresa();
            sstPrincipal.Items["Proceso"].Text = "Acerca de";
            Rutinas.AplicarAccesoAFuncionalidad(faux, Properties.Settings.Default.PrivilegioAccesoFuncionalidad);
            faux.FormularioPadre = this;
            faux.MdiParent = this;
            faux.ConexionSQL = cConexionSQLCentral;
            faux.ConexionSQL = cConexionSQLMaestro;
            faux.StartPosition = FormStartPosition.CenterScreen;
            faux.TopLevel = false;
            faux.AutoScaleMode = AutoScaleMode.None;
            faux.Show();
            faux.Focus();
        }

        private void tsmMarca_Click(object sender, EventArgs e)
        {
            
        }

        private void formularioEjemploToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!Rutinas.ChequearFormularioActivo(this, "fParametroEstanqueTipo", sstPrincipal))
            //{
            //    fParametroEstanqueTipo fAux = new fParametroEstanqueTipo();
            //    sstPrincipal.Items["Proceso"].Text = "Ejemplo";
            //    Rutinas.AplicarAccesoAFuncionalidad(fAux, Properties.Settings.Default.PrivilegioAccesoFuncionalidad);
            //    fAux.FormularioPadre = this;
            //    fAux.MdiParent = this;
            //    fAux.ConexionSQL = cConexionSQLCentral;
            //    fAux.StartPosition = FormStartPosition.CenterScreen;
            //    fAux.TopLevel = false;
            //    fAux.AutoScaleMode = AutoScaleMode.None;
            //    fAux.Show();
            //    fAux.Focus();
            //}
        }
        
        private void tsmPlanta_Click_1(object sender, EventArgs e)
        {
            fPlanta faux = new fPlanta();
            sstPrincipal.Items["Proceso"].Text = "Acerca de";
            Rutinas.AplicarAccesoAFuncionalidad(faux, Properties.Settings.Default.PrivilegioAccesoFuncionalidad);
            faux.FormularioPadre = this;
            faux.MdiParent = this;
            faux.ConexionSQL = cConexionSQLCentral;
            faux.StartPosition = FormStartPosition.CenterScreen;
            faux.TopLevel = false;
            faux.AutoScaleMode = AutoScaleMode.None;
            faux.Show();
            faux.Focus();
        }

        private void tsmMarca_Click_1(object sender, EventArgs e)
        {
            fMarca faux = new fMarca();
            sstPrincipal.Items["Proceso"].Text = "Acerca de";
            Rutinas.AplicarAccesoAFuncionalidad(faux, Properties.Settings.Default.PrivilegioAccesoFuncionalidad);
            faux.FormularioPadre = this;
            faux.MdiParent = this;
            faux.ConexionSQL = cConexionSQLCentral;
            faux.StartPosition = FormStartPosition.CenterScreen;
            faux.TopLevel = false;
            faux.AutoScaleMode = AutoScaleMode.None;
            faux.Show();
            faux.Focus();
        }

        private void tslArea_Click(object sender, EventArgs e)
        {
            if (!Rutinas.ChequearFormularioActivo(this, "fArea", sstPrincipal))
            {
                fArea faux = new Maestros.fArea();
                sstPrincipal.Items["Proceso"].Text = "Acerca de";
                Rutinas.AplicarAccesoAFuncionalidad(faux, Properties.Settings.Default.PrivilegioAccesoFuncionalidad);
                faux.FormularioPadre = this;
                faux.MdiParent = this;
                faux.ConexionSQL = cConexionSQLCentral;
                faux.ConexionSQLMaestro = cConexionSQLMaestro;
                faux.StartPosition = FormStartPosition.CenterScreen;
                faux.TopLevel = false;
                faux.AutoScaleMode = AutoScaleMode.None;
                faux.Show();
                faux.Focus();
            }               
        }

        private void tslUsuario_Click(object sender, EventArgs e)
        {
            fUsuario faux = new Maestros.fUsuario();
            sstPrincipal.Items["Proceso"].Text = "Acerca de";
            Rutinas.AplicarAccesoAFuncionalidad(faux, Properties.Settings.Default.PrivilegioAccesoFuncionalidad);
            faux.FormularioPadre = this;
            faux.MdiParent = this;
            faux.ConexionSQL = cConexionSQLCentral;
            faux.ConexionSQLMaestro = cConexionSQLMaestro;
            faux.StartPosition = FormStartPosition.CenterScreen;
            faux.TopLevel = false;
            faux.AutoScaleMode = AutoScaleMode.None;
            faux.Show();
            faux.Focus();
        }

        private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fModelo faux = new Maestros.fModelo();
            sstPrincipal.Items["Proceso"].Text = "Acerca de";
            Rutinas.AplicarAccesoAFuncionalidad(faux, Properties.Settings.Default.PrivilegioAccesoFuncionalidad);
            faux.FormularioPadre = this;
            faux.MdiParent = this;
            faux.ConexionSQL = cConexionSQLCentral;            
            faux.StartPosition = FormStartPosition.CenterScreen;
            faux.TopLevel = false;
            faux.AutoScaleMode = AutoScaleMode.None;
            faux.Show();
            faux.Focus();
        }

        private void activoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fActivo faux = new fActivo();
            sstPrincipal.Items["Proceso"].Text = "Acerca de";
            Rutinas.AplicarAccesoAFuncionalidad(faux, Properties.Settings.Default.PrivilegioAccesoFuncionalidad);
            faux.FormularioPadre = this;
            faux.MdiParent = this;
            faux.ConexionSQL = cConexionSQLCentral;
            //faux.ConexionSQLMaestro = cConexionSQLMaestro;
            faux.StartPosition = FormStartPosition.CenterScreen;
            faux.TopLevel = false;
            faux.AutoScaleMode = AutoScaleMode.None;
            faux.Show();
            faux.Focus();
        }

        private void asociarActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAsociaActivo faux = new fAsociaActivo();
            sstPrincipal.Items["Proceso"].Text = "Acerca de";
            Rutinas.AplicarAccesoAFuncionalidad(faux, Properties.Settings.Default.PrivilegioAccesoFuncionalidad);
            faux.FormularioPadre = this;
            faux.MdiParent = this;
            faux.ConexionSQL = cConexionSQLCentral;            
            faux.StartPosition = FormStartPosition.CenterScreen;
            faux.TopLevel = false;
            faux.AutoScaleMode = AutoScaleMode.None;
            faux.Show();
            faux.Focus();
        }

        private void tsmBuscaxUsuario_Click(object sender, EventArgs e)
        {
            fBusquedaActivos faux = new fBusquedaActivos();
            sstPrincipal.Items["Proceso"].Text = "Acerca de";
            Rutinas.AplicarAccesoAFuncionalidad(faux, Properties.Settings.Default.PrivilegioAccesoFuncionalidad);
            faux.FormularioPadre = this;
            faux.MdiParent = this;
            faux.ConexionSQL = cConexionSQLCentral;
            faux.StartPosition = FormStartPosition.CenterScreen;
            faux.TopLevel = false;
            faux.AutoScaleMode = AutoScaleMode.None;
            faux.Show();
            faux.Focus();
        }

        private void tsAuditoria_Click(object sender, EventArgs e)
        {
            fAuditoria faux = new fAuditoria();
            sstPrincipal.Items["Proceso"].Text = "Acerca de";
            Rutinas.AplicarAccesoAFuncionalidad(faux, Properties.Settings.Default.PrivilegioAccesoFuncionalidad);
            faux.FormularioPadre = this;
            faux.MdiParent = this;
            faux.ConexionSQL = cConexionSQLCentral;
            faux.StartPosition = FormStartPosition.CenterScreen;
            faux.TopLevel = false;
            faux.AutoScaleMode = AutoScaleMode.None;
            faux.Show();
            faux.Focus();
        }

        private void tslItemBusqueda_Click(object sender, EventArgs e)
        {
            fBusqueda faux = new fBusqueda();
            sstPrincipal.Items["Proceso"].Text = "Acerca de";
            Rutinas.AplicarAccesoAFuncionalidad(faux, Properties.Settings.Default.PrivilegioAccesoFuncionalidad);
            faux.FormularioPadre = this;
            faux.MdiParent = this;
            faux.ConexionSQL = cConexionSQLCentral;
            faux.StartPosition = FormStartPosition.CenterScreen;
            faux.TopLevel = false;
            faux.AutoScaleMode = AutoScaleMode.None;
            faux.Show();
            faux.Focus();
        }

        private void tsmBusqActxUsuario_Click(object sender, EventArgs e)
        {
            fBusquedaActivos faux = new fBusquedaActivos();
            sstPrincipal.Items["Proceso"].Text = "Acerca de";
            Rutinas.AplicarAccesoAFuncionalidad(faux, Properties.Settings.Default.PrivilegioAccesoFuncionalidad);
            faux.FormularioPadre = this;
            faux.MdiParent = this;
            faux.ConexionSQL = cConexionSQLCentral;
            faux.StartPosition = FormStartPosition.CenterScreen;
            faux.TopLevel = false;
            faux.AutoScaleMode = AutoScaleMode.None;
            faux.Show();
            faux.Focus();
        }
    }
}
