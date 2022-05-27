using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[10];
            Random R = new Random();
            try
            {
                for (int x = 0; x < arreglo.Length; x++)
                {
                    arreglo[x] = R.Next(10, 99);
                }
                Array.Sort(arreglo);
                Console.WriteLine("\n\nARREGLO ORDENADO");
                for (int x = 0; x < arreglo.Length; x++)
                {
                    Console.WriteLine("\t{0}.-{1}", x + 1, arreglo[x]);
                }
                Console.Write("\n\nPresione ENTER para continuar...");
                Console.ReadKey();
                arreglo[15] = 12345; //acceso indice fuera de rango

            }catch (IndexOutOfRangeException i)
            {
                Console.WriteLine("\nMENSAJE DE ERROR" + i.Message);
                Console.WriteLine("\nRUTA DE ERROR" + i.StackTrace);
                Console.Write("\nPRESIONE ENTER PARA CONTINUAR...");
                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("\nBLOQUE FINALLY SIEMPRE SE EJECUTA");
                Console.WriteLine("\nPRESIONE ENTER PARA SALIR DEL PROGRAMA");
                Console.ReadKey();
            }

        }
    }
}
