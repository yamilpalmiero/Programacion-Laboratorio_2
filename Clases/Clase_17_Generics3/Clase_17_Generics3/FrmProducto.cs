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

namespace Clase_17_Generics3
{
    public partial class FrmProducto : Form
    {
        private Producto prodcuto;

        public FrmProducto()
        {
            InitializeComponent();
            this.prodcuto = Validadora.InicializarElemento<Producto>(prodcuto);
        }

        public Producto Producto { get { return this.prodcuto; } }
    }
}
