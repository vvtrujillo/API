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
    public partial class fUsuario : Form
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
        private int idUsuario = 0;
       // private int idArea = 1;
        private int Nombre = 1;
        private int Apellido = 2;
        private int NombreUsuario = 3;
        private int CargoUsuario = 4;
        private int EmailUsuario = 5;
        private int TelefonoUsuario = 6;
        

        private string auxIdEmpresa;
        private string auxIdPlantaArea;
        private string auxIdPlanta;
        private string auxIdArea;

        private bool vaciosTextBox;
        private bool vaciosComboBox;
        private bool auxActualizar;

        private int intIdUsuarioUpdate;

        public fUsuario()
        {
            InitializeComponent();
        }

        private void EstadoInicial()
        {
            ObtieneListaUsuarios();
            CargarComboboxEmpresa();

            cmbEmpresa.Enabled = false;
            cmbPlanta.Enabled = false;
            cmbArea.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtNombreUser.Enabled = false;
            txtEmail.Enabled = false;
            txtTelefono.Enabled = false;
            txtCargo.Enabled = false;

            txtApellido.Text = String.Empty;
            txtCargo.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtIdUsuario.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtNombreUser.Text = String.Empty;
            txtTelefono.Text = String.Empty;

            cmbArea.SelectedIndex = -1;
            cmbEmpresa.SelectedIndex = -1;
            cmbPlanta.SelectedIndex = -1;

            tsbCancelarUsu.Visible = false;
            tsbGrabarUsu.Visible = false;
            tsbNuevoUsu.Visible = true;
            tsEditarUsu.Visible = true;

            vaciosComboBox = false;
            vaciosTextBox = false;

            dgListaUsuarios.Enabled = false;
            auxActualizar = false;

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
            if (pDataGrid.Name == "dgListaUsuarios")
            {
                dgListaUsuarios.Columns[idUsuario].Visible = false; pDataGrid.Columns[idUsuario].HeaderText = "idUsuario";
                dgListaUsuarios.Columns[Nombre].Width = 100; pDataGrid.Columns[Nombre].HeaderText = "Nombre";
                dgListaUsuarios.Columns[Apellido].Width = 100; pDataGrid.Columns[Apellido].HeaderText = "Apellido";
                dgListaUsuarios.Columns[NombreUsuario].Width = 100; pDataGrid.Columns[NombreUsuario].HeaderText = "Usuario";
                dgListaUsuarios.Columns[CargoUsuario].Width = 100; pDataGrid.Columns[CargoUsuario].HeaderText = "Cargo";
                dgListaUsuarios.Columns[EmailUsuario].Width = 230; pDataGrid.Columns[EmailUsuario].HeaderText = "Email";
                dgListaUsuarios.Columns[TelefonoUsuario].Width = 100; pDataGrid.Columns[TelefonoUsuario].HeaderText = "Telefono";
            }
        }

        private void ObtieneListaUsuarios()
        {
            string aux = "EXEC spObtieneListaUsuarios";
            SqlConnection SqlCon = new SqlConnection(cConexionSQL);
            SqlDataAdapter SqlDa = new SqlDataAdapter(aux, SqlCon);
            DataSet ds = new DataSet("Consulta");
            SqlDa.Fill(ds, "Consulta");
            dgListaUsuarios.DataSource = ds.Tables["Consulta"];
            PrepararDataGrid(dgListaUsuarios);
            dgListaUsuarios.Refresh();
            if (dgListaUsuarios.RowCount > 0) { dgListaUsuarios.Rows[0].Selected = false; }
            dgListaUsuarios.ClearSelection();
        }

        private void CargarComboboxEmpresa()
        {
            Rutinas.CargarDatosComboBox(cConexionSQLMaestro, "pa_ObtenerEmpresas", cmbEmpresa, "Nombre", "IDEmpresa");
            cmbEmpresa.SelectedIndex = -1;
        }

        private void cargarComboBoxPlanta()
        {
            string cadenaSPObtienePlanta = "pa_ObtenerEmpresaPlantas " + auxIdEmpresa;

            Rutinas.CargarDatosComboBox(cConexionSQLMaestro, cadenaSPObtienePlanta, cmbPlanta, "Descripcion", "IDPlanta");
            cmbPlanta.SelectedIndex = -1;
        }

        private void cargarComboBoxArea()
        {
            string cadenaObtieneArea = "spObtieneComboBoxArea " + auxIdPlanta;

            Rutinas.CargarDatosComboBox(cConexionSQL, cadenaObtieneArea, cmbArea, "NombreArea", "idArea");
            cmbArea.SelectedIndex = -1;
        }

        private void fUsuario_Load(object sender, EventArgs e)
        {
            EstadoInicial();                        
        }

        private void cmbEmpresa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            auxIdEmpresa = Convert.ToString(cmbEmpresa.SelectedValue);
            cmbPlanta.Enabled = true;
            cargarComboBoxPlanta();
        }

        private void cmbPlanta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            auxIdPlanta = Convert.ToString(cmbPlanta.SelectedValue);
            cmbArea.Enabled = true;
            cargarComboBoxArea();
        }

        private void InsertNewUsuario()
        {
            char auxtipoAccion = 'I';
            string auxRespuesta="";
            int auxidUsuarioInsert = 0;

            SqlConnection Con = new SqlConnection(cConexionSQL);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spInsertUpdateUsuario", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@accion", SqlDbType.VarChar, 1);
            auxParametro = cmd.Parameters.Add("@idArea", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@NombreUsuario", SqlDbType.VarChar, 50);
            auxParametro = cmd.Parameters.Add("@ApellidoUsuario", SqlDbType.VarChar, 50);
            auxParametro = cmd.Parameters.Add("@NombreUser", SqlDbType.VarChar, 50);
            auxParametro = cmd.Parameters.Add("@CargoUsuario", SqlDbType.VarChar, 50);
            auxParametro = cmd.Parameters.Add("@EmailUsuario", SqlDbType.VarChar, 70);
            auxParametro = cmd.Parameters.Add("@TelefonoUsuario", SqlDbType.VarChar, 30);
            auxParametro = cmd.Parameters.Add("@ImprimeUnix", SqlDbType.Char, 1);
            auxParametro = cmd.Parameters.Add("@idUsuario", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@msgError", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@accion"].Value = auxtipoAccion;
            cmd.Parameters["@idArea"].Value = auxIdArea;
            cmd.Parameters["@NombreUsuario"].Value = txtNombre.Text.Trim();
            cmd.Parameters["@ApellidoUsuario"].Value = txtApellido.Text.Trim();
            cmd.Parameters["@NombreUser"].Value = txtNombreUser.Text.Trim();
            cmd.Parameters["@CargoUsuario"].Value = txtCargo.Text.Trim();
            cmd.Parameters["@EmailUsuario"].Value = txtEmail.Text.Trim();
            cmd.Parameters["@TelefonoUsuario"].Value = txtTelefono.Text.Trim();
            cmd.Parameters["@ImprimeUnix"].Value = "";
            cmd.Parameters["@idUsuario"].Value = auxidUsuarioInsert;


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
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "bueno", "Operación Correcta.", "Se realizó el ingreso de nuevo usuario.", false, false);
                EstadoInicial();             
            }


        }

        private void cmbArea_SelectionChangeCommitted(object sender, EventArgs e)
        {
            auxIdArea = Convert.ToString(cmbArea.SelectedValue);
            habilitaTextBox();
        }

        private void tsbGrabar_Click(object sender, EventArgs e)
        {
            if (auxActualizar != true)
            {
                revisaTextBoxVacios();
                revisaComboBoxVacios();

                if (vaciosTextBox == true || vaciosComboBox == true)
                {
                    Rutinas.PresentaMensajeAceptar(cFormularioPadre, "malo", "Faltan datos", "De ingresar al menos Nombre, Apellido y Nombre de usuario.", false, false);
                }
                else
                {
                    InsertNewUsuario();
                }
            }
            else
            {
                UpdateUsuario();
            }       
        }       

        private void tsMarca_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void habilitaTextBox()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtNombreUser.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefono.Enabled = true;
            txtCargo.Enabled = true;
        }

        private void tsbCerrarUsu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbCancelarUsu_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void tsbNuevoUsu_Click(object sender, EventArgs e)
        {
            cmbEmpresa.Enabled = true;
            tsbCancelarUsu.Visible = true;
            tsbGrabarUsu.Visible = true;
            tsEditarUsu.Visible = false;
        }

        private void revisaTextBoxVacios()
        {
            if(String.IsNullOrEmpty(txtApellido.Text)||String.IsNullOrEmpty(txtNombre.Text)||String.IsNullOrEmpty(txtNombreUser.Text))
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
            if(String.IsNullOrEmpty(cmbEmpresa.Text)||String.IsNullOrEmpty(cmbPlanta.Text)||String.IsNullOrEmpty(cmbArea.Text))
            {
                vaciosComboBox = true;
            }
            else
            {
                vaciosComboBox = false;
            }
        }

        private void tsEditarUsu_Click(object sender, EventArgs e)
        {
            dgListaUsuarios.Enabled = true;
            tsbCancelarUsu.Visible = true;
            tsbNuevoUsu.Visible = false;
            tsbGrabarUsu.Visible = true;

            txtNombre.Enabled= true;
            txtApellido.Enabled = true;
            txtNombreUser.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefono.Enabled = true;
            txtCargo.Enabled = true;
            auxActualizar = true;         
        }

        private void dgListaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgListaUsuarios.SelectedCells[Nombre].Value.ToString();
            txtApellido.Text = dgListaUsuarios.SelectedCells[Apellido].Value.ToString();
            txtNombreUser.Text = dgListaUsuarios.SelectedCells[NombreUsuario].Value.ToString();
            txtCargo.Text = dgListaUsuarios.SelectedCells[CargoUsuario].Value.ToString();
            txtEmail.Text = dgListaUsuarios.SelectedCells[EmailUsuario].Value.ToString();
            txtTelefono.Text = dgListaUsuarios.SelectedCells[TelefonoUsuario].Value.ToString();
            intIdUsuarioUpdate = Convert.ToInt32(dgListaUsuarios.SelectedCells[idUsuario].Value.ToString());
        }

        private void UpdateUsuario()
        {
            string auxRespuesta = "";
            SqlConnection Con = new SqlConnection(cConexionSQL);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spUpdateUsuarioAPI", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@intIdUsuario", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@vchNombre", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@vchApellido", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@vchNombreUsuario", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@vchCargoUsuario", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@vchEmailUsuario", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@vchTelefonoUsuario", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@msgError", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@intIdUsuario"].Value = intIdUsuarioUpdate;
            cmd.Parameters["@vchNombre"].Value = txtNombre.Text.Trim();
            cmd.Parameters["@vchApellido"].Value = txtApellido.Text.Trim();
            cmd.Parameters["@vchNombreUsuario"].Value = txtNombreUser.Text.Trim();
            cmd.Parameters["@vchCargoUsuario"].Value = txtCargo.Text.Trim();
            cmd.Parameters["@vchEmailUsuario"].Value = txtEmail.Text.Trim();
            cmd.Parameters["@vchTelefonoUsuario"].Value = txtTelefono.Text.Trim();

            try
            {
                cmd.ExecuteNonQuery();
                if (cmd.Parameters["@msgError"].Value.ToString() != "")
                {
                    auxRespuesta = "No se pudo Actualizar, " + cmd.Parameters["@msgError"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                auxRespuesta = "No se pudo Actualizar" + ex.ToString();
            }

            cmd.Connection.Close(); cmd.Connection.Dispose();
            Con.Close(); Con.Dispose();

            if (auxRespuesta == "")
            {
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "bueno", "Operación Correcta.", "Se realizó la Actualización de Usuario.", false, false);
                EstadoInicial();
            }

        }
    }
}
