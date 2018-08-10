namespace API.Fin
{ 
    partial class fAcercaDe
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
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labVersion = new System.Windows.Forms.Label();
            this.labDescripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(425, 201);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(129, 40);
            this.buttonCerrar.TabIndex = 0;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(50, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Administración plataforma informática";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labVersion
            // 
            this.labVersion.BackColor = System.Drawing.Color.Transparent;
            this.labVersion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labVersion.Location = new System.Drawing.Point(247, 35);
            this.labVersion.Name = "labVersion";
            this.labVersion.Size = new System.Drawing.Size(307, 23);
            this.labVersion.TabIndex = 6;
            this.labVersion.Text = "Versión:";
            this.labVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labDescripcion
            // 
            this.labDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.labDescripcion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDescripcion.ForeColor = System.Drawing.Color.White;
            this.labDescripcion.Location = new System.Drawing.Point(12, 153);
            this.labDescripcion.Name = "labDescripcion";
            this.labDescripcion.Size = new System.Drawing.Size(381, 91);
            this.labDescripcion.TabIndex = 8;
            this.labDescripcion.Text = "labDescripcion";
            this.labDescripcion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labDescripcion.Visible = false;
            // 
            // fAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(566, 253);
            this.ControlBox = false;
            this.Controls.Add(this.labDescripcion);
            this.Controls.Add(this.labVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fAcercaDe";
            this.Tag = "Acerca de";
            this.Load += new System.EventHandler(this.fAcercaDe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labVersion;
        private System.Windows.Forms.Label labDescripcion;
    }
}