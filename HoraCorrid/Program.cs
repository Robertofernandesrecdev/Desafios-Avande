using System;

namespace HoraCorrid
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texto = Console.ReadLine().Split(" ");
            int A = int.Parse(texto[0]), N = int.Parse(texto[1]);

            int totPlacas = A * N;

            for (int i = 10; i <= 90; i += 10)
            {
                double result = (double)totPlacas / 100 * i;
                Console.Write(Math.Ceiling(result) + " ");
            }
        }
    }
}
        
    

