namespace API.Formularios.Auditoria
{
    partial class fAuditoria
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
            this.tsAuditoria = new System.Windows.Forms.ToolStrip();
            this.tsbCerrarAudit = new System.Windows.Forms.ToolStripButton();
            this.tsbAuditoria = new System.Windows.Forms.ToolStripLabel();
            this.dgAuditoria = new System.Windows.Forms.DataGridView();
            this.tsAuditoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAuditoria)).BeginInit();
            this.SuspendLayout();
            // 
            // tsAuditoria
            // 
            this.tsAuditoria.BackColor = System.Drawing.Color.Transparent;
            this.tsAuditoria.BackgroundImage = global::API.Properties.Resources.BarraBotones;
            this.tsAuditoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsAuditoria.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCerrarAudit,
            this.tsbAuditoria});
            this.tsAuditoria.Location = new System.Drawing.Point(0, 0);
            this.tsAuditoria.Name = "tsAuditoria";
            this.tsAuditoria.Size = new System.Drawing.Size(1155, 25);
            this.tsAuditoria.TabIndex = 194;
            this.tsAuditoria.Text = "toolStrip1";
            this.tsAuditoria.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsAuditoria_MouseDown);
            // 
            // tsbCerrarAudit
            // 
            this.tsbCerrarAudit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrarAudit.AutoSize = false;
            this.tsbCerrarAudit.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsbCerrarAudit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbCerrarAudit.Image = global::API.Properties.Resources.Cerrar_16;
            this.tsbCerrarAudit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbCerrarAudit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrarAudit.Name = "tsbCerrarAudit";
            this.tsbCerrarAudit.Size = new System.Drawing.Size(70, 22);
            this.tsbCerrarAudit.Text = "Cerrar";
            this.tsbCerrarAudit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbCerrarAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbCerrarAudit.Click += new System.EventHandler(this.tsbCerrarAudit_Click);
            // 
            // tsbAuditoria
            // 
            this.tsbAuditoria.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tsbAuditoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbAuditoria.Name = "tsbAuditoria";
            this.tsbAuditoria.Size = new System.Drawing.Size(66, 22);
            this.tsbAuditoria.Text = "Auditoria";
            // 
            // dgAuditoria
            // 
            this.dgAuditoria.AllowUserToAddRows = false;
            this.dgAuditoria.AllowUserToDeleteRows = false;
            this.dgAuditoria.AllowUserToResizeColumns = false;
            this.dgAuditoria.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.dgAuditoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgAuditoria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgAuditoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgAuditoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(152)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAuditoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAuditoria.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgAuditoria.Location = new System.Drawing.Point(14, 61);
            this.dgAuditoria.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgAuditoria.MultiSelect = false;
            this.dgAuditoria.Name = "dgAuditoria";
            this.dgAuditoria.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.dgAuditoria.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgAuditoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAuditoria.Size = new System.Drawing.Size(1120, 520);
            this.dgAuditoria.TabIndex = 195;
            this.dgAuditoria.TabStop = false;
            // 
            // fAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 605);
            this.Controls.Add(this.dgAuditoria);
            this.Controls.Add(this.tsAuditoria);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fAuditoria";
            this.Tag = "fAuditoria";
            this.Text = "fAuditoria";
            this.Load += new System.EventHandler(this.fAuditoria_Load);
            this.tsAuditoria.ResumeLayout(false);
            this.tsAuditoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAuditoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsAuditoria;
        private System.Windows.Forms.ToolStripButton tsbCerrarAudit;
        private System.Windows.Forms.ToolStripLabel tsbAuditoria;
        private System.Windows.Forms.DataGridView dgAuditoria;
    }
}