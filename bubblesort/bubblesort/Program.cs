using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubblesort
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //comienzo con las variables, pero antes, debo colocar el arreglo []
            
            int[] number = { 5, 1, 22, 101, 50, 52, 35, 2 };
            
            //ahora el resto de las variables, especificando el largo de num
            int vtemporal;
            int largodenumero = number.Length;
            
            //para que el usuario vea el antes y luego, coloco el arreglo en su estado original luego de las declaraciones, ya que si lo coloco más abajo, no va a mostrar lo requerido.
            Console.WriteLine("Sus números en estado original:");
            foreach (int num in number)
            {
                Console.WriteLine(num + "");
            }

            //comienzo con el for y la condicional para indicar su comienzo y que este va en aumento:
            for (int i = 1; i < largodenumero; i++)
            {
                for (int j = 0; j < (largodenumero - 1); j++)
                {

                    //con el if indico que debe cambiar de lugar los números que no estén en una posición adecuada:
                    if (number[j] > number[j + 1])
                    {
                        vtemporal = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = vtemporal;

                    }
                }
            }

            //finalmente, imprimo los números en orden y le coloco console read para que esta no se cierre al dar el resultado: 
            Console.WriteLine("Sus números de forma organizada:");
            foreach (int num in number)
            {
                Console.WriteLine(num + "");
            }
            Console.Read();

        }
    }
}
