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
//using API.Formularios.Maestros;

namespace API.Formularios.Maestros
{
    public partial class fModelo : Form
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
        private bool vacio;

        //Variables grilla
        private int idModelo = 0;
        private int Modelo = 1;
        private int Marca = 2;

        //variables locales
        private int idMarcaInsert;
        private int idModeloSelecc;
        private bool ActualizaModeloBool;

        public fModelo()
        {
            InitializeComponent();
        }

        private void EstadoInicial()
        {
            CargarComboBoxMarca();
            BloqueaObjetosIngreso();
            ObtieneModelo();
            LimpiaVariables();
            tsActualiza.Visible = false;            
            vacio = false;
            tsbCancelar.Visible = false;
            tsbGrabar.Visible = false;
            tsEditar.Visible = true;
            ActualizaModeloBool = false;
        }

        private void LimpiaVariables()
        {
            idMarcaInsert = 0;
            idModeloSelecc = 0;
            txtNombreModelo.Text = String.Empty;
            txtNombreModelo.Text = "";
        }

        private void CargarComboBoxMarca()
        {
            Rutinas.CargarDatosComboBox(cConexionSQL, "spObtieneMarcaComboBox", cmbMarcaModelo, "NombreMarca", "idMarca");
            cmbMarcaModelo.SelectedIndex = -1;
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
            if (pDataGrid.Name == "dgModelo")
            {
                dgModelo.Columns[idModelo].Visible = false; pDataGrid.Columns[idModelo].HeaderText = "idModelo";
                dgModelo.Columns[Modelo].Width = 200; pDataGrid.Columns[Modelo].HeaderText = "Modelo";
                dgModelo.Columns[Marca].Width = 200; pDataGrid.Columns[Marca].HeaderText = "Marca";
            }
        }

        private void ObtieneModelo()
        {
            //spObtieneModelos
            string aux = "EXEC spObtieneModelos";
            SqlConnection SqlCon = new SqlConnection(cConexionSQL);
            SqlDataAdapter SqlDa = new SqlDataAdapter(aux, SqlCon);
            DataSet ds = new DataSet("Consulta");
            SqlDa.Fill(ds, "Consulta");
            dgModelo.DataSource = ds.Tables["Consulta"];
            PrepararDataGrid(dgModelo);
            dgModelo.Refresh();
            if (dgModelo.RowCount > 0) { dgModelo.Rows[0].Selected = false; }
            dgModelo.ClearSelection();
        }

        private void IngresaNuevoModelo()
        {
            string auxRespuesta = "";

            SqlConnection Con = new SqlConnection(cConexionSQL);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spInsertNewModelo", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@vchNombreModelo", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@intIdMarca", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@msgError", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@vchNombreModelo"].Value = txtNombreModelo.Text.Trim();
            cmd.Parameters["@intIdMarca"].Value = idMarcaInsert;

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

        private void ActualizaModelo()
        {
            string auxRespuesta = "";

            SqlConnection Con = new SqlConnection(cConexionSQL);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spActualizaModelo", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@intIdModelo", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@vchNombreModelo", SqlDbType.VarChar,255);
            auxParametro = cmd.Parameters.Add("@msgError", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@intIdModelo"].Value = idModeloSelecc;
            cmd.Parameters["@vchNombreModelo"].Value = txtNombreModelo.Text.Trim();

            try
            {
                cmd.ExecuteNonQuery();
                if (cmd.Parameters["@msgError"].Value.ToString() != "")
                {
                    auxRespuesta = "No se pudo actualizar, " + cmd.Parameters["@msgError"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                auxRespuesta = "No se pudo actualizar" + ex.ToString();
            }

            cmd.Connection.Close(); cmd.Connection.Dispose();
            Con.Close(); Con.Dispose();

            if (auxRespuesta == "")
            {
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "bueno", "Operación Correcta.", "Se realizó la Actualización", false, false);
                EstadoInicial();

            }
            else
            {
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "malo", "Error en la Operación.", auxRespuesta, false, false);
            }

        }

        private void EliminaModelo()
        {
            string auxRespuesta = "";

            SqlConnection Con = new SqlConnection(cConexionSQL);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spEliminaModelo", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@intIdModelo", SqlDbType.Int);            
            auxParametro = cmd.Parameters.Add("@msgError", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@intIdModelo"].Value = idModeloSelecc;

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

        private void BloqueaObjetosIngreso()
        {
            cmbMarcaModelo.Enabled = false;
            txtNombreModelo.Enabled = false;
            dgModelo.Enabled = false;
        }

        private void HabilitaObjetosIngreso()
        {
            cmbMarcaModelo.Enabled = true;
            txtNombreModelo.Enabled = true;
            
        }

        private void EditarModelo()
        {           
            tsActualiza.Visible = false;
            tsbGrabar.Visible = true;
            cmbMarcaModelo.Enabled = true;
            txtNombreModelo.Enabled = true;
            ActualizaModeloBool = true;
        }

        private void fModelo_Load(object sender, EventArgs e)
        {
            EstadoInicial();
            ObtieneModelo();
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            dgModelo.Enabled = false;
            tsbGrabar.Visible = true;
            tsbCancelar.Visible = true;
            tsEditar.Visible = false;
            HabilitaObjetosIngreso();            
        }

        private void cmbMarcaModelo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idMarcaInsert = Convert.ToInt32(cmbMarcaModelo.SelectedValue);
        }

        private void tsbGrabar_Click(object sender, EventArgs e)
        {
            if (ActualizaModeloBool != true)
            {
                ValidaControlesCompletos();

                if (vacio == true)
                {
                    Rutinas.PresentaMensajeAceptar(cFormularioPadre, "malo", "Campos Vacíos", "Debe ingresar todos los campos para insertar", false, false);
                }
                else
                {
                    IngresaNuevoModelo();
                }
            }
            else
            {
                ActualizaModelo();
            }
                        
        }

        private void dgModelo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            int auxfila = e.RowIndex;

            idModeloSelecc = Convert.ToInt32(dgModelo.Rows[auxfila].Cells[idModelo].Value.ToString());
            cmbMarcaModelo.Text = dgModelo.Rows[auxfila].Cells[Marca].Value.ToString();
            txtNombreModelo.Text = dgModelo.Rows[auxfila].Cells[Modelo].Value.ToString();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (Rutinas.PresentaMensajeAceptarCancelar(cFormularioPadre, "critico", "", "Se va a realizar la Eliminación\n" +
                                                    "¿Desea continuar con la operación?", false, false))
            {
                EliminaModelo();
            }                            
        }

        private void tsEditar_Click(object sender, EventArgs e)
        {
            dgModelo.Enabled = true;
            EditarModelo();
        }

        private void tsModelo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void tsActualiza_Click(object sender, EventArgs e)
        {
            if (Rutinas.PresentaMensajeAceptarCancelar(cFormularioPadre, "critico", "", "Se va a realizar la Actualización\n" +
                                                    "¿Desea continuar con la operación?", false, false))
            {
                ActualizaModelo();
            }
            EstadoInicial();
        }       

        private void ValidaControlesCompletos()
        {
            if (String.IsNullOrEmpty(txtNombreModelo.Text)||(String.IsNullOrEmpty(cmbMarcaModelo.Text)))
            {                
                vacio = true;                
            }
            else
            {
                vacio = false;
            }
        }
    }
}
