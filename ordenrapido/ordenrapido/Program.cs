using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenrapido
{
    internal class Program
    {
            private static void ordenrapido(int[] arr, int izq, int derech)
            {
                if (izq < derech)
                {   
                    //para organizar los elementos:
                    int pivote = Partition(arr, izq, derech);

                    if (pivote > 1)
                    {
                    ordenrapido(arr, izq, pivote - 1);
                    }
                    if (pivote + 1 < derech)
                    {
                    ordenrapido(arr, pivote + 1, derech);
                    }
                }

            }

            private static int Partition(int[] arr, int izqu, int derech)
            {
                int pivote = arr[izqu];
                //para comparar las cantidades y organizarlas
                while (true)
                {

                    while (arr[izqu] < pivote)
                    {
                        izqu++;
                    }

                    while (arr[derech] > pivote)
                    {
                        derech--;
                    }

                    if (izqu < derech)
                    {
                        if (arr[izqu] == arr[derech]) return derech;

                        int temp = arr[izqu];
                        arr[izqu] = arr[derech];
                        arr[derech] = temp;


                    }
                    else
                    {
                        return derech;
                    }
                }
            }
            static void Main(string[] args)
            {
                int[] arreglo = new int[] { 5, 1, 22, 101, 50, 52, 35, 2 };

                Console.WriteLine("Números en su estado original: ");
                foreach (var elemento in arreglo)
                {
                    Console.Write(" " + elemento);
                }
                Console.WriteLine();
                
                //uso cero para indicar que comienza desde el primer elementos
                ordenrapido(arreglo, 0, arreglo.Length - 1);

                Console.WriteLine();
                Console.WriteLine("Números organizados: ");

                foreach (var elemento in arreglo)
                {
                    Console.Write(" " + elemento);
                }
                Console.WriteLine();
                Console.Read();
            }
        }
    }



