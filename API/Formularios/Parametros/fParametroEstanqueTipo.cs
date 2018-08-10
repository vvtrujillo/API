using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace API.Formularios.Parametros
{
    public partial class fParametroEstanqueTipo : Form
    {
        //declaraciones para mover el formulario con el mouse desde el toolstrip (menu botones del formulario)
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //fin declaraciones para mover el formulario


        clMSC.clMSC Rutinas = new clMSC.clMSC();

        private string cConexionSQL;
        public string ConexionSQL { set { cConexionSQL = value; } }
        private Font cFuente;
        public Font Fuente { set { cFuente = value; } }
        private Color cColorFondoConFoco;
        public Color ColorFondoConFoco { set { cColorFondoConFoco = value; } }
        private Color cColorFondoSinFoco;
        public Color ColorFondoSinFoco { set { cColorFondoSinFoco = value; } }
        private StatusStrip cBarraEstado;
        public StatusStrip BarraEstado { set { cBarraEstado = value; } }
        private Form cFormularioPadre;
        public Form FormularioPadre { set { cFormularioPadre = value; } }

        public fParametroEstanqueTipo()
        {
            InitializeComponent();
        }

        private void EstadoIncial()
        {
            dgTipoEstanque.ClearSelection();
            //tsbImprimir.Enabled = dgTipoEstanque.RowCount == 0 ? tsbImprimir.Enabled = false : tsbImprimir.Enabled = true;
            tsbEliminar.Enabled = false;
            tsbGrabar.Tag = "";
            tsbGrabar.Enabled = false;
            mtbCodigoTipoEstanque.Text = ""; mtbCodigoTipoEstanque.Enabled = false;
            mtbDescripcionTipoEstanque.Text = ""; mtbDescripcionTipoEstanque.Enabled = false;
            chbActivo.Checked = false; chbActivo.Enabled = false;
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
            if (pDataGrid.Name == "dgTipoEstanque")
            {
                dgTipoEstanque.Columns[0].Width = 80; pDataGrid.Columns[0].HeaderText = "Código";
                dgTipoEstanque.Columns[1].Width = 225; pDataGrid.Columns[1].HeaderText = "Descripción";
                dgTipoEstanque.Columns[2].Width = 74; pDataGrid.Columns[2].HeaderText = "Activo";
            }
        }
        private void ObtenerTipoEstanque()
        {
            string aux = "EXEC pa_ObtenerTipoEstanque";
            SqlConnection SqlCon = new SqlConnection(cConexionSQL);
            SqlDataAdapter SqlDa = new SqlDataAdapter(aux, SqlCon);
            DataSet ds = new DataSet("Consulta");
            SqlDa.Fill(ds, "Consulta");
            dgTipoEstanque.DataSource = ds.Tables["Consulta"];
            PrepararDataGrid(dgTipoEstanque);
            dgTipoEstanque.Refresh();
            if (dgTipoEstanque.RowCount > 0) { dgTipoEstanque.Rows[0].Selected = false; }
            dgTipoEstanque.ClearSelection();
        }
        private bool VerificarCodigoExistente()
        {
            foreach (DataGridViewRow fila in dgTipoEstanque.Rows)
            {
                if (fila.Cells[0].Value.ToString().Trim() == mtbCodigoTipoEstanque.Text.Trim())
                {
                    return true;
                }
            }
            return false;
        }
        private void ActualizarTipoEstanque()
        {
            string auxRespuesta = "";
            SqlConnection cnTipoEstanque = new SqlConnection(cConexionSQL);
            SqlCommand cmActualizarTipoEstanque = new SqlCommand("pa_ActualizarTipoEstanque", cnTipoEstanque);
            cmActualizarTipoEstanque.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmActualizarTipoEstanque.Parameters.Add("@IDTipoActualizacion", SqlDbType.VarChar, 01);
            auxParametro = cmActualizarTipoEstanque.Parameters.Add("@IDTipoEstanque", SqlDbType.Int);
            auxParametro = cmActualizarTipoEstanque.Parameters.Add("@Descripcion", SqlDbType.VarChar, 70);
            auxParametro = cmActualizarTipoEstanque.Parameters.Add("@Activo", SqlDbType.Bit);
            auxParametro = cmActualizarTipoEstanque.Parameters.Add("@MensajeError", SqlDbType.VarChar, 300);
            auxParametro.Direction = ParameterDirection.Output;

            cmActualizarTipoEstanque.Parameters["@IDTipoActualizacion"].Value = tsbGrabar.Tag.ToString();
            cmActualizarTipoEstanque.Parameters["@IDTipoEstanque"].Value = mtbCodigoTipoEstanque.Text;
            cmActualizarTipoEstanque.Parameters["@Descripcion"].Value = mtbDescripcionTipoEstanque.Text;
            cmActualizarTipoEstanque.Parameters["@Activo"].Value = chbActivo.Checked;
            try
            {
                cnTipoEstanque.Open();
                cmActualizarTipoEstanque.ExecuteNonQuery();
                if (cmActualizarTipoEstanque.Parameters["@MensajeError"].Value.ToString() != "")
                {
                    auxRespuesta = "Vaya, SQL informó un problema al grabar el tipo de estanque. " + cmActualizarTipoEstanque.Parameters["@MensajeError"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                auxRespuesta = "Vaya, se presentó un problema al grabar el tipo de estanque. " + ex.ToString();
            }
            cmActualizarTipoEstanque.Connection.Close(); cmActualizarTipoEstanque.Connection.Dispose();
            cnTipoEstanque.Close(); cnTipoEstanque.Dispose();
            if (auxRespuesta == "")
            {
                ObtenerTipoEstanque();
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "bueno", "Operación correcta", "El tipo de estanque fue correctamente grabada en la base de datos", false, false);
            }
            else
            {
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "malo", "Error al realizar la operación", auxRespuesta, false, false);
            }
            EstadoIncial();
        }
        private void EliminarTipoEstanque(string pIDTipoEstanque)
        {
            string auxRespueta = "";
            SqlConnection cnEliminarTipoEstanque = new SqlConnection(cConexionSQL);
            SqlCommand cmEliminarTipoEstanque = new SqlCommand("pa_EliminarTipoEstanque", cnEliminarTipoEstanque);
            cmEliminarTipoEstanque.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmEliminarTipoEstanque.Parameters.Add("@IDTipoEstanque", SqlDbType.Int);
            auxParametro = cmEliminarTipoEstanque.Parameters.Add("@MensajeError", SqlDbType.VarChar, 300);
            auxParametro.Direction = ParameterDirection.Output;

            cmEliminarTipoEstanque.Parameters["@IDTipoEstanque"].Value = pIDTipoEstanque;
            try
            {
                cnEliminarTipoEstanque.Open();
                cmEliminarTipoEstanque.ExecuteNonQuery();
                if (cmEliminarTipoEstanque.Parameters["@MensajeError"].Value.ToString() != "")
                {
                    auxRespueta = "Vaya, SQL informó un problema al eliminar el tipo de estanque " + cmEliminarTipoEstanque.Parameters["@MensajeError"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                auxRespueta = "Vaya, Se presentó un problema al grabar el tipo de estanque. " + ex.ToString();
            }
            cmEliminarTipoEstanque.Connection.Close(); cmEliminarTipoEstanque.Connection.Dispose();
            cnEliminarTipoEstanque.Close(); cnEliminarTipoEstanque.Dispose();
            if (auxRespueta == "")
            {
                ObtenerTipoEstanque();
                EstadoIncial();
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "bueno", "Operacion correcta", "El codigo del tipo de estanque " + pIDTipoEstanque + " fue eliminado de la base de datos", false, false);
            }
            if (auxRespueta != "")
            {
                Rutinas.PresentaMensajeAceptar(cFormularioPadre, "malo", "Error al realizar la operación", auxRespueta, false, false);
            }
            EstadoIncial();
        }   


        private void fParametroTipoEstanque_Load(object sender, EventArgs e)
        {
            EstadoIncial();
            //ObtenerTipoEstanque();
            Rutinas.ColorearControles(this, Properties.Settings.Default.ColorFondoSinFoco);
        }
        private void fParametroTipoEstanque_Shown(object sender, EventArgs e)
        {
            dgTipoEstanque.ClearSelection();
        }
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            EstadoIncial();
            tsbGrabar.Enabled = false;
            tsbGrabar.Tag = "I";
            mtbCodigoTipoEstanque.Enabled = true;
            mtbDescripcionTipoEstanque.Enabled = true;
            chbActivo.Enabled = true;
            mtbCodigoTipoEstanque.Focus();
        }
        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            //cBarraEstado.Items["Proceso"].Text = "Control de producción.";
        }
        private void tsbGrabar_Click(object sender, EventArgs e)
        {
            if (tsbGrabar.Tag.ToString() == "I")
            {
                if (!VerificarCodigoExistente())
                    ActualizarTipoEstanque();
                else
                {
                    Rutinas.PresentaMensajeAceptar(cFormularioPadre, "malo", "Error en la operación",
                                                    "No se puede agregar el codigo ingresado, puesto que ya existe en la base de datos", false, false);
                    mtbCodigoTipoEstanque.Focus();
                    return;
                }
            }
            else if (tsbGrabar.Tag.ToString() == "M")
            {
                ActualizarTipoEstanque();
            }
            EstadoIncial();
        }
        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (Rutinas.PresentaMensajeAceptarCancelar(cFormularioPadre, "critico", "Eliminación de tipo de estanque",
                                                      "Se procedera a eliminar el tipo de estanque seleccionado, ¿Continuamos?", false, false))
            {
                EliminarTipoEstanque(dgTipoEstanque.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void dgTipoEstanque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            tsbEliminar.Enabled = true;
            tsbGrabar.Tag = "M";
            int auxFila = e.RowIndex;
            mtbCodigoTipoEstanque.Text = dgTipoEstanque.Rows[auxFila].Cells[0].Value.ToString();
            mtbDescripcionTipoEstanque.Text = dgTipoEstanque.Rows[auxFila].Cells[1].Value.ToString(); mtbDescripcionTipoEstanque.Enabled = true;
            chbActivo.Checked = (bool)dgTipoEstanque.Rows[auxFila].Cells[2].Value; chbActivo.Enabled = true;
        }
        private void ChequearCambioEdicion(object sender, EventArgs e)
        {
            if (tsbGrabar.Tag.ToString() == "M")
            {
                if (mtbCodigoTipoEstanque.Text != dgTipoEstanque.SelectedRows[0].Cells[0].Value.ToString() ||
                    mtbDescripcionTipoEstanque.Text != dgTipoEstanque.SelectedRows[0].Cells[1].Value.ToString() ||
                    chbActivo.Checked != (bool)dgTipoEstanque.SelectedRows[0].Cells[2].Value)
                {
                    tsbGrabar.Enabled = mtbDescripcionTipoEstanque.Text.Trim() != string.Empty ? true : false;
                }
                else
                    tsbGrabar.Enabled = false;
            }
            else if (tsbGrabar.Tag.ToString() == "I")
            {
                tsbGrabar.Enabled = mtbDescripcionTipoEstanque.Text.Trim() != string.Empty ? true : false;
            }
        }
        private void toolsStripPerfiles_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        private void tsbImprimir_Click(object sender, EventArgs e)
        {

        }
        private void ControlLlegaElFoco(object sender, EventArgs e)
        {
            Control c = sender as Control;
            Rutinas.LlegaElFoco(c, Properties.Settings.Default.ColorFondoConFoco);
        }
        private void ControlSeVaElFoco(object sender, EventArgs e)
        {
            Control c = sender as Control;
            Rutinas.LlegaElFoco(c, Properties.Settings.Default.ColorFondoSinFoco);
        }
        private void mtbCodigoTipoEstanque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mtbDescripcionTipoEstanque.Focus();
            }
        }
        private void mtbDescripcionTipoEstanque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chbActivo.Focus();
            }
        }
        private void chbActivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mtbCodigoTipoEstanque.Focus();
            }
        }
        private void toolStripLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        private void mtbCodigoTipoEstanque_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              //permitir teclas de control como retroceso 
              if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void dgTipoEstanque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
