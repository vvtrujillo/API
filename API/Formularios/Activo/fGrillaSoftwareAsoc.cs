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

namespace API.Formularios.Activo
{
    public partial class fGrillaSoftwareAsoc : Form
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

        private string cConexionSQLMaestro;
        public string ConexionSQLMaestro { set { cConexionSQLMaestro = value; } }
        private string cConexionSQL;

        public string ConexionSQL { set { cConexionSQL = value; } }
        private System.Drawing.Font cFuente;
        public System.Drawing.Font Fuente { set { cFuente = value; } }

        public int intIdHardwareGrillaSw;         

        private int chkSel = 0;
        private int NombreProducto = 1;
        private int Cantidad = 2;
        private int NoLicencia = 3;
        private int TipoLicencia = 4;
        private int DescripcionSW = 5;
        private int Disponibles = 6;
        private int idActivoSel = 7;

        public fGrillaSoftwareAsoc()
        {
            InitializeComponent();
        }

        private void ObtieneListadoSoftwareDisponible()
        {
            SqlConnection SqlCon = new SqlConnection(cConexionCentral);
            SqlCommand cmd = new SqlCommand("spObtieneListaSWDispGrilla", SqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;


            SqlCon.Open();

            SqlDataReader drBuscar;
            drBuscar = cmd.ExecuteReader();
            dgListaSoftwareDisp.Rows.Clear();

            if (drBuscar.HasRows)
            {

                drBuscar.Read();
                do
                {
                    dgListaSoftwareDisp.Rows.Add(1);
                    dgListaSoftwareDisp.Rows[dgListaSoftwareDisp.Rows.Count - 1].Cells[chkSel].Value = false;
                    dgListaSoftwareDisp.Rows[dgListaSoftwareDisp.Rows.Count - 1].Cells[NombreProducto].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreProducto"));
                    dgListaSoftwareDisp.Rows[dgListaSoftwareDisp.Rows.Count - 1].Cells[Cantidad].Value = drBuscar.GetInt32(drBuscar.GetOrdinal("Cantidad"));
                    dgListaSoftwareDisp.Rows[dgListaSoftwareDisp.Rows.Count - 1].Cells[NoLicencia].Value = drBuscar.GetString(drBuscar.GetOrdinal("NoLicencia"));
                    dgListaSoftwareDisp.Rows[dgListaSoftwareDisp.Rows.Count - 1].Cells[TipoLicencia].Value = drBuscar.GetString(drBuscar.GetOrdinal("TipoLicencia"));
                    dgListaSoftwareDisp.Rows[dgListaSoftwareDisp.Rows.Count - 1].Cells[DescripcionSW].Value = drBuscar.GetString(drBuscar.GetOrdinal("DescripcionSW"));
                    dgListaSoftwareDisp.Rows[dgListaSoftwareDisp.Rows.Count - 1].Cells[Disponibles].Value = drBuscar.GetInt32(drBuscar.GetOrdinal("Disponibles"));
                    dgListaSoftwareDisp.Rows[dgListaSoftwareDisp.Rows.Count - 1].Cells[idActivoSel].Value = drBuscar.GetInt32(drBuscar.GetOrdinal("idActivo"));
                    dgListaSoftwareDisp.Columns[Disponibles].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
                while (drBuscar.Read());
            }

            PrepararDataGridListaDisponibles(dgListaSoftwareDisp);

            drBuscar.Close(); drBuscar.Dispose();
            cmd.Connection.Close(); cmd.Connection.Dispose();
            SqlCon.Close(); SqlCon.Dispose();
        }

        private void fGrillaSoftwareAsoc_Load(object sender, EventArgs e)
        {
            ObtieneListadoSoftwareDisponible();
        }

        private void PrepararDataGridListaDisponibles(DataGridView pDataGrid)
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
            if (pDataGrid.Name == "dgListaSoftwareDisp")
            {
                dgListaSoftwareDisp.Columns[chkSel].Width = 30; pDataGrid.Columns[chkSel].HeaderText = "Sel";
                dgListaSoftwareDisp.Columns[NombreProducto].Width = 180; pDataGrid.Columns[NombreProducto].HeaderText = "Nombre";
                dgListaSoftwareDisp.Columns[Cantidad].Width = 70; pDataGrid.Columns[Cantidad].HeaderText = "Cantidad";
                dgListaSoftwareDisp.Columns[NoLicencia].Width = 280; pDataGrid.Columns[NoLicencia].HeaderText = "No Licencia";
                dgListaSoftwareDisp.Columns[TipoLicencia].Width = 70; pDataGrid.Columns[TipoLicencia].HeaderText = "Tipo Licencia";
                dgListaSoftwareDisp.Columns[DescripcionSW].Width = 300; pDataGrid.Columns[DescripcionSW].HeaderText = "Descripción";
                dgListaSoftwareDisp.Columns[Disponibles].Width = 70; pDataGrid.Columns[Disponibles].HeaderText = "Disponibles";
                dgListaSoftwareDisp.Columns[idActivoSel].Visible = false; pDataGrid.Columns[idActivoSel].HeaderText = "idActivo";                

            }
        }

        private void VerificarSoftwareSeleccionado(DataGridView pDataGrid, int pFila, int pColumna)
        {
            if (pFila < 0 || pColumna != 0) { return; } //columna distinta de cero

            foreach (DataGridViewRow row in pDataGrid.Rows)
            {
                if (pFila != row.Index)
                {
                    DataGridViewCheckBoxCell chbDesocupados = (DataGridViewCheckBoxCell)row.Cells[chkSel]; //columna donde se hace la selección
                    if ((bool)chbDesocupados.Value == true)
                    {
                        chbDesocupados.Value = false;
                    }
                }
            }

            //AgregoSoftware = true;
        }

        private void dgListaSoftwareDisp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgListaSoftwareDisp.EndEdit();
            //VerificarSoftwareSeleccionado(dgListaSoftwareDisp, e.RowIndex, e.ColumnIndex);
        }

