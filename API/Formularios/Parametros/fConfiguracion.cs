using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Runtime.InteropServices;
using Desarrollo.Formularios;

namespace API.Formularios.Parametros
{
    public partial class fConfiguracion : Form
    {
        //Declaraciones para mover el formulario con el mouse desde el toolstrip (menu de botones del formulario)
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //Fin declaraciones para mover el formulario
                

        private Form cFormularioPadre;
        public Form FormularioPadre { set { cFormularioPadre = value; } }

        private string cConexionCentral;
        public string ConexionCentral { set { cConexionCentral = value; } }

        private SplitContainer cScoPrincipal;
        public SplitContainer ScoPrincipal { set { cScoPrincipal = value; } }
        private mdiPrincipal cMdiPrincipal;
        public mdiPrincipal MdiPrincipal { set { cMdiPrincipal = value; } }

        clMSC.clMSC rutinas = new clMSC.clMSC();

        public fConfiguracion()
        {
            InitializeComponent();
            rutinas.ColorearControles(this, Properties.Settings.Default.ColorFondoSinFoco);
        }
        
        private bool ValidarCampos()
        {
            string auxMensaje = "";
            int contErrores = 0;
            if (txtServidorMaestro.Text.Trim() == string.Empty & contErrores == 0) { contErrores++; auxMensaje = "Falta ingresar el servidor maestro de entidades."; txtServidorMaestro.Focus(); }
            if (txtBaseEntidades.Text.Trim() == string.Empty & contErrores == 0) { contErrores++; auxMensaje = "Falta ingresar la base de datos de entidades."; txtBaseEntidades.Focus(); }
            if (txtServidorCentral.Text.Trim() == string.Empty & contErrores == 0) { contErrores++; auxMensaje = "Falta ingresar el servidor central."; txtServidorCentral.Focus(); }
            if (txtBaseCentral.Text.Trim() == string.Empty & contErrores == 0) { contErrores++; auxMensaje = "Falta ingresar la base de datos central."; txtBaseCentral.Focus(); }
            if (contErrores == 0)
            {
                return true;
            }
            else
            {
                rutinas.PresentaMensajeAceptar(cFormularioPadre, "alertamalorojo", "Error de validación", auxMensaje, false, false);
                return false;
            }
        }

        private void fConfiguracion_Load(object sender, EventArgs e)
        {
            txtServidorMaestro.Text = Properties.Settings.Default.ServidorSQLMaestroEntidades;
            txtBaseEntidades.Text = Properties.Settings.Default.BaseSQLMaestroEntidades;
            txtServidorCentral.Text = Properties.Settings.Default.ServidorSQLCentral;
            txtBaseCentral.Text = Properties.Settings.Default.BaseSQLCentral;
        }
        private void fConfiguracion_Shown(object sender, EventArgs e)
        {
            txtServidorMaestro.Focus();
        }
        private void tsConfiguracion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        private void ControlLlegaELFoco(object sender, EventArgs e)
        {
            Control c = sender as Control;
            rutinas.LlegaElFoco(c, Properties.Settings.Default.ColorFondoConFoco);  // cColorFondoConFoco);
        }
        private void ControlSeVaELFoco(object sender, EventArgs e)
        {
            Control c = sender as Control;
            rutinas.LlegaElFoco(c, Properties.Settings.Default.ColorFondoSinFoco);  // cColorFondoSinFoco);
        }
        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsbGrabar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (ValidarCampos())
            {
                Properties.Settings.Default.ServidorSQLMaestroEntidades = txtServidorMaestro.Text.Trim();
                Properties.Settings.Default.BaseSQLMaestroEntidades = txtBaseEntidades.Text.Trim();
                Properties.Settings.Default.ServidorSQLCentral = txtServidorCentral.Text.Trim();
                Properties.Settings.Default.BaseSQLCentral = txtBaseCentral.Text.Trim();
                Properties.Settings.Default.Save();                

                rutinas.PresentaMensajeAceptar(this.MdiParent, "alertabuenoverde", "Configuración actualizada", "Parámetros de configuración grabados correctamente.", false, false);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}