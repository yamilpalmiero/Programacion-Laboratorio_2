using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

using Entidades;

namespace Views
{
    public partial class FrmPrincipal : Form
    {
        List<Thread> listaHilos;
        Thread hiloUno;
        Thread hiloDos;
        Xml<string> xml;
        Binario<List<Paciente>> bin;
        List<Paciente> pacientes;
        Texto texto;
        string archivo;



        public FrmPrincipal()
        {
            hiloUno = new Thread(this.Cargar);
            hiloUno.Name = "hiloCargar data";

            hiloDos = new Thread(this.ActualizarCadaCincoSegundos);
            hiloDos.Name = "hiloActualizar";

            listaHilos = new List<Thread>();

            xml = new Xml<string>();
            bin = new Binario<List<Paciente>>();

            pacientes = new List<Paciente>();
            texto = new Texto();

            InitializeComponent();
        }



        //BOTONES
        private void btnXML_Click(object sender, EventArgs e)
        {
            if (ofdImportar.ShowDialog() == DialogResult.OK)
            {
                lblActualizar.Text = ofdImportar.FileName;
                if (texto.Leer(ofdImportar.FileName, out archivo))
                {
                    rtbActualizar.Text = archivo;
                }
            }
        }

        private void btnBD_Click(object sender, EventArgs e)
        {
            pacientes = PacienteDAO.SeleccionarPacientes();

            foreach (Paciente p in pacientes)
            {
                rtbActualizar.Text += p.Nombre + " " + p.Apellido + " " + p.Turno + "\n";
            }
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmLlamador();

            formulario.Show();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            if (!hiloUno.IsAlive)
            {
                hiloUno.Start();//Inicio los hilos que cargan data
                hiloDos.Start();//Inicio el hilo que actualiza
            }
            else
            {
                hiloUno.Abort();
                hiloDos.Abort();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }






        //METODOS
        public void Cargar()
        {

        }

        public void ActualizarCadaCincoSegundos()
        {
            while (true)
            {
                if (this.lblActualizar.InvokeRequired)//si lo pido, hago...
                {
                    this.lblActualizar.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.lblActualizar.Text = "Si no tenia el metodo, lo pido y lo uso.";
                        this.rtbActualizar.Text += "Actualizando";//Banco.Cuenta.ToString()
                    }
                    );
                }
                else
                {
                    this.lblActualizar.Text = "Si ya lo tenia lo uso.";
                    this.rtbActualizar.Text += "Actualizando";//Banco.Cuenta.ToString()
                }

                Thread.Sleep(5000);
            }
        }
    }
}
