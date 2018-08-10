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
    public partial class fActivo : Form
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

        public string intIdMarcaActivo;

        //variables locales
        private string intMarcaCB;
        private string intModeloCB;

        //variables para Insertar un Hardware
        private string TipoProducto;
        private string NombreProducto;
        private string EstadoActivo;
        private string Cantidad;
        private string Garantia;
        private string Usuario;
        private string Equipo;
        private string tipoDispHW;
        private string idEquipoDominio;
        private string NombreHW;
        private string idModelo;
        private string idMarca;
        private string SerieHW;
        private string dtFechaAsocU;
        private string VidaUtil;
        private string EstadoHW;
        private string idUsuario;
        private string TipoComputador;
        private string GeneracionProc;
        private string VelProcesador;
        private string TipoDiscoDuro;
        private string CapacidadDD;
        private string VelocidadDD;
        private string MemoriaRam;
        private string TipoComunic;
        private string CantidadBocas;
        private string TipoImpresora;
        private string VelocidadImpr;
        private string TipoMonitor;
        private string TamanoMonitor;
        private string TipoPantallaComp;
        private string TamanoPantallaComp;


        //variables para Insumos

        private string vchTipoProducto;
        private string vchNombreProd;
        private string vchEstadoActivo;
        private string intCantidad;
        private string vchGarantia;
        private string idFactura;
        private string idOcEncabezado;
        private string vchUsuario;
        private string vchEquipo;
        private string vchTipoInsumo;
        private string vchNombreInsumo;
        private string vchPartNumberIns;
        private string vchNumSerieIns;
        private string intIdModelo;
        private string intIdMarca;
        private string intIdUsuario;

        private string vchTipoLicenSW;
        private string vchEstadoActSW;
        private string vchAnoSW;
        private string vchTipoSW;

        private string vchNombreFabricanteSW;

        public fActivo()
        {
            InitializeComponent();
        }

        private void fActivo_Load(object sender, EventArgs e)
        {
            EstadoInicial();
            CargaComboBoxTotal();                       
        }

        private void CargaComboBoxTotal()
        {
            CargarComboBoxEstados();
            CargarComboBoxMarca();
            CargarComboBoxFacturaActivo();
            CargarComboBoxEstadosSW();
            CargarComboBoxMarcaSW();
            CargarComboBoxTipoLicSW();
            CargarComboBoxEstadosIns();
            CargarComboBoxMarcaIns();
            CargarComboBoxTipoSW();
            CargarComboBoxTipoHW();
            CargarComboBoxTipoCompHW();
            CargarComboBoxModeloProcHW();
            CargarComboBoxVelocidadProcHW();
            CargarComboBoxCapacidadDDHw();
            CargarComboBoxGeneracionProcHW();
            CargarComboBoxMemoriaRamHW();
            CargarDatosComboBoxTipoIns();
            CargarComboBoxTipoImprHW();
            CargarComboBoxVelocImprHW();
            CargarComboBoxTipoPantallaHW();
            CargarComboBoxTamanoPantallaHW();
        }

        private void cmbModelo_SelectionChangeCommitted(object sender, EventArgs e)
        {                        
            intModeloCB = Convert.ToString(cmbModeloHW.SelectedValue);           
        }


        private void limpiaVariables()
        {
            txtNombreProdHW.Text = String.Empty;
            cmbEstadoActHW.Text = String.Empty;
            cmbMarcaHW.SelectedIndex = -1;
            cmbModeloHW.SelectedIndex = -1;

            
            dtpFechaVenc.Value = DateTime.Now;
            dtpFechaCompra.Value = DateTime.Now;
            dtpFechaCompraHW.Value = DateTime.Now;

            TipoProducto = "";
            NombreProducto = "";
            EstadoActivo = "";
            Cantidad = "";
            Garantia = "";
            Usuario = "";
            Equipo = "";
            tipoDispHW = "";
            idEquipoDominio = "";
            NombreHW = "";
            idModelo = "";
            idMarca = "";
            SerieHW = "";
            dtFechaAsocU = "";
            VidaUtil = "";
            EstadoHW = "";
            idUsuario = "";
            TipoComputador = "";
            GeneracionProc = "";
            VelProcesador = "";
            TipoDiscoDuro = "";
            CapacidadDD = "";
            VelocidadDD = "";
            MemoriaRam = "";
            TipoComunic = "";
            CantidadBocas = "";
            TipoImpresora = "";
            VelocidadImpr = "";
            TipoMonitor = "";
            TamanoMonitor = "";
            TipoPantallaComp = "";
            TamanoPantallaComp = "";


            //variables para Insumos
            vchTipoProducto = "";
            vchNombreProd = "";
            vchEstadoActivo = "";
            intCantidad = "";
            vchGarantia = "";
            idFactura = "";
            idOcEncabezado = "";
            vchUsuario = "";
            vchEquipo = "";
            vchTipoInsumo = "";
            vchNombreInsumo = "";
            vchPartNumberIns = "";
            vchNumSerieIns = "";
            intIdModelo = "";
            intIdMarca = "";
            intIdUsuario = "";

            // Variables SW
            vchTipoLicenSW = "";
            vchEstadoActSW = "";
            vchAnoSW = "";
            vchTipoSW = "";

            //Text Box SW
            txtNombrePrdSW.Text = String.Empty;
            txtCantidadSW.Text = String.Empty;
            txtLicencia.Text = String.Empty;
            txtNombrePrdSW.Text = String.Empty;
            txtVersionSW.Text = String.Empty;
            txtDescripcionSW.Text = String.Empty;          

            //Text Box HW
            txtNombreProdHW.Text = String.Empty;            
            txtNumSerie.Text = String.Empty;

            //Text Box Ins
            txtNomProdInsumo.Text = String.Empty;
            txtNumSerieIns.Text = String.Empty;
            txtPartNumberIns.Text = String.Empty;

            //Combo Box SW

            cmbEstadoSW.SelectedIndex = -1;
            cmbMarcaSW.SelectedIndex = -1;
            cmbTipoSW.SelectedIndex = -1;
            cmbTipoLicSW.SelectedIndex = -1;
            cmbAnoSW.SelectedIndex = -1;

            //Combo Box HW

            cmbEstadoActHW.SelectedIndex = -1;
            cmbTipoHW.SelectedIndex = -1;
            cmbMarcaHW.SelectedIndex = -1;
            cmbModeloHW.SelectedIndex = -1;
            cmbTipoCompu.SelectedIndex = -1;
            cmbModProc.SelectedIndex = -1;
            cmbVelocProc.SelectedIndex = -1;
            cmbCapacDDHw.SelectedIndex = -1;
            cmbGeneracionProcHW.SelectedIndex = -1;
            cmbCapacMemRam.SelectedIndex = -1;
            cmbTipoPantallaHW.SelectedIndex = -1;
            cmbTamPantallaHW.SelectedIndex = -1;

            //Combo Box Ins

            cmbEstInsumo.SelectedIndex = -1;
            cmbMarInsumo.SelectedIndex = -1;
            cmbModeloInsumo.SelectedIndex = -1;
            cmbTipoInsumo.SelectedIndex = -1;

            //combo Box Impresora
            cmbTipoImprHW.SelectedValue = -1;
            cmbVelocImprHW.SelectedValue = -1;

            //limpia radio button
            rbVenceSi.Checked = false;
            rbVenceNo.Checked = false;

            //group Box Vencimiento
            gbVencimientoSW.Visible = false;

        }   

        private void EstadoInicial()
        {
            limpiaVariables();
            tsEditarActivo.Visible = false;
            tsbImprimirActivo.Visible = false;
            tsbEliminarActivo.Visible = false;
            cmbModeloHW.Enabled = false;

            ((Control)this.tbImprHW).Enabled = false;
            ((Control)this.tbpComunHW).Enabled = false;
            ((Control)this.tbpMonitorHW).Enabled = false;
            ((Control)this.tbCompuHW).Enabled = false;
        }

        private void Grabar()
        {
            string tabActivo;

            tabActivo = tbContenedorAct.SelectedTab.Name;            

            if (tabActivo=="tbPageSW")
            {
                InsertNewActivo();
            }
            else if (tabActivo=="tbPageHW")
            {
                InsertaNewActivoHW();                
            }
            else if (tabActivo=="tbPageInsumo")
            {
                InsertNewActivoIns();
            }

        }


        private void InsertNewActivoIns()
        {
            string auxRespuesta = "";

            SqlConnection Con = new SqlConnection(cConexionSQL);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spInsertNewActivoInsumo", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@vchTipoProducto", SqlDbType.VarChar, 20);
            auxParametro = cmd.Parameters.Add("@vchNombreProd", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@vchEstadoActivo", SqlDbType.VarChar, 50);
            auxParametro = cmd.Parameters.Add("@intCantidad", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@vchGarantia", SqlDbType.VarChar, 10);
            auxParametro = cmd.Parameters.Add("@idFactura", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@idOcEncabezado", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@vchUsuario", SqlDbType.VarChar, 20);
            auxParametro = cmd.Parameters.Add("@vchEquipo", SqlDbType.VarChar, 30);
            auxParametro = cmd.Parameters.Add("@vchTipoInsumo", SqlDbType.VarChar, 20);
            auxParametro = cmd.Parameters.Add("@vchNombreInsumo", SqlDbType.VarChar, 100);
            auxParametro = cmd.Parameters.Add("@vchPartNumberIns", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@vchNumSerieIns", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@intIdModelo", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@intIdMarca", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@intIdUsuario", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@dtFechaCompra", SqlDbType.DateTime);
            auxParametro = cmd.Parameters.Add("@msgError", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@vchTipoProducto"].Value = "INSUMO";
            cmd.Parameters["@vchNombreProd"].Value = txtNomProdInsumo.Text.Trim();
            cmd.Parameters["@vchEstadoActivo"].Value = vchEstadoActivo;
            cmd.Parameters["@intCantidad"].Value = DBNull.Value;
            cmd.Parameters["@vchGarantia"].Value = DBNull.Value;
            cmd.Parameters["@idFactura"].Value = DBNull.Value;
            cmd.Parameters["@idOcEncabezado"].Value = DBNull.Value;
            cmd.Parameters["@vchUsuario"].Value = Properties.Settings.Default.Login;
            cmd.Parameters["@vchEquipo"].Value = Environment.MachineName;
            cmd.Parameters["@vchTipoInsumo"].Value = vchTipoInsumo;
            cmd.Parameters["@vchNombreInsumo"].Value = txtNomProdInsumo.Text.Trim();
            cmd.Parameters["@vchPartNumberIns"].Value = txtPartNumberIns.Text.Trim();
            cmd.Parameters["@vchNumSerieIns"].Value = txtNumSerieIns.Text.Trim();
            cmd.Parameters["@intIdModelo"].Value = intModeloCB;
            cmd.Parameters["@intIdMarca"].Value = intMarcaCB;
            cmd.Parameters["@intIdUsuario"].Value = DBNull.Value;
            cmd.Parameters["@dtFechaCompra"].Value = dtpFechaCompraIns.Text;

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
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "bueno", "Operación Correcta.", "Se realizó la Inserción", false, false);
                EstadoInicial();

            }
            else
            {
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "malo", "Error en la Operación.", auxRespuesta, false, false);
            }

        }

        private void InsertaNewActivoHW()
        {
            string auxRespuesta = "";

            SqlConnection Con = new SqlConnection(cConexionSQL);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spInsertNewActivoHW", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@TipoProducto", SqlDbType.VarChar, 20);
            auxParametro = cmd.Parameters.Add("@NombreProducto", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@EstadoActivo", SqlDbType.VarChar, 50);
            auxParametro = cmd.Parameters.Add("@Cantidad", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@Garantia", SqlDbType.VarChar, 10);
            auxParametro = cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 20);
            auxParametro = cmd.Parameters.Add("@Equipo", SqlDbType.VarChar, 30);
            auxParametro = cmd.Parameters.Add("@tipoDispHW", SqlDbType.VarChar, 50);
            auxParametro = cmd.Parameters.Add("@idEquipoDominio", SqlDbType.VarChar, 50);
            auxParametro = cmd.Parameters.Add("@NombreHW", SqlDbType.VarChar, 100);
            auxParametro = cmd.Parameters.Add("@idModelo", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@idMarca", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@SerieHW", SqlDbType.VarChar, 100);
            auxParametro = cmd.Parameters.Add("@dtFechaAsocU", SqlDbType.DateTime);
            auxParametro = cmd.Parameters.Add("@VidaUtil", SqlDbType.VarChar, 10);
            auxParametro = cmd.Parameters.Add("@EstadoHW", SqlDbType.VarChar, 50);
            auxParametro = cmd.Parameters.Add("@idUsuario", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@TipoComputador", SqlDbType.VarChar, 20);
            auxParametro = cmd.Parameters.Add("@GeneracionProc", SqlDbType.VarChar, 20);
            auxParametro = cmd.Parameters.Add("@VelProcesador", SqlDbType.VarChar, 20);
            auxParametro = cmd.Parameters.Add("@TipoDiscoDuro", SqlDbType.VarChar, 20);
            auxParametro = cmd.Parameters.Add("@CapacidadDD", SqlDbType.VarChar, 20);
            auxParametro = cmd.Parameters.Add("@VelocidadDD", SqlDbType.VarChar, 20);
            auxParametro = cmd.Parameters.Add("@MemoriaRam", SqlDbType.VarChar, 20);
            auxParametro = cmd.Parameters.Add("@TipoComunic", SqlDbType.VarChar, 20);
            auxParametro = cmd.Parameters.Add("@CantidadBocas", SqlDbType.VarChar, 20);
            auxParametro = cmd.Parameters.Add("@TipoImpresora", SqlDbType.VarChar, 20);
            auxParametro = cmd.Parameters.Add("@VelocidadImpr", SqlDbType.VarChar, 20);
            auxParametro = cmd.Parameters.Add("@TipoMonitor", SqlDbType.VarChar, 20);
            auxParametro = cmd.Parameters.Add("@TamanoMonitor", SqlDbType.VarChar, 20);
            auxParametro = cmd.Parameters.Add("@dtFechaCompra", SqlDbType.DateTime);
            auxParametro = cmd.Parameters.Add("@vchTipoPantComp", SqlDbType.VarChar, 5);
            auxParametro = cmd.Parameters.Add("@vchTamanoPantComp", SqlDbType.VarChar, 5);
            auxParametro = cmd.Parameters.Add("@msgError", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;


            cmd.Parameters["@TipoProducto"].Value = "HARDWARE";
            cmd.Parameters["@NombreProducto"].Value = txtNombreProdHW.Text.Trim();
            cmd.Parameters["@EstadoActivo"].Value = EstadoHW;
            cmd.Parameters["@Cantidad"].Value = Convert.ToInt32("1");
            cmd.Parameters["@Garantia"].Value = DBNull.Value;
            cmd.Parameters["@Usuario"].Value = Properties.Settings.Default.Login;
            cmd.Parameters["@Equipo"].Value = Environment.MachineName;
            cmd.Parameters["@tipoDispHW"].Value = tipoDispHW;
            cmd.Parameters["@idEquipoDominio"].Value = DBNull.Value;
            cmd.Parameters["@NombreHW"].Value = txtNombreProdHW.Text.Trim();
            cmd.Parameters["@idModelo"].Value = intModeloCB;
            cmd.Parameters["@idMarca"].Value = intMarcaCB;
            cmd.Parameters["@SerieHW"].Value = txtNumSerie.Text.Trim();
            cmd.Parameters["@dtFechaAsocU"].Value = DBNull.Value;
            cmd.Parameters["@VidaUtil"].Value = DBNull.Value;
            cmd.Parameters["@EstadoHW"].Value = EstadoHW;
            cmd.Parameters["@idUsuario"].Value = DBNull.Value;
            cmd.Parameters["@TipoComputador"].Value =  TipoComputador;
            cmd.Parameters["@GeneracionProc"].Value = GeneracionProc;
            cmd.Parameters["@VelProcesador"].Value = VelProcesador;
            cmd.Parameters["@TipoDiscoDuro"].Value = DBNull.Value;
            cmd.Parameters["@CapacidadDD"].Value = CapacidadDD;
            cmd.Parameters["@VelocidadDD"].Value = DBNull.Value;
            cmd.Parameters["@MemoriaRam"].Value = MemoriaRam;
            cmd.Parameters["@TipoComunic"].Value = DBNull.Value;
            cmd.Parameters["@CantidadBocas"].Value = DBNull.Value;
            cmd.Parameters["@TipoImpresora"].Value = TipoImpresora;
            cmd.Parameters["@VelocidadImpr"].Value = VelocidadImpr;
            cmd.Parameters["@TipoMonitor"].Value = DBNull.Value;
            cmd.Parameters["@TamanoMonitor"].Value = DBNull.Value;
            cmd.Parameters["@dtFechaCompra"].Value = dtpFechaCompraHW.Text;
            cmd.Parameters["@vchTipoPantComp"].Value = TipoPantallaComp;
            cmd.Parameters["@vchTamanoPantComp"].Value = TamanoPantallaComp;

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
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "bueno", "Operación Correcta.", "Se realizó la Inserción", false, false);
                EstadoInicial();

            }
            else
            {
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "malo", "Error en la Operación.", auxRespuesta, false, false);
            }


        }

        private void InsertNewActivo()
        {

            string auxRespuesta = "";

            SqlConnection Con = new SqlConnection(cConexionSQL);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spInsertNewActivoSW", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@TipoProducto", SqlDbType.VarChar, 20);
            auxParametro = cmd.Parameters.Add("@NombreProducto", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@EstadoActivo", SqlDbType.VarChar, 50);
            auxParametro = cmd.Parameters.Add("@Cantidad", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@Garantia", SqlDbType.VarChar, 20);
            auxParametro = cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 30);
            auxParametro = cmd.Parameters.Add("@Equipo", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@NumLicencia", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@TipoLicencia", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@NombreSW", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@VersionSW", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@AnoSW", SqlDbType.VarChar, 10);
            auxParametro = cmd.Parameters.Add("@DescripcionSW", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@TiempoVencimiento", SqlDbType.VarChar, 10);
            auxParametro = cmd.Parameters.Add("@FechaVencimiento", SqlDbType.DateTime);
            auxParametro = cmd.Parameters.Add("@FabricanteSW", SqlDbType.VarChar, 50);
            auxParametro = cmd.Parameters.Add("@dtFechaCompra", SqlDbType.DateTime);
            auxParametro = cmd.Parameters.Add("@vchTipoSoftware", SqlDbType.VarChar, 30);
            auxParametro = cmd.Parameters.Add("@msgError", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;



            cmd.Parameters["@TipoProducto"].Value = "SOFTWARE";
            cmd.Parameters["@NombreProducto"].Value = txtNombrePrdSW.Text.Trim();
            cmd.Parameters["@EstadoActivo"].Value = vchEstadoActSW;
            cmd.Parameters["@Cantidad"].Value = Convert.ToInt32(txtCantidadSW.Text.Trim());
            cmd.Parameters["@Garantia"].Value = "";
            cmd.Parameters["@Usuario"].Value = Properties.Settings.Default.Login;
            cmd.Parameters["@Equipo"].Value = Environment.MachineName;
            cmd.Parameters["@NumLicencia"].Value = txtLicencia.Text.Trim();
            cmd.Parameters["@TipoLicencia"].Value = vchTipoLicenSW;
            cmd.Parameters["@NombreSW"].Value = txtNombrePrdSW.Text.Trim();
            cmd.Parameters["@VersionSW"].Value = txtVersionSW.Text.Trim();
            cmd.Parameters["@AnoSW"].Value = vchAnoSW;
            cmd.Parameters["@DescripcionSW"].Value = txtDescripcionSW.Text.Trim();
            cmd.Parameters["@TiempoVencimiento"].Value = "";
            if (rbVenceSi.Checked) { cmd.Parameters["@FechaVencimiento"].Value = dtpFechaVenc.Text; } else { cmd.Parameters["@FechaVencimiento"].Value = DBNull.Value; }        
            cmd.Parameters["@FabricanteSW"].Value = vchNombreFabricanteSW;
            cmd.Parameters["@dtFechaCompra"].Value = dtpFechaCompra.Text;
            cmd.Parameters["@vchTipoSoftware"].Value = vchTipoSW;


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
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "bueno", "Operación Correcta.", "Se realizó la Inserción", false, false);
                EstadoInicial();

            }
            else
            {
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "malo", "Error en la Operación.", auxRespuesta, false, false);
            }

        }

        private void tsbGrabar_Click(object sender, EventArgs e)
        {
            Grabar();          
        }

        private void dgContieneHW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgContieneHW_DoubleClick(object sender, EventArgs e)
        {
          
        }  
             

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            limpiaVariables();
        }

        private void cmbTipoSel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            

                

        }

        private void cmbMarcaSW_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            intIdMarcaActivo = Convert.ToString(cmbMarcaSW.SelectedValue);
            vchNombreFabricanteSW = cmbMarcaSW.Text;
     
        }

        

        private void cmbMarInsumo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            intMarcaCB = Convert.ToString(cmbMarInsumo.SelectedValue);
            CargarComboBoxModeloIns();
        }

        private void cmbModeloInsumo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            intModeloCB = Convert.ToString(cmbModeloInsumo.SelectedValue);          
        }

      

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tsActivo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }       

        private void cmbAnoSW_DropDown(object sender, EventArgs e)
        {
            cmbAnoSW.DataSource = Enumerable.Range(1950, 100).ToList();
            
        }

        private void txtLicencia_TextChanged(object sender, EventArgs e)
        {
            
        
        }

        private void txtLicencia_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CargarComboBoxEstados()
        {
            Rutinas.CargarDatosComboBox(cConexionSQL, "spObtieneEstadosAct", cmbEstadoActHW, "Estado", "idEstado");
            cmbEstadoActHW.SelectedIndex = -1;
        }
        private void CargarComboBoxEstadosSW()
        {
            Rutinas.CargarDatosComboBox(cConexionSQL, "spObtieneEstadosAct", cmbEstadoSW, "Estado", "idEstado");
            cmbEstadoSW.SelectedIndex = -1;
        }
        private void CargarComboBoxEstadosIns()
        {
            Rutinas.CargarDatosComboBox(cConexionSQL, "spObtieneEstadosAct", cmbEstInsumo, "Estado", "idEstado");
            cmbEstInsumo.SelectedIndex = -1;
        }

        private void CargarComboBoxMarca()
        {
            Rutinas.CargarDatosComboBox(cConexionSQL, "spObtieneMarcaComboBox", cmbMarcaHW, "NombreMarca", "idMarca");
            cmbMarcaHW.SelectedIndex = -1;
        }

        private void CargarComboBoxMarcaSW()
        {
            Rutinas.CargarDatosComboBox(cConexionSQL, "spObtieneMarcaComboBox", cmbMarcaSW, "NombreMarca", "idMarca");
            cmbMarcaSW.SelectedIndex = -1;
        }
        private void CargarComboBoxMarcaIns()
        {
            Rutinas.CargarDatosComboBox(cConexionSQL, "spObtieneMarcaComboBox", cmbMarInsumo, "NombreMarca", "idMarca");
            cmbMarInsumo.SelectedIndex = -1;
        }

        private void CargarComboBoxModelo()
        {
            string CadenaSPObtieneMarca = "spObtieneModeloComboBox " + intMarcaCB;
            Rutinas.CargarDatosComboBox(cConexionSQL, CadenaSPObtieneMarca, cmbModeloHW, "NombreModelo", "idModelo");
            cmbModeloHW.SelectedIndex = -1;
        }

        private void CargarComboBoxModeloIns()
        {
            string CadenaSPObtieneMarca = "spObtieneModeloComboBox " + intMarcaCB;
            Rutinas.CargarDatosComboBox(cConexionSQL, CadenaSPObtieneMarca, cmbModeloInsumo, "NombreModelo", "idModelo");
            cmbModeloInsumo.SelectedIndex = -1;
        }


        private void CargarComboBoxFacturaActivo()
        {
            
        }

        private void CargarComboBoxTipoSW()
        {
            Rutinas.CargarDatosComboBox(cConexionSQL, "spObtieneComboBoxTipoSW", cmbTipoSW, "ValorParam", "idParametro");
            cmbTipoSW.SelectedIndex = -1;
        }

        private void CargarComboBoxTipoLicSW()
        {
            Rutinas.CargarDatosComboBox(cConexionSQL, "spObtieneComboBoxTipoLicSW", cmbTipoLicSW, "ValorParam", "idParametro");
            cmbTipoLicSW.SelectedIndex = -1;
        }

        private void CargarComboBoxTipoHW()
        {
            Rutinas.CargarDatosComboBox(cConexionSQL, "spObtieneCBTipoHW", cmbTipoHW, "DescripParam", "idParamHW");
            cmbTipoHW.SelectedIndex = -1;
        }

        private void CargarComboBoxTipoCompHW()
        {
            Rutinas.CargarDatosComboBox(cConexionSQL, "spObtieneCBTipoCompHW", cmbTipoCompu, "ValorParam", "idParamHW");
            cmbTipoCompu.SelectedIndex = -1;                
        }

        private void CargarComboBoxModeloProcHW()
        {
            Rutinas.CargarDatosComboBox(cConexionSQL, "spObtieneCBModeloProc", cmbModProc, "ValorParam", "idParamHW");
            cmbModProc.SelectedIndex = -1;
        }

        private void CargarComboBoxVelocidadProcHW()
        {
            Rutinas.CargarDatosComboBox(cConexionSQL, "spObtieneCBVelocProc", cmbVelocProc, "ValorParam", "idParamHW");
            cmbVelocProc.SelectedIndex = -1;
        }

        private void CargarComboBoxCapacidadDDHw()
        {
            Rutinas.CargarDatosComboBox(cConexionSQL, "spObtieneCBCapacDD", cmbCapacDDHw, "ValorParam", "idParamHW");
            cmbCapacDDHw.SelectedIndex = -1;
        }

        private void CargarComboBoxGeneracionProcHW()
        {
            Rutinas.CargarDatosComboBox(cConexionSQL, "spObtieneCBGeneProcHW", cmbGeneracionProcHW, "ValorParam", "idParamHW");
            cmbGeneracionProcHW.SelectedIndex = -1;
        }

        private void CargarComboBoxMemoriaRamHW()
        {
            Rutinas.CargarDatosComboBox(cConexionSQL, "spObtieneCBCapacMemRamHW", cmbCapacMemRam, "ValorParam", "idParamHW");
            cmbCapacMemRam.SelectedIndex = -1;
        }

        private void CargarDatosComboBoxTipoIns()
        {
            Rutinas.CargarDatosComboBox(cConexionSQL, "spObtieneCBTipoInsumo", cmbTipoInsumo, "ValorParam", "idParamHW");
            cmbTipoInsumo.SelectedIndex = -1;
        }

        private void CargarComboBoxTipoPantallaHW()
        {
            Rutinas.CargarDatosComboBox(cConexionSQL, "spObtieneCBTipoMonitor", cmbTipoPantallaHW, "ValorParam", "idParamHW");
            cmbTipoPantallaHW.SelectedIndex = -1;
        }

        private void CargarComboBoxTamanoPantallaHW()
        {
            Rutinas.CargarDatosComboBox(cConexionSQL, "spObtieneCBTamanoMonitor", cmbTamPantallaHW, "ValorParam", "idParamHW");
            cmbTamPantallaHW.SelectedIndex = -1;
        }

        private void cmbEstadoActHW_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EstadoHW = cmbEstadoActHW.Text;       
        }

        private void cmbTipoHW_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
            tipoDispHW = cmbTipoHW.Text;

            if (tipoDispHW=="COMPUTADOR")
            {
                ((Control)this.tbCompuHW).Enabled = true;
                
                tcHardwareTipo.SelectedTab = tbCompuHW;
            }
            else if (tipoDispHW == "IMPRESORAS")
            {
                ((Control)this.tbImprHW).Enabled = true;
                
                tcHardwareTipo.SelectedTab = tbImprHW;
            }
            else if (tipoDispHW == "COMUNICACIONES")
            {
                ((Control)this.tbpComunHW).Enabled = true;
                
                tcHardwareTipo.SelectedTab = tbpComunHW;
            }
            else if (tipoDispHW == "MONITOR")
            {
                ((Control)this.tbpMonitorHW).Enabled = true;
                
                tcHardwareTipo.SelectedTab = tbpMonitorHW;
            }

            BloqueaTabsHardware(tipoDispHW);

        }

        private void BloqueaTabsHardware(string tipoDispHab)
        {
            if (tipoDispHab== "COMPUTADOR")
            {
                ((Control)this.tbImprHW).Enabled = false;
                ((Control)this.tbpComunHW).Enabled = false;
                ((Control)this.tbpMonitorHW).Enabled = false;                
            }

            else if (tipoDispHab== "IMPRESORA")
            {                
                ((Control)this.tbpComunHW).Enabled = false;
                ((Control)this.tbpMonitorHW).Enabled = false;
                ((Control)this.tbCompuHW).Enabled = false;
            }

            else if (tipoDispHab == "COMUNICACIONES")
            {
                ((Control)this.tbImprHW).Enabled = false;          
                ((Control)this.tbpMonitorHW).Enabled = false;
                ((Control)this.tbCompuHW).Enabled = false;
            }

            else if (tipoDispHab == "MONITOR")
            {
                ((Control)this.tbImprHW).Enabled = false;
                ((Control)this.tbpComunHW).Enabled = false;              
                ((Control)this.tbCompuHW).Enabled = false;
            }
        }

        private void cmbMarcaHW_SelectionChangeCommitted(object sender, EventArgs e)
        {
            intMarcaCB = Convert.ToString(cmbMarcaHW.SelectedValue);
            CargarComboBoxModelo();
            cmbModeloHW.Enabled = true;
        }

        private void cmbModeloHW_SelectionChangeCommitted(object sender, EventArgs e)
        {
            intModeloCB = Convert.ToString(cmbModeloHW.SelectedValue);
        }

        private void cmbTipoCompu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TipoComputador = cmbTipoCompu.Text;
        }

        private void cmbVelocProc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            VelProcesador = cmbVelocProc.Text;
        }

        private void cmbCapacDDHw_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CapacidadDD = cmbCapacDDHw.Text;
        }

        private void cmbCapacMemRam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MemoriaRam = cmbCapacMemRam.Text;
        }

        private void cmbGeneracionProcHW_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GeneracionProc = cmbGeneracionProcHW.Text;
        }

        private void cmbEstInsumo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            vchEstadoActivo = cmbEstInsumo.Text;
        }
        
        private void cmbTipoInsumo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            vchTipoInsumo = cmbTipoInsumo.Text;
        }

        private void cmbTipoLicSW_SelectionChangeCommitted(object sender, EventArgs e)
        {
            vchTipoLicenSW = cmbTipoLicSW.Text;
        }

        private void cmbEstadoSW_SelectionChangeCommitted(object sender, EventArgs e)
        {
            vchEstadoActSW = cmbEstadoSW.Text;
        }

        private void cmbAnoSW_SelectionChangeCommitted(object sender, EventArgs e)
        {
            vchAnoSW = cmbAnoSW.Text;
        }

        private void MuestraVencimiento()
        {
            if (rbVenceSi.Checked)
            {
                gbVencimientoSW.Visible = true;
            }
            else if (rbVenceNo.Checked)
            {
                gbVencimientoSW.Visible = false;
            }
        }

        private void rbVenceSi_Click(object sender, EventArgs e)
        {
            MuestraVencimiento();
        }

        private void rbVenceNo_Click(object sender, EventArgs e)
        {
            MuestraVencimiento();
        }

        private void CargarComboBoxTipoImprHW()
        {
            Rutinas.CargarDatosComboBox(cConexionSQL, "spObtieneCBTipoImprHW", cmbTipoImprHW, "ValorParam", "idParamHW");
            cmbTipoImprHW.SelectedIndex = -1;
        }

        private void CargarComboBoxVelocImprHW()
        {
            Rutinas.CargarDatosComboBox(cConexionSQL, "spObtieneCBVelocImprHW", cmbVelocImprHW, "ValorParam", "idParamHW");
            cmbVelocImprHW.SelectedIndex = -1;
        }

        private void cmbTipoImprHW_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TipoImpresora = cmbTipoImprHW.Text;
        }

        private void cmbVelocImprHW_SelectionChangeCommitted(object sender, EventArgs e)
        {
            VelocidadImpr = cmbVelocImprHW.Text;
        }

        private void cmbTipoSW_SelectionChangeCommitted(object sender, EventArgs e)
        {
            vchTipoSW = cmbTipoSW.Text;
        }

        private void cmbTipoPantallaHW_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TipoPantallaComp = cmbTipoPantallaHW.Text;
        }

        private void cmbTamPantallaHW_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TamanoPantallaComp = cmbTamPantallaHW.Text;
        }

        
    }
}
