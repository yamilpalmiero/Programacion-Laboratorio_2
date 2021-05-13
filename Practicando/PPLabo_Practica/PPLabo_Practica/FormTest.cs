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

namespace PPLabo_Practica
{
    public partial class FrmTest : Form
    {
        private Vendedor vendedor;
        public FrmTest()
        {
            InitializeComponent();
            vendedor = new Vendedor(nombre);
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);
        }

        private void lstStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstStock.Items = e
        }

        private void FrmTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("¿Seguro desea salir?",
                            "Saliendo...",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
        }

        private void FrmTest_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
