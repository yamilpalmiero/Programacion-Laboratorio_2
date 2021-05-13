using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;

namespace Comiqueria
{
    public partial class FrmTester : Form
    {
        private Vendedor vendedor;

        public FrmTester()
        {
            InitializeComponent();
            vendedor = new Vendedor("Yamil");
        }

        private void FrmTester_Load(object sender, EventArgs e)
        {
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);

            this.lstStock.Items.Add(p1);
            this.lstStock.Items.Add(p2);
            this.lstStock.Items.Add(p3);
            this.lstStock.Items.Add(p4);
            this.lstStock.Items.Add(p5);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (vendedor + (Publicacion)lstStock.SelectedItem)
            {
                MessageBox.Show("Venta exitosa!",
                                "VENTA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sin stock.",
                                "VENTA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnVerInforme_Click(object sender, EventArgs e)
        {
            this.rtbInforme.Text = "";
            this.rtbInforme.Text += Vendedor.InformeDeVentas(vendedor);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmTester_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro desea salir?",
                                                  "Saliendo...",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
