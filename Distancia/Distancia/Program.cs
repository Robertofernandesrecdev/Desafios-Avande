using System;

namespace Distancia
{
    class Program
    {
        static void Main(string[] args)
        {
        int x= 60 , y= 90;
        int quilometros = Int32.Parse(Console.ReadLine());
        int minutos = quilometros /(y - x ) * 60; // Digite aqui o calculo dos minutos
        Console.WriteLine(minutos + " minutos");
    }
}
        }

