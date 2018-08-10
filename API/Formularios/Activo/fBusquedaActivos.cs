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

namespace API.Formularios.Activo
{
    public partial class fBusquedaActivos : Form
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

        //variables locales
        private string strUsuarioBusqueda;

        //variables para grilla HW
        private int idHardware=0;
        private int NombreHW =1;
        private int SerieHW =2;
        private int NombreUsuario =3;
        private int NombreEquipRed =4;

        //variables para grilla SW
        private int idSoftware = 0;
        private int NombreSW = 1;
        private int NoLicencia = 2;
        private int TipoLicencia = 3;
        private int NombreUsuarioSW = 4;

        public fBusquedaActivos()
        {
            InitializeComponent();
        }

        private void EstadoInicial()
        {
            strUsuarioBusqueda = "";

            //Limpia Grillas
            dgListaHardwareUser.Rows.Clear();
            dgListaSoftwareUser.Rows.Clear();

            gbListHardware.Enabled = false;
            gbListSoftware.Enabled = false;


        }

        private void PrepararDataGridHW(DataGridView pDataGrid)
        {
            foreach (DataGridViewColumn c in pDataGrid.Columns)
            {
                c.Resizable = DataGridViewTriState.True;
                c.ReadOnly = true;
                c.DefaultCellStyle.Font = cFuente;

            }
            pDataGrid.RowHeadersVisible = false;
            if (pDataGrid.Name == "dgListaHardwareUser")
            {
                dgListaHardwareUser.Columns[idHardware].Visible = false; pDataGrid.Columns[idHardware].HeaderText = "idHardware";
                dgListaHardwareUser.Columns[NombreHW].Width = 150; pDataGrid.Columns[NombreHW].HeaderText = "Nombre";
                dgListaHardwareUser.Columns[SerieHW].Width = 100; pDataGrid.Columns[SerieHW].HeaderText = "N° Serie";
                dgListaHardwareUser.Columns[NombreUsuario].Width = 150; pDataGrid.Columns[NombreUsuario].HeaderText = "Nombre Usuario";
                dgListaHardwareUser.Columns[NombreEquipRed].Width = 150; pDataGrid.Columns[NombreEquipRed].HeaderText = "Nombre de Red";
                
            }
        }

        private void PrepararDataGridSW(DataGridView pDataGrid)
        {
            foreach (DataGridViewColumn c in pDataGrid.Columns)
            {
                c.Resizable = DataGridViewTriState.True;
                c.ReadOnly = true;
                c.DefaultCellStyle.Font = cFuente;

            }
            pDataGrid.RowHeadersVisible = false;
            if (pDataGrid.Name == "dgListaSoftwareUser")
            {
                dgListaSoftwareUser.Columns[idSoftware].Visible = false; pDataGrid.Columns[idSoftware].HeaderText = "idSoftware";
                dgListaSoftwareUser.Columns[NombreSW].Width = 100; pDataGrid.Columns[NombreSW].HeaderText = "Nombre";
                dgListaSoftwareUser.Columns[NoLicencia].Width = 250; pDataGrid.Columns[NoLicencia].HeaderText = "Licencia";
                dgListaSoftwareUser.Columns[TipoLicencia].Width = 50; pDataGrid.Columns[TipoLicencia].HeaderText = "Tipo Lic";
                dgListaSoftwareUser.Columns[NombreUsuarioSW].Width = 150; pDataGrid.Columns[NombreUsuarioSW].HeaderText = "Nombre Usuario";

            }
        }

        private void btnBuscarUsuarioAct_Click(object sender, EventArgs e)
        {
            strUsuarioBusqueda = Rutinas.Buscar(cConexionSQL, "Usuarios", "Usuario", "id", "idUsuario", "Nombre", "NombreUsuario", "", btnBuscarUsuarioAct, true);

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

            txtUsuarioBuscarAct.Text = cmd.Parameters["@vchNombreUsuario"].Value.ToString();

            cmd.Connection.Close(); cmd.Connection.Dispose();
            Con.Close(); Con.Dispose();

            BusquedaActivoHWxUsuario();

            BusquedaActivoSWxUsuario();
        }

        private void BusquedaActivoHWxUsuario()
        {
            string aux = "EXEC soObtieneListaHWSWporUsuario " + "'"+"HW" +"'" + ", " + Convert.ToInt32(strUsuarioBusqueda);
            SqlConnection SqlCon = new SqlConnection(cConexionSQL);
            SqlDataAdapter SqlDa = new SqlDataAdapter(aux, SqlCon);
            DataSet ds = new DataSet("Consulta");          
            SqlDa.Fill(ds, "Consulta");
            dgListaHardwareUser.DataSource = ds.Tables["Consulta"];
            PrepararDataGridHW(dgListaHardwareUser);
            dgListaHardwareUser.Refresh();
            if (dgListaHardwareUser.RowCount > 0) { dgListaHardwareUser.Rows[0].Selected = false; }
            dgListaHardwareUser.ClearSelection();           
        }

        private void BusquedaActivoSWxUsuario()
        {
            string aux = "EXEC soObtieneListaHWSWporUsuario " + "'" + "SW" + "'" + ", " + Convert.ToInt32(strUsuarioBusqueda);
            SqlConnection SqlCon = new SqlConnection(cConexionSQL);
            SqlDataAdapter SqlDa = new SqlDataAdapter(aux, SqlCon);
            DataSet ds = new DataSet("Consulta");
            SqlDa.Fill(ds, "Consulta");
            dgListaSoftwareUser.DataSource = ds.Tables["Consulta"];
            PrepararDataGridSW(dgListaSoftwareUser);
            dgListaSoftwareUser.Refresh();
            if (dgListaSoftwareUser.RowCount > 0) { dgListaSoftwareUser.Rows[0].Selected = false; }
            dgListaSoftwareUser.ClearSelection();
        }

        private void fBusquedaActivos_Load(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void tsbCerrarBusqActixUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsBusquedaxUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
