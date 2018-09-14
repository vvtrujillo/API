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

namespace API.Formularios.Busquedas
{
    public partial class fListadoHardware : Form
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

        private System.Drawing.Font cFuente;
        public System.Drawing.Font Fuente { set { cFuente = value; } }

        private int NombreHW = 0;
        private int CapacidadDDComp = 1;
        private int VelProcesadorComp = 2;
        private int MemoriaRamComp = 3;
        private int TamanoPantalla = 4;

        private int NombreHWMon = 0;
        private int TamanoMonitorHW = 1;
        private int TipoMonitorHW = 2;

        private int NombreHWComun = 0;
        private int TipoComunicacionesHW = 1;
        private int CantidadBocas = 2;

        private int NombreHWImpr = 0;
        private int TipoImpresoraHW = 1;
        private int VelocidadImpr = 2;


        public fListadoHardware()
        {
            InitializeComponent();
        }

        private void fListadoHardware_Load(object sender, EventArgs e)
        {
            ObtieneListadoComputador();
            ObtieneListadoMonitor();
            ObtieneListadoImpresoras();
            ObtieneListadoCOmunicaciones();
        }

        private void ObtieneListadoComputador()
        {
            string aux = "EXEC spObtieneListaHardwareComputador";
            SqlConnection SqlCon = new SqlConnection(cConexionSQL);
            SqlDataAdapter SqlDa = new SqlDataAdapter(aux, SqlCon);
            DataSet ds = new DataSet("Consulta");
            SqlDa.Fill(ds, "Consulta");
            dgListadoComputadores.DataSource = ds.Tables["Consulta"];
            PrapararDataGridComputadores(dgListadoComputadores);
            dgListadoComputadores.Refresh();
            if (dgListadoComputadores.RowCount > 0) { dgListadoComputadores.Rows[0].Selected = false; }
            dgListadoComputadores.ClearSelection();
        }

