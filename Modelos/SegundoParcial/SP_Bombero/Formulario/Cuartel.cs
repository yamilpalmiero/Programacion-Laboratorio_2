using Entidades;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Cuartel : Form
    {
        private List<Bombero> bomberos;
        private List<PictureBox> fuegos;
        private List<Thread> salidasEnAccion;


        public Cuartel()
        {
            InitializeComponent();


            PictureBox fuego1 = new PictureBox();
            PictureBox fuego2 = new PictureBox();
            PictureBox fuego3 = new PictureBox();
            PictureBox fuego4 = new PictureBox();

            // 
            // fuego4
            // 
            fuego4.Image = global::Formulario.Properties.Resources.fire;
            fuego4.Location = new System.Drawing.Point(83, 225);
            fuego4.Name = "fuego4";
            fuego4.Size = new System.Drawing.Size(64, 64);
            fuego4.TabIndex = 12;
            fuego4.TabStop = false;
            fuego4.Visible = false;
            // 
            // fuego3
            // 
            fuego3.Image = global::Formulario.Properties.Resources.fire;
            fuego3.Location = new System.Drawing.Point(83, 155);
            fuego3.Name = "fuego3";
            fuego3.Size = new System.Drawing.Size(64, 64);
            fuego3.TabIndex = 11;
            fuego3.TabStop = false;
            fuego3.Visible = false;
            // 
            // fuego2
            // 
            fuego2.Image = global::Formulario.Properties.Resources.fire;
            fuego2.Location = new System.Drawing.Point(83, 85);
            fuego2.Name = "fuego2";
            fuego2.Size = new System.Drawing.Size(64, 64);
            fuego2.TabIndex = 10;
            fuego2.TabStop = false;
            fuego2.Visible = false;
            // 
            // fuego1
            // 
            fuego1.Image = global::Formulario.Properties.Resources.fire;
            fuego1.Location = new System.Drawing.Point(83, 13);
            fuego1.Name = "fuego1";
            fuego1.Size = new System.Drawing.Size(64, 64);
            fuego1.TabIndex = 9;
            fuego1.TabStop = false;
            fuego1.Visible = false;

            this.Controls.Add(fuego1);
            this.Controls.Add(fuego2);
            this.Controls.Add(fuego3);
            this.Controls.Add(fuego4);

            this.fuegos = new List<PictureBox>();
            this.fuegos.Add(fuego1);
            this.fuegos.Add(fuego2);
            this.fuegos.Add(fuego3);
            this.fuegos.Add(fuego4);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            this.bomberos = new List<Bombero>();
            Bombero b1 = new Bombero("M. Palermo");
            b1.MarcarFin += FinalDeSalida;
            this.bomberos.Add(b1);
            Bombero b2 = new Bombero("G. Schelotto");
            b2.MarcarFin += FinalDeSalida;
            this.bomberos.Add(b2);
            Bombero b3 = new Bombero("C. Tevez");
            b3.MarcarFin += FinalDeSalida;
            this.bomberos.Add(b3);
            Bombero b4 = new Bombero("F. Gago");
            b4.MarcarFin += FinalDeSalida;
            this.bomberos.Add(b4);
        }

        private void btnEnviar1_Click(object sender, EventArgs e)
        {
            this.DespacharServicio(0);
        }

        private void btnEnviar2_Click(object sender, EventArgs e)
        {
            this.DespacharServicio(1);
        }

        private void btnEnviar3_Click(object sender, EventArgs e)
        {
            this.DespacharServicio(2);
        }

        private void btnEnviar4_Click(object sender, EventArgs e)
        {
            this.DespacharServicio(3);
        }

        private void DespacharServicio(int index)
        {
            try
            {
                if (this.fuegos[index].Visible)
                {
                    throw new BomberoOcupadoException("El bombero está apagando otro fuego.");
                }
                else
                {
                    this.fuegos[index].Visible = true;
                    Thread nuevaSalida = new Thread(new ParameterizedThreadStart(this.bomberos[index].AtenderSalida));
                    nuevaSalida.Start(index);
                    salidasEnAccion.Add(nuevaSalida);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void InvokeDelegate(int bomberoIndex)
        {
            FinDeSalida finSalida = new FinDeSalida(this.FinalDeSalida);
            this.Invoke(finSalida, new object[] { bomberoIndex });
        }

        private void FinalDeSalida(int bomberoIndex)
        {
            if (this.fuegos[bomberoIndex].InvokeRequired)
                this.InvokeDelegate(bomberoIndex);
            else
                this.fuegos[bomberoIndex].Visible = false;
        }




        private void Cuartel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Thread item in salidasEnAccion)//Asegurarse de que ningun hilo de la lista quede vivo
                {
                    if (item.IsAlive)
                    {
                        item.Abort();
                    }
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnReporte1_Click(object sender, EventArgs e)
        {
            try
            {
                this.bomberos[0].Guardar(bomberos[0]);
            }
            catch (BomberoOcupadoException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReporte2_Click(object sender, EventArgs e)
        {
            try
            {
                this.bomberos[1].Guardar(bomberos[1]);
            }
            catch (BomberoOcupadoException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReporte3_Click(object sender, EventArgs e)
        {
            try
            {
                this.bomberos[2].Guardar(bomberos[2]);
            }
            catch (BomberoOcupadoException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReporte4_Click(object sender, EventArgs e)
        {
            try
            {
                this.bomberos[3].Guardar(bomberos[3]);
            }
            catch (BomberoOcupadoException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
