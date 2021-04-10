using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MisEntidades;

namespace SobrecargaOperadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa cosa1 = new Cosa();
            Cosa cosa2 = new Cosa();
            OtraCosa otraCosa = new OtraCosa(5);

            if (cosa1 == cosa2)//Esta comparacion me la permite porque son del mismo tipo
            {

            }

            if (cosa1 == otraCosa)//No me lo permite porque son de diferente tipo. Entonces hay que sobrecargar el ==
            {

            }


            OtraCosa oc1 = new OtraCosa(5);
            OtraCosa oc2 = 6;//Esto en principio no se puede, por eso simulamos la sobrecarga de casteo implicito
            OtraCosa oc3 = (OtraCosa)"Hola";//Se simula el casteo explicito
            Console.WriteLine(oc2);
        }
    }
}
