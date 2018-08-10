using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Net;

namespace API.Fin
{ 
    public partial class fActualizaControlAcceso : Form
    {
        //private string cConexionSQL;
        //public string ConexionSQL { set { cConexionSQL = value; } }
        private StatusStrip cBarraEstado;
        public StatusStrip BarraEstado { set { cBarraEstado = value; } }
        private Form cFormularioPadre;
        public Form FormularioPadre { set { cFormularioPadre = value; } }
        private string cAñoMesProceso;
        public string AñoMesProceso { set { cAñoMesProceso = value; } }
        private int ContadorMenu = 0;
        private int CuentaNivel = 0;
        private string cConexionSQL = "";

        public fActualizaControlAcceso()
        {
            InitializeComponent();
        }


        private void FormatearDatagrid(DataGridView pDataGrid)
        {
            pDataGrid.RowHeadersVisible = false;
            pDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised; // .RaisedVertical;
            foreach (DataGridViewColumn c in pDataGrid.Columns) { c.Resizable = DataGridViewTriState.False; c.ReadOnly = true; }


            if (pDataGrid.Name == "dgvServidoresSQL")
            {
                //CodigoVendedor Vendedor PreciosModificados
                pDataGrid.Columns[0].Width = 85; pDataGrid.Columns[0].HeaderText = "Host";
                pDataGrid.Columns[1].Width = 135; pDataGrid.Columns[1].HeaderText = "Instancia SQL";
                pDataGrid.Columns[2].Width = 100; pDataGrid.Columns[2].HeaderText = "Versión SQL";
                pDataGrid.Columns[3].Width = 130; pDataGrid.Columns[3].HeaderText = "Control de acceso";
                pDataGrid.Columns[4].Width = 150; pDataGrid.Columns[4].HeaderText = "Seguridad integrada";

                //Estilo encabezados
                pDataGrid.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopLeft;
                pDataGrid.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopLeft;
                pDataGrid.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopLeft;
                pDataGrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopLeft;
                pDataGrid.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
                //Estilo celdas
                pDataGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                pDataGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                pDataGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                pDataGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                pDataGrid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //DataGridViewColumn aux = new DataGridViewColumn();
                //aux = pDataGrid.Columns[0];
                //pDataGrid.Sort(aux, ListSortDirection.Ascending);

                //DataGridTableStyle DcStyle = new DataGridTableStyle();

            }
        }
        private void ObtenerServidoresSQLDisponibles()
        {
            //System.Data.Sql.SqlDataSourceEnumerator instance = System.Data.Sql.SqlDataSourceEnumerator.Instance;
            //dgvServidoresSQL.DataSource = instance.GetDataSources();
            //FormatearDatagrid(dgvServidoresSQL);
            //dgvServidoresSQL.Columns.Add(4);

            /*
            dgvServidoresSQL.Rows.Add(1);
            dgvServidoresSQL.Rows[dgvServidoresSQL.Rows.Count - 1].Cells[0].Value = @"MOLINO10"; 
            dgvServidoresSQL.Rows[dgvServidoresSQL.Rows.Count - 1].Cells[1].Value = @"MOLINO10\CONTROLACCESO";
            dgvServidoresSQL.Rows[dgvServidoresSQL.Rows.Count - 1].Cells[2].Value = "2012 Express";
            dgvServidoresSQL.Rows[dgvServidoresSQL.Rows.Count - 1].Cells[3].Value = "ControlAcceso";
            dgvServidoresSQL.Rows[dgvServidoresSQL.Rows.Count - 1].Cells[4].Value = "0";                    //0=seguridad integrada false,   1=Seguridad integrada true

            dgvServidoresSQL.Rows.Add(1);
            dgvServidoresSQL.Rows[dgvServidoresSQL.Rows.Count - 1].Cells[0].Value = @"PCPESMAL";
            dgvServidoresSQL.Rows[dgvServidoresSQL.Rows.Count - 1].Cells[1].Value = @"PCPESMAL\PCPESMAL";
            dgvServidoresSQL.Rows[dgvServidoresSQL.Rows.Count - 1].Cells[2].Value = "2008 R2 Express";
            dgvServidoresSQL.Rows[dgvServidoresSQL.Rows.Count - 1].Cells[3].Value = "ControlAccesoMalloco";
            dgvServidoresSQL.Rows[dgvServidoresSQL.Rows.Count - 1].Cells[4].Value = "0";                    //0=seguridad integrada false,   1=Seguridad integrada true
            
            dgvServidoresSQL.Rows.Add(1);
            dgvServidoresSQL.Rows[dgvServidoresSQL.Rows.Count - 1].Cells[0].Value = @"PCPEMAL1";
            dgvServidoresSQL.Rows[dgvServidoresSQL.Rows.Count - 1].Cells[1].Value = @"PCPEMAL1\PCPEMAL1";
            dgvServidoresSQL.Rows[dgvServidoresSQL.Rows.Count - 1].Cells[2].Value = "2008 R2 Express";
            dgvServidoresSQL.Rows[dgvServidoresSQL.Rows.Count - 1].Cells[3].Value = "ControlAccesoMalloco";
            dgvServidoresSQL.Rows[dgvServidoresSQL.Rows.Count - 1].Cells[4].Value = "0";                    //0=seguridad integrada false,   1=Seguridad integrada true

            dgvServidoresSQL.Rows.Add(1);
            dgvServidoresSQL.Rows[dgvServidoresSQL.Rows.Count - 1].Cells[0].Value = @"PCPESAJ1";
            dgvServidoresSQL.Rows[dgvServidoresSQL.Rows.Count - 1].Cells[1].Value = @"PCPESAJ1\ROMSANTIAGO";
            dgvServidoresSQL.Rows[dgvServidoresSQL.Rows.Count - 1].Cells[2].Value = "2008 R2 Express";
            dgvServidoresSQL.Rows[dgvServidoresSQL.Rows.Count - 1].Cells[3].Value = "ControlAccesoSantiago";
            dgvServidoresSQL.Rows[dgvServidoresSQL.Rows.Count - 1].Cells[4].Value = "0";                    //0=seguridad integrada false,   1=Seguridad integrada true

             */

            dgvServidoresSQL.Rows.Add(1);
            dgvServidoresSQL.Rows[dgvServidoresSQL.Rows.Count - 1].Cells[0].Value = @"139.10.11.85";
            dgvServidoresSQL.Rows[dgvServidoresSQL.Rows.Count - 1].Cells[1].Value = @"139.10.11.85\MOLINO14";
            dgvServidoresSQL.Rows[dgvServidoresSQL.Rows.Count - 1].Cells[2].Value = "2014 Express";
            dgvServidoresSQL.Rows[dgvServidoresSQL.Rows.Count - 1].Cells[3].Value = "ControlAcceso";
            dgvServidoresSQL.Rows[dgvServidoresSQL.Rows.Count - 1].Cells[4].Value = "0";                    //0=seguridad integrada false,   1=Seguridad integrada true

            //dgvServidoresSQL.Rows[0].Cells[0].Value = "MOLINO2"; dgvServidoresSQL.Rows[0].Cells[1].Value = "MOLINO2"; dgvServidoresSQL.Rows[0].Cells[2].Value = "2005 Standard"; dgvServidoresSQL.Rows[0].Cells[3].Value = "ControlAcceso";
            //dgvServidoresSQL.Rows[1].Cells[0].Value = "MOLINO4"; dgvServidoresSQL.Rows[1].Cells[1].Value = "MOLINO4"; dgvServidoresSQL.Rows[1].Cells[2].Value = "2008 R2 Standard"; dgvServidoresSQL.Rows[1].Cells[3].Value = "ControlAcceso";
            //dgvServidoresSQL.Rows[2].Cells[0].Value = "MOLINO6"; dgvServidoresSQL.Rows[2].Cells[1].Value = "MOLINO6"; dgvServidoresSQL.Rows[2].Cells[2].Value = "2008 Standard"; dgvServidoresSQL.Rows[2].Cells[3].Value = "ControlAcceso";
            //dgvServidoresSQL.Rows[3].Cells[0].Value = "MOLINO61"; dgvServidoresSQL.Rows[3].Cells[1].Value = "MOLINO61"; dgvServidoresSQL.Rows[3].Cells[2].Value = "2008 Standard"; dgvServidoresSQL.Rows[3].Cells[3].Value = "ControlAcceso";

            //dgvServidoresSQL.RowHeadersVisible = false;
            //dgvServidoresSQL.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgvServidoresSQL.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            //foreach (DataGridViewColumn c in dgvServidoresSQL.Columns) { c.Resizable = DataGridViewTriState.False; c.ReadOnly = true; }
            FormatearDatagrid(dgvServidoresSQL);
            dgvServidoresSQL.ClearSelection();
        }

