using System;

namespace idade_dias
{
    class Program
    {
  public static void Main (string[] args) {
    var idadeEmDias = int.Parse(Console.ReadLine());
    var anos = 0; // Implemente aqui o calculo dos anos
    var meses = 0; // Implemente aqui o calculo dos meses 
    while (idadeEmDias >= 365)
        {
            idadeEmDias -= 365;
            anos++;
        }

        while (idadeEmDias >= 30)
        {
            idadeEmDias -= 30;
            meses++;
        } 

    Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{idadeEmDias} dia(s)");
  }
}
        }
    

