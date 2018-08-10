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

namespace API
{
    public partial class Empresa : Form
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

        private string cConexionSQLMaestro;
        public string ConexionSQLMaestro { set { cConexionSQLMaestro = value; } }
        private Font cFuente;
        public Font Fuente { set { cFuente = value; } }

        public string idEmpresaObtener;
        //variables que se utilizan para DataGrid del form Empresa
        public int idEmpresa = 0;
        public int NombreEmpresa = 1;
        public int RazonSocial = 2;
        public int DireccionEmp = 3;
        public int CiudadEmp = 4;
        public int idSociedad = 5;



        public Empresa()
        {
            InitializeComponent();
        }


        private void EstadoInicial()
        {
            txtBoxNombreEmpresa.Text = String.Empty;
            txtBoxRazonSocial.Text = String.Empty;
            txtBoxDireccion.Text = String.Empty;
            txtBoxCiudad.Text = String.Empty;
            txtIdSociedad.Text = String.Empty;

            tsbImprimir.Visible = false;
            tsbCancelar.Visible = false;
            tsbGrabar.Enabled = false;

            BloqueoTxtBox();
        }

        private void BloqueoTxtBox()
        {
            txtBoxNombreEmpresa.Enabled = false;
            txtBoxRazonSocial.Enabled = false;
            txtBoxDireccion.Enabled = false;
            txtBoxCiudad.Enabled = false;
            txtIdSociedad.Enabled = false;
        }

        private void HabilitaTextBox()
        {
            txtBoxNombreEmpresa.Enabled = true;
            txtBoxRazonSocial.Enabled = true;
            txtBoxDireccion.Enabled = true;
            txtBoxCiudad.Enabled = true;
            txtIdSociedad.Enabled = true;
        }

        private void PrepararDataGrid(DataGridView pDataGrid)
        {
            foreach (DataGridViewColumn c in pDataGrid.Columns)
            {
                c.Resizable = DataGridViewTriState.True;
                c.ReadOnly = true;
                c.DefaultCellStyle.Font = cFuente;
            }
            pDataGrid.RowHeadersVisible = false;
            if (pDataGrid.Name == "dgEmpresa")
            {
                dgEmpresa.Columns[idEmpresa].Width = 30; pDataGrid.Columns[idEmpresa].HeaderText = "idEmpresa";
                dgEmpresa.Columns[NombreEmpresa].Width = 225; pDataGrid.Columns[NombreEmpresa].HeaderText = "Nombre";
                dgEmpresa.Columns[RazonSocial].Width = 225; pDataGrid.Columns[RazonSocial].HeaderText = "Razón Social";
                dgEmpresa.Columns[DireccionEmp].Width = 74; pDataGrid.Columns[DireccionEmp].HeaderText = "Dirección";
                dgEmpresa.Columns[CiudadEmp].Width = 74; pDataGrid.Columns[CiudadEmp].HeaderText = "Ciudad";
                dgEmpresa.Columns[idSociedad].Width = 74; pDataGrid.Columns[idSociedad].HeaderText = "Sociedad";
            }
        }

        private void ExtraeEmpresas()
        {
            string aux = "EXEC spObtieneEmpresas";
            SqlConnection SqlCon = new SqlConnection(cConexionSQL);
            SqlDataAdapter SqlDa = new SqlDataAdapter(aux, SqlCon);
            DataSet ds = new DataSet("Consulta");
            SqlDa.Fill(ds, "Consulta");
            dgEmpresa.DataSource = ds.Tables["Consulta"];
            PrepararDataGrid(dgEmpresa);
            dgEmpresa.Refresh();
            if (dgEmpresa.RowCount > 0) { dgEmpresa.Rows[0].Selected = false; }
            dgEmpresa.ClearSelection();
        }

