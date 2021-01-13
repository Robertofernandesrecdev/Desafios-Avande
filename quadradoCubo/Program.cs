using System;

namespace quadradoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
        int N = Int32.Parse(Console.ReadLine());
        for (int i = 1; i <= N; i++) {
          int quadrado = i*i;
          int cubo = quadrado*i;
          Console.WriteLine(i+" "+quadrado+" "+cubo);
        }
    }
}
}