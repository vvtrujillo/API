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

namespace API.Formularios.Maestros
{
    public partial class fArea : Form
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

        private Font cFuente;
        public Font Fuente { set { cFuente = value; } }


        //declarar variables para grilla área
        private int idArea = 0;
        private int idPlanta = 1;
        private int NombreArea = 2;
        private int ResponsableArea = 3;
        private int TelefonoArea = 4;
        private int EmailArea = 5;

        private string auxIdEmpresa;
        private string auxIDPlanta;

        private bool vaciosTextBox;
        private bool vaciosComboBox;

        //Vamos a traer las empresas
                
        private void ObtieneAreas()
        {
            string aux = "EXEC spObtieneAreaPlantas";
            SqlConnection SqlCon = new SqlConnection(cConexionSQL);
            SqlDataAdapter SqlDa = new SqlDataAdapter(aux, SqlCon);
            DataSet ds = new DataSet("Consulta");
            SqlDa.Fill(ds, "Consulta");
            dgArea.DataSource = ds.Tables["Consulta"];
            PrepararDataGrid(dgArea);
            dgArea.Refresh();
            if (dgArea.RowCount > 0) { dgArea.Rows[0].Selected = false; }
            dgArea.ClearSelection();
        }

        private void InsertNewArea()
        {
            char auxTipoAccion = 'I';
            int auxIntIdArea = 0;
            string auxRespuesta = "";

            SqlConnection Con = new SqlConnection(cConexionSQL);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spInsertUpdateArea", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@accion", SqlDbType.VarChar, 1);
            auxParametro = cmd.Parameters.Add("@idPlanta", SqlDbType.VarChar, 2);
            auxParametro = cmd.Parameters.Add("@NombreArea", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@RespArea", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@telefonoArea", SqlDbType.VarChar, 50);
            auxParametro = cmd.Parameters.Add("@emailArea", SqlDbType.VarChar, 50);
            auxParametro = cmd.Parameters.Add("@idArea", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@msgError", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@accion"].Value = auxTipoAccion;
            cmd.Parameters["@idPlanta"].Value = auxIDPlanta;
            cmd.Parameters["@NombreArea"].Value = txtNombreArea.Text.Trim();
            cmd.Parameters["@RespArea"].Value = txtRespArea.Text.Trim();            
            cmd.Parameters["@telefonoArea"].Value = txtTelefonoArea.Text.Trim();
            cmd.Parameters["@emailArea"].Value = txtEmailArea.Text.Trim();
            cmd.Parameters["@idArea"].Value = auxIntIdArea;

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
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "bueno", "Operación Correcta.", "Se realizó la inserción.", false, false);
                EstadoInicial();       
            }

        }

        private void EstadoInicial()
        {
            cmbEmpresa.SelectedIndex = -1;
            cmbPlanta.SelectedIndex = -1;
            cmbPlanta.Enabled = false;
            txtNombreArea.Text = String.Empty;
            txtNombreArea.Enabled = false;
            txtRespArea.Text = String.Empty;
            txtRespArea.Enabled = false;
            txtEmailArea.Text = String.Empty;
            txtEmailArea.Enabled = false;
            txtTelefonoArea.Text = String.Empty;
            txtTelefonoArea.Enabled = false;

            cmbEmpresa.Enabled = false;
            tsbGrabar.Visible = false;
            tsbCancelar.Visible = false;
        }

        private void HabilitaTextBoxArea()
        {
            txtNombreArea.Enabled = true;
            txtRespArea.Enabled = true;
            txtTelefonoArea.Enabled = true;
            txtEmailArea.Enabled = true;
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
            if (pDataGrid.Name == "dgArea")
            {
                dgArea.Columns[idArea].Visible = false; pDataGrid.Columns[idArea].HeaderText = "idArea";
                dgArea.Columns[idPlanta].Visible=false; pDataGrid.Columns[idPlanta].HeaderText = "idPlanta";
                dgArea.Columns[NombreArea].Width = 200; pDataGrid.Columns[NombreArea].HeaderText = "Nombre Área";
                dgArea.Columns[ResponsableArea].Width = 200; pDataGrid.Columns[ResponsableArea].HeaderText = "Responsable";
                dgArea.Columns[TelefonoArea].Width = 70; pDataGrid.Columns[TelefonoArea].HeaderText = "Teléfono";
                dgArea.Columns[EmailArea].Width = 200; pDataGrid.Columns[EmailArea].HeaderText = "Email";                
            }
        }

        private void CargarComboboxEmpresa()
        {
            Rutinas.CargarDatosComboBox(cConexionSQLMaestro, "pa_ObtenerEmpresas", cmbEmpresa, "Nombre", "IDEmpresa");
            cmbEmpresa.SelectedIndex = -1;            
        }

        private void cargarComboBoxPlanta()
        {
            string cadenaSPObtienePlanta= "pa_ObtenerEmpresaPlantas "+ auxIdEmpresa;
           
            Rutinas.CargarDatosComboBox(cConexionSQL, cadenaSPObtienePlanta, cmbPlanta, "Descripcion", "IDPlanta");
            cmbPlanta.SelectedIndex = -1;
        }       

        private void fArea_Load(object sender, EventArgs e)
        {
            EstadoInicial();
            CargarComboboxEmpresa();
            ObtieneAreas();
        }

        public fArea()
        {
            InitializeComponent();
        }

        private void tsMarca_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void tslArea_Click(object sender, EventArgs e)
        {

        }

        private void tslArea_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void cmbEmpresa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            auxIdEmpresa = Convert.ToString(cmbEmpresa.SelectedValue);
            cmbPlanta.Enabled = true;
            cargarComboBoxPlanta();         
        }

        private void tsbGrabar_Click(object sender, EventArgs e)
        {
            revisaTextBoxVacios();
            revisaComboBoxVacios();

            if(vaciosTextBox==true||vaciosComboBox==true)
            {
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "malo", "Faltan datos", "De ingresar al menos Nombre de área.", false, false);
            }
            else
            {
                InsertNewArea();
            }            
        }

        private void cmbPlanta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            auxIDPlanta = Convert.ToString(cmbPlanta.SelectedValue);
            HabilitaTextBoxArea();
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            cmbEmpresa.Enabled = true;
            tsbGrabar.Visible = true;
            tsbCancelar.Visible = true;
        }

        private void revisaTextBoxVacios()
        {
            if(String.IsNullOrEmpty(txtNombreArea.Text))
            {
                vaciosTextBox = true;            
            }
            else
            {
                vaciosTextBox = false;
            }
        }

        private void revisaComboBoxVacios()
        {
            if (String.IsNullOrEmpty(cmbEmpresa.Text) || String.IsNullOrEmpty(cmbPlanta.Text))
            {
                vaciosComboBox = true;
            }
            else
            {
                vaciosComboBox = false;
            }                
        }
    }
}
