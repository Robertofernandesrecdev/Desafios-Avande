using System;

namespace pizza_ano
{
    class Program
    {
        static void Main(string[] args)

     {
         string[] line = Console.ReadLine().Split(" ");
        int totalPessoas = int.Parse(line[0]);
        int totalDatas = int.Parse(line[1]);
    
    string dataConsiderada = "";
    
    for (int i = 0; i < totalDatas; i++)
    {
      int podemComparecer = 0;
      
      string[] dataConfirmacao = Console.ReadLine().Split(" ");
      dataConsiderada = dataConfirmacao[0];
      
      for (int y = 1; y < totalPessoas + 1; y++)
      {
        podemComparecer += int.Parse(dataConfirmacao[y]);
      }
      
      if (podemComparecer == totalPessoas)
      {
        Console.WriteLine(dataConsiderada);
        break;
      } 
      else if ( i + 1 >= totalDatas)
      {
        Console.WriteLine("Pizza antes de FdA");
      }
    }
  }
}
        }
    