        //Rutinas para acceso a árbol de menpu principal.
        private void ActualizarAccesoMenuPrincipal()
        {
            Form auxFormularioMDI = this.MdiParent;
            MenuStrip auxMenu = null;
            foreach (Control auxControl in auxFormularioMDI.Controls)
            {
                if (auxControl.GetType() == typeof(System.Windows.Forms.MenuStrip))
                {
                    auxMenu = (MenuStrip)auxControl;

                    //ToolStripItem ts = auxMenu.OwnerItem;

                    CuentaNivel = 0;
                    GrabarMenuPrincipal(Properties.Settings.Default.IDSistema, CuentaNivel, auxMenu.Name, auxMenu.Text, auxMenu.Text, "raiz", "MenuPrincipal");    //ag.ToString());
                    //MessageBox.Show(auxMenu.Name + " - " + auxMenu.Text);
                    foreach (ToolStripMenuItem m in auxMenu.Items)
                    {
                        //MessageBox.Show(m.Name + " - " + m.Text);
                        //ToolStripItem ts = m.OwnerItem;
                        CuentaNivel = 1;
                        GrabarMenuPrincipal(Properties.Settings.Default.IDSistema, CuentaNivel, m.Name, m.Text, m.Text, auxMenu.Name, m.Tag.ToString());  // m.Tag.ToString());
                        if (m.DropDownItems.Count > 0)
                        {
                            CuentaNivel++;
                            EscanearArbolDeMenu(m.DropDownItems, m.Name);
                        }
                    }
                }
            }
            GrabarFuncionalidadMenuAPerfiles(Properties.Settings.Default.IDSistema);
        }
        private void GrabarMenuPrincipal(int pIDSistema, int pNivel, string pIDMenu, string pTexto, string pDescripcion, string pIDMenuPadre, string pIDFormularioQueInvoca)
        {
            ContadorMenu++;
            //SqlConnection cnControlAcceso = new SqlConnection("server=" + Properties.Settings.Default.ServidorSQLCentral + ";Integrated security=true;database=ControlAcceso");
            SqlConnection cnControlAcceso = new SqlConnection(cConexionSQL);
            SqlCommand cmActualizar = new SqlCommand("pa_ActualizarFuncionalidadMenuPrincipal", cnControlAcceso);
            cmActualizar.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;
            auxParametro = cmActualizar.Parameters.Add("@IDSistema", SqlDbType.Int);
            auxParametro = cmActualizar.Parameters.Add("@IDMenu", SqlDbType.VarChar, 100);
            auxParametro = cmActualizar.Parameters.Add("@Texto", SqlDbType.VarChar, 100);
            auxParametro = cmActualizar.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100);
            auxParametro = cmActualizar.Parameters.Add("@IDMenuPadre", SqlDbType.VarChar, 100);
            auxParametro = cmActualizar.Parameters.Add("@IDFormularioQueInvoca", SqlDbType.VarChar, 100);
            auxParametro = cmActualizar.Parameters.Add("@Resultado", SqlDbType.VarChar, 300);
            auxParametro.Direction = ParameterDirection.Output;

