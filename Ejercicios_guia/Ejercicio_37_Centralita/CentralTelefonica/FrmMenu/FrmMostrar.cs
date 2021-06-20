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
    public partial class FrmMostrar : Form
    {
        Centralita centralita;
        Llamada.TipoLlamada tipo;

        public FrmMostrar()
        {
            InitializeComponent();
        }
        public FrmMostrar(Centralita centralita, Llamada.TipoLlamada tipo)
            : this()
        {
            this.centralita = centralita;
            this.tipo = tipo;
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        rtbLlamadas.Text += ("Facturacion por Local\n" + centralita.GananciasPorLocal);
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        rtbLlamadas.Text += ("Facturacion por Provincial\nPesos: $" + centralita.GananciasPorProvincial);
                        break;
                    default:
                        StringBuilder total = new StringBuilder();
                        total.AppendLine("Facturacion por Local: " + centralita.GananciasPorLocal);
                        total.AppendLine("Facturacion por Provincial: " + centralita.GananciasPorProvincial);
                        total.AppendLine("Facturacion Total: " + centralita.GananciasPorTotal);
                        rtbLlamadas.Text += total.ToString();
                        break;
                }
            }
        }
    }
}
