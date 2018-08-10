using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace API.Formularios
{
    public partial class fVistaPrevia : Form
    { 
        //CrystalDecisions.CrystalReports.Engine.ReportDocument auxReporte;
        private CrystalDecisions.CrystalReports.Engine.ReportDocument auxReporte;
        public CrystalDecisions.CrystalReports.Engine.ReportDocument Reporte { get { return auxReporte; } set { auxReporte = value; } }
        private CrystalDecisions.Windows.Forms.CrystalReportViewer auxVistaPrevia;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer VistaPrevia { get { return auxVistaPrevia; } set { auxVistaPrevia = value; } }

        public fVistaPrevia()
        {
            InitializeComponent();
        }

        private void fVistaPrevia_Load(object sender, EventArgs e)
        {
        }
        public void EnlazarVisor()
        { 
            //auxVistaPrevia = this.crVisorDeReporte;
        }

        private void fVistaPrevia_Leave(object sender, EventArgs e)
        {
            auxReporte.Close(); auxReporte.Dispose();
            auxVistaPrevia.Dispose();
        }
    }
}