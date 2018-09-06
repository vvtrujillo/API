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
    public partial class fMarca : Form
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

        public string idEmpresaObtener;
        //variables que se utilizan para DataGrid del form fMarca
        public int chkBoxDG = 0;
        public int idMarca = 1;
        public int NombreMarca = 2;
        public int NombreCortoMarca = 3;
        public int PaisMarca = 4;

        //
        public int intIdMarcaSel;


        public fMarca()
        {
            InitializeComponent();
        }

        private void EstadoInicial()
        {
            txtMarca.Enabled = false;
            txtMarca.Text = String.Empty;
            intIdMarcaSel = 0;
            tsbEliminar.Visible = false;
            tsbCancelar.Visible = false;
            tsbGrabar.Visible = false;
            ExtraeMarca();
        }        

        private void BloqueoTxtBox()
        {
            txtMarca.Enabled = false;
           
        }

        private void HabilitaTextBox()
        {
            txtMarca.Enabled = true;
            
        }

        private void PrepararDataGrid(DataGridView pDataGrid)
        {
            pDataGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            pDataGrid.RowHeadersVisible = false;
            pDataGrid.ReadOnly = false;

            foreach (DataGridViewColumn c in pDataGrid.Columns)
            {
                c.Resizable = DataGridViewTriState.True;
                if (c.Name=="Sel")
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
            if (pDataGrid.Name == "dgMarca")
            {
                dgMarca.Columns[chkBoxDG].Width = 40; pDataGrid.Columns[chkBoxDG].HeaderText = "Sel";
                dgMarca.Columns[idMarca].Visible = false; pDataGrid.Columns[idMarca].HeaderText = "idMarca";
                dgMarca.Columns[NombreMarca].Width = 200; pDataGrid.Columns[NombreMarca].HeaderText = "Nombre Marca";
                dgMarca.Columns[NombreMarca].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void ExtraeMarca()
        {
           // string aux = "EXEC spObtieneMarcas";
            SqlConnection SqlCon = new SqlConnection(cConexionSQL);
            SqlCommand cmActualizar = new SqlCommand("spObtieneMarcas", SqlCon);
            cmActualizar.CommandType = CommandType.StoredProcedure;
            SqlCon.Open();

            SqlDataReader drBuscar;
            drBuscar = cmActualizar.ExecuteReader();
            dgMarca.Rows.Clear();
            if (drBuscar.HasRows)
            {
                
                drBuscar.Read();
                do
                {
                    dgMarca.Rows.Add(1);
                    dgMarca.Rows[dgMarca.Rows.Count - 1].Cells[chkBoxDG].Value = false;
                    dgMarca.Rows[dgMarca.Rows.Count - 1].Cells[idMarca].Value = drBuscar.GetInt32(drBuscar.GetOrdinal("idMarca"));
                    dgMarca.Rows[dgMarca.Rows.Count - 1].Cells[NombreMarca].Value = drBuscar.GetString(drBuscar.GetOrdinal("NombreMarca"));
                   
                }
                while (drBuscar.Read());
            }

            PrepararDataGrid(dgMarca);

            //SqlDataAdapter SqlDa = new SqlDataAdapter(aux, SqlCon);
            //DataSet ds = new DataSet("Consulta");
            //SqlDa.Fill(ds, "Consulta");
            //dgMarca.DataSource = ds.Tables["Consulta"];
            //PrepararDataGrid(dgMarca);
            //dgMarca.Refresh();
            //if (dgMarca.RowCount > 0) { dgMarca.Rows[0].Selected = false; }
            //dgMarca.ClearSelection();

            drBuscar.Close(); drBuscar.Dispose();
            cmActualizar.Connection.Close(); cmActualizar.Connection.Dispose();
            SqlCon.Close(); SqlCon.Dispose();
        }

        private void IngresaNuevaMarca()
        {
            string auxRespuesta = "";

            SqlConnection Con = new SqlConnection(cConexionSQL);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spIngresaNewMarca", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@vchNombreMarca", SqlDbType.VarChar, 255);            
            auxParametro = cmd.Parameters.Add("@msgError", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@vchNombreMarca"].Value = txtMarca.Text.Trim();

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

        private void EliminaMarca()
        {
            string auxRespuesta = "";

            SqlConnection Con = new SqlConnection(cConexionSQL);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spEliminaMarca", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@intIdMarca", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@msgError", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@intIdMarca"].Value = intIdMarcaSel;

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

        private void ActualizaNombreMarca()
        {
            string auxRespuesta = "";

            SqlConnection Con = new SqlConnection(cConexionSQL);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spUpdateNombreMarca", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;
                       
            auxParametro = cmd.Parameters.Add("@vchNombreMarca", SqlDbType.VarChar, 255);
            auxParametro = cmd.Parameters.Add("@intIdMarca", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@msgError", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;
            
            cmd.Parameters["@vchNombreMarca"].Value = txtMarca.Text.Trim();
            cmd.Parameters["@intIdMarca"].Value = intIdMarcaSel;

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

        private void fMarca_Load(object sender, EventArgs e)
        {
            EstadoInicial();
            ExtraeMarca();
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void tsbGrabar_Click(object sender, EventArgs e)
        {   
            if(String.IsNullOrEmpty(txtMarca.Text))
            {
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "malo", "Debe ingresar Marca a grabar", "", false, false);                
            }
            else
            {
                IngresaNuevaMarca();
            }            
        }

        private void dgMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgMarca.EndEdit();
            VerificarCanastosSeleccionados(dgMarca, e.RowIndex, e.ColumnIndex);

            if (e.RowIndex < 0) { return; }
            int auxfila = e.RowIndex;

            intIdMarcaSel = Convert.ToInt32(dgMarca.Rows[auxfila].Cells[idMarca].Value.ToString());
            txtMarca.Text = dgMarca.Rows[auxfila].Cells[NombreMarca].Value.ToString();
        }

        private void tsMarca_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            txtMarca.Enabled = true;
            txtMarca.Text = String.Empty;
            tsbGrabar.Visible = true;
            tsEditar.Visible = false;
        }

        private void tsEditar_Click(object sender, EventArgs e)
        {
            txtMarca.Enabled = true;
            tsbEliminar.Visible = true;
            tsbEliminar.Enabled = true;
            tsbGrabar.Visible = true;
            tsbCancelar.Visible = true;

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (Rutinas.PresentaMensajeAceptarCancelar(cFormularioPadre, "critico", "", "Se va a realizar la Eliminación de "+ txtMarca.Text +"\n" +
                                                    "¿Desea continuar con la operación?", false, false))
            {
                EliminaMarca();
            }       
        }

        private void VerificarCanastosSeleccionados(DataGridView pDataGrid, int pFila, int pColumna)
        {
            if (pFila < 0 || pColumna != 0) { return; } //columna distinta de cero

            foreach (DataGridViewRow row in pDataGrid.Rows)
            {
                if (pFila != row.Index)
                {
                    DataGridViewCheckBoxCell chbDesocupados = (DataGridViewCheckBoxCell)row.Cells[0]; //columna donde se hace la selección
                    if ((bool)chbDesocupados.Value == true)
                    {
                        chbDesocupados.Value = false;
                    }
                }
            }
        }
    }
}
