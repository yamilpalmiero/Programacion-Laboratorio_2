using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiClaseException
{
    public static class Metodo
    {
        public static double Dividir(int numeroUno, int numeroDos)
        {
            double resultado = 0;

            try
            {
                resultado = numeroUno / numeroDos;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.ToString());

                throw new MiClaseException("Error al intentar dividir\nClass Metodo.Dividir", e);
            }
            finally
            {
                Console.WriteLine("Se ejecuta el bloque finally");
            }

            if (resultado < 1)
            {
                throw new Exception("Resultado menor a 1");
            }

            return resultado;
        }
    }
}
