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
        private bool faltandatos;
        private bool AgregoSoftware;
        private bool ControlesVacios;

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
        private int tipoCompHw = 1;
        private int idHardware=2;
        private int SerieHW=3;
        private int NombreHW=4;
        private int NombreMarca=5;
        private int NombreModelo=6;
        private int DireccionIP = 7;
        private int NombreEquipRed = 8;

        //Variables grilla Impresora
        private int CheckSelImp = 0;
        private int idHardwareImp = 1;
        private int TipoImpresoraHW = 2;
        private int SerieHWImp = 3;
        private int NombreHWImp = 4;
        private int NombreMarcaImp = 5;
        private int NombreModeloImp = 6;
        private int DireccionIPImp = 7;
        private int NombreEquipRedImp = 8;

        //variables grilla Monitor
        private int CheckSelMon = 0;
        private int idHardwareMon = 1;
        private int TipoMonitorHW = 2;
        private int SerieHWMon = 3;
        private int NombreHWMon = 4;
        private int NombreMarcaMon = 5;
        private int NombreModeloMon = 6;

        //variables grilla Comunicaciones
        private int CheckSelComu = 0;
        private int idHardwareComu = 1;
        private int TipoComuniacionesHW = 2;
        private int SerieHWComu = 3;
        private int NombreHWComu = 4;
        private int NombreMarcaComu = 5;
        private int NombreModeloComu = 6;
        private int DireccionIPComu = 7;
        private int NombreEquipRedComu = 8;

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

        private void ConsultaDatosIngresados()
        {
            
        }

        private void EstadoInicial()
        {
            cmbHardwareAsoc.Enabled = false;
            tcAsocActivos.Enabled = false;
            faltandatos = false;

            //Elimina botones
            tsbImprimirActivo.Visible = false;
            tsEditarActivo.Visible = false;

            //Limpia txt
            txtUsuarioBuscar.Text = String.Empty;
            txtNumIPComp.Text = String.Empty;
            txtNombEquipRed.Text = String.Empty;

            //Limpia Combo Box
            cmbHardwareAsoc.SelectedIndex = -1;

            //Limpia Grilla            
            dgSeleccComp.Rows.Clear();
            dgSoftwareList.Rows.Clear();
            dgSeleccImpr.Rows.Clear();

            //
            tcAsocActivos.SelectedTab = tbpCompu;

            //Limpia Variables
            strUsuarioBusqueda = "";
            vchTipoHWAsoc = "";
            vchTipoEspHW = "";
            intIdSoftware = 0;
            idCompHwSelecc = 0;
            AgregoSoftware = false;
            ControlesVacios = false;
            
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
            pDataGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            pDataGrid.RowHeadersVisible = false;
            pDataGrid.ReadOnly = false;

            foreach (DataGridViewColumn c in pDataGrid.Columns)
            {
                c.Resizable = DataGridViewTriState.True;
                if (c.Name == "sel_hw_imp")
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

            if (pDataGrid.Name == "dgSeleccImpr")
            {
                dgSeleccImpr.Columns[CheckSelImp].Width = 30; pDataGrid.Columns[CheckSelImp].HeaderText = "Sel";
                dgSeleccImpr.Columns[idHardwareImp].Visible = false; pDataGrid.Columns[idHardwareImp].HeaderText = "idHardware";
                dgSeleccImpr.Columns[SerieHWImp].Width = 100; pDataGrid.Columns[SerieHWImp].HeaderText = "N° Serie";
                dgSeleccImpr.Columns[NombreHWImp].Width = 300; pDataGrid.Columns[NombreHWImp].HeaderText = "Nombre HW";
                dgSeleccImpr.Columns[NombreMarcaImp].Width = 130; pDataGrid.Columns[NombreMarcaImp].HeaderText = "Marca";
                dgSeleccImpr.Columns[NombreModeloImp].Width = 150; pDataGrid.Columns[NombreModeloImp].HeaderText = "Modelo";
            }
        }

        private void PrepararDataGridComun(DataGridView pDataGrid)
        {
            pDataGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            pDataGrid.RowHeadersVisible = false;
            pDataGrid.ReadOnly = false;

            foreach (DataGridViewColumn c in pDataGrid.Columns)
            {
                c.Resizable = DataGridViewTriState.True;
                if (c.Name == "sel_comu")
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

            if (pDataGrid.Name == "dgSeleccComun")
            {
                dgSeleccComun.Columns[CheckSelComu].Width = 30; pDataGrid.Columns[CheckSelComu].HeaderText = "Sel";
                dgSeleccComun.Columns[idHardwareComu].Visible = false; pDataGrid.Columns[idHardwareComu].HeaderText = "idHardware";
                dgSeleccComun.Columns[SerieHWComu].Width = 100; pDataGrid.Columns[SerieHWComu].HeaderText = "N° Serie";
                dgSeleccComun.Columns[NombreHWComu].Width = 300; pDataGrid.Columns[NombreHWComu].HeaderText = "Nombre HW";
                dgSeleccComun.Columns[NombreMarcaComu].Width = 130; pDataGrid.Columns[NombreMarcaComu].HeaderText = "Marca";
                dgSeleccComun.Columns[NombreModeloComu].Width = 150; pDataGrid.Columns[NombreModeloComu].HeaderText = "Modelo";
            }
        }

        private void PrepararDataGridMonit(DataGridView pDataGrid)
        {
            pDataGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            pDataGrid.RowHeadersVisible = false;
            pDataGrid.ReadOnly = false;

            foreach (DataGridViewColumn c in pDataGrid.Columns)
            {
                c.Resizable = DataGridViewTriState.True;
                if (c.Name == "sel_monit")
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

            if (pDataGrid.Name == "dgSeleccMonit")
            {
                dgSeleccMonit.Columns[CheckSelMon].Width = 30; pDataGrid.Columns[CheckSelMon].HeaderText = "Sel";
                dgSeleccMonit.Columns[idHardwareMon].Visible = false; pDataGrid.Columns[idHardwareMon].HeaderText = "idHardware";
                dgSeleccMonit.Columns[SerieHWMon].Width = 100; pDataGrid.Columns[SerieHWMon].HeaderText = "N° Serie";
                dgSeleccMonit.Columns[NombreHWMon].Width = 300; pDataGrid.Columns[NombreHWMon].HeaderText = "Nombre HW";
                dgSeleccMonit.Columns[NombreMarcaMon].Width = 130; pDataGrid.Columns[NombreMarcaMon].HeaderText = "Marca";
                dgSeleccMonit.Columns[NombreModeloMon].Width = 150; pDataGrid.Columns[NombreModeloMon].HeaderText = "Modelo";
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
            SqlCommand cmd = new SqlCommand("spObtieneListaHardwareComp", SqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
                    
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
                    dgSeleccComp.Rows[dgSeleccComp.Rows.Count - 1].Cells[tipoCompHw].Value = drBuscar.GetString(drBuscar.GetOrdinal("TipoComputador"));
                    dgSeleccComp.Rows[dgSeleccComp.Rows.Count - 1].Cells[SerieHW].Value = drBuscar.GetString(drBuscar.GetOrdinal("SerieHW"));
                    dgSeleccComp.Rows[dgSeleccComp.Rows.Count - 1].Cells[NombreHW].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreHW"));
                    dgSeleccComp.Rows[dgSeleccComp.Rows.Count - 1].Cells[NombreMarca].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreMarca"));
                    dgSeleccComp.Rows[dgSeleccComp.Rows.Count - 1].Cells[NombreModelo].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreModelo"));
                    dgSeleccComp.Rows[dgSeleccComp.Rows.Count - 1].Cells[DireccionIP].Value = drBuscar.GetString(drBuscar.GetOrdinal("DireccionIP"));
                    dgSeleccComp.Rows[dgSeleccComp.Rows.Count - 1].Cells[NombreEquipRed].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreEquipRed"));
                    dgSeleccComp.Columns[NombreModelo].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
                while (drBuscar.Read());
            }

            PrepararDataGridComp(dgSeleccComp);

            drBuscar.Close(); drBuscar.Dispose();
            cmd.Connection.Close(); cmd.Connection.Dispose();
            SqlCon.Close(); SqlCon.Dispose();
            
            if(dgSeleccComp.Rows.Count==0)
            {
                Rutinas.PresentaMensajeAceptar(cFormularioPadre,"alertaexclamacionamarillo","Atención","No existen Computadores disponibles para asociar.",false,false);
                EstadoInicial();
            }
        }

        private void ObtieneHWyaAsociadoUsr()
        {
            SqlConnection SqlCon = new SqlConnection(cConexionSQL);
            SqlCommand cmd = new SqlCommand("spObtieneListaHardwareyaAsoc", SqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@intIdUsuario", SqlDbType.Int);

            cmd.Parameters["@intIdUsuario"].Value = Convert.ToInt32(strUsuarioBusqueda); ;

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
                    dgSeleccComp.Rows[dgSeleccComp.Rows.Count - 1].Cells[tipoCompHw].Value = drBuscar.GetString(drBuscar.GetOrdinal("TipoComputador"));
                    dgSeleccComp.Rows[dgSeleccComp.Rows.Count - 1].Cells[SerieHW].Value = drBuscar.GetString(drBuscar.GetOrdinal("SerieHW"));
                    dgSeleccComp.Rows[dgSeleccComp.Rows.Count - 1].Cells[NombreHW].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreHW"));
                    dgSeleccComp.Rows[dgSeleccComp.Rows.Count - 1].Cells[NombreMarca].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreMarca"));
                    dgSeleccComp.Rows[dgSeleccComp.Rows.Count - 1].Cells[NombreModelo].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreModelo"));
                    dgSeleccComp.Rows[dgSeleccComp.Rows.Count - 1].Cells[DireccionIP].Value = drBuscar.GetString(drBuscar.GetOrdinal("DireccionIP"));
                    dgSeleccComp.Rows[dgSeleccComp.Rows.Count - 1].Cells[NombreEquipRed].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreEquipRed"));
                    dgSeleccComp.Columns[NombreModelo].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
                while (drBuscar.Read());
            }

            PrepararDataGridComp(dgSeleccComp);

            drBuscar.Close(); drBuscar.Dispose();
            cmd.Connection.Close(); cmd.Connection.Dispose();
            SqlCon.Close(); SqlCon.Dispose();
            ObtieneSoftwareList();
            gbSoftwareList.Visible = true;
        }

        private void ObtieneHWAsocImpr()
        {
            SqlConnection SqlCon = new SqlConnection(cConexionSQL);
            SqlCommand cmd = new SqlCommand("spObtieneListaHardwareImp", SqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlCon.Open();

            SqlDataReader drBuscar;
            drBuscar = cmd.ExecuteReader();
            dgSeleccImpr.Rows.Clear();
            if (drBuscar.HasRows)
            {

                drBuscar.Read();
                do
                {
                    dgSeleccImpr.Rows.Add(1);
                    dgSeleccImpr.Rows[dgSeleccImpr.Rows.Count - 1].Cells[CheckSelImp].Value = false;
                    dgSeleccImpr.Rows[dgSeleccImpr.Rows.Count - 1].Cells[idHardwareImp].Value = drBuscar.GetInt32(drBuscar.GetOrdinal("idHardware"));
                    dgSeleccImpr.Rows[dgSeleccImpr.Rows.Count - 1].Cells[TipoImpresoraHW].Value = drBuscar.GetString(drBuscar.GetOrdinal("TipoImpresoraHW"));
                    dgSeleccImpr.Rows[dgSeleccImpr.Rows.Count - 1].Cells[SerieHWImp].Value = drBuscar.GetString(drBuscar.GetOrdinal("SerieHW"));
                    dgSeleccImpr.Rows[dgSeleccImpr.Rows.Count - 1].Cells[NombreHWImp].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreHW"));
                    dgSeleccImpr.Rows[dgSeleccImpr.Rows.Count - 1].Cells[NombreMarcaImp].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreMarca"));
                    dgSeleccImpr.Rows[dgSeleccImpr.Rows.Count - 1].Cells[NombreModeloImp].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreModelo"));
                    dgSeleccImpr.Rows[dgSeleccImpr.Rows.Count - 1].Cells[DireccionIPImp].Value = drBuscar.GetString(drBuscar.GetOrdinal("DireccionIP"));
                    dgSeleccImpr.Rows[dgSeleccImpr.Rows.Count - 1].Cells[NombreEquipRedImp].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreEquipRed"));
                    dgSeleccImpr.Columns[NombreModeloImp].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
                while (drBuscar.Read());
            }

            PrepararDataGridImpr(dgSeleccImpr);

            drBuscar.Close(); drBuscar.Dispose();
            cmd.Connection.Close(); cmd.Connection.Dispose();
            SqlCon.Close(); SqlCon.Dispose();

            if (dgSeleccImpr.Rows.Count == 0)
            {
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "alertaexclamacionamarillo", "Atención", "No existen Impresoras disponibles para asociar.", false, false);
                EstadoInicial();
            }
        }

        private void ObtieneHWAsocMonit()
        {
            SqlConnection SqlCon = new SqlConnection(cConexionSQL);
            SqlCommand cmd = new SqlCommand("spObtieneListaHardwareMonit", SqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlCon.Open();

            SqlDataReader drBuscar;
            drBuscar = cmd.ExecuteReader();
            dgSeleccMonit.Rows.Clear();
            if (drBuscar.HasRows)
            {

                drBuscar.Read();
                do
                {
                    dgSeleccMonit.Rows.Add(1);
                    dgSeleccMonit.Rows[dgSeleccMonit.Rows.Count - 1].Cells[CheckSelMon].Value = false;
                    dgSeleccMonit.Rows[dgSeleccMonit.Rows.Count - 1].Cells[idHardwareMon].Value = drBuscar.GetInt32(drBuscar.GetOrdinal("idHardware"));
                    dgSeleccMonit.Rows[dgSeleccMonit.Rows.Count - 1].Cells[TipoMonitorHW].Value = drBuscar.GetString(drBuscar.GetOrdinal("TipoMonitorHW"));
                    dgSeleccMonit.Rows[dgSeleccMonit.Rows.Count - 1].Cells[SerieHWMon].Value = drBuscar.GetString(drBuscar.GetOrdinal("SerieHW"));
                    dgSeleccMonit.Rows[dgSeleccMonit.Rows.Count - 1].Cells[NombreHWMon].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreHW"));
                    dgSeleccMonit.Rows[dgSeleccMonit.Rows.Count - 1].Cells[NombreMarcaMon].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreMarca"));
                    dgSeleccMonit.Rows[dgSeleccMonit.Rows.Count - 1].Cells[NombreModeloMon].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreModelo"));
                    dgSeleccMonit.Columns[NombreModeloMon].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
                while (drBuscar.Read());
            }

            PrepararDataGridMonit(dgSeleccMonit);

            drBuscar.Close(); drBuscar.Dispose();
            cmd.Connection.Close(); cmd.Connection.Dispose();
            SqlCon.Close(); SqlCon.Dispose();

            if (dgSeleccMonit.Rows.Count == 0)
            {
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "alertaexclamacionamarillo", "Atención", "No existen Monitores disponibles para asociar.", false, false);
                EstadoInicial();
            }
        }

        private void ObtieneHWAsocComun()
        {
            SqlConnection SqlCon = new SqlConnection(cConexionSQL);
            SqlCommand cmd = new SqlCommand("spObtieneListaHardwareComun", SqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlCon.Open();

            SqlDataReader drBuscar;
            drBuscar = cmd.ExecuteReader();
            dgSeleccComun.Rows.Clear();
            if (drBuscar.HasRows)
            {

                drBuscar.Read();
                do
                {
                    dgSeleccComun.Rows.Add(1);
                    dgSeleccComun.Rows[dgSeleccComun.Rows.Count - 1].Cells[CheckSelComu].Value = false;
                    dgSeleccComun.Rows[dgSeleccComun.Rows.Count - 1].Cells[idHardwareComu].Value = drBuscar.GetInt32(drBuscar.GetOrdinal("idHardware"));
                    dgSeleccComun.Rows[dgSeleccComun.Rows.Count - 1].Cells[TipoComuniacionesHW].Value = drBuscar.GetString(drBuscar.GetOrdinal("TipoComunicacionesHW"));
                    dgSeleccComun.Rows[dgSeleccComun.Rows.Count - 1].Cells[SerieHWComu].Value = drBuscar.GetString(drBuscar.GetOrdinal("SerieHW"));
                    dgSeleccComun.Rows[dgSeleccComun.Rows.Count - 1].Cells[NombreHWComu].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreHW"));
                    dgSeleccComun.Rows[dgSeleccComun.Rows.Count - 1].Cells[NombreMarcaComu].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreMarca"));
                    dgSeleccComun.Rows[dgSeleccComun.Rows.Count - 1].Cells[NombreModeloComu].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreModelo"));
                    dgSeleccComun.Rows[dgSeleccComun.Rows.Count - 1].Cells[DireccionIPComu].Value = drBuscar.GetString(drBuscar.GetOrdinal("DireccionIP"));
                    dgSeleccComun.Rows[dgSeleccComun.Rows.Count - 1].Cells[NombreEquipRedComu].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreEquipRed"));
                    dgSeleccComun.Columns[NombreModeloComu].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                while (drBuscar.Read());
            }

            PrepararDataGridComun(dgSeleccComun);

            drBuscar.Close(); drBuscar.Dispose();
            cmd.Connection.Close(); cmd.Connection.Dispose();
            SqlCon.Close(); SqlCon.Dispose();

            if (dgSeleccComun.Rows.Count == 0)
            {
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "alertaexclamacionamarillo", "Atención", "No existen Equipos de Comuniaciones disponibles para asociar.", false, false);
                EstadoInicial();
            }
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
                    dgSoftwareList.Columns[DescripcionSW].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
            dgSeleccComp.Rows.Clear();
            dgSeleccImpr.Rows.Clear();                       

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
            if (AgregoSoftware)
            {
                cmd.Parameters["@intIdSoftware"].Value = intIdSoftware;                
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

        private void cmbHardwareAsoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            vchTipoHWAsoc = cmbHardwareAsoc.Text;
            tcAsocActivos.Enabled = true;

            if (vchTipoHWAsoc=="COMPUTADOR")
            {                            
                tcAsocActivos.SelectedTab = tbpCompu;

                BuscaActivoDeUsuario("COMP");
            }
            else if (vchTipoHWAsoc=="IMPRESORAS")
            {
             
                tcAsocActivos.SelectedTab = tbpImpresora;
                BuscaActivoDeUsuario("IMPR");

            }
            else if (vchTipoHWAsoc == "MONITOR")
            {

                tcAsocActivos.SelectedTab = tbpMonitor;
                BuscaActivoDeUsuario("MONI");

            }
            else if (vchTipoHWAsoc == "COMUNICACIONES")
            {
                tcAsocActivos.SelectedTab = tbpComun;
                BuscaActivoDeUsuario("COMU");
            }
        }
        
        private void BuscaActivoDeUsuario(string tipoHw)
        {            
            SqlConnection Con = new SqlConnection(cConexionSQL);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spConsultaSiUsuarioTieneHWAsoc", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@intIdUsuario", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@chTipohw", SqlDbType.Char,4);
            auxParametro = cmd.Parameters.Add("@vchMsgOut", SqlDbType.Char, 1);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@intIdUsuario"].Value = Convert.ToInt32(strUsuarioBusqueda);
            cmd.Parameters["@chTipohw"].Value = tipoHw;

            cmd.ExecuteNonQuery();           

            if (cmd.Parameters["@vchMsgOut"].Value.ToString()=="S") 
            {
                if (tipoHw=="COMP")
                {
                    if (Rutinas.PresentaMensajeAceptarCancelar(cFormularioPadre, "alertaconsultaamarillo", "Atención", "Usuario ya tiene Computador asignado.\n"
                                                           + "Desea Agregar Software a este?", false, false) == false)
                    {                        
                        ObtieneHWAsocComp();
                    }

                    else
                    {
                        ObtieneHWyaAsociadoUsr();
                        txtNumIPComp.Enabled = false;
                        txtNombEquipRed.Enabled = false;
                    }
                }

                else if (tipoHw=="IMPR")
                {
                    if (Rutinas.PresentaMensajeAceptarCancelar(cFormularioPadre, "alertaconsultaamarillo", "Atención", "Usuario ya tiene Impresora asignado.\n"
                                                           + "Desea asignar otra?", false, false))
                    {
                        ObtieneHWAsocImpr();
                    }
                    else
                    {
                        EstadoInicial();
                    }
                }

                else if (tipoHw == "MONI")
                {
                    if (Rutinas.PresentaMensajeAceptarCancelar(cFormularioPadre, "alertaconsultaamarillo", "Atención", "Usuario ya tiene Monitor asignado.\n"
                                                           + "Desea asignar otro?", false, false))
                    {
                        ObtieneHWAsocMonit();
                    }
                    else
                    {
                        EstadoInicial();
                    }
                }

                else if (tipoHw == "COMU")
                {
                    if (Rutinas.PresentaMensajeAceptarCancelar(cFormularioPadre, "alertaconsultaamarillo", "Atención", "Usuario ya tiene Equipo de Comuniaciones asignado.\n"
                                                           + "Desea asignar otro?", false, false))
                    {
                        ObtieneHWAsocComun();
                    }
                    else
                    {
                        EstadoInicial();
                    }
                }

            }
            else
            {
                if (tipoHw == "COMP")
                {
                    ObtieneHWAsocComp();
                }
                else if (tipoHw == "IMPR")
                {
                    ObtieneHWAsocImpr();
                }
                else if (tipoHw == "MONI")
                {
                    ObtieneHWAsocMonit();
                }
                else if (tipoHw == "COMU")
                {
                    ObtieneHWAsocComun();
                }

            }

            cmd.Connection.Close(); cmd.Connection.Dispose();
            Con.Close(); Con.Dispose();
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
            txtNumIPComp.Text=Convert.ToString(dgSeleccComp.Rows[e.RowIndex].Cells[DireccionIP].Value);
            txtNombEquipRed.Text = Convert.ToString(dgSeleccComp.Rows[e.RowIndex].Cells[NombreEquipRed].Value);
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

        private void VerificarImpresoraSeleccionada(DataGridView pDataGrid, int pFila, int pColumna)
        {
            if (pFila < 0 || pColumna != 0) { return; } //columna distinta de cero

            foreach (DataGridViewRow row in pDataGrid.Rows)
            {
                if (pFila != row.Index)
                {
                    DataGridViewCheckBoxCell chbDesocupados = (DataGridViewCheckBoxCell)row.Cells[CheckSelImp]; //columna donde se hace la selección
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

            AgregoSoftware = true;
        }

        private void dgSoftwareList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgSoftwareList.EndEdit();
            VerificarSoftwareSeleccionado(dgSoftwareList, e.RowIndex, e.ColumnIndex);
            intIdSoftware= Convert.ToInt32(dgSoftwareList.Rows[e.RowIndex].Cells[idSoftware].Value);
        }

        private void tsbGrabarActivo_Click(object sender, EventArgs e)
        {
            ValidaControlesCompletos();
            if (ControlesVacios == true)
            {
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "alertamalorojo","Error","Debe ingresar todos los datos para grabar.",false,false);
                return;
            } //verifica text box completos

            if (tcAsocActivos.SelectedTab==tbpCompu)
            {
                if (AgregoSoftware == false)
                {
                    if (Rutinas.PresentaMensajeAceptarCancelar(cFormularioPadre, "alertaexclamacionamarillo", "Atención", "Desea Agregar Software antes de Grabar?", false, false))
                    {
                        gbSoftwareList.Visible = true;
                        ObtieneSoftwareList();
                    }
                    else
                    {
                        InsertaNuevoAsocHW();
                    }
                }
                else
                {
                    InsertaNuevoAsocHW();
                }
            }

            else
            {
                InsertaNuevoAsocHW();
            }           

        }

        private void tsbCancelarAsocActivo_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void ValidaControlesCompletos()
        {
            if (tcAsocActivos.SelectedTab==tbpCompu)
            {
                if (String.IsNullOrEmpty(txtNumIPComp.Text) || String.IsNullOrEmpty(txtNombEquipRed.Text))
                {
                    ControlesVacios = true;
                }
                else
                {
                    ControlesVacios = false;
                }
            }
            else
            {
                ControlesVacios = false;
            }
        }

        private void dgSeleccImpr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgSeleccImpr.EndEdit();
            VerificarImpresoraSeleccionada(dgSeleccImpr, e.RowIndex, e.ColumnIndex);
            intIdHardware = Convert.ToInt32(dgSeleccImpr.Rows[e.RowIndex].Cells[idHardwareImp].Value);
        }

        private void dgSeleccMonit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgSeleccMonit.EndEdit();
            intIdHardware = Convert.ToInt32(dgSeleccMonit.Rows[e.RowIndex].Cells[idHardwareMon].Value);
        }

        private void dgSeleccComun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgSeleccComun.EndEdit();
            intIdHardware = Convert.ToInt32(dgSeleccComun.Rows[e.RowIndex].Cells[idHardwareComu].Value);
        }
    }
}
