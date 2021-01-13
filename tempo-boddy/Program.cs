using System;

namespace tempo_boddy
{
    class Program
    {
        static void Main(string[] args)
        {
    {
        int N = Int32.Parse(Console.ReadLine()); // O Console.ReadLine recebe o input do teclado ou seja vem como string, vc tem em usar o int.parse para converer para int.
        string presentes = Console.ReadLine();
        string saida = "Farei hoje!";

        string[] stringTempoPresentes = presentes.Split(" "); //Split é usado para quebrar uma cadeia de caracteres delimitada em subcadeias de caracteres. Você pode usar uma matriz de caracteres ou uma matriz de cadeia de caracteres para especificar zero ou mais caracteres de delimitação ou Strings.
        int[] tempoPresentes = Array.ConvertAll<string, int>(stringTempoPresentes, int.Parse); // O método Array.ConvertAll, converte uma matriz de um tipo em uma matriz de outro tipo.

        if (tempoPresentes[0] + tempoPresentes[1] > N) // condição 
        {
            saida = "Deixa para amanha!"; //saida
        }

        System.Console.WriteLine(saida); // escreve a saida na tela 

    }
        }
    }
}
