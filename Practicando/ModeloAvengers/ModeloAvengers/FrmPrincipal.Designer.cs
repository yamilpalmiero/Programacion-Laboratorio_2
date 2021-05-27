
namespace ModeloAvengers
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMostrarPersonajes = new System.Windows.Forms.Button();
            this.rtbPersonajes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnMostrarPersonajes
            // 
            this.btnMostrarPersonajes.Location = new System.Drawing.Point(240, 34);
            this.btnMostrarPersonajes.Name = "btnMostrarPersonajes";
            this.btnMostrarPersonajes.Size = new System.Drawing.Size(296, 65);
            this.btnMostrarPersonajes.TabIndex = 0;
            this.btnMostrarPersonajes.Text = "Mostrar Personajes";
            this.btnMostrarPersonajes.UseVisualStyleBackColor = true;
            this.btnMostrarPersonajes.Click += new System.EventHandler(this.btnMostrarPersonajes_Click);
            // 
            // rtbPersonajes
            // 
            this.rtbPersonajes.Location = new System.Drawing.Point(21, 123);
            this.rtbPersonajes.Name = "rtbPersonajes";
            this.rtbPersonajes.Size = new System.Drawing.Size(759, 633);
            this.rtbPersonajes.TabIndex = 1;
            this.rtbPersonajes.Text = "";
            this.rtbPersonajes.TextChanged += new System.EventHandler(this.rtbPersonajes_TextChanged);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 771);
            this.Controls.Add(this.rtbPersonajes);
            this.Controls.Add(this.btnMostrarPersonajes);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmPrincipal";
            this.Text = "Yamil.Palmiero.2C";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarPersonajes;
        private System.Windows.Forms.RichTextBox rtbPersonajes;
    }
}

