using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Biblioteca;

namespace Formulario
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }


        //TXT

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Prueba.txt";
                Archivador archivador = new Archivador(rutaEscritorio);
                string texto = rtbTextoAGuardar.Text;

                archivador.Guardar(texto);
                MessageBox.Show("Se guardo correctamente.", "Informacion",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No tiene permisos. Contacte al administrador", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Prueba.txt";
                Archivador archivador = new Archivador(rutaEscritorio);

                rtbTextoALeer.Text = archivador.Leer();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No tiene permisos. Contacte al administrador", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        //XML y BINARIO

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            if (rbtXml.Checked)
            {
                SerializarXml();
            }
            else
            {
                SerializarBinario();
            }
        }

        private void btnDeserializar_Click(object sender, EventArgs e)
        {
            if (rbtXml.Checked)
                DeserializarXml();
            else
                DeserializarBinario();
        }


        //METODOS SERIALIZACION

        private void SerializarXml()
        {
            try
            {
                Persona persona = new Persona(txtNombre.Text, txtApellido.Text);//Que quiero serializar??
                string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Prueba.xml";//Donde?
                SerializadorXml<Persona> serializadorXml = new SerializadorXml<Persona>(rutaEscritorio);//Como?

                serializadorXml.Guardar(persona);//Serializo

                MessageBox.Show("Serializado a XML correctamente.", "Informacion",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);//Informo
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SerializarBinario()
        {
            try
            {
                Persona persona = new Persona(txtNombre.Text, txtApellido.Text);//Que quiero serializar??
                string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Prueba.bin";//Donde?
                SerializadorBinario<Persona> serializadorBinario = new SerializadorBinario<Persona>(rutaEscritorio);//Como?

                serializadorBinario.Guardar(persona);//Serializo

                MessageBox.Show("Serializado a BINARIO correctamente.", "Informacion",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);//Informo
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DeserializarXml()
        {
            try
            {
                Persona persona = null;//Que quiero serializar??
                string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Prueba.xml";//Donde?
                SerializadorXml<Persona> serializadorXml = new SerializadorXml<Persona>(rutaEscritorio);//Como?

                persona = serializadorXml.Leer();//Deserializo
                rtbPersona.Text = persona.ToString();//Lo muestro en el richTextBox
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeserializarBinario()
        {
            try
            {
                Persona persona = null;//Que quiero serializar??
                string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Prueba.bin";//Donde?
                SerializadorBinario<Persona> serializadorBinario = new SerializadorBinario<Persona>(rutaEscritorio);//Como?

                persona = serializadorBinario.Leer();//Deserializo
                rtbPersona.Text = persona.ToString();//Lo muestro en el richTextBox
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
