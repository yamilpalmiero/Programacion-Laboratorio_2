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

namespace SegundoParcialBitacora
{
    public partial class frmPpal : Form
    {
        private LosHilos hilos;



        public frmPpal()
        {
            InitializeComponent();
            this.hilos = new LosHilos();
            this.hilos.AvisoFin += MostrarMensajeFin;
        }

        private void frmPpal_Load(object sender, EventArgs e)
        {

        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            try
            {
                hilos += 1;
            }
            catch (CantidadInvalidaException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hilos.Bitacora);
        }


        public void MostrarMensajeFin(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }
}
