
namespace Palmiero.Yamil._2C
{
    partial class FormularioPrincipal
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
            this.MostrarPersonajes = new System.Windows.Forms.Button();
            this.rtbPersonajes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // MostrarPersonajes
            // 
            this.MostrarPersonajes.Location = new System.Drawing.Point(266, 25);
            this.MostrarPersonajes.Name = "MostrarPersonajes";
            this.MostrarPersonajes.Size = new System.Drawing.Size(269, 45);
            this.MostrarPersonajes.TabIndex = 0;
            this.MostrarPersonajes.Text = "Mostrar Personajes";
            this.MostrarPersonajes.UseVisualStyleBackColor = true;
            this.MostrarPersonajes.Click += new System.EventHandler(this.MostrarPersonajes_Click);
            // 
            // rtbPersonajes
            // 
            this.rtbPersonajes.Location = new System.Drawing.Point(37, 98);
            this.rtbPersonajes.Name = "rtbPersonajes";
            this.rtbPersonajes.Size = new System.Drawing.Size(719, 559);
            this.rtbPersonajes.TabIndex = 1;
            this.rtbPersonajes.Text = "";
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 678);
            this.Controls.Add(this.rtbPersonajes);
            this.Controls.Add(this.MostrarPersonajes);
            this.Name = "FormularioPrincipal";
            this.Text = "Yamil.Palmiero.2C";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MostrarPersonajes;
        private System.Windows.Forms.RichTextBox rtbPersonajes;
    }
}

