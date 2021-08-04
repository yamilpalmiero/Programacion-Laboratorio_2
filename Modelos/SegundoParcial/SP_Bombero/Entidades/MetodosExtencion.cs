using System;

namespace Entidades
{
    public static class MetodosExtencion
    {
        public static int DiferenciaEnMinutos(this DateTime inicio, DateTime fin)
        {
            int diferencia = (fin - inicio).Minutes;

            return diferencia;
        }
    }
}
