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
        private int intIdHardware;
        private int intIdSoftware;
        private int intIdUsuario;
        private int intIdAsocHw;
        private int intIdAsocSw;
        
        //variables para grilla HW
        private int seleccion_hw = 0;
        private int idHardware=1;
        private int NombreHW =2;
        private int SerieHW =3;
        private int NombreUsuario =4;
        private int NombreEquipRed =5;
        private int idAsochw = 6;

        //variables para grilla SW
        private int seleccion_sw = 0;
        private int idSoftware = 1;
        private int NombreSW = 2;
        private int NoLicencia = 3;
        private int TipoLicencia = 4;
        private int NombreUsuarioSW = 5;
        private int idAsocSw = 6;

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
            pDataGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            pDataGrid.RowHeadersVisible = false;
            pDataGrid.ReadOnly = false;

            foreach (DataGridViewColumn c in pDataGrid.Columns)
            {
                c.Resizable = DataGridViewTriState.True;
                if (c.Name == "sel_hw")
                {
                    c.ReadOnly = false;
                }
                else
                {
                    c.ReadOnly = true;
                }
                c.DefaultCellStyle.Font = cFuente;
            }
            pDataGrid.RowHeadersVisible = false;

            if (pDataGrid.Name == "dgListaHardwareUser")
            {
                dgListaHardwareUser.Columns[seleccion_hw].Width = 30; pDataGrid.Columns[seleccion_hw].HeaderText = "Sel";
                dgListaHardwareUser.Columns[idHardware].Visible = false; pDataGrid.Columns[idHardware].HeaderText = "idHardware";
                dgListaHardwareUser.Columns[NombreHW].Width = 150; pDataGrid.Columns[NombreHW].HeaderText = "Nombre";
                dgListaHardwareUser.Columns[SerieHW].Width = 100; pDataGrid.Columns[SerieHW].HeaderText = "N° Serie";
                dgListaHardwareUser.Columns[NombreUsuario].Width = 150; pDataGrid.Columns[NombreUsuario].HeaderText = "Nombre Usuario";
                dgListaHardwareUser.Columns[NombreEquipRed].Width = 150; pDataGrid.Columns[NombreEquipRed].HeaderText = "Nombre de Red";
                //dgListaHardwareUser.Columns[idAsochw].Visible = false; pDataGrid.Columns[idAsochw].HeaderText = "idAsoc";
                dgListaHardwareUser.Columns[NombreEquipRed].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
        }

        private void PrepararDataGridSW(DataGridView pDataGrid)
        {
            pDataGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            pDataGrid.RowHeadersVisible = false;
            pDataGrid.ReadOnly = false;

            foreach (DataGridViewColumn c in pDataGrid.Columns)
            {
                c.Resizable = DataGridViewTriState.True;
                if (c.Name == "sel_sw")
                {
                    c.ReadOnly = false;
                }
                else
                {
                    c.ReadOnly = true;
                }
                c.DefaultCellStyle.Font = cFuente;
            }
            pDataGrid.RowHeadersVisible = false;

            if (pDataGrid.Name == "dgListaSoftwareUser")
            {
                dgListaSoftwareUser.Columns[seleccion_sw].Width = 30; pDataGrid.Columns[seleccion_sw].HeaderText = "Sel";
                dgListaSoftwareUser.Columns[idSoftware].Visible = false; pDataGrid.Columns[idSoftware].HeaderText = "idSoftware";
                dgListaSoftwareUser.Columns[NombreSW].Width = 200; pDataGrid.Columns[NombreSW].HeaderText = "Nombre";
                dgListaSoftwareUser.Columns[NoLicencia].Width = 250; pDataGrid.Columns[NoLicencia].HeaderText = "Código Licencia";
                dgListaSoftwareUser.Columns[TipoLicencia].Width = 50; pDataGrid.Columns[TipoLicencia].HeaderText = "Tipo Licencia";
                dgListaSoftwareUser.Columns[NombreUsuarioSW].Width = 150; pDataGrid.Columns[NombreUsuarioSW].HeaderText = "Nombre Usuario";
                dgListaSoftwareUser.Columns[idAsocSw].Visible=false; pDataGrid.Columns[idAsocSw].HeaderText = "id Asoc";
                dgListaSoftwareUser.Columns[NombreUsuarioSW].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            SqlConnection SqlCon = new SqlConnection(cConexionSQL);
            SqlCommand cmd = new SqlCommand("soObtieneListaHWSWporUsuario", SqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@vchTipoBusqueda", SqlDbType.VarChar, 20);
            auxParametro = cmd.Parameters.Add("@intIdUsuario", SqlDbType.VarChar, 255);

            cmd.Parameters["@vchTipoBusqueda"].Value = "HW";
            cmd.Parameters["@intIdUsuario"].Value = Convert.ToInt32(strUsuarioBusqueda);

            SqlCon.Open();

            SqlDataReader drBuscar;
            drBuscar = cmd.ExecuteReader();
            dgListaHardwareUser.Rows.Clear();
            if (drBuscar.HasRows)
            {

                drBuscar.Read();
                do
                {
                    dgListaHardwareUser.Rows.Add(1);
                    dgListaHardwareUser.Rows[dgListaHardwareUser.Rows.Count - 1].Cells[seleccion_hw].Value = false;
                    dgListaHardwareUser.Rows[dgListaHardwareUser.Rows.Count - 1].Cells[idHardware].Value = drBuscar.GetInt32(drBuscar.GetOrdinal("idHardware"));
                    dgListaHardwareUser.Rows[dgListaHardwareUser.Rows.Count - 1].Cells[NombreHW].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreHW"));
                    dgListaHardwareUser.Rows[dgListaHardwareUser.Rows.Count - 1].Cells[SerieHW].Value = drBuscar.GetString(drBuscar.GetOrdinal("SerieHW"));
                    dgListaHardwareUser.Rows[dgListaHardwareUser.Rows.Count - 1].Cells[NombreUsuario].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreUsuario"));
                    dgListaHardwareUser.Rows[dgListaHardwareUser.Rows.Count - 1].Cells[NombreEquipRed].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreEquipRed"));
                    //dgListaHardwareUser.Rows[dgListaHardwareUser.Rows.Count - 1].Cells[idAsochw].Value = drBuscar.GetInt32(drBuscar.GetOrdinal("idAsocHW"));
                    dgListaHardwareUser.Columns[NombreEquipRed].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
                while (drBuscar.Read());
            }

            PrepararDataGridHW(dgListaHardwareUser);

            drBuscar.Close(); drBuscar.Dispose();
            cmd.Connection.Close(); cmd.Connection.Dispose();
            SqlCon.Close(); SqlCon.Dispose();           
        }

        private void BusquedaActivoSWxUsuario()
        {            
            SqlConnection SqlCon = new SqlConnection(cConexionSQL);
            SqlCommand cmd = new SqlCommand("soObtieneListaHWSWporUsuario", SqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@vchTipoBusqueda", SqlDbType.VarChar, 20);
            auxParametro = cmd.Parameters.Add("@intIdUsuario", SqlDbType.VarChar, 255);

            cmd.Parameters["@vchTipoBusqueda"].Value = "SW";
            cmd.Parameters["@intIdUsuario"].Value = Convert.ToInt32(strUsuarioBusqueda);

            SqlCon.Open();

            SqlDataReader drBuscar;
            drBuscar = cmd.ExecuteReader();
            dgListaSoftwareUser.Rows.Clear();
            if (drBuscar.HasRows)
            {

                drBuscar.Read();
                do
                {
                    dgListaSoftwareUser.Rows.Add(1);
                    dgListaSoftwareUser.Rows[dgListaSoftwareUser.Rows.Count - 1].Cells[seleccion_sw].Value = false;
                    dgListaSoftwareUser.Rows[dgListaSoftwareUser.Rows.Count - 1].Cells[idSoftware].Value = drBuscar.GetInt32(drBuscar.GetOrdinal("idSoftware"));
                    dgListaSoftwareUser.Rows[dgListaSoftwareUser.Rows.Count - 1].Cells[NombreSW].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreSW"));
                    dgListaSoftwareUser.Rows[dgListaSoftwareUser.Rows.Count - 1].Cells[NoLicencia].Value = drBuscar.GetString(drBuscar.GetOrdinal("NoLicencia"));
                    dgListaSoftwareUser.Rows[dgListaSoftwareUser.Rows.Count - 1].Cells[TipoLicencia].Value = drBuscar.GetString(drBuscar.GetOrdinal("TipoLicencia"));
                    dgListaSoftwareUser.Rows[dgListaSoftwareUser.Rows.Count - 1].Cells[NombreUsuarioSW].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreUsuario"));
                    dgListaSoftwareUser.Rows[dgListaSoftwareUser.Rows.Count - 1].Cells[idAsocSw].Value = drBuscar.GetInt32(drBuscar.GetOrdinal("idAsocHW"));
                    dgListaSoftwareUser.Columns[NombreEquipRed].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
                while (drBuscar.Read());
            }

            PrepararDataGridSW(dgListaSoftwareUser);

            drBuscar.Close(); drBuscar.Dispose();
            cmd.Connection.Close(); cmd.Connection.Dispose();
            SqlCon.Close(); SqlCon.Dispose();           
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

        private void dgListaHardwareUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgListaHardwareUser.EndEdit();
            VerificarHardwareSeleccionado(dgListaHardwareUser, e.RowIndex, e.ColumnIndex);
            intIdHardware = Convert.ToInt32(dgListaHardwareUser.Rows[e.RowIndex].Cells[idHardware].Value);
            //intIdAsocHw = Convert.ToInt32(dgListaHardwareUser.Rows[e.RowIndex].Cells[idAsochw].Value);
        }

        private void VerificarHardwareSeleccionado(DataGridView pDataGrid, int pFila, int pColumna)
        {
            if (pFila < 0 || pColumna != 0) { return; } //columna distinta de cero

            foreach (DataGridViewRow row in pDataGrid.Rows)
            {
                if (pFila != row.Index)
                {
                    DataGridViewCheckBoxCell chbDesocupados = (DataGridViewCheckBoxCell)row.Cells[seleccion_hw]; //columna donde se hace la selección
                    if ((bool)chbDesocupados.Value == true)
                    {
                        chbDesocupados.Value = false;
                    }
                }
            }
        }

        private void VerificarSoftwareSeleccionado(DataGridView pDataGrid, int pFila, int pColumna)
        {
            if (pFila < 0 || pColumna != 0) { return; } //columna distinta de cero

            foreach (DataGridViewRow row in pDataGrid.Rows)
            {
                if (pFila != row.Index)
                {
                    DataGridViewCheckBoxCell chbDesocupados = (DataGridViewCheckBoxCell)row.Cells[seleccion_sw]; //columna donde se hace la selección
                    if ((bool)chbDesocupados.Value == true)
                    {
                        chbDesocupados.Value = false;
                    }
                }
            }
        }

        private void dgListaSoftwareUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgListaSoftwareUser.EndEdit();
            VerificarHardwareSeleccionado(dgListaSoftwareUser, e.RowIndex, e.ColumnIndex);
            intIdAsocSw= Convert.ToInt32(dgListaSoftwareUser.Rows[e.RowIndex].Cells[idAsocSw].Value);
        }

        private void EliminaHardwareSeleccionado( string strTipoAct)
        {
            string auxRespuesta = "";

            SqlConnection Con = new SqlConnection(cConexionSQL);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spUpdateDeleteAsocHW", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@chTipoAct", SqlDbType.Char, 1);
            auxParametro = cmd.Parameters.Add("@intIdAsocHW", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@intIdSoftware", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@intIdHardware", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@intIdUsuario", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@vchUsuario", SqlDbType.VarChar,50);
            auxParametro = cmd.Parameters.Add("@dtFechaSistema", SqlDbType.DateTime);
            auxParametro = cmd.Parameters.Add("@vchTerminalUsuario", SqlDbType.VarChar,50);
            auxParametro = cmd.Parameters.Add("@msgError", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@chTipoAct"].Value = strTipoAct;
            cmd.Parameters["@intIdAsocHW"].Value = intIdAsocHw;
            cmd.Parameters["@intIdSoftware"].Value = DBNull.Value;
            cmd.Parameters["@intIdHardware"].Value = intIdHardware;
            cmd.Parameters["@intIdUsuario"].Value = Convert.ToInt32(strUsuarioBusqueda);
            cmd.Parameters["@vchUsuario"].Value = Properties.Settings.Default.Login;
            cmd.Parameters["@dtFechaSistema"].Value = DateTime.Now;
            cmd.Parameters["@vchTerminalUsuario"].Value = Environment.MachineName;


            try
            {
                cmd.ExecuteNonQuery();
                if (cmd.Parameters["@msgError"].Value.ToString() != "")
                {
                    auxRespuesta = "No se pudo eliminar, " + cmd.Parameters["@msgError"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                auxRespuesta = "No se pudo eliminar" + ex.ToString();
            }

            cmd.Connection.Close(); cmd.Connection.Dispose();
            Con.Close(); Con.Dispose();

            if (auxRespuesta == "")
            {
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "bueno", "Operación Correcta.", "Se realizó la Eliminación", false, false);
                EstadoInicial();

            }
            else
            {
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "malo", "Error en la Operación.", auxRespuesta, false, false);
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            tsbEliminarActUsuBusq.Visible = true;
            tsbCancelarDelAct.Visible = true;
            gbListHardware.Enabled = true;
            gbListSoftware.Enabled = true;
        }

        private void tsbEliminarActUsuBusq_Click(object sender, EventArgs e)
        {
            if (Rutinas.PresentaMensajeAceptarCancelar(cFormularioPadre, "alertaconsultaamarillo", "Se va a eliminar la selección.", ""
                                                           + "Esta seguro que desea eliminar del usuario?", false, false))
            {
                EliminaHardwareSeleccionado("H");
            }
            else
            {
                EstadoInicial();
            }
            
        }

        private void tsbCancelarDelAct_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }
    }
}