            cmActualizar.Parameters["@IDSistema"].Value = pIDSistema;
            cmActualizar.Parameters["@IDMenu"].Value = pIDMenu;
            cmActualizar.Parameters["@Texto"].Value = pTexto;
            cmActualizar.Parameters["@Descripcion"].Value = pDescripcion;
            cmActualizar.Parameters["@IDMenuPadre"].Value = pIDMenuPadre;
            cmActualizar.Parameters["@IDFormularioQueInvoca"].Value = pIDFormularioQueInvoca;
            try
            {
                cnControlAcceso.Open();
                cmActualizar.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ooops, hubo un problema al recuperar información de su clave de acceso." + (char)13 + ex.ToString());
            }
            cmActualizar.Connection.Close(); cmActualizar.Dispose();
            cnControlAcceso.Close(); cnControlAcceso.Dispose();
        }
        private void EscanearArbolDeMenu(ToolStripItemCollection pItemMenu, string pMenuPadre)
        {
            foreach (ToolStripItem item in pItemMenu)
            {
                if (item.GetType() == typeof(ToolStripMenuItem))
                {
                    ToolStripItem ts = item.OwnerItem;

                    //GrabarFuncionalidad(Properties.Settings.Default.IDSistema, item.Name, "menu", item.Text, ts.Owner.Parent.Name, ts.Owner.Parent.Text + ts.Owner.Parent.Tag.ToString(), item.Tag.ToString(), pMenuPadre, "Submenu");
                    GrabarMenuPrincipal(Properties.Settings.Default.IDSistema, CuentaNivel, item.Name, item.Text, item.Text.ToString(), ts.Name, item.Tag.ToString());
                    //Si el tag del item, no es igal a "fPrincipal" y no es "-", es un formulario del sistema
                    //se debe analizar si tiene botones.


                    if (((ToolStripMenuItem)item).DropDownItems.Count > 0)
                    {
                        CuentaNivel++;
                        EscanearArbolDeMenu(((ToolStripMenuItem)item).DropDownItems, item.Name);
                    }
                }
            }

        }
        private void GrabarFuncionalidadMenuAPerfiles(int pIDSistema)
        {
            ContadorMenu++;
            //SqlConnection cnControlAcceso = new SqlConnection("server=" + Properties.Settings.Default.ServidorSQLCentral + ";Integrated security=true;database=ControlAcceso");
            SqlConnection cnControlAcceso = new SqlConnection(cConexionSQL);
            SqlCommand cmActualizar = new SqlCommand("pa_ActualizarFuncionalidadMenuAPerfiles", cnControlAcceso);
            cmActualizar.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;
            auxParametro = cmActualizar.Parameters.Add("@IDSistema", SqlDbType.Int);
            auxParametro = cmActualizar.Parameters.Add("@Resultado", SqlDbType.VarChar, 300);
            auxParametro.Direction = ParameterDirection.Output;

            cmActualizar.Parameters["@IDSistema"].Value = pIDSistema;
            try
            {
                cnControlAcceso.Open();
                cmActualizar.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ooops, hubo un problema al grabar la fase 2." + (char)13 + ex.ToString());
            }
            cmActualizar.Connection.Close(); cmActualizar.Dispose();
            cnControlAcceso.Close(); cnControlAcceso.Dispose();
        }              