        private void InsertNuevaEmpresa()
        {
            char InsertChar = 'I';
            int idSociedad = 0;
            int idEmpresa = 1;
            string auxRespuesta = "";

            SqlConnection Con = new SqlConnection(cConexionSQL);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spInsertUpdateEmpresa", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@accion", SqlDbType.VarChar, 1);
            auxParametro = cmd.Parameters.Add("@NombreEmp", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@RazonSocial", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@Direccion", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@Ciudad", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@idSociedad", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@idEmpresa", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@msgError", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@accion"].Value = InsertChar;
            cmd.Parameters["@NombreEmp"].Value = txtBoxNombreEmpresa.Text.Trim();
            cmd.Parameters["@RazonSocial"].Value = txtBoxRazonSocial.Text.Trim();
            cmd.Parameters["@Direccion"].Value = txtBoxDireccion.Text.Trim();
            cmd.Parameters["@Ciudad"].Value = txtBoxCiudad.Text.Trim();
            cmd.Parameters["@idSociedad"].Value = txtIdSociedad.Text.Trim();
            cmd.Parameters["@idEmpresa"].Value = idEmpresa;

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
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "bueno", "Operación Correcta.", "", false, false);
                EstadoInicial();
                ExtraeEmpresas();
            }


        }

        private void actualizaEmpresa()
        {
            char ActualizaChar = 'U';
            int idEmpresa = 1;
            SqlConnection Con = new SqlConnection(cConexionSQL);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spInsertUpdateEmpresa", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@accion", SqlDbType.VarChar, 1);
            auxParametro = cmd.Parameters.Add("@NombreEmp", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@RazonSocial", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@Direccion", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@Ciudad", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@idSociedad", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@idEmpresa", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@msgError", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@accion"].Value = ActualizaChar;
            cmd.Parameters["@NombreEmp"].Value = txtBoxNombreEmpresa.Text.Trim();
            cmd.Parameters["@RazonSocial"].Value = txtBoxRazonSocial.Text.Trim();
            cmd.Parameters["@Direccion"].Value = txtBoxDireccion.Text.Trim();
            cmd.Parameters["@Ciudad"].Value = txtBoxCiudad.Text.Trim();
            cmd.Parameters["@idSociedad"].Value = txtIdSociedad.Text.Trim();
            cmd.Parameters["@idEmpresa"].Value = idEmpresa;

        }


        private void Empresa_Load(object sender, EventArgs e)
        {
            EstadoInicial();
            ExtraeEmpresas();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void tsEmpresa_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

     
        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            HabilitaTextBox();
            tsbCancelar.Visible = true;
            tsbGrabar.Enabled = true;
        }


        private void tsbImprimir_Click(object sender, EventArgs e)
        {

        }

        private void tsbGrabar_Click(object sender, EventArgs e)
        {
            InsertNuevaEmpresa();
            EstadoInicial();
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void dgEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            int auxfila = e.RowIndex;

            txtIdEmpresa.Text = dgEmpresa.Rows[auxfila].Cells[idEmpresa].Value.ToString();
            txtBoxNombreEmpresa.Text = dgEmpresa.Rows[auxfila].Cells[NombreEmpresa].Value.ToString();
            txtBoxRazonSocial.Text = dgEmpresa.Rows[auxfila].Cells[RazonSocial].Value.ToString();
            txtBoxDireccion.Text = dgEmpresa.Rows[auxfila].Cells[DireccionEmp].Value.ToString();
            txtBoxCiudad.Text = dgEmpresa.Rows[auxfila].Cells[CiudadEmp].Value.ToString();
            txtIdSociedad.Text = dgEmpresa.Rows[auxfila].Cells[idSociedad].Value.ToString();
        }

        private void dgEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            int auxfila = e.RowIndex;
            txtBoxNombreEmpresa.Text = dgEmpresa.Rows[auxfila].Cells[NombreEmpresa].Value.ToString();
            txtBoxRazonSocial.Text = dgEmpresa.Rows[auxfila].Cells[RazonSocial].Value.ToString();
            txtBoxDireccion.Text = dgEmpresa.Rows[auxfila].Cells[DireccionEmp].Value.ToString();
            txtBoxCiudad.Text = dgEmpresa.Rows[auxfila].Cells[CiudadEmp].Value.ToString();
            txtIdSociedad.Text = dgEmpresa.Rows[auxfila].Cells[idSociedad].Value.ToString();
        }

        private void tsEditar_Click(object sender, EventArgs e)
        {
            HabilitaTextBox();
            tsbCancelar.Visible = true;
            tsbNuevo.Enabled = false;
            tsbGrabar.Enabled = true;
        }
    }
}
