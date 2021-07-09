using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Entidades;


namespace Views
{
    public partial class FrmVacunatorio : Form
    {
        public FrmVacunatorio()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            XmlTextReader xmlTextReader = new XmlTextReader("centrovacunacion.xml");
            while (xmlTextReader.Read())
            {
                OpenFileDialog();
            }
        }

        private void btnBaseDeDatos_Click(object sender, EventArgs e)
        {

        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
        }

        private void FrmVacunatorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
