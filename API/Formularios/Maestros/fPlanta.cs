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


namespace API.Formularios
{
    public partial class fPlanta : Form
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

        //variables para los campos de la grilla Planta
        public int idPlanta = 0;
        public int NombrePlanta = 1;
        public int DireccionPlanta = 2;
        public int CiudadPlanta = 3;
        public int TelefonoPlanta = 4;
        public int EmailPlanta = 5;
        public int EmpresaPlanta = 6;
        
        public fPlanta()
        {
            InitializeComponent();
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
                dgPlanta.Columns[idPlanta].Width = 30; pDataGrid.Columns[idPlanta].HeaderText = "idPlanta";
                dgPlanta.Columns[NombrePlanta].Width = 200; pDataGrid.Columns[NombrePlanta].HeaderText = "Nombre Planta";
                dgPlanta.Columns[DireccionPlanta].Width = 225; pDataGrid.Columns[DireccionPlanta].HeaderText = "Dirección";
                dgPlanta.Columns[CiudadPlanta].Width = 74; pDataGrid.Columns[CiudadPlanta].HeaderText = "Ciudad";
                dgPlanta.Columns[TelefonoPlanta].Width = 74; pDataGrid.Columns[TelefonoPlanta].HeaderText = "Teléfono";
                dgPlanta.Columns[EmailPlanta].Width = 225; pDataGrid.Columns[EmailPlanta].HeaderText = "Email";
            }
        }

        private void ExtraePlanta()
        {
            string aux = "EXEC spObtienePlantas";
            SqlConnection SqlCon = new SqlConnection(cConexionSQL);
            SqlDataAdapter SqlDa = new SqlDataAdapter(aux, SqlCon);
            DataSet ds = new DataSet("Consulta");
            SqlDa.Fill(ds, "Consulta");
            dgPlanta.DataSource = ds.Tables["Consulta"];
            PrepararDataGrid(dgPlanta);
            dgPlanta.Refresh();
            if (dgPlanta.RowCount > 0) { dgPlanta.Rows[0].Selected = false; }
            dgPlanta.ClearSelection();
        }

        private void CargarComboboxEmpresa()
        {
            Rutinas.CargarDatosComboBox(cConexionSQL, "spObtieneComboBoxEmpresa", cmbEmpresa, "NombreEmpresa","idEmpresa");
            cmbEmpresa.SelectedIndex = -1;
        }

        private void fPlanta_Load(object sender, EventArgs e)
        {
            CargarComboboxEmpresa();
            ExtraePlanta();
        }

        private void dgPlanta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    
}
