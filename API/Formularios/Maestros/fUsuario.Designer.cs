namespace API.Formularios.Maestros
{
    partial class fUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsMarca = new System.Windows.Forms.ToolStrip();
            this.tsbCerrarUsu = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsEditarUsu = new System.Windows.Forms.ToolStripButton();
            this.tsbGrabarUsu = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevoUsu = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelarUsu = new System.Windows.Forms.ToolStripButton();
            this.tslUsuario = new System.Windows.Forms.ToolStripLabel();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.lblidUsuario = new System.Windows.Forms.Label();
            this.txtNombreUser = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbPlanta = new System.Windows.Forms.ComboBox();
            this.lblPlanta = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.dgListaUsuarios = new System.Windows.Forms.DataGridView();
            this.tsMarca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMarca
            // 
            this.tsMarca.BackColor = System.Drawing.Color.Transparent;
            this.tsMarca.BackgroundImage = global::API.Properties.Resources.BarraBotones;
            this.tsMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsMarca.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCerrarUsu,
            this.tsbEliminar,
            this.tsEditarUsu,
            this.tsbGrabarUsu,
            this.tsbNuevoUsu,
            this.tsbCancelarUsu,
            this.tslUsuario});
            this.tsMarca.Location = new System.Drawing.Point(0, 0);
            this.tsMarca.Name = "tsMarca";
            this.tsMarca.Size = new System.Drawing.Size(899, 25);
            this.tsMarca.TabIndex = 66;
            this.tsMarca.Text = "toolStrip1";
            this.tsMarca.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsMarca_MouseDown);
            // 
            // tsbCerrarUsu
            // 
            this.tsbCerrarUsu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrarUsu.AutoSize = false;
            this.tsbCerrarUsu.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsbCerrarUsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbCerrarUsu.Image = global::API.Properties.Resources.Cerrar_16;
            this.tsbCerrarUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbCerrarUsu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrarUsu.Name = "tsbCerrarUsu";
            this.tsbCerrarUsu.Size = new System.Drawing.Size(70, 22);
            this.tsbCerrarUsu.Text = "Cerrar";
            this.tsbCerrarUsu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbCerrarUsu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbCerrarUsu.Click += new System.EventHandler(this.tsbCerrarUsu_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbEliminar.AutoSize = false;
            this.tsbEliminar.Enabled = false;
            this.tsbEliminar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsbEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(80, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbEliminar.Visible = false;
            // 
            // tsEditarUsu
            // 
            this.tsEditarUsu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsEditarUsu.AutoSize = false;
            this.tsEditarUsu.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsEditarUsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsEditarUsu.Image = global::API.Properties.Resources.Modificar;
            this.tsEditarUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsEditarUsu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEditarUsu.Name = "tsEditarUsu";
            this.tsEditarUsu.Size = new System.Drawing.Size(80, 22);
            this.tsEditarUsu.Text = "Editar";
            this.tsEditarUsu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsEditarUsu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsEditarUsu.Visible = false;
            // 
            // tsbGrabarUsu
            // 
            this.tsbGrabarUsu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbGrabarUsu.AutoSize = false;
            this.tsbGrabarUsu.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsbGrabarUsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbGrabarUsu.Image = global::API.Properties.Resources.Grabar2;
            this.tsbGrabarUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbGrabarUsu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGrabarUsu.Name = "tsbGrabarUsu";
            this.tsbGrabarUsu.Size = new System.Drawing.Size(80, 22);
            this.tsbGrabarUsu.Text = "Grabar";
            this.tsbGrabarUsu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbGrabarUsu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbGrabarUsu.Click += new System.EventHandler(this.tsbGrabar_Click);
            // 
            // tsbNuevoUsu
            // 
            this.tsbNuevoUsu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbNuevoUsu.AutoSize = false;
            this.tsbNuevoUsu.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsbNuevoUsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbNuevoUsu.Image = global::API.Properties.Resources.Nuevo_18;
            this.tsbNuevoUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbNuevoUsu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevoUsu.Name = "tsbNuevoUsu";
            this.tsbNuevoUsu.Size = new System.Drawing.Size(80, 22);
            this.tsbNuevoUsu.Text = "Nuevo";
            this.tsbNuevoUsu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbNuevoUsu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbNuevoUsu.Click += new System.EventHandler(this.tsbNuevoUsu_Click);
            // 
            // tsbCancelarUsu
            // 
            this.tsbCancelarUsu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCancelarUsu.AutoSize = false;
            this.tsbCancelarUsu.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsbCancelarUsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbCancelarUsu.Image = global::API.Properties.Resources.cancel_icon;
            this.tsbCancelarUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbCancelarUsu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelarUsu.Name = "tsbCancelarUsu";
            this.tsbCancelarUsu.Size = new System.Drawing.Size(90, 22);
            this.tsbCancelarUsu.Text = "Cancelar";
            this.tsbCancelarUsu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbCancelarUsu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbCancelarUsu.Click += new System.EventHandler(this.tsbCancelarUsu_Click);
            // 
            // tslUsuario
            // 
            this.tslUsuario.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tslUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tslUsuario.Name = "tslUsuario";
            this.tslUsuario.Size = new System.Drawing.Size(56, 22);
            this.tslUsuario.Text = "Usuario";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.Location = new System.Drawing.Point(576, 51);
            this.txtIdUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(72, 25);
            this.txtIdUsuario.TabIndex = 75;
            this.txtIdUsuario.Visible = false;
            // 
            // lblidUsuario
            // 
            this.lblidUsuario.AutoSize = true;
            this.lblidUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidUsuario.Location = new System.Drawing.Point(503, 55);
            this.lblidUsuario.Name = "lblidUsuario";
            this.lblidUsuario.Size = new System.Drawing.Size(64, 17);
            this.lblidUsuario.TabIndex = 74;
            this.lblidUsuario.Text = "idUsuario";
            this.lblidUsuario.Visible = false;
            // 
            // txtNombreUser
            // 
            this.txtNombreUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUser.Location = new System.Drawing.Point(184, 216);
            this.txtNombreUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreUser.Name = "txtNombreUser";
            this.txtNombreUser.Size = new System.Drawing.Size(182, 25);
            this.txtNombreUser.TabIndex = 73;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(73, 219);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(106, 17);
            this.lblNombreUsuario.TabIndex = 72;
            this.lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(123, 186);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(56, 17);
            this.lblApellido.TabIndex = 71;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(184, 183);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(182, 25);
            this.txtApellido.TabIndex = 70;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(184, 150);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(182, 25);
            this.txtNombre.TabIndex = 69;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(122, 153);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 17);
            this.lblNombre.TabIndex = 68;
            this.lblNombre.Text = "Nombre";
            // 
            // cmbPlanta
            // 
            this.cmbPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlanta.FormattingEnabled = true;
            this.cmbPlanta.Location = new System.Drawing.Point(184, 84);
            this.cmbPlanta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPlanta.Name = "cmbPlanta";
            this.cmbPlanta.Size = new System.Drawing.Size(229, 25);
            this.cmbPlanta.TabIndex = 79;
            this.cmbPlanta.SelectionChangeCommitted += new System.EventHandler(this.cmbPlanta_SelectionChangeCommitted);
            // 
            // lblPlanta
            // 
            this.lblPlanta.AutoSize = true;
            this.lblPlanta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanta.Location = new System.Drawing.Point(136, 87);
            this.lblPlanta.Name = "lblPlanta";
            this.lblPlanta.Size = new System.Drawing.Size(43, 17);
            this.lblPlanta.TabIndex = 78;
            this.lblPlanta.Text = "Planta";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(120, 55);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(59, 17);
            this.lblEmpresa.TabIndex = 77;
            this.lblEmpresa.Text = "Empresa";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(184, 51);
            this.cmbEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(229, 25);
            this.cmbEmpresa.TabIndex = 76;
            this.cmbEmpresa.SelectionChangeCommitted += new System.EventHandler(this.cmbEmpresa_SelectionChangeCommitted);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(134, 252);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(44, 17);
            this.lblCargo.TabIndex = 80;
            this.lblCargo.Text = "Cargo";
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(184, 249);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(182, 25);
            this.txtCargo.TabIndex = 81;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(457, 156);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 17);
            this.lblEmail.TabIndex = 82;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(502, 153);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(182, 25);
            this.txtEmail.TabIndex = 83;            
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(438, 189);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(58, 17);
            this.lblTelefono.TabIndex = 84;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(502, 186);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(87, 25);
            this.txtTelefono.TabIndex = 85;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(144, 120);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(35, 17);
            this.lblArea.TabIndex = 87;
            this.lblArea.Text = "Área";
            // 
            // cmbArea
            // 
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(184, 117);
            this.cmbArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(229, 25);
            this.cmbArea.TabIndex = 88;
            this.cmbArea.SelectionChangeCommitted += new System.EventHandler(this.cmbArea_SelectionChangeCommitted);
            // 
            // dgListaUsuarios
            // 
            this.dgListaUsuarios.AllowUserToAddRows = false;
            this.dgListaUsuarios.AllowUserToDeleteRows = false;
            this.dgListaUsuarios.AllowUserToResizeColumns = false;
            this.dgListaUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.dgListaUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgListaUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgListaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgListaUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(152)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgListaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgListaUsuarios.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgListaUsuarios.Location = new System.Drawing.Point(76, 292);
            this.dgListaUsuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgListaUsuarios.MultiSelect = false;
            this.dgListaUsuarios.Name = "dgListaUsuarios";
            this.dgListaUsuarios.ReadOnly = true;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.dgListaUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgListaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListaUsuarios.Size = new System.Drawing.Size(750, 173);
            this.dgListaUsuarios.TabIndex = 190;
            this.dgListaUsuarios.TabStop = false;
            // 
            // fUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 500);
            this.Controls.Add(this.dgListaUsuarios);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.cmbPlanta);
            this.Controls.Add(this.lblPlanta);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.lblidUsuario);
            this.Controls.Add(this.txtNombreUser);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tsMarca);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fUsuario";
            this.Text = "fUsuario";
            this.Load += new System.EventHandler(this.fUsuario_Load);
            this.tsMarca.ResumeLayout(false);
            this.tsMarca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMarca;
        private System.Windows.Forms.ToolStripButton tsbCerrarUsu;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsEditarUsu;
        private System.Windows.Forms.ToolStripButton tsbGrabarUsu;
        private System.Windows.Forms.ToolStripButton tsbNuevoUsu;
        private System.Windows.Forms.ToolStripButton tsbCancelarUsu;
        private System.Windows.Forms.ToolStripLabel tslUsuario;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label lblidUsuario;
        private System.Windows.Forms.TextBox txtNombreUser;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbPlanta;
        private System.Windows.Forms.Label lblPlanta;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.DataGridView dgListaUsuarios;
    }
}