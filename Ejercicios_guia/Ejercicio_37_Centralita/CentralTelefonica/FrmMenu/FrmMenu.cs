using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CentralitaHerencia;

namespace FrmMenu
{
    public partial class FrmMenu : Form
    {
        Centralita centralita = new Centralita();

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador frmLlamador = new FrmLlamador(centralita);
            frmLlamador.ShowDialog();
            centralita = frmLlamador.Centralita;
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            if (ReferenceEquals(centralita, null))
            {
                MessageBox.Show("No se cargo ninguna llamada", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                FrmMostrar frmMostrar = new FrmMostrar(centralita, Llamada.TipoLlamada.Todas);
                frmMostrar.ShowDialog();
            }
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            if (ReferenceEquals(centralita, null))
            {
                MessageBox.Show("No se cargo ninguna llamada", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                FrmMostrar frmMostrar = new FrmMostrar(centralita, Llamada.TipoLlamada.Local);
                frmMostrar.ShowDialog();
            }
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            if (ReferenceEquals(centralita, null))
            {
                MessageBox.Show("No se cargo ninguna llamada", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                FrmMostrar frmMostrar = new FrmMostrar(centralita, Llamada.TipoLlamada.Provincial);
                frmMostrar.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
