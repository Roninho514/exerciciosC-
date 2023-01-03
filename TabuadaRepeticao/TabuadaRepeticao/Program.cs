using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabuadaRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int contador = 1; contador <= 10; contador ++)
            {
                for(int numerador = 1; numerador <=10; numerador++)
                {
                    int result = contador * numerador;
                    Console.WriteLine("{0} x {1} = {2}" , contador, numerador,result);
                }

                Console.WriteLine("--------------------");

            }
                Console.ReadLine();
        }
    }
}
