namespace Desarrollo.Formularios
{
    partial class fListaHW
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
            this.dgObtieneHW = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgObtieneHW)).BeginInit();
            this.SuspendLayout();
            // 
            // dgObtieneHW
            // 
            this.dgObtieneHW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgObtieneHW.Location = new System.Drawing.Point(12, 57);
            this.dgObtieneHW.Name = "dgObtieneHW";
            this.dgObtieneHW.Size = new System.Drawing.Size(977, 261);
            this.dgObtieneHW.TabIndex = 0;
            // 
            // fListaHW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 330);
            this.Controls.Add(this.dgObtieneHW);
            this.Name = "fListaHW";
            this.Text = "fListaHW";
            this.Load += new System.EventHandler(this.fListaHW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgObtieneHW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgObtieneHW;
    }
}