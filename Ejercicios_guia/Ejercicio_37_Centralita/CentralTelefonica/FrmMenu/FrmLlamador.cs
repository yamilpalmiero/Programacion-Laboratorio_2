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
    public partial class FrmLlamador : Form
    {
        Centralita centralita;
        TextBox auxTxt = new TextBox();

        public FrmLlamador()
        {
            InitializeComponent();
        }

        public FrmLlamador(Centralita centralita)
            : this()
        {
            this.centralita = centralita;

        }

        public Centralita Centralita
        {
            get
            {
                return this.centralita;
            }
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            auxTxt.Text = "Nro Destino";
        }

        private void gbPanel_Enter(object sender, EventArgs e)
        {

        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (auxTxt == txtNroDestino)
                txtNroDestino.Text += "1";
            if (auxTxt == txtNroOrigen)
                txtNroOrigen.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (auxTxt == txtNroDestino)
                txtNroDestino.Text += "2";
            if (auxTxt == txtNroOrigen)
                txtNroOrigen.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (auxTxt == txtNroDestino)
                txtNroDestino.Text += "3";
            if (auxTxt == txtNroOrigen)
                txtNroOrigen.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (auxTxt == txtNroDestino)
                txtNroDestino.Text += "4";
            if (auxTxt == txtNroOrigen)
                txtNroOrigen.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (auxTxt == txtNroDestino)
                txtNroDestino.Text += "5";
            if (auxTxt == txtNroOrigen)
                txtNroOrigen.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (auxTxt == txtNroDestino)
                txtNroDestino.Text += "6";
            if (auxTxt == txtNroOrigen)
                txtNroOrigen.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (auxTxt == txtNroDestino)
                txtNroDestino.Text += "7";
            if (auxTxt == txtNroOrigen)
                txtNroOrigen.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (auxTxt == txtNroDestino)
                txtNroDestino.Text += "8";
            if (auxTxt == txtNroOrigen)
                txtNroOrigen.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (auxTxt == txtNroDestino)
                txtNroDestino.Text += "9";
            if (auxTxt == txtNroOrigen)
                txtNroOrigen.Text += "9";
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            if (auxTxt == txtNroDestino)
                txtNroDestino.Text += "*";
            if (auxTxt == txtNroOrigen)
                txtNroOrigen.Text += "*";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (auxTxt == txtNroDestino)
                txtNroDestino.Text += "0";
            if (auxTxt == txtNroOrigen)
                txtNroOrigen.Text += "0";
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            if (auxTxt == txtNroDestino)
                txtNroDestino.Text += "#";
            if (auxTxt == txtNroOrigen)
                txtNroOrigen.Text += "#";
            if (txtNroDestino.Text.IndexOf('#') == 0)
                cmbFranja.Enabled = true;
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text[0] == '#')
            {
                Provincial.Franja franja;
                Enum.TryParse(cmbFranja.SelectedValue.ToString(), out franja);
                Provincial llamada = new Provincial(txtNroOrigen.Text, franja, new Random().Next(1, 50), txtNroDestino.Text);
                if (!ReferenceEquals(llamada, null))
                {
                    this.centralita += llamada;
                    MessageBox.Show("Llamada realiza con exito\n");
                }
            }
            else
            {
                //cmbFranja.Enabled = false;
                Local llamada = new Local(txtNroOrigen.Text, new Random().Next(1, 50), txtNroDestino.Text, (float)new Random().Next(5, 56) / 10);
                if (!ReferenceEquals(llamada, null))
                {
                    this.centralita += llamada;
                    MessageBox.Show("Llamada realiza con exito\n");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroOrigen.Text = "";
            txtNroDestino.Text = "";
            //cmbFranja.Enabled = true;
            txtNroOrigen.Text = "42424566";
            txtNroDestino.Text = "Nro Destino";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
