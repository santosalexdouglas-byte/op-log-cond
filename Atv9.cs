/*Ref. (5 pontos)
9 - Escreva um programa que leia um número e verifique se ele é positivo,
negativo ou zero.
Nome:
*/

public static class Atv9
{
    public static void Executar()
    {
        {
            Console.Write("Digite um número:");

            //num é a variável que guarda o número que você digitar
            double num = double.Parse(Console.ReadLine()!);

            if (num > 0)
            {
                Console.WriteLine("O número é positivo");
            }
            else if (num < 0)
            {
                Console.WriteLine("O número é negativo");
            }
            else
            {
                Console.WriteLine("O número é zero");

            }
        }
    }
}