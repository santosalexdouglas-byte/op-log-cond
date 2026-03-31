/*Ref (15 pontos)
4 – Ler valor de nota de N1 e N2, calcular a média e escrever a nota correspondente, tal que 0 é a menor nota e 10 a maior,
 e imprimir o conceito equivalente (A, B, C, D ou E), conforme a seguinte tabela:
 A - nota >= 8,5 e nota <= 10 
 B - nota >= 7 e nota < 8,5 
 C - nota >= 5 e nota < 7 
 D - nota >= 3 e nota < 5 
 E - nota < 3
 Nome:*/

using System.Collections.Concurrent;
using System.Formats.Asn1;

public static class Atv4
{
    public static void Executar()
    {
        //Entrada de dados
        Console.Write("Digite a nota N1;");
        double N1 = double.Parse(Console.ReadLine()!);

        Console.Write("Digite a nota N2;");
        double N2 = double.Parse(Console.ReadLine()!);

        //Cálculo da média
        double n2 = double.Parse(Console.ReadLine()!);

        //Cálculo da média
        double media = (N1 + N2) / 2;

        //Exibir a média calculada
        Console.WriteLine("media:" + media);

        //Escada de perguntas para definir o conceito
        if (media > 8.5 && media <= 10)
        {
            Console.WriteLine("conceito:A");
            {
                if (media >= 7 && media < 8.5)
                {
                    Console.WriteLine("Conceito:B");
                }
                if (media >= 5 && media < 7)
                {
                    Console.WriteLine("Conceito:C");
                }
                if (media >= 3 && media < 5)
                {
                    Console.WriteLine("Conceito:D");
                }
                if (media < 3)
                {
                    Console.WriteLine("Conceito:e");
                }
                if (media < 2)
                {
                    Console.WriteLine("Nota inválida!");
                }
            }
        }
    }
}
