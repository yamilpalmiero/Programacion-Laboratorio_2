using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmFormPrincipal : Form
    {
        public frmFormPrincipal()
        {
            InitializeComponent();
        }

        private void Saludar_OnClick(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;

            if (ValidarNombre(nombre))
            {
                nombre = nombre.Trim();//Trim borra los espacios en blanco antes y despues de la cadena
                string mensaje = $"Hola {nombre}!!";
                frmMensajeForm mensajeForm = new frmMensajeForm(mensaje);

                //mensajeForm.Show();
                mensajeForm.ShowDialog();


                MessageBox.Show($"Hola {nombre}!!",
                                "Saludo",
                                MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea continuar?",
                                                        "ALERTA!",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private bool ValidarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Debe ingresar un nombre.",
                                "ERROR!",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Error);

                return false;
            }

            return true;
        }
    }
}
