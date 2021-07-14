using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiClaseException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double res;

                res = Metodo.Dividir(10, 0);//Este metodo ya hace el try catch de MiClaseException

                Console.WriteLine("Resultado: {0}", res);
            }
            /*catch (StackOverflowException e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("InnerException: {0}", e.InnerException);
            }*/
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());//Esto imprime el Stack Trace
            }

            Console.ReadKey();
        }
    }
}
