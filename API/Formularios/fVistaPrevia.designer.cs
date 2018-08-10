namespace API.Formularios
{
    partial class fVistaPrevia
    { 
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            //this.crVisorDeReporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crVisorDeReporte
            // 
            //this.crVisorDeReporte.ActiveViewIndex = -1;
            //this.crVisorDeReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //this.crVisorDeReporte.Cursor = System.Windows.Forms.Cursors.Default;
            //this.crVisorDeReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.crVisorDeReporte.Location = new System.Drawing.Point(0, 0);
            //this.crVisorDeReporte.Name = "crVisorDeReporte";
            //this.crVisorDeReporte.SelectionFormula = "";
            //this.crVisorDeReporte.ShowGotoPageButton = false;
            //this.crVisorDeReporte.ShowGroupTreeButton = false;
            //this.crVisorDeReporte.ShowParameterPanelButton = false;
            //this.crVisorDeReporte.ShowRefreshButton = false;
            //this.crVisorDeReporte.ShowTextSearchButton = false;
            //this.crVisorDeReporte.Size = new System.Drawing.Size(288, 254);
            //this.crVisorDeReporte.TabIndex = 0;
            ////this.crVisorDeReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            //this.crVisorDeReporte.ViewTimeSelectionFormula = "";
            // 
            // fVistaPrevia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 254);
            //this.Controls.Add(this.crVisorDeReporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fVistaPrevia";
            this.Text = "fVistaPrevia";
            this.Load += new System.EventHandler(this.fVistaPrevia_Load);
            this.Leave += new System.EventHandler(this.fVistaPrevia_Leave);
            this.ResumeLayout(false);

        }

        #endregion

       // private CrystalDecisions.Windows.Forms.CrystalReportViewer crVisorDeReporte;

    }
}