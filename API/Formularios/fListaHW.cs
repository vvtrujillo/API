using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Desarrollo.Formularios
{
    public partial class fListaHW : Form
    {

        //Declaraciones para mover el formulario con el mouse desde el toolstrip (menu de botones del formulario)
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //Fin declaraciones para mover el formulario

        clMSC.clMSC Rutinas = new clMSC.clMSC();

        private Form cFormularioPadre;
        public Form FormularioPadre { set { cFormularioPadre = value; } }

        //conexion a BD AdministracionPlataformaInformatica del servidor MOLINO61\CULTIVODES
        private string cConexionSQL;
        public string ConexionSQL { set { cConexionSQL = value; } }

        //conexion a BD MaestroEntidades del servidor MOLINO14\MOLINO14
        private string cConexionSQLMaestro;
        public string ConexionSQLMaestro { set { cConexionSQLMaestro = value; } }

        private Font cFuente;
        public Font Fuente { set { cFuente = value; } }


        //variables grilla



        public fListaHW()
        {
            InitializeComponent();
        }

        private void fListaHW_Load(object sender, EventArgs e)
        {

        }
    }
}
