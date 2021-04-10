using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    /// <summary>
    /// Esta es la clase Program.cs
    /// </summary>
    class Program
    {
        //ATRIBUTOS DE LA CLASE
        public int entero;
        private float flotante;

        //CONSTRUCTOR DE CLASE
        public Program()//Mismo nombre que la clase. No le paso nada
        {
            this.entero = 1;
            this.flotante = (float)1.1;//1.1f es lo mismo
        }

        public Program(int a)//Primera sobrecarga. Le paso el atributo entero
        {
            this.entero = a;
        }

        public Program(float b)//Segunda sobrecarga. Le paso el atributo flotante
        {
            this.flotante = b;
        }

        public Program(int a, float b):this()//Tercera sobrecarga. Le paso los dos atributos
        {
            this.entero = a;
            this.flotante = b;
        }

        public Program(float b, int a)//Cuarta sobrecarga. Le paso los dos atributos pero al reves
        {
            this.flotante = b;
            this.entero = a;
        }

        Program objeto1 = new Program();
        Program objeto2 = new Program(5);
        Program objeto3 = new Program(2.3f);
        Program objeto4 = new Program(5, 2.3f);



        /// <summary>
        /// Metodo sin parametros
        /// </summary>
        private static void MetodoSobrecargado()
        {
            Console.WriteLine("Sin parametros");
        }

        /// <summary>
        /// Metodo sobrecargado con un parametro int
        /// </summary>
        /// <param name="a">Se muestra este parametro</param>
        private static void MetodoSobrecargado(int a)
        {
            Console.WriteLine(a);
        }

        private static void MetodoSobrecargado(string a)
        {
            Console.WriteLine(a);
        }

        /// <summary>
        /// Le paso un string y trato de transformarlo en un entero
        /// </summary>
        /// <param name="b">String que le paso</param>
        /// <param name="a">Entero que devuelve</param>
        private void MetodoSobrecargado(string b, out int a)
        {
            if (int.TryParse(b, out a))//TryParse devuelve un booleano dependiendo si pudo transformalo a entero o no. Necesita parametro de entrada (string) y el de salida (entero)
            {
                Console.WriteLine("Se pudo convertir!!");
                Console.WriteLine("El valor es: {0}", a);
            }
            else
            {
                Console.WriteLine("No se convirtio.");
                a = -1;
            }
        }

        static void Main(string[] args)
        {
            //METODOS ESTATICOS --> Clase.Metodo
            Program.MetodoSobrecargado();
            Program.MetodoSobrecargado(5);
            Program.MetodoSobrecargado("Hola");


            //METODO DE INSTANCIA (NO ESTATICO) --> objeto.Metodo
            Program objeto = new Program();

            int numero = 0;
            objeto.MetodoSobrecargado("88", out numero);
            Console.WriteLine(numero);

            Console.ReadKey(true);
        }
    }
}
