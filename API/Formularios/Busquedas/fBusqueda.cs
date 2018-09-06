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

namespace API.Formularios.Busquedas
{
    public partial class fBusqueda : Form
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

        //variables grilla dgListaSoftwareDisp
        private int NoLicencia = 0;
        private int TipoLicencia = 1;
        private int NombreSW = 2;
        private int DescripcionSW = 3;
        private int CantDisponible = 4;

        public fBusqueda()
        {
            InitializeComponent();
        }

        private void EstadoInicial()
        {
            txtCodLicenciaBusq.Text = String.Empty;
            dgListaSoftwareDisp.Rows.Clear();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            string auxRespuesta = "";

            SqlConnection Con = new SqlConnection(cConexionSQL);           
            SqlCommand cmd = new SqlCommand("spObtieneListadoSWDisponible", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@vchNoLicencia", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@vchMsgeSalida", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@vchNoLicencia"].Value = txtCodLicenciaBusq.Text.Trim();

            Con.Open();

            try
            {
                cmd.ExecuteNonQuery();
                if (cmd.Parameters["@vchMsgeSalida"].Value.ToString() != "")
                {
                    auxRespuesta = cmd.Parameters["@vchMsgeSalida"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                auxRespuesta = "No se pudo mostrar." + ex.ToString();
            }            

            if (auxRespuesta == "")
            {
                SqlDataReader drBuscar;
                drBuscar = cmd.ExecuteReader();
                dgListaSoftwareDisp.Rows.Clear();

                if (drBuscar.HasRows)
                {

                    drBuscar.Read();
                    do
                    {

                        dgListaSoftwareDisp.Rows.Add(1);
                        dgListaSoftwareDisp.Rows[dgListaSoftwareDisp.Rows.Count - 1].Cells[NoLicencia].Value = drBuscar.GetString(drBuscar.GetOrdinal("NoLicencia"));
                        dgListaSoftwareDisp.Rows[dgListaSoftwareDisp.Rows.Count - 1].Cells[TipoLicencia].Value = drBuscar.GetString(drBuscar.GetOrdinal("TipoLicencia"));
                        dgListaSoftwareDisp.Rows[dgListaSoftwareDisp.Rows.Count - 1].Cells[NombreSW].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreSW"));
                        dgListaSoftwareDisp.Rows[dgListaSoftwareDisp.Rows.Count - 1].Cells[DescripcionSW].Value = drBuscar.GetString(drBuscar.GetOrdinal("DescripcionSW"));
                        dgListaSoftwareDisp.Rows[dgListaSoftwareDisp.Rows.Count - 1].Cells[CantDisponible].Value = drBuscar.GetInt32(drBuscar.GetOrdinal("CantDisponible"));
                        dgListaSoftwareDisp.Columns[CantDisponible].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    while (drBuscar.Read());
                }

                PrepararDataGridSoftwareList(dgListaSoftwareDisp);
            }
            else
            {
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "malo", "Error en la Operación.", auxRespuesta, false, false);
            }

            cmd.Connection.Close(); cmd.Connection.Dispose();
            Con.Close(); Con.Dispose();

        }

        private void PrepararDataGridSoftwareList(DataGridView pDataGrid)
        {
            pDataGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            pDataGrid.RowHeadersVisible = false;
            pDataGrid.ReadOnly = false;

            
            pDataGrid.RowHeadersVisible = false;

            if (pDataGrid.Name == "dgListaSoftwareDisp")
            {
                dgListaSoftwareDisp.Columns[NoLicencia].Width = 250; pDataGrid.Columns[NoLicencia].HeaderText = "Licencia";
                dgListaSoftwareDisp.Columns[TipoLicencia].Width = 50; pDataGrid.Columns[TipoLicencia].HeaderText = "Tipo";
                dgListaSoftwareDisp.Columns[NombreSW].Width = 150; pDataGrid.Columns[NombreSW].HeaderText = "Nombre";
                dgListaSoftwareDisp.Columns[DescripcionSW].Width = 200; pDataGrid.Columns[DescripcionSW].HeaderText = "Descripción";
                dgListaSoftwareDisp.Columns[CantDisponible].Width = 50; pDataGrid.Columns[CantDisponible].HeaderText = "Cantidad Disponible";
                dgListaSoftwareDisp.Columns[CantDisponible].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
        }

        private void tsbCerrarBusqSwDisp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fBusqueda_Load(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void tsBusqSwDisp_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void tsLimpiarListSwDisp_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }
    }
}
