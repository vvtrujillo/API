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
using API.Formularios.Maestros;

namespace API.Formularios.Gestion_Tickets
{
    public partial class fAgregaTicket : Form
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

        private string cConexionSQL;
        public string ConexionSQL { set { cConexionSQL = value; } }
        private Font cFuente;
        public Font Fuente { set { cFuente = value; } }

        public string cConexionSQLCentral = string.Empty;

        private string strUsuarioBusqueda;
        private int TipoTicket;
        private int PrioridadTicket;

        public fAgregaTicket()
        {
            InitializeComponent();
        }

        private void fAgregaTicket_Load(object sender, EventArgs e)
        {
            CargarComboBoxTipoTicket();
            CargarComboBoxPrioridadTicket();
        }

        private void EstadoInicial()
        {
            strUsuarioBusqueda = "";
            TipoTicket = 0;
            PrioridadTicket = 0;
        }

        private void btnBuscarUsuarioAddTicket_Click(object sender, EventArgs e)
        {
            strUsuarioBusqueda = Rutinas.Buscar(cConexionSQL, "Usuarios", "Usuario", "id", "idUsuario", "Nombre", "NombreUsuario", "", btnBuscarUsuarioAddTicket, true);

            SqlConnection Con = new SqlConnection(cConexionSQL);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spObtieneUsuario", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@intIdUsuario", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@vchNombreUsuario", SqlDbType.VarChar, 50);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@intIdUsuario"].Value = Convert.ToInt32(strUsuarioBusqueda);

            cmd.ExecuteNonQuery();            

            txtNombreUsuarioAddTicket.Text = cmd.Parameters["@vchNombreUsuario"].Value.ToString();

            cmd.Connection.Close(); cmd.Connection.Dispose();
            Con.Close(); Con.Dispose();           
           
        }

        private void tsbCerrarAddTicket_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsAgregaTicket_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void CargarComboBoxTipoTicket()
        {
            Rutinas.CargarDatosComboBox(cConexionSQL, "spObtieneCBTipoTicket", cmbTipoTicket, "NombreTipo", "idTipoTicket");
            cmbTipoTicket.SelectedIndex = -1;
        }

        private void CargarComboBoxPrioridadTicket()
        {
            Rutinas.CargarDatosComboBox(cConexionSQL, "spObtieneCBPrioridadTicket", cmbPrioridadTicket, "NombrePrioridad", "idPrioridadTicket");
            cmbPrioridadTicket.SelectedIndex = -1;
        }

        private void InsertaNuevoTicket()
        {
            string auxRespuesta = "";
            string NumeroTicket = "";

            SqlConnection Con = new SqlConnection(cConexionSQL);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spInsertNewTicket", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@vchTituloTicket", SqlDbType.VarChar, 20);
            auxParametro = cmd.Parameters.Add("@vchDescripcionTicket", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@intIdUsuarioAtendido", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@intIdTipoTicket", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@intIdPrioridadTicket", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@dtFechaSistema", SqlDbType.DateTime);
            auxParametro = cmd.Parameters.Add("@vchEquipo", SqlDbType.VarChar, 30);
            auxParametro = cmd.Parameters.Add("@vchUsuario", SqlDbType.VarChar, 20);
            auxParametro = cmd.Parameters.Add("@intIdTicketSalida", SqlDbType.Int);
            auxParametro.Direction = ParameterDirection.Output;
            auxParametro = cmd.Parameters.Add("@vchMsgError", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@vchTituloTicket"].Value = txtTituloTicket.Text.Trim();
            cmd.Parameters["@vchDescripcionTicket"].Value = txtDescripTicket.Text;
            cmd.Parameters["@intIdUsuarioAtendido"].Value = strUsuarioBusqueda;
            cmd.Parameters["@intIdTipoTicket"].Value = TipoTicket;
            cmd.Parameters["@intIdPrioridadTicket"].Value = PrioridadTicket;
            cmd.Parameters["@dtFechaSistema"].Value = DateTime.Now;
            cmd.Parameters["@vchEquipo"].Value = Environment.MachineName;
            cmd.Parameters["@vchUsuario"].Value = Properties.Settings.Default.Login;

            try
            {
                cmd.ExecuteNonQuery();
                NumeroTicket = cmd.Parameters["@intIdTicketSalida"].Value.ToString();

                if (cmd.Parameters["@vchMsgError"].Value.ToString() != "")
                {
                    auxRespuesta = "No se pudo insertar, " + cmd.Parameters["@vchMsgError"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                auxRespuesta = "No se pudo insertar" + ex.ToString();
            }

            cmd.Connection.Close(); cmd.Connection.Dispose();
            Con.Close(); Con.Dispose();

            if (auxRespuesta == "")
            {
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "alertabuenoverde", "Éxito", "Se creo correctamente Ticket Número: " + NumeroTicket, false, false);
                EstadoInicial();

            }
            else
            {
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "malo", "Error en la Operación.", auxRespuesta, false, false);
            }

        }

        private void cmbTipoTicket_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TipoTicket = Convert.ToInt32(cmbTipoTicket.SelectedValue);
        }

        private void cmbPrioridadTicket_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PrioridadTicket = Convert.ToInt32(cmbPrioridadTicket.SelectedValue);
        }

        private void tsbGrabarAddTicket_Click(object sender, EventArgs e)
        {
            InsertaNuevoTicket();
        }
    }
}