        //Rutinas para acceso a funcionalidad dentro de formulario.
        private void RecursivoFuncionalidad(Form pFormulario, Control pControl)
        {
            foreach (Control c in pControl.Controls)
            {
                if (/*c.GetType() != typeof(Button) && */c.GetType() != typeof(ToolStrip) && c.GetType() != typeof(Label) && c.GetType() != typeof(Splitter))
                {
                    //GrabarFuncionalidadBoton(Properties.Settings.Default.IDSistema, pFormulario.Name, c.Name, c.Text, c.GetType().ToString(), c.Parent.Name);
                    GrabarFuncionalidadBoton(Properties.Settings.Default.IDSistema, pFormulario.Name, c.Name, EscanearNombreSinPrefijos(c.GetType().ToString()) + c.Name, c.GetType().ToString(), c.Parent.Name);
                    if (c.Controls.Count > 0) { RecursivoFuncionalidad(pFormulario, c); }
                }

                if (c.GetType() == typeof(ToolStrip))
                {
                    GrabarFuncionalidadBoton(Properties.Settings.Default.IDSistema, pFormulario.Name, c.Name, "Barra de botones: " + c.Name, c.GetType().ToString(), c.Parent.Name);
                    ToolStrip t = (ToolStrip)c;
                    foreach (ToolStripItem tsi in t.Items)
                    {
                        ToolStrip auxToolStrip = tsi.Owner;
                        GrabarFuncionalidadBoton(Properties.Settings.Default.IDSistema, pFormulario.Name, tsi.Name, "Botón de barra: " + tsi.Text, c.GetType().ToString(), auxToolStrip.Name);
                    }
                }

            }
        }
        private void GrabarFuncionalidadBoton(int pIDSistema, string pFormularioContenedor, string pFuncionalidad, string pTexto, string pTipo, string pFuncionalidadPadre)
        {
            ContadorMenu++;
            //SqlConnection cnControlAcceso = new SqlConnection("server=" + Properties.Settings.Default.ServidorSQLCentral + ";Integrated security=true;database=ControlAcceso");
            SqlConnection cnControlAcceso = new SqlConnection(cConexionSQL);
            SqlCommand cmActualizar = new SqlCommand("pa_ActualizarFuncionalidadBoton", cnControlAcceso);
            cmActualizar.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;
            auxParametro = cmActualizar.Parameters.Add("@IDSistema", SqlDbType.Int);
            auxParametro = cmActualizar.Parameters.Add("@FormularioContenedor", SqlDbType.VarChar, 100);
            auxParametro = cmActualizar.Parameters.Add("@Funcionalidad", SqlDbType.VarChar, 100);
            auxParametro = cmActualizar.Parameters.Add("@Texto", SqlDbType.VarChar, 100);
            auxParametro = cmActualizar.Parameters.Add("@TipoFuncionalidad", SqlDbType.VarChar, 50);
            auxParametro = cmActualizar.Parameters.Add("@FuncionalidadPadre", SqlDbType.VarChar, 100);
            auxParametro = cmActualizar.Parameters.Add("@Resultado", SqlDbType.VarChar, 300);
            auxParametro.Direction = ParameterDirection.Output;

            cmActualizar.Parameters["@IDSistema"].Value = pIDSistema;
            cmActualizar.Parameters["@FormularioContenedor"].Value = pFormularioContenedor;
            cmActualizar.Parameters["@Funcionalidad"].Value = pFuncionalidad;
            cmActualizar.Parameters["@Texto"].Value = pTexto;
            cmActualizar.Parameters["@TipoFuncionalidad"].Value = pTipo;
            cmActualizar.Parameters["@FuncionalidadPadre"].Value = pFuncionalidadPadre;
            try
            {
                cnControlAcceso.Open();
                cmActualizar.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ooops, hubo un problema al recuperar información de su clave de acceso." + (char)13 + ex.ToString());
            }
            cmActualizar.Connection.Close(); cmActualizar.Dispose();
            cnControlAcceso.Close(); cnControlAcceso.Dispose();
        }
        private void GrabarFuncionalidadBotonAPerfiles(int pIDSistema)
        {
            ContadorMenu++;
            //SqlConnection cnControlAcceso = new SqlConnection("server=" + Properties.Settings.Default.ServidorSQLCentral + ";Integrated security=true;database=ControlAcceso");
            SqlConnection cnControlAcceso = new SqlConnection(cConexionSQL);
            SqlCommand cmActualizar = new SqlCommand("pa_ActualizarFuncionalidadBotonAPerfiles", cnControlAcceso);
            cmActualizar.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;
            auxParametro = cmActualizar.Parameters.Add("@IDSistema", SqlDbType.Int);
            auxParametro = cmActualizar.Parameters.Add("@Resultado", SqlDbType.VarChar, 300);
            auxParametro.Direction = ParameterDirection.Output;

            cmActualizar.Parameters["@IDSistema"].Value = pIDSistema;
            try
            {
                cnControlAcceso.Open();
                cmActualizar.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ooops, hubo un problema al grabar la fase 2." + (char)13 + ex.ToString());
            }
            cmActualizar.Connection.Close(); cmActualizar.Dispose();
            cnControlAcceso.Close(); cnControlAcceso.Dispose();
        }
        private string EscanearNombreSinPrefijos(string pTipo)
        {
            string auxNombre = "";
            for (int i = pTipo.Length - 1; i > 0; i--)
            {
                if (pTipo.Substring(i, 1) != ".")
                {
                    auxNombre = pTipo.Substring(i, 1) + auxNombre;
                }
                else
                {
                    break;
                }
            }
            return auxNombre +": ";
        }
        private void ActualizarFuncionalidadBoton()
        {
            Type[] AllTypesInProjects = Assembly.GetExecutingAssembly().GetTypes();
            for (int i = 0; i < AllTypesInProjects.Length; i++)
            {
                if (AllTypesInProjects[i].BaseType == typeof(Form))
                {            /* Convert Type to Object */
                    Form f = (Form)Activator.CreateInstance(AllTypesInProjects[i]);
                    string FormText = f.Text;
                    //MessageBox.Show(f.Name);    // listBox1.Items.Add(FormText);
                    //if (f.Name == "fEtiquetas") { RecursivoFuncionalidad(f, (Control)f); }
                    GrabarFuncionalidadBoton(Properties.Settings.Default.IDSistema, f.Name, f.Name, "Formulario contenedor: " + f.Name, f.GetType().ToString(), "raiz");
                    RecursivoFuncionalidad(f, (Control)f);
                }
            }
            GrabarFuncionalidadBotonAPerfiles(Properties.Settings.Default.IDSistema);
            //MessageBox.Show("Listo.");
        }


