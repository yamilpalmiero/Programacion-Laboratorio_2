using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ComiqueriaLogic;//Acceso a la comiqueria

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        private Producto productoSeleccionado;
        private Comiqueria comiqueria;

        public VentasForm(Producto productoSeleccionado, Comiqueria comiqueria)
        {
            InitializeComponent();
            this.productoSeleccionado = productoSeleccionado;
            this.comiqueria = comiqueria;
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            this.lblDescripcion.Text = this.productoSeleccionado.Descripcion;
        }

        private void ActualizarPrecio()
        {
            int cantidadSeleccionada = Convert.ToInt32(this.numericUpDownCantidad.Value);
            double nuevoPrecioFinal = Venta.CalcularPrecioFinal(this.productoSeleccionado.Precio, cantidadSeleccionada);
            this.lblPrecioFinal.Text = String.Format("Precio Final: ${0:0.00}", nuevoPrecioFinal);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int cantidadSeleccionada = Convert.ToInt32(this.numericUpDownCantidad.Value);

            if (cantidadSeleccionada <= productoSeleccionado.Stock)
            {
                this.comiqueria.Vender(this.productoSeleccionado, cantidadSeleccionada);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("La cantidad indicada supera el stock disponible. Por favor, disminuya la cantidad.",
                                "Stock Superado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            ActualizarPrecio();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
