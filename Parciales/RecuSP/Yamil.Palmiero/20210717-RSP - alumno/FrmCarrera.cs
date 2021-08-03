﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;


namespace _20210717_RSP___alumno
{

    public partial class FrmCarrera : Form
    {

        private Carrera carrera;//La uso para guardar a xml
        private Thread thread;//Hilo secundario
        private AutoF1 v1;
        private AutoF1 v2;


        public FrmCarrera()
        {
            InitializeComponent();
            this.pcbAutoUno.Image = this.imgListAutos.Images[0];
            this.pcbAutoDos.Image = this.imgListAutos.Images[0];
        }

        private void InitializeAutosYCarrera()
        {
            Random random = new Random();
            this.v1 = new AutoF1("Ferrari", random.Next(5, 20), this.pcbAutoUno.Location.X);
            Thread.Sleep(2000);//pongo un sleep para el random
            this.v2 = new AutoF1("Renault", random.Next(5, 20), this.pcbAutoDos.Location.X);

            this.carrera = new Carrera(this.Size.Width); //instancion la carrera y le envio el maximo del form

            //Agrego vehiculos a la carrera
            this.carrera += v1;
            this.carrera += v2;

        }

        private void FrmCarrera_Shown(object sender, EventArgs e)
        {
            //Alumno: Instanciar hilo secundario
            thread = new Thread(carrera.IniciarCarrera);//Instancio el hilo secundario
            thread.Start();//Darle start SIEMPRE
        }

        /// <summary>
        /// Dibuja el avance de los autos
        /// </summary>
        private void AvanzarAuto()
        {
            //Alumno:Metodo que maneja el evento InformarAvance
            if (this.pcbAutoUno.InvokeRequired && this.pcbAutoDos.InvokeRequired)
            {
                this.pcbAutoUno.BeginInvoke((MethodInvoker)delegate ()
                {
                    //carrera.InformarAvance += AvanzarAuto;
                    this.pcbAutoUno.Location = new Point(this.v1.UbicacionEnPista, this.pcbAutoUno.Location.Y);
                    this.pcbAutoDos.Location = new Point(this.v2.UbicacionEnPista, this.pcbAutoDos.Location.Y);
                });
            }
            else//El ELSE podria no estar
            {
                //carrera.InformarAvance += AvanzarAuto;
                this.pcbAutoUno.Location = new Point(this.v1.UbicacionEnPista, this.pcbAutoUno.Location.Y);
                this.pcbAutoDos.Location = new Point(this.v2.UbicacionEnPista, this.pcbAutoDos.Location.Y);
            }
            Thread.Sleep(50);
        }
        /// <summary>
        /// Metodo donde se agregaran los manejadores al evento de carrera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCarrera_Load(object sender, EventArgs e)
        {
            this.InitializeAutosYCarrera();

            //Alumno:Metodo donde se agregaran los manejadores al evento de carrera
            carrera.InformarAvance += AvanzarAuto;//Te das cuenta cuales son los metodos porque cumplen con la firma de los delegados
            carrera.InformarLlegada += ImprimirMensaje;
        }
        /// <summary>
        /// Imprime los mensajes de llegada
        /// </summary>
        /// <param name="mensaje"></param>
        private void ImprimirMensaje(string mensaje)
        {
            //Alumno:Metodo que maneja el evento InformarLlegada
            MessageBox.Show(mensaje, "Llegadas", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }


        private void FrmCarrera_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK; //Establezco el resultado en OK para finalizar el primer FORM
            thread.Abort();//SIEMPRE matar los threads en el FormClosing

            //Alumno:serializar carrera
            GestorDeArchivos gestorArchivo = new GestorDeArchivos(AppDomain.CurrentDomain.BaseDirectory + "Carrera.xml");//Serializo la carrera con una instancia del gestor
            gestorArchivo.Guardar(carrera);
        }
    }
}
