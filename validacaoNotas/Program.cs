using System;

namespace validacaoNotas
{
    class Program
    {
        static void Main(string[] args)
        {
        double somaNotas = 0;
        int contador = 0;
        do
        {
            double notaEntrada = double.Parse(Console.ReadLine());

            if (notaEntrada < 0 || notaEntrada > 10)
            {
                Console.WriteLine("nota invalida");
            }
            else
            {
                contador++;
                somaNotas += notaEntrada;
            }
        } while (contador < 2);
        Console.WriteLine("media = " + (somaNotas / 2).ToString("N2"));
    }
}
}        
    

