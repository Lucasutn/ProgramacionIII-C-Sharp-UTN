using System;
using static System.Console;

namespace Dado
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey imput = ConsoleKey.Enter;

            Dado dado = new Dado(6);


            while (imput.Equals(ConsoleKey.Enter))
            {
                WriteLine("Ingrese apuesta 1-6 \n");


                bool resul = play(int.Parse(Console.ReadLine()), dado);


                if (resul)
                {
                    WriteLine("Ganador \n");
                }
                else
                {
                    WriteLine("Perdedor \n");
                }

                WriteLine("\n Enter para Continuar::\n");
                imput = ReadKey().Key;
            }
        }


        private static bool play(int apuesta, Dado dado)
        {
            
            return apuesta == dado.lanzar();
        }
    }
}