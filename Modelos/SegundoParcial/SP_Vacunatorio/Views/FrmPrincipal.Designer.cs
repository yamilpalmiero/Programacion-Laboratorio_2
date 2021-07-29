
namespace Views
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
            this.btnXML = new System.Windows.Forms.Button();
            this.btnBD = new System.Windows.Forms.Button();
            this.btnBinario = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblActualizar = new System.Windows.Forms.Label();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.rtbActualizar = new System.Windows.Forms.RichTextBox();
            this.ofdImportar = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnXML
            // 
            this.btnXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXML.Location = new System.Drawing.Point(29, 23);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(468, 134);
            this.btnXML.TabIndex = 0;
            this.btnXML.Text = "Importar de XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // btnBD
            // 
            this.btnBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBD.Location = new System.Drawing.Point(29, 163);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(468, 134);
            this.btnBD.TabIndex = 1;
            this.btnBD.Text = "Importar de BD";
            this.btnBD.UseVisualStyleBackColor = true;
            this.btnBD.Click += new System.EventHandler(this.btnBD_Click);
            // 
            // btnBinario
            // 
            this.btnBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinario.Location = new System.Drawing.Point(29, 303);
            this.btnBinario.Name = "btnBinario";
            this.btnBinario.Size = new System.Drawing.Size(468, 134);
            this.btnBinario.TabIndex = 2;
            this.btnBinario.Text = "Importar de Binario";
            this.btnBinario.UseVisualStyleBackColor = true;
            this.btnBinario.Click += new System.EventHandler(this.btnBinario_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(29, 443);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(468, 134);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblActualizar
            // 
            this.lblActualizar.AutoSize = true;
            this.lblActualizar.Location = new System.Drawing.Point(352, 599);
            this.lblActualizar.Name = "lblActualizar";
            this.lblActualizar.Size = new System.Drawing.Size(70, 17);
            this.lblActualizar.TabIndex = 4;
            this.lblActualizar.Text = "Actualizar";
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(48, 614);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(193, 69);
            this.btnComenzar.TabIndex = 5;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // rtbActualizar
            // 
            this.rtbActualizar.Location = new System.Drawing.Point(275, 625);
            this.rtbActualizar.Name = "rtbActualizar";
            this.rtbActualizar.Size = new System.Drawing.Size(209, 118);
            this.rtbActualizar.TabIndex = 6;
            this.rtbActualizar.Text = "";
            // 
            // ofdImportar
            // 
            this.ofdImportar.FileName = "Seleccionar";
            this.ofdImportar.Filter = "Archivos de texto (*.txt)|*.txt";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 794);
            this.Controls.Add(this.rtbActualizar);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.lblActualizar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBinario);
            this.Controls.Add(this.btnBD);
            this.Controls.Add(this.btnXML);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vacunatorio UTN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.Button btnBD;
        private System.Windows.Forms.Button btnBinario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblActualizar;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.RichTextBox rtbActualizar;
        private System.Windows.Forms.OpenFileDialog ofdImportar;
    }
}

