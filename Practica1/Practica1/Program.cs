using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 0; i <= 5; i++)
                for (j = 0; j <= 20; j = j + 2)
                {
                    if ((i == 1) && (j >= 7))
                        goto salida;
                    Console.WriteLine("i vale {0} y j vale {1}.", i, j);
                }
            salida:
            Console.WriteLine("Fin del programa");
        }
    }
}
