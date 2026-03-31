/*Ref. (10 pontos)
3 - Escreva um programa que receba três números inteiros e mostre eles em ordem crescente.Nome:*/
public static class Atv3
{
    public static void Executar()
    {
        int n1;
        int n2;
        int n3;
        int maior = 0;
        int intermediario = 0;
        int menor = 0;

        Console.Write("Digite o primeiro numero: ");
        n1 = int.Parse(Console.ReadLine()!);

        Console.Write("Digite o segundo numero: ");
        n2 = int.Parse(Console.ReadLine()!);

        Console.Write("Digite o terceiro numero: "); n3 = int.Parse(Console.ReadLine()!);

        if ((n1 > n2) && (n1 > n3))
        {
            maior = n1;

            if (n2 > n3)
            {
                intermediario = n2;
                menor = n3;
            }
            else
            {
                intermediario = n3;
                menor = n2;
            }
        }


        if ((n2 > n1) && (n2 > n3))
        {
            maior = n2;

            if (n1 > n3)
            {
                intermediario = n1;
                menor = n3;
            }
            else
            {
                intermediario = n3;
                menor = n1;
            }
        }

        if ((n3 > n1) && (n3 > n2))
        {
            maior = n3;

            if (n1 > n2)
            {
                intermediario = n1;
                menor = n2;
            }
            else
            {
                intermediario = n2;
                menor = n1;
            }
        }

        Console.WriteLine($" {menor}, {intermediario}, {maior}");
    }
}