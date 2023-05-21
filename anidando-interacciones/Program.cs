using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anidando_interacciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables 
            int i;// variable interio
            int j; //variable exterio
            int resultado; //guarda el valor

            //proceso del bucles
            for (i=1; i <= 10; i++) //bucle exterio
            {
                Console.WriteLine("tabla de multiplicar de  {0}", i);//nos dice la tabla de mult actual
                for (j = 1; j <= 10; j++) //bucle interio
                {
                    resultado = i * j;
                    Console.WriteLine("{0} * {1} = {2}", i, j, resultado);
                }

            }
        }
    }
}