        private void txtFiltroNombreSw_TextChanged(object sender, EventArgs e)
        {
            (dgListaSoftwareDisp.DataSource as DataTable).DefaultView.RowFilter = string.Format("a.NombreProducto LIKE '{0}%' OR a.NombreProducto LIKE '% {0}%'", txtFiltroNombreSw.Text);
        }

        private void tsAsociaSwGrilla_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void tsbCerrarAsoSwGrilla_Click(object sender, EventArgs e)
        {
            Program.cierraFormularioGrillaSw = true;
            this.Close();
        }

        private void tsbGrabarAsocSwGrilla_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgListaSoftwareDisp.Rows)
            {
                if (Convert.ToBoolean(row.Cells[chkSel].Value))
                {
                    int intActivoSeleccionadoSW = Convert.ToInt32(dgListaSoftwareDisp.Rows[row.Index].Cells[idActivoSel].Value);
                   // MessageBox.Show("el valor Activo " + Convert.ToString(intActivoSeleccionadoSW));

                    InsertaAsociacionSoftwareaHW(intActivoSeleccionadoSW);                    
                }
            }

            this.Close();
        }

        private void InsertaAsociacionSoftwareaHW(int idActivoSeleccionado)
        {
            string auxRespuesta = "";

            SqlConnection Con = new SqlConnection(cConexionCentral);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spInsertNewAsocSwaHw", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@intIdActivoAsoc", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@intIdHardwareAsoc", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@msgError", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@intIdActivoAsoc"].Value = idActivoSeleccionado;
            cmd.Parameters["@intIdHardwareAsoc"].Value = intIdHardwareGrillaSw;

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
               
                Program.InsertaSoftwareGrillaSW = true;                
            }
            else
            {
                
                Program.InsertaSoftwareGrillaSW = false;               
            }
        }
    }
}