        private void PrapararDataGridComputadores(DataGridView pDataGrid)
        {
            foreach (DataGridViewColumn c in pDataGrid.Columns)
            {
                c.Resizable = DataGridViewTriState.True;
                c.ReadOnly = true;
                c.DefaultCellStyle.Font = cFuente;

            }
            pDataGrid.RowHeadersVisible = false;
            if (pDataGrid.Name == "dgListadoComputadores")
            {
                dgListadoComputadores.Columns[NombreHW].Width = 200; pDataGrid.Columns[NombreHW].HeaderText = "Nombre";
                dgListadoComputadores.Columns[CapacidadDDComp].Width = 75; pDataGrid.Columns[CapacidadDDComp].HeaderText = "Capacidad DD";
                dgListadoComputadores.Columns[VelProcesadorComp].Width = 100; pDataGrid.Columns[VelProcesadorComp].HeaderText = "Velocidad Procesador";
                dgListadoComputadores.Columns[MemoriaRamComp].Width = 100; pDataGrid.Columns[MemoriaRamComp].HeaderText = "Memoria Ram";
                dgListadoComputadores.Columns[TamanoPantalla].Width = 100; pDataGrid.Columns[TamanoPantalla].HeaderText = "Tamaño Pantalla";
                dgListadoComputadores.Columns[TamanoPantalla].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void ObtieneListadoMonitor()
        {
            string aux = "EXEC spObtieneListaHardwareMonitor";
            SqlConnection SqlCon = new SqlConnection(cConexionSQL);
            SqlDataAdapter SqlDa = new SqlDataAdapter(aux, SqlCon);
            DataSet ds = new DataSet("Consulta");
            SqlDa.Fill(ds, "Consulta");
            dgListadoMonitores.DataSource = ds.Tables["Consulta"];
            PreparaDataGridMonitor(dgListadoMonitores);
            dgListadoMonitores.Refresh();
            if (dgListadoMonitores.RowCount > 0) { dgListadoMonitores.Rows[0].Selected = false; }
            dgListadoMonitores.ClearSelection();
        }

        private void PreparaDataGridMonitor(DataGridView pDataGrid)
        {
            foreach (DataGridViewColumn c in pDataGrid.Columns)
            {
                c.Resizable = DataGridViewTriState.True;
                c.ReadOnly = true;
                c.DefaultCellStyle.Font = cFuente;

            }
            pDataGrid.RowHeadersVisible = false;
            if (pDataGrid.Name == "dgListadoMonitores")
            {
                dgListadoMonitores.Columns[NombreHWMon].Width = 200; pDataGrid.Columns[NombreHWMon].HeaderText = "Nombre";
                dgListadoMonitores.Columns[TamanoMonitorHW].Width = 75; pDataGrid.Columns[TamanoMonitorHW].HeaderText = "Tamaño";
                dgListadoMonitores.Columns[TipoMonitorHW].Width = 100; pDataGrid.Columns[TipoMonitorHW].HeaderText = "Velocidad Procesador";
                dgListadoMonitores.Columns[TipoMonitorHW].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void tsbCerrarListadoHardware_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ObtieneListadoImpresoras()
        {
            string aux = "EXEC spObtieneListaHardwareImpresora";
            SqlConnection SqlCon = new SqlConnection(cConexionSQL);
            SqlDataAdapter SqlDa = new SqlDataAdapter(aux, SqlCon);
            DataSet ds = new DataSet("Consulta");
            SqlDa.Fill(ds, "Consulta");
            dgListadoImpresoras.DataSource = ds.Tables["Consulta"];
            PreparaDataGridImpresoras(dgListadoImpresoras);
            dgListadoImpresoras.Refresh();
            if (dgListadoImpresoras.RowCount > 0) { dgListadoImpresoras.Rows[0].Selected = false; }
            dgListadoImpresoras.ClearSelection();
        }

        private void PreparaDataGridImpresoras(DataGridView pDataGrid)
        {
            foreach (DataGridViewColumn c in pDataGrid.Columns)
            {
                c.Resizable = DataGridViewTriState.True;
                c.ReadOnly = true;
                c.DefaultCellStyle.Font = cFuente;

            }
            pDataGrid.RowHeadersVisible = false;
            if (pDataGrid.Name == "dgListadoImpresoras")
            {
                dgListadoImpresoras.Columns[NombreHWImpr].Width = 200; pDataGrid.Columns[NombreHWImpr].HeaderText = "Nombre";
                dgListadoImpresoras.Columns[TipoImpresoraHW].Width = 75; pDataGrid.Columns[TipoImpresoraHW].HeaderText = "Tipo";
                dgListadoImpresoras.Columns[VelocidadImpr].Width = 100; pDataGrid.Columns[VelocidadImpr].HeaderText = "Velocidad Impresión";
                dgListadoImpresoras.Columns[VelocidadImpr].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void ObtieneListadoCOmunicaciones()
        {
            string aux = "EXEC spObtieneListadoHardwareComun";
            SqlConnection SqlCon = new SqlConnection(cConexionSQL);
            SqlDataAdapter SqlDa = new SqlDataAdapter(aux, SqlCon);
            DataSet ds = new DataSet("Consulta");
            SqlDa.Fill(ds, "Consulta");
            dgListadoComunicaciones.DataSource = ds.Tables["Consulta"];
            PrepararDataGridComunicaciones(dgListadoComunicaciones);
            dgListadoComunicaciones.Refresh();
            if (dgListadoComunicaciones.RowCount > 0) { dgListadoComunicaciones.Rows[0].Selected = false; }
            dgListadoComunicaciones.ClearSelection();
        }

        private void PrepararDataGridComunicaciones(DataGridView pDataGrid)
        {
            foreach (DataGridViewColumn c in pDataGrid.Columns)
            {
                c.Resizable = DataGridViewTriState.True;
                c.ReadOnly = true;
                c.DefaultCellStyle.Font = cFuente;

            }
            pDataGrid.RowHeadersVisible = false;
            if (pDataGrid.Name == "dgListadoComunicaciones")
            {
                dgListadoComunicaciones.Columns[NombreHWComun].Width = 200; pDataGrid.Columns[NombreHWComun].HeaderText = "Nombre";
                dgListadoComunicaciones.Columns[TipoComunicacionesHW].Width = 75; pDataGrid.Columns[TipoComunicacionesHW].HeaderText = "Tipo";
                dgListadoComunicaciones.Columns[CantidadBocas].Width = 100; pDataGrid.Columns[CantidadBocas].HeaderText = "Cantidad Bocas";
                dgListadoComunicaciones.Columns[VelocidadImpr].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void tsListadoHardwareFull_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