        private void fAcercaDe_Load(object sender, EventArgs e)
        {
            labVersion.Text = "Versión: " + Properties.Settings.Default.VersionSistema;
            ObtenerServidoresSQLDisponibles();
            labConexion.Text = "";
        }
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        private void buttonGrabarMenu_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            foreach (DataGridViewRow fila in dgvServidoresSQL.Rows)
            {
                cConexionSQL = "server=" + fila.Cells[1].Value.ToString().Trim() + ";";             //Agrega la instancia SQL desde el datagrid.
                cConexionSQL += "database=" + fila.Cells[3].Value.ToString().Trim() + ";";          //Agrega la base de datos desdel el datagrid.
                //if (fila.Cells[2].Value.ToString().ToUpper().IndexOf("EXPRESS") > -1)
                if (fila.Cells[4].Value.ToString() == "0")
                {
                    cConexionSQL += "Integrated security = false;User=sa;Password=molinera";
                }
                else
                {
                    cConexionSQL += "Integrated security = true";
                }
                labConexion.Text = "Actualizando acceso a menu en: " + cConexionSQL;
                Application.DoEvents();
                ActualizarAccesoMenuPrincipal();
            }
            labConexion.Text = "";
            this.Cursor = Cursors.Default;
            MessageBox.Show("Listo.");
        }
        private void bGrabarBoton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            foreach (DataGridViewRow fila in dgvServidoresSQL.Rows)
            {
                cConexionSQL = "server=" + fila.Cells[1].Value.ToString().Trim() + ";";       //Agrega la instancia SQL desde el datagrid.
                cConexionSQL += "database=" + fila.Cells[3].Value.ToString().Trim() + ";";     //Agrega la base de datos desdel el datagrid.
                //if (fila.Cells[2].Value.ToString().ToUpper().IndexOf("EXPRESS") > -1)
                if (fila.Cells[4].Value.ToString() == "0")
                {
                    cConexionSQL += "Integrated security = false;User=sa;Password=molinera";
                }
                else
                {
                    cConexionSQL += "Integrated security = true";
                }
                labConexion.Text = "Actualizando funcionalidad en: " + cConexionSQL;
                Application.DoEvents();
                ActualizarFuncionalidadBoton();
            }
            labConexion.Text = "";
            this.Cursor = Cursors.Default;
            MessageBox.Show("Listo.");

        }

        //Rutinas en prueba, no terminadas.
        private void MarcarItemsDeMenuParaEliminacion(int pIDSistema)
        {
            SqlConnection cnControlAcceso = new SqlConnection("server=MOLINO2;Integrated security=true;database=ControlAcceso");
            SqlCommand cmBorrar = new SqlCommand("pa_ActualizarItemDeMenuBorrado", cnControlAcceso);
            cmBorrar.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;
            auxParametro = cmBorrar.Parameters.Add("@IDSistema", SqlDbType.Int);
            auxParametro = cmBorrar.Parameters.Add("@Resultado", SqlDbType.VarChar, 300);
            auxParametro.Direction = ParameterDirection.Output;
            cmBorrar.Parameters["@IDSistema"].Value = pIDSistema;
            cnControlAcceso.Open();
            cmBorrar.ExecuteNonQuery();
            cmBorrar.Connection.Close();
            cmBorrar.Dispose();
        }
        private void GrabarItemDeMenu(int pIDSistema, string pMenu, string pTexto, string pFormulario, string pMenuPadre)
        {
            ContadorMenu++;
            SqlConnection cnControlAcceso = new SqlConnection("server=" + Properties.Settings.Default.ServidorSQLMaestroEntidades + ";Integrated security=true;database=ControlAcceso");
            SqlCommand cmActualizar = new SqlCommand("pa_ActualizarItemDeMenu", cnControlAcceso);
            cmActualizar.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;
            auxParametro = cmActualizar.Parameters.Add("@IDSistema", SqlDbType.Int);
            auxParametro = cmActualizar.Parameters.Add("@Menu", SqlDbType.VarChar, 50);
            auxParametro = cmActualizar.Parameters.Add("@Texto", SqlDbType.VarChar, 50);
            auxParametro = cmActualizar.Parameters.Add("@Formulario", SqlDbType.VarChar, 50);
            auxParametro = cmActualizar.Parameters.Add("@MenuPadre", SqlDbType.VarChar, 50);
            auxParametro = cmActualizar.Parameters.Add("@ContadorMenu", SqlDbType.Int);
            auxParametro = cmActualizar.Parameters.Add("@Resultado", SqlDbType.VarChar, 300);
            auxParametro.Direction = ParameterDirection.Output;

            cmActualizar.Parameters["@IDSistema"].Value = pIDSistema;
            cmActualizar.Parameters["@Menu"].Value = pMenu;
            cmActualizar.Parameters["@Texto"].Value = pTexto;
            cmActualizar.Parameters["@Formulario"].Value = pFormulario;
            cmActualizar.Parameters["@MenuPadre"].Value = pMenuPadre;
            cmActualizar.Parameters["@ContadorMenu"].Value = ContadorMenu;
            try
            {
                cnControlAcceso.Open();
                cmActualizar.ExecuteNonQuery();
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Ooops, hubo un problema al recuperar información de su clave de acceso." + (char)13 + ex.ToString());
            }
            cmActualizar.Connection.Close(); cmActualizar.Dispose();
            cnControlAcceso.Close(); cnControlAcceso.Dispose();
        }

       
        
    }
}
