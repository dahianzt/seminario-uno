using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenseleccion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                int[] number = { 5, 1, 22, 101, 50, 52, 35, 2 };

                int babynumber = 0;
                int place = 0;
                int tempo = 0;

                for (int i = 0; i < number.Length - 1; i++)
                {
                    babynumber = number[i];
                    place = i;

                    for (int j = i + 1; j < number.Length; j++)
                    {
                        if (number[j] < babynumber)
                        {
                            babynumber = number[j];
                            place = j;  
                        }
                    }

                    if (place != i)
                    {
                        tempo = number[i];
                        number[i] = number[place];
                        number[place] = tempo;
                    }
                }

                Console.WriteLine("Aquí están sus números organizados: ");

                for (int i = 0; i < number.Length; i++)
                {
                    Console.WriteLine(number[i]);
                }

            Console.Read();
        }
            
        
        
        }
    }

