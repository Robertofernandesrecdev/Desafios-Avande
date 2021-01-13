using System;

namespace primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
        int limit = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < limit; i++) 
        {
            string[] line = Console.ReadLine().Split(" ");
            double X = double.Parse(line[0]);
            double Y = double.Parse(line[1]);
            if (Y == 0) {
              Console.WriteLine("divisao impossivel");
            }else if (X / Y < 0 && X / Y > -0.05){
              Console.WriteLine("-0.0");
            } else {
              double divisao = X / Y; // Digite aqui o calculo da divisao
              Console.WriteLine(divisao.ToString("N1"));
            } 
        }
    }
        }
    }

