using System;
using System.Linq;

namespace corridaTartarugas
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0, limit = 0;
            while (limit < 3)
            {
                int N = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 Converte um valor especificado em um inteiro com sinal de 32 bits.
                int[] tSpeed = new int[N];
                string[] turSpeed = Console.ReadLine().Split();
                for (int i = 0; i < turSpeed.Length; i++)
                {
                    tSpeed[i] = Convert.ToInt32(turSpeed[i]);
                }

                max = tSpeed.Max(); // retorna o valor máximo em uma sequêcia de valores! 

                if (max < 10)
                {
                    Console.WriteLine(1);
                }
                else if (max < 20)
                {
                    Console.WriteLine(2);
                }
                else if (max >= 20)
                {
                    Console.WriteLine(3);
                }
                limit++;
            }
        }
    }
}
        
    

