
namespace Comiqueria
{
    partial class FrmTester
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
            this.lstStock = new System.Windows.Forms.ListBox();
            this.rtbInforme = new System.Windows.Forms.RichTextBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnVerInforme = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstStock
            // 
            this.lstStock.FormattingEnabled = true;
            this.lstStock.ItemHeight = 16;
            this.lstStock.Location = new System.Drawing.Point(23, 23);
            this.lstStock.Name = "lstStock";
            this.lstStock.Size = new System.Drawing.Size(364, 244);
            this.lstStock.TabIndex = 0;
            // 
            // rtbInforme
            // 
            this.rtbInforme.Location = new System.Drawing.Point(428, 23);
            this.rtbInforme.Name = "rtbInforme";
            this.rtbInforme.Size = new System.Drawing.Size(360, 415);
            this.rtbInforme.TabIndex = 1;
            this.rtbInforme.Text = "";
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(23, 296);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(364, 44);
            this.btnVender.TabIndex = 2;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnVerInforme
            // 
            this.btnVerInforme.Location = new System.Drawing.Point(23, 346);
            this.btnVerInforme.Name = "btnVerInforme";
            this.btnVerInforme.Size = new System.Drawing.Size(364, 44);
            this.btnVerInforme.TabIndex = 3;
            this.btnVerInforme.Text = "Ver &Informe";
            this.btnVerInforme.UseVisualStyleBackColor = true;
            this.btnVerInforme.Click += new System.EventHandler(this.btnVerInforme_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(23, 394);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(364, 44);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 465);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerInforme);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.rtbInforme);
            this.Controls.Add(this.lstStock);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTester";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tester App de Yamil Palmiero (2°C)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTester_FormClosing);
            this.Load += new System.EventHandler(this.FrmTester_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstStock;
        private System.Windows.Forms.RichTextBox rtbInforme;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnVerInforme;
        private System.Windows.Forms.Button btnSalir;
    }
}

