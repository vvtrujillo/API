using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;


namespace API.Fin
{ 
    public partial class fAcercaDe : Form
    {
        private string cConexionSQL;
        public string ConexionSQL { set { cConexionSQL = value; } }

        private StatusStrip cBarraEstado;
        public StatusStrip BarraEstado { set { cBarraEstado = value; } }
        private Form cFormularioPadre;
        public Form FormularioPadre { set { cFormularioPadre = value; } }

        public fAcercaDe()
        {
            InitializeComponent();
        }       





        private void fAcercaDe_Load(object sender, EventArgs e)
        {           
            labVersion.Text = "Versión: " + Properties.Settings.Default.VersionSistema;
            labDescripcion.Text = "Servidor SQL: " + Properties.Settings.Default.ServidorSQLCentral + (char)13;
            labDescripcion.Text += "Base: " + Properties.Settings.Default.BaseSQLCentral + (char)13;
            //if (Properties.Settings.Default.IDPlanta != "25")
            //{
            //    labDescripcion.Text += "Configurado para trabajo local en " + Properties.Settings.Default.DescripcionPlanta + (char)13;
            //    labDescripcion.Text += "Servidor SQL local: " + Properties.Settings.Default.ServidorSQLPlanta + (char)13;
            //    labDescripcion.Text += "Base local: " + Properties.Settings.Default.BaseDatosPlanta;
            //}
        }
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); this.Dispose();
        }

    }
}
