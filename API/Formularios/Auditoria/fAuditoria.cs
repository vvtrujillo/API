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

namespace API.Formularios.Auditoria
{
    public partial class fAuditoria : Form
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

        //variables grilla auditoria
        private int idAuditoria = 0;
        private int Tabla = 1;
        private int Campo = 2;
        private int Accion = 3;
        private int valorAnterior = 4;
        private int valorNuevo = 5;
        private int FechaModificacion = 6;
        private int usuarioModificacion = 7;
        private int TerminalModificacion = 8;

        public fAuditoria()
        {
            InitializeComponent();
        }

        private void PrepararDataGridAudi(DataGridView pDataGrid)
        {
            foreach (DataGridViewColumn c in pDataGrid.Columns)
            {
                c.Resizable = DataGridViewTriState.True;
                c.ReadOnly = true;
                c.DefaultCellStyle.Font = cFuente;
            }
            pDataGrid.RowHeadersVisible = false;
            if (pDataGrid.Name == "dgAuditoria")
            {
                dgAuditoria.Columns[idAuditoria].Visible = false; pDataGrid.Columns[idAuditoria].HeaderText = "idAuditoria";
                dgAuditoria.Columns[Tabla].Width = 100; pDataGrid.Columns[Tabla].HeaderText = "Tabla";
                dgAuditoria.Columns[Campo].Width = 100; pDataGrid.Columns[Campo].HeaderText = "Campo";
                dgAuditoria.Columns[Accion].Width = 50; pDataGrid.Columns[Accion].HeaderText = "Accion";
                dgAuditoria.Columns[valorAnterior].Width = 100; pDataGrid.Columns[valorAnterior].HeaderText = "Valor Anterior";
                dgAuditoria.Columns[valorNuevo].Width = 100; pDataGrid.Columns[valorNuevo].HeaderText = "Valor Nuevo";
                dgAuditoria.Columns[FechaModificacion].Width = 200; pDataGrid.Columns[FechaModificacion].HeaderText = "Fecha Modifiación";
                dgAuditoria.Columns[usuarioModificacion].Width = 200; pDataGrid.Columns[usuarioModificacion].HeaderText = "Usuario Modificación";
                dgAuditoria.Columns[TerminalModificacion].Width = 200; pDataGrid.Columns[TerminalModificacion].HeaderText = "Terminal Modificación";
                dgAuditoria.Columns[TerminalModificacion].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void BusquedaAuditoria()
        {
            string aux = "EXEC spObtieneAuditoria";
            SqlConnection SqlCon = new SqlConnection(cConexionSQL);
            SqlDataAdapter SqlDa = new SqlDataAdapter(aux, SqlCon);
            DataSet ds = new DataSet("Consulta");
            SqlDa.Fill(ds, "Consulta");
            dgAuditoria.DataSource = ds.Tables["Consulta"];
            PrepararDataGridAudi(dgAuditoria);
            dgAuditoria.Refresh();
            if (dgAuditoria.RowCount > 0) { dgAuditoria.Rows[0].Selected = false; }
            dgAuditoria.ClearSelection();
        }

        private void fAuditoria_Load(object sender, EventArgs e)
        {
            BusquedaAuditoria();
        }

        private void tsbCerrarAudit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsAuditoria_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
