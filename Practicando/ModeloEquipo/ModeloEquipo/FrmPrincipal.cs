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

namespace ModeloEquipo
{
    public partial class FrmPrincipal : Form
    {
        private DirectorTecnico dt;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            dt = new DirectorTecnico(txtNombre.Text, txtApellido.Text, int.Parse(nudEdad.Value.ToString()), (int)nudDNI.Value, (int)nudExperiencia.Value);
            MessageBox.Show("Se ha creado el DT!", "BIEN!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (dt is null)
            {
                MessageBox.Show("Aun no se ha creado el DT del formulario.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dt != null && dt.ValidarAptitud())
            {
                MessageBox.Show("El DT es apto", "BIEN!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El DT no es apto", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
