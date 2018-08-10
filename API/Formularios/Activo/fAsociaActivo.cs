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
    public partial class fAsociaActivo : Form
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
        private string vchTipoHWAsoc;
        private string vchTipoEspHW;

        //Variables para Insert Asoc Nuevo
        private int idCompHwSelecc;
        private int intIdHardware;
        private int intIdSoftware;
        private int intIdUsuario;
        private int intIdInsumo;
        private string vchIpEquipo;
        private string vchNombreEqRed;

        //variables grilla Computador
        private int checkSelComp = 0;
        private int idHardware=1;
        private int SerieHW=2;
        private int NombreHW=3;
        private int NombreMarca=4;
        private int NombreModelo=5;

        //Variables grilla Impresora
        private int idHardwareImpr = 0;
        private int SerieHWImpr = 1;
        private int NombreHWImpr = 2;
        private int NombreMarcaImpr = 3;
        private int NombreModeloImpr = 4;

        //variables grilla Software list
        private int checkSelSW = 0;
        private int idSoftware = 1;
        private int NoLicencia = 2;
        private int TipoLicencia = 3;
        private int NombreSW = 4;
        private int DescripcionSW = 5;

        //variables para Asoc HW a usuario


        public fAsociaActivo()
        {
            InitializeComponent();
        }

        private void EstadoInicial()
        {
            cmbHardwareAsoc.Enabled = false;
            cmbTipoHWAsocAct.Enabled = false;
            tcAsocActivos.Enabled = false;

            //Elimina botones
            tsbImprimirActivo.Visible = false;
            tsbEliminarActivo.Visible = false;
            tsEditarActivo.Visible = false;

            //Limpia txt
            txtUsuarioBuscar.Text = String.Empty;
            txtNumIPComp.Text = String.Empty;
            txtNombEquipRed.Text = String.Empty;

            //Limpia Combo Box
            cmbHardwareAsoc.SelectedIndex = -1;
            cmbTipoHWAsocAct.SelectedIndex = -1;

            //Limpia Grilla            
            dgSeleccComp.Rows.Clear();
            dgSoftwareList.Rows.Clear();

            //Limpia Variables
            strUsuarioBusqueda = "";
            vchTipoHWAsoc = "";
            vchTipoEspHW = "";
            intIdSoftware = 0;
            idCompHwSelecc = 0;

            //Radio Button
            rbSWsi.Enabled = false; rbSWsi.Checked = false;
            rbSWno.Enabled = false; rbSWno.Checked = false;
            
            //Area Sw
            gbSoftwareList.Visible = false;
        }

        private void CargarComboBoxTipoHW()
        {
            Rutinas.CargarDatosComboBox(cConexionSQL, "spObtieneCBTipoHW", cmbHardwareAsoc, "DescripParam", "idParamHW");
            cmbHardwareAsoc.SelectedIndex = -1;            
        }

        private void PrepararDataGridComp(DataGridView pDataGrid)
        {
            pDataGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            pDataGrid.RowHeadersVisible = false;
            pDataGrid.ReadOnly = false;

            foreach (DataGridViewColumn c in pDataGrid.Columns)
            {
                c.Resizable = DataGridViewTriState.True;
                if (c.Name == "selec_hw_comp")
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

                if (pDataGrid.Name == "dgSeleccComp")
                {
                    dgSeleccComp.Columns[checkSelComp].Width = 30; pDataGrid.Columns[checkSelComp].HeaderText = "Sel";
                    dgSeleccComp.Columns[idHardware].Visible = false; pDataGrid.Columns[idHardware].HeaderText = "idHardware";
                    dgSeleccComp.Columns[SerieHW].Width = 100; pDataGrid.Columns[SerieHW].HeaderText = "N° Serie";
                    dgSeleccComp.Columns[NombreHW].Width = 300; pDataGrid.Columns[NombreHW].HeaderText = "Nombre HW";
                    dgSeleccComp.Columns[NombreMarca].Width = 130; pDataGrid.Columns[NombreMarca].HeaderText = "Marca";
                    dgSeleccComp.Columns[NombreModelo].Width = 150; pDataGrid.Columns[NombreModelo].HeaderText = "Modelo";
                }
            
        }

        private void PrepararDataGridImpr(DataGridView pDataGrid)
        {
            foreach (DataGridViewColumn c in pDataGrid.Columns)
            {
                c.Resizable = DataGridViewTriState.True;
                c.ReadOnly = true;
                c.DefaultCellStyle.Font = cFuente;
            }
            pDataGrid.RowHeadersVisible = false;
            if (pDataGrid.Name == "dgSeleccImpr")
            {
                dgSeleccImpr.Columns[idHardwareImpr].Visible = false; pDataGrid.Columns[idHardwareImpr].HeaderText = "idHardware";
                dgSeleccImpr.Columns[SerieHWImpr].Width = 100; pDataGrid.Columns[SerieHWImpr].HeaderText = "N° Serie";
                dgSeleccImpr.Columns[NombreHWImpr].Width = 200; pDataGrid.Columns[NombreHWImpr].HeaderText = "Nombre HW";
                dgSeleccImpr.Columns[NombreMarcaImpr].Width = 100; pDataGrid.Columns[NombreMarcaImpr].HeaderText = "Marca";
                dgSeleccImpr.Columns[NombreModeloImpr].Width = 150; pDataGrid.Columns[NombreModeloImpr].HeaderText = "Modelo";
            }
        }

        private void PrepararDataGridSwList(DataGridView pDataGrid)
        {
            pDataGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            pDataGrid.RowHeadersVisible = false;
            pDataGrid.ReadOnly = false;

            foreach (DataGridViewColumn c in pDataGrid.Columns)
            {
                c.Resizable = DataGridViewTriState.True;
                if (c.Name == "check_sel_sw")
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
            if (pDataGrid.Name == "dgSoftwareList")
            {
                dgSoftwareList.Columns[checkSelSW].Width = 30; pDataGrid.Columns[checkSelSW].HeaderText = "Sel";
                dgSoftwareList.Columns[idSoftware].Visible = false; pDataGrid.Columns[idSoftware].HeaderText = "idSoftware";
                dgSoftwareList.Columns[NoLicencia].Width = 250; pDataGrid.Columns[NoLicencia].HeaderText = "N° Licencia";
                dgSoftwareList.Columns[TipoLicencia].Width = 50; pDataGrid.Columns[TipoLicencia].HeaderText = "Tipo Licencia";
                dgSoftwareList.Columns[NombreSW].Width = 150; pDataGrid.Columns[NombreSW].HeaderText = "Nombre Software";
                dgSoftwareList.Columns[DescripcionSW].Width = 300; pDataGrid.Columns[DescripcionSW].HeaderText = "Descripción";
            }
        }


        private void ObtieneHWAsocComp()
        {   
            SqlConnection SqlCon = new SqlConnection(cConexionSQL);
            SqlCommand cmd = new SqlCommand("spObtieneTipoHWAsocAct", SqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;
            auxParametro = cmd.Parameters.Add("@vchTipoHW", SqlDbType.VarChar, 50);
            auxParametro = cmd.Parameters.Add("@vchTipoEspHW", SqlDbType.VarChar, 50);

            cmd.Parameters["@vchTipoHW"].Value = vchTipoHWAsoc;
            cmd.Parameters["@vchTipoEspHW"].Value = vchTipoEspHW;

            SqlCon.Open();

            SqlDataReader drBuscar;
            drBuscar = cmd.ExecuteReader();
            dgSeleccComp.Rows.Clear();
            if (drBuscar.HasRows)
            {

                drBuscar.Read();
                do
                {
                    dgSeleccComp.Rows.Add(1);
                    dgSeleccComp.Rows[dgSeleccComp.Rows.Count - 1].Cells[checkSelComp].Value = false;
                    dgSeleccComp.Rows[dgSeleccComp.Rows.Count - 1].Cells[idHardware].Value = drBuscar.GetInt32(drBuscar.GetOrdinal("idHardware"));
                    dgSeleccComp.Rows[dgSeleccComp.Rows.Count - 1].Cells[SerieHW].Value = drBuscar.GetString(drBuscar.GetOrdinal("SerieHW"));
                    dgSeleccComp.Rows[dgSeleccComp.Rows.Count - 1].Cells[NombreHW].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreHW"));
                    dgSeleccComp.Rows[dgSeleccComp.Rows.Count - 1].Cells[NombreMarca].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreMarca"));
                    dgSeleccComp.Rows[dgSeleccComp.Rows.Count - 1].Cells[NombreModelo].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreModelo"));

                }
                while (drBuscar.Read());
            }

            PrepararDataGridComp(dgSeleccComp);

            drBuscar.Close(); drBuscar.Dispose();
            cmd.Connection.Close(); cmd.Connection.Dispose();
            SqlCon.Close(); SqlCon.Dispose();

        }

        private void ObtieneHWAsocImpr()
        {
            string aux = "EXEC spObtieneTipoHWAsocAct " + "'"+vchTipoHWAsoc+"'" + "," + "'"+vchTipoEspHW+"'";
            SqlConnection SqlCon = new SqlConnection(cConexionSQL);
            SqlDataAdapter SqlDa = new SqlDataAdapter(aux, SqlCon);
            DataSet ds = new DataSet("Consulta");
            SqlDa.Fill(ds, "Consulta");
            dgSeleccImpr.DataSource = ds.Tables["Consulta"];
            PrepararDataGridImpr(dgSeleccImpr);
            dgSeleccImpr.Refresh();
            if (dgSeleccImpr.RowCount > 0) { dgSeleccImpr.Rows[0].Selected = false; }
            dgSeleccImpr.ClearSelection();
        }

        private void ObtieneSoftwareList()
        {
            SqlConnection SqlCon = new SqlConnection(cConexionSQL);
            SqlCommand cmd = new SqlCommand("spObtieneListaSWDisp", SqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlCon.Open();

            SqlDataReader drBuscar;
            drBuscar = cmd.ExecuteReader();
            dgSoftwareList.Rows.Clear();
            if (drBuscar.HasRows)
            {

                drBuscar.Read();
                do
                {
                    dgSoftwareList.Rows.Add(1);
                    dgSoftwareList.Rows[dgSoftwareList.Rows.Count - 1].Cells[checkSelSW].Value = false;
                    dgSoftwareList.Rows[dgSoftwareList.Rows.Count - 1].Cells[idSoftware].Value = drBuscar.GetInt32(drBuscar.GetOrdinal("idSoftware"));
                    dgSoftwareList.Rows[dgSoftwareList.Rows.Count - 1].Cells[NoLicencia].Value = drBuscar.GetString(drBuscar.GetOrdinal("NoLicencia"));
                    dgSoftwareList.Rows[dgSoftwareList.Rows.Count - 1].Cells[TipoLicencia].Value = drBuscar.GetString(drBuscar.GetOrdinal("TipoLicencia"));
                    dgSoftwareList.Rows[dgSoftwareList.Rows.Count - 1].Cells[NombreSW].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreSW"));
                    dgSoftwareList.Rows[dgSoftwareList.Rows.Count - 1].Cells[DescripcionSW].Value = drBuscar.GetString(drBuscar.GetOrdinal("DescripcionSW"));

                }
                while (drBuscar.Read());
            }

            PrepararDataGridSwList(dgSoftwareList);

            drBuscar.Close(); drBuscar.Dispose();
            cmd.Connection.Close(); cmd.Connection.Dispose();
            SqlCon.Close(); SqlCon.Dispose();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            strUsuarioBusqueda = Rutinas.Buscar(cConexionSQL, "Usuarios", "Usuario", "id", "idUsuario", "Nombre", "NombreUsuario", "", btnBuscarUsuario, true);
            
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

            txtUsuarioBuscar.Text = cmd.Parameters["@vchNombreUsuario"].Value.ToString();
            
            cmd.Connection.Close(); cmd.Connection.Dispose();
            Con.Close(); Con.Dispose();

            CargarComboBoxTipoHW();
            cmbHardwareAsoc.Enabled = true;

        }

        private void InsertaNuevoAsocHW()
        {
            string auxRespuesta = "";

            SqlConnection Con = new SqlConnection(cConexionSQL);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spInsertNewAsocHWUsu", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@intIdHardware", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@intIdSoftware", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@intIdUsuario", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@intIdInsumo", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@dtFechaAsign", SqlDbType.DateTime);
            auxParametro = cmd.Parameters.Add("@vchUsuario", SqlDbType.VarChar, 30);            
            auxParametro = cmd.Parameters.Add("@vchEquipo", SqlDbType.VarChar, 50);
            auxParametro = cmd.Parameters.Add("@vchIpEquipo", SqlDbType.VarChar, 20);
            auxParametro = cmd.Parameters.Add("@vchNombreEqRed", SqlDbType.VarChar, 100);
            auxParametro = cmd.Parameters.Add("@msgError", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@intIdHardware"].Value = intIdHardware;
            if (rbSWsi.Checked)
            {
                cmd.Parameters["@intIdSoftware"].Value = intIdSoftware;
            }
            else if (rbSWno.Checked)
            {
                cmd.Parameters["@intIdSoftware"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@intIdSoftware"].Value = DBNull.Value;
            }            
            cmd.Parameters["@intIdUsuario"].Value = Convert.ToInt32(strUsuarioBusqueda);
            cmd.Parameters["@intIdInsumo"].Value = DBNull.Value;
            cmd.Parameters["@dtFechaAsign"].Value = DateTime.Now;
            cmd.Parameters["@vchUsuario"].Value = Properties.Settings.Default.Login;           
            cmd.Parameters["@vchEquipo"].Value = Environment.MachineName;
            cmd.Parameters["@vchIpEquipo"].Value = txtNumIPComp.Text.Trim();
            cmd.Parameters["@vchNombreEqRed"].Value = txtNombEquipRed.Text.Trim();


            try
            {
                cmd.ExecuteNonQuery();
                if (cmd.Parameters["@msgError"].Value.ToString() != "")
                {
                    auxRespuesta = "No se pudo insertar, " + cmd.Parameters["@msgError"].Value.ToString();
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
                if (Rutinas.PresentaMensajeAceptarCancelar(cFormularioPadre, "alertabuenoverde", "Operación Correcta.", "Se realizó la Inserción.\n"
                                                           +"Desea Agregar otro Software?", false, false))
                {
                    ObtieneSoftwareList();
                }
                else
                {
                    EstadoInicial();
                }
                
            }
            else
            {
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "malo", "Error en la Operación.", auxRespuesta, false, false);
            }

        }

        private void fAsociaActivo_Load(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void tsbCerrarAsoAct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsAsociaActivo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void CargaComboBoxTipoHWAsocAct()
        {
            string spObtieneCBTipo;
            spObtieneCBTipo = "spObtieneCBTipoHWAsoc " + vchTipoHWAsoc;

            Rutinas.CargarDatosComboBox(cConexionSQL, spObtieneCBTipo, cmbTipoHWAsocAct, "TipoHW", "idTipo");
            cmbTipoHWAsocAct.SelectedIndex = -1;
        }

        private void cmbHardwareAsoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            vchTipoHWAsoc = cmbHardwareAsoc.Text;
            tcAsocActivos.Enabled = true;
            rbSWsi.Enabled = true;
            rbSWno.Enabled = true; 

            if (vchTipoHWAsoc=="COMPUTADOR")
            {
                CargaComboBoxTipoHWAsocAct();
                cmbTipoHWAsocAct.Enabled = true;
                                         
                tcAsocActivos.SelectedTab = tbpCompu;

                BuscaActivoDeUsuario();
            }
            else if (vchTipoHWAsoc=="IMPRESORAS")
            {
                CargaComboBoxTipoHWAsocAct();
                cmbTipoHWAsocAct.Enabled = true;

                tcAsocActivos.SelectedTab = tbpImpresora;                
            }
        }
        
        private void BuscaActivoDeUsuario()
        {            
            SqlConnection Con = new SqlConnection(cConexionSQL);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spConsultaSiUsuarioTieneHWAsoc", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@intIdUsuario", SqlDbType.Int);            
            auxParametro = cmd.Parameters.Add("@vchMsgOut", SqlDbType.Char, 1);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@intIdUsuario"].Value = Convert.ToInt32(strUsuarioBusqueda);

            cmd.ExecuteNonQuery();           

            if (cmd.Parameters["@vchMsgOut"].Value.ToString()=="S")
            {
                if (Rutinas.PresentaMensajeAceptarCancelar(cFormularioPadre, "alertaconsultaamarillo", "", "Usuario ya tiene HW asignado.\n"
                                                           + "Desea Agregar otro ?", false, false)==false)
                {
                    EstadoInicial();
                }               
               
            }

            cmd.Connection.Close(); cmd.Connection.Dispose();
            Con.Close(); Con.Dispose();
        }    

        private void cmbTipoHWAsocAct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            vchTipoEspHW = cmbTipoHWAsocAct.Text;
            if (vchTipoHWAsoc == "COMPUTADOR")
            {
                ObtieneHWAsocComp();
            }
            else if (vchTipoHWAsoc == "IMPRESORAS")
            {
                ObtieneHWAsocImpr();
            }
        }

        private void tsbCancelarActivo_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void rbSWsi_Click(object sender, EventArgs e)
        {
            gbSoftwareList.Visible = true;
            ObtieneSoftwareList();
        }

        private void rbSWno_Click(object sender, EventArgs e)
        {
            gbSoftwareList.Visible = false;
        }

        private void dgSeleccComp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgSeleccComp.EndEdit();
            VerificarComputadorSeleccionado(dgSeleccComp, e.RowIndex, e.ColumnIndex);
            intIdHardware = Convert.ToInt32(dgSeleccComp.Rows[e.RowIndex].Cells[idHardware].Value);
        }

        private void VerificarComputadorSeleccionado(DataGridView pDataGrid, int pFila, int pColumna)
        {
            if (pFila < 0 || pColumna != 0) { return; } //columna distinta de cero

            foreach (DataGridViewRow row in pDataGrid.Rows)
            {
                if (pFila != row.Index)
                {
                    DataGridViewCheckBoxCell chbDesocupados = (DataGridViewCheckBoxCell)row.Cells[checkSelComp]; //columna donde se hace la selección
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
                    DataGridViewCheckBoxCell chbDesocupados = (DataGridViewCheckBoxCell)row.Cells[checkSelSW]; //columna donde se hace la selección
                    if ((bool)chbDesocupados.Value == true)
                    {
                        chbDesocupados.Value = false;
                    }
                }
            }
        }

        private void dgSoftwareList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgSoftwareList.EndEdit();
            VerificarSoftwareSeleccionado(dgSoftwareList, e.RowIndex, e.ColumnIndex);
            intIdSoftware= Convert.ToInt32(dgSoftwareList.Rows[e.RowIndex].Cells[idSoftware].Value);
        }

        private void tsbGrabarActivo_Click(object sender, EventArgs e)
        {
            InsertaNuevoAsocHW();
        }
    }
}
