using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    //DELEGADOS
    public delegate void InformacionDeAvance();
    public delegate void InformacionLlegada(string mensaje);

    public class Carrera
    {
        private List<AutoF1> autos = new List<AutoF1>();
        private int kms;
        //EVENTOS
        public event InformacionDeAvance InformarAvance;
        public event InformacionLlegada InformarLlegada;



        /// <summary>
        /// 
        /// </summary>
        public Carrera()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="kms"></param>
        public Carrera(int kms)
        {
            this.kms = kms;
        }


        /// <summary>
        /// 
        /// </summary>
        public List<AutoF1> Autos
        {
            get { return this.autos; }
            set { this.autos = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Kms
        {
            get { return this.kms; }
            set { this.kms = value; }
        }





        /// <summary>
        /// 
        /// </summary>
        public void IniciarCarrera()//HILO SECUNDARIO
        {
            int posicionLlegada = 1;//Empieza en 1 porque es la posicion de llegada del ganador

            while (autos[0].Posicion == 0 || autos[1].Posicion == 0)//Se debera iterar hasta que todos los autos tengan posicion
            {
                if (InformarAvance != null)
                {
                    foreach (AutoF1 auto in autos)//Recorrer la lista de autos de la carrera y acelerar cada auto
                    {
                        auto.Acelerar();//Acelerar cada auto
                        InformarAvance.Invoke();//Informar avance del auto
                        Thread.Sleep(10);//Realizar un sleep de 10 milisegundos

                        if (auto.UbicacionEnPista > Kms && auto.Posicion == 0)//Si la ubicacion en la pista del auto es mayor a Kms de carrera y la posicion del auto no fue asignada
                        {
                            auto.Posicion = posicionLlegada;//Se le asigna la posicion de llegada al auto
                            posicionLlegada++;//Si llega primero se asigna el 1 y si llega segundo el 2 (1++)

                            if (InformarLlegada != null)
                            {
                                GestorBaseDeDatos gestorDB = new GestorBaseDeDatos();
                                GestorDeArchivos archivo = new GestorDeArchivos(AppDomain.CurrentDomain.BaseDirectory + "\\Carreras.txt");
                                ((IGuardar<AutoF1>)archivo).Guardar(auto);//Almacenar la llegada de los autos en un archivo de texto
                                gestorDB.Guardar(auto);//Almacenar la llegada de los autos a la BD
                                InformarLlegada.Invoke(auto.ToString());//Se informa la llegada del auto a la meta. Reutilizar ToString
                            }
                        }
                    }
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="carrera"></param>
        /// <param name="auto"></param>
        /// <returns></returns>
        public static Carrera operator +(Carrera carrera, AutoF1 auto)
        {
            if (carrera != null && auto != null)
            {
                carrera.autos.Add(auto);
            }

            return carrera;
        }
    }
}
