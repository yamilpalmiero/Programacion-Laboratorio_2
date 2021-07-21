
namespace Formulario
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
            this.rtbTextoAGuardar = new System.Windows.Forms.RichTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.rtbTextoALeer = new System.Windows.Forms.RichTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnSerializar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.gpbFormato = new System.Windows.Forms.GroupBox();
            this.rbtXml = new System.Windows.Forms.RadioButton();
            this.rbtBinario = new System.Windows.Forms.RadioButton();
            this.btnDeserializar = new System.Windows.Forms.Button();
            this.rtbPersona = new System.Windows.Forms.RichTextBox();
            this.gpbFormato.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbTextoAGuardar
            // 
            this.rtbTextoAGuardar.Location = new System.Drawing.Point(22, 19);
            this.rtbTextoAGuardar.Name = "rtbTextoAGuardar";
            this.rtbTextoAGuardar.Size = new System.Drawing.Size(384, 76);
            this.rtbTextoAGuardar.TabIndex = 0;
            this.rtbTextoAGuardar.Text = "";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(337, 105);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 24);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(337, 245);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(69, 24);
            this.btnLeer.TabIndex = 3;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // rtbTextoALeer
            // 
            this.rtbTextoALeer.Location = new System.Drawing.Point(22, 159);
            this.rtbTextoALeer.Name = "rtbTextoALeer";
            this.rtbTextoALeer.Size = new System.Drawing.Size(384, 76);
            this.rtbTextoALeer.TabIndex = 2;
            this.rtbTextoALeer.Text = "";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(451, 38);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(133, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(625, 38);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(133, 26);
            this.txtApellido.TabIndex = 5;
            // 
            // btnSerializar
            // 
            this.btnSerializar.Location = new System.Drawing.Point(655, 102);
            this.btnSerializar.Name = "btnSerializar";
            this.btnSerializar.Size = new System.Drawing.Size(100, 27);
            this.btnSerializar.TabIndex = 6;
            this.btnSerializar.Text = "Serializar";
            this.btnSerializar.UseVisualStyleBackColor = true;
            this.btnSerializar.Click += new System.EventHandler(this.btnSerializar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(448, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(622, 18);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 17);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido";
            // 
            // gpbFormato
            // 
            this.gpbFormato.Controls.Add(this.rbtBinario);
            this.gpbFormato.Controls.Add(this.rbtXml);
            this.gpbFormato.Location = new System.Drawing.Point(451, 74);
            this.gpbFormato.Name = "gpbFormato";
            this.gpbFormato.Size = new System.Drawing.Size(176, 55);
            this.gpbFormato.TabIndex = 9;
            this.gpbFormato.TabStop = false;
            this.gpbFormato.Text = "Formato";
            // 
            // rbtXml
            // 
            this.rbtXml.AutoSize = true;
            this.rbtXml.Checked = true;
            this.rbtXml.Location = new System.Drawing.Point(17, 28);
            this.rbtXml.Name = "rbtXml";
            this.rbtXml.Size = new System.Drawing.Size(52, 21);
            this.rbtXml.TabIndex = 0;
            this.rbtXml.TabStop = true;
            this.rbtXml.Text = "Xml";
            this.rbtXml.UseVisualStyleBackColor = true;
            // 
            // rbtBinario
            // 
            this.rbtBinario.AutoSize = true;
            this.rbtBinario.Location = new System.Drawing.Point(75, 28);
            this.rbtBinario.Name = "rbtBinario";
            this.rbtBinario.Size = new System.Drawing.Size(73, 21);
            this.rbtBinario.TabIndex = 10;
            this.rbtBinario.Text = "Binario";
            this.rbtBinario.UseVisualStyleBackColor = true;
            // 
            // btnDeserializar
            // 
            this.btnDeserializar.Location = new System.Drawing.Point(658, 245);
            this.btnDeserializar.Name = "btnDeserializar";
            this.btnDeserializar.Size = new System.Drawing.Size(100, 27);
            this.btnDeserializar.TabIndex = 10;
            this.btnDeserializar.Text = "Deserializar";
            this.btnDeserializar.UseVisualStyleBackColor = true;
            this.btnDeserializar.Click += new System.EventHandler(this.btnDeserializar_Click);
            // 
            // rtbPersona
            // 
            this.rtbPersona.Location = new System.Drawing.Point(448, 159);
            this.rtbPersona.Name = "rtbPersona";
            this.rtbPersona.Size = new System.Drawing.Size(307, 76);
            this.rtbPersona.TabIndex = 11;
            this.rtbPersona.Text = "";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 294);
            this.Controls.Add(this.rtbPersona);
            this.Controls.Add(this.btnDeserializar);
            this.Controls.Add(this.gpbFormato);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnSerializar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.rtbTextoALeer);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.rtbTextoAGuardar);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Principal";
            this.gpbFormato.ResumeLayout(false);
            this.gpbFormato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTextoAGuardar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.RichTextBox rtbTextoALeer;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnSerializar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.GroupBox gpbFormato;
        private System.Windows.Forms.RadioButton rbtBinario;
        private System.Windows.Forms.RadioButton rbtXml;
        private System.Windows.Forms.Button btnDeserializar;
        private System.Windows.Forms.RichTextBox rtbPersona;
    }
}

