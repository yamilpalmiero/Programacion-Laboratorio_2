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
    public partial class FrmCliente : Form
    {
        private Cliente cliente;
        public FrmCliente()
        {
            InitializeComponent();
            this.cliente = Validadora.InicializarElemento<Cliente>(cliente);
        }

        public Cliente Cliente
        {
            get { return this.cliente; }
        }
    }
}
