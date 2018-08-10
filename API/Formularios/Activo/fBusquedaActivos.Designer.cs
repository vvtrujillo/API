namespace API.Formularios.Activo
{
    partial class fBusquedaActivos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblUsuarioAscAct = new System.Windows.Forms.Label();
            this.txtUsuarioBuscarAct = new System.Windows.Forms.TextBox();
            this.btnBuscarUsuarioAct = new System.Windows.Forms.Button();
            this.dgListaHardwareUser = new System.Windows.Forms.DataGridView();
            this.gbListHardware = new System.Windows.Forms.GroupBox();
            this.gbListSoftware = new System.Windows.Forms.GroupBox();
            this.dgListaSoftwareUser = new System.Windows.Forms.DataGridView();
            this.tsBusquedaxUsuario = new System.Windows.Forms.ToolStrip();
            this.tsbCerrarBusqActixUsuario = new System.Windows.Forms.ToolStripButton();
            this.tslBusquedaActxUsuario = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaHardwareUser)).BeginInit();
            this.gbListHardware.SuspendLayout();
            this.gbListSoftware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaSoftwareUser)).BeginInit();
            this.tsBusquedaxUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuarioAscAct
            // 
            this.lblUsuarioAscAct.AutoSize = true;
            this.lblUsuarioAscAct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioAscAct.Location = new System.Drawing.Point(12, 43);
            this.lblUsuarioAscAct.Name = "lblUsuarioAscAct";
            this.lblUsuarioAscAct.Size = new System.Drawing.Size(53, 17);
            this.lblUsuarioAscAct.TabIndex = 67;
            this.lblUsuarioAscAct.Text = "Usuario";
            // 
            // txtUsuarioBuscarAct
            // 
            this.txtUsuarioBuscarAct.Enabled = false;
            this.txtUsuarioBuscarAct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioBuscarAct.Location = new System.Drawing.Point(71, 40);
            this.txtUsuarioBuscarAct.Name = "txtUsuarioBuscarAct";
            this.txtUsuarioBuscarAct.Size = new System.Drawing.Size(100, 25);
            this.txtUsuarioBuscarAct.TabIndex = 69;
            // 
            // btnBuscarUsuarioAct
            // 
            this.btnBuscarUsuarioAct.Image = global::API.Properties.Resources.Buscar_16;
            this.btnBuscarUsuarioAct.Location = new System.Drawing.Point(177, 40);
            this.btnBuscarUsuarioAct.Name = "btnBuscarUsuarioAct";
            this.btnBuscarUsuarioAct.Size = new System.Drawing.Size(28, 25);
            this.btnBuscarUsuarioAct.TabIndex = 68;
            this.btnBuscarUsuarioAct.UseVisualStyleBackColor = true;
            this.btnBuscarUsuarioAct.Click += new System.EventHandler(this.btnBuscarUsuarioAct_Click);
            // 
            // dgListaHardwareUser
            // 
            this.dgListaHardwareUser.AllowUserToAddRows = false;
            this.dgListaHardwareUser.AllowUserToDeleteRows = false;
            this.dgListaHardwareUser.AllowUserToResizeColumns = false;
            this.dgListaHardwareUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.dgListaHardwareUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgListaHardwareUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgListaHardwareUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgListaHardwareUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(152)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgListaHardwareUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgListaHardwareUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgListaHardwareUser.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgListaHardwareUser.Location = new System.Drawing.Point(6, 20);
            this.dgListaHardwareUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgListaHardwareUser.MultiSelect = false;
            this.dgListaHardwareUser.Name = "dgListaHardwareUser";
            this.dgListaHardwareUser.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.dgListaHardwareUser.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgListaHardwareUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListaHardwareUser.Size = new System.Drawing.Size(554, 138);
            this.dgListaHardwareUser.TabIndex = 190;
            this.dgListaHardwareUser.TabStop = false;
            // 
            // gbListHardware
            // 
            this.gbListHardware.Controls.Add(this.dgListaHardwareUser);
            this.gbListHardware.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListHardware.Location = new System.Drawing.Point(6, 74);
            this.gbListHardware.Name = "gbListHardware";
            this.gbListHardware.Size = new System.Drawing.Size(573, 165);
            this.gbListHardware.TabIndex = 191;
            this.gbListHardware.TabStop = false;
            this.gbListHardware.Text = "Hardware";
            // 
            // gbListSoftware
            // 
            this.gbListSoftware.Controls.Add(this.dgListaSoftwareUser);
            this.gbListSoftware.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListSoftware.Location = new System.Drawing.Point(6, 245);
            this.gbListSoftware.Name = "gbListSoftware";
            this.gbListSoftware.Size = new System.Drawing.Size(573, 176);
            this.gbListSoftware.TabIndex = 192;
            this.gbListSoftware.TabStop = false;
            this.gbListSoftware.Text = "Software";
            // 
            // dgListaSoftwareUser
            // 
            this.dgListaSoftwareUser.AllowUserToAddRows = false;
            this.dgListaSoftwareUser.AllowUserToDeleteRows = false;
            this.dgListaSoftwareUser.AllowUserToResizeColumns = false;
            this.dgListaSoftwareUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.dgListaSoftwareUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgListaSoftwareUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgListaSoftwareUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgListaSoftwareUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(152)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgListaSoftwareUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgListaSoftwareUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgListaSoftwareUser.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgListaSoftwareUser.Location = new System.Drawing.Point(6, 20);
            this.dgListaSoftwareUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgListaSoftwareUser.MultiSelect = false;
            this.dgListaSoftwareUser.Name = "dgListaSoftwareUser";
            this.dgListaSoftwareUser.ReadOnly = true;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.dgListaSoftwareUser.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgListaSoftwareUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListaSoftwareUser.Size = new System.Drawing.Size(554, 149);
            this.dgListaSoftwareUser.TabIndex = 190;
            this.dgListaSoftwareUser.TabStop = false;
            // 
            // tsBusquedaxUsuario
            // 
            this.tsBusquedaxUsuario.BackColor = System.Drawing.Color.Transparent;
            this.tsBusquedaxUsuario.BackgroundImage = global::API.Properties.Resources.BarraBotones;
            this.tsBusquedaxUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsBusquedaxUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCerrarBusqActixUsuario,
            this.tslBusquedaActxUsuario});
            this.tsBusquedaxUsuario.Location = new System.Drawing.Point(0, 0);
            this.tsBusquedaxUsuario.Name = "tsBusquedaxUsuario";
            this.tsBusquedaxUsuario.Size = new System.Drawing.Size(635, 25);
            this.tsBusquedaxUsuario.TabIndex = 193;
            this.tsBusquedaxUsuario.Text = "toolStrip1";
            this.tsBusquedaxUsuario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsBusquedaxUsuario_MouseDown);
            // 
            // tsbCerrarBusqActixUsuario
            // 
            this.tsbCerrarBusqActixUsuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrarBusqActixUsuario.AutoSize = false;
            this.tsbCerrarBusqActixUsuario.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsbCerrarBusqActixUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbCerrarBusqActixUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbCerrarBusqActixUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrarBusqActixUsuario.Name = "tsbCerrarBusqActixUsuario";
            this.tsbCerrarBusqActixUsuario.Size = new System.Drawing.Size(70, 22);
            this.tsbCerrarBusqActixUsuario.Text = "Cerrar";
            this.tsbCerrarBusqActixUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbCerrarBusqActixUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbCerrarBusqActixUsuario.Click += new System.EventHandler(this.tsbCerrarBusqActixUsuario_Click);
            // 
            // tslBusquedaActxUsuario
            // 
            this.tslBusquedaActxUsuario.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tslBusquedaActxUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tslBusquedaActxUsuario.Name = "tslBusquedaActxUsuario";
            this.tslBusquedaActxUsuario.Size = new System.Drawing.Size(71, 22);
            this.tslBusquedaActxUsuario.Text = "Búsqueda";
            // 
            // fBusquedaActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 475);
            this.Controls.Add(this.tsBusquedaxUsuario);
            this.Controls.Add(this.gbListSoftware);
            this.Controls.Add(this.gbListHardware);
            this.Controls.Add(this.txtUsuarioBuscarAct);
            this.Controls.Add(this.btnBuscarUsuarioAct);
            this.Controls.Add(this.lblUsuarioAscAct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fBusquedaActivos";
            this.Text = "fBusquedaActivos";
            this.Load += new System.EventHandler(this.fBusquedaActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaHardwareUser)).EndInit();
            this.gbListHardware.ResumeLayout(false);
            this.gbListSoftware.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaSoftwareUser)).EndInit();
            this.tsBusquedaxUsuario.ResumeLayout(false);
            this.tsBusquedaxUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuarioAscAct;
        private System.Windows.Forms.TextBox txtUsuarioBuscarAct;
        private System.Windows.Forms.Button btnBuscarUsuarioAct;
        private System.Windows.Forms.DataGridView dgListaHardwareUser;
        private System.Windows.Forms.GroupBox gbListHardware;
        private System.Windows.Forms.GroupBox gbListSoftware;
        private System.Windows.Forms.DataGridView dgListaSoftwareUser;
        private System.Windows.Forms.ToolStrip tsBusquedaxUsuario;
        private System.Windows.Forms.ToolStripButton tsbCerrarBusqActixUsuario;
        private System.Windows.Forms.ToolStripLabel tslBusquedaActxUsuario;
    }
}