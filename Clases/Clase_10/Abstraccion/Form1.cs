using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClasesAbstractas;

namespace Abstraccion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FacturaA fa = new FacturaA();
            FacturaB fb = new FacturaB();
            FacturaC fc = new FacturaC();

            MessageBox.Show("Factura1 - CUIT: {0}", fa.RetornarNumeroDeCuit());
            MessageBox.Show("Factura2 - CUIT: {0}", fb.RetornarNumeroDeCuit());
            MessageBox.Show("Factura3 - CUIT: {0}", fc.RetornarNumeroDeCuit());
        }
    }
}
