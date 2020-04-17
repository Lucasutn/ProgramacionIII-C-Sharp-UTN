using System;

namespace Dado
{
    public class Dado
    {
        private int numbers;

        public Dado(int numbers)
        {
            this.numbers = numbers;
        }


        public int lanzar()
        {
            return new Random().Next(numbers) + 1;
        }
    }
}