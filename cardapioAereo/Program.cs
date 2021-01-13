using System;

namespace cardapioAereo
{
    class Program
    {
        static void Main(string[] args)
        {
    
    string[] entrada1 = Console.ReadLine().Split(" ");
    int ca = int.Parse(entrada1[0]);
    int ba = int.Parse(entrada1[1]);
    int pa = int.Parse(entrada1[2]);
    
    string[] entrada2 = Console.ReadLine().Split(" ");
    int cr = int.Parse(entrada2[0]);
    int br = int.Parse(entrada2[1]);
    int pr = int.Parse(entrada2[2]);
    
    int CIndisponivel = 0;
    int BIndisponivel = 0;
    int PIndisponivel = 0;

    if (cr > ca)
      CIndisponivel = cr - ca;

    if (br > ba)
      BIndisponivel = br - ba;

    if (pr > pa)
      PIndisponivel = pr - pa;

    int TotalIndisponivel = CIndisponivel + BIndisponivel + PIndisponivel;

    if (TotalIndisponivel >= 0)
      Console.Write(TotalIndisponivel);
    
  }
}
        }
    

