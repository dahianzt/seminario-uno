using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insercionsort
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //primero coloco cada uno de los numeros
            int[] numeros = new int[] { 5, 1, 22, 101, 50, 52, 35, 2 };

            Console.WriteLine("Números sin ordenar :");
             //llamo a los numeros
            resulta(numeros);
            Console.WriteLine("\nNúmeros luego de ordenar :");
            //llamo otra vez a los numeros pero luego de ordenar
            resulta(inserccionorden(numeros));
            Console.WriteLine("\n");
            Console.Read();
        }

        static int[] inserccionorden(int[] arregloins)
        {
            for (int i = 0; i < arregloins.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arregloins[j - 1] > arregloins[j])
                    {
                        int tempo = arregloins[j - 1];
                        arregloins[j - 1] = arregloins[j];
                        arregloins[j] = tempo;
                    }
                }
            }
            return arregloins;
        }
        public static void resulta(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i.ToString() + "  ");
            }
            
        }
        
        
    }
}
