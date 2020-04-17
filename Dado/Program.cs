using System;
using System.Runtime.CompilerServices;
using static System.Console;

namespace Dado
{
    class Program
    {
        
        Dado dado = new Dado(6);
        
        static void Main(string[] args)
        {
            ConsoleKey imput = ConsoleKey.Enter;
            

            while (imput.Equals(ConsoleKey.Enter))
            {
                WriteLine("Ingrese apuesta 1-6 \n");

                int apuesta = int.Parse(Console.ReadLine());

                int resul = play(apuesta, new Program().dado);


                if (resul == apuesta)
                {
                    WriteLine($"Ganador:   { apuesta  } \n");
                }
                else
                {
                    WriteLine($"Perdedor:   { apuesta  } \n");
                    
                }

                WriteLine("\n Enter para Continuar::\n");
                imput = ReadKey().Key;
            }
        }


        private static int play(int apuesta, Dado dado)
        {
            
            return dado.lanzar();
        }
    }
    
}