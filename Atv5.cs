/*Ref (15 pontos)
5 - As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia,
e R$ 0,25 se forem compradas pelo menos doze.
 Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra.Nome:*/


public static class Atv5
{
    public static void Executar()
    {
        {
            Console.Write("Digite a quantidade de maças:");
            int quantidade = int.Parse(Console.ReadLine()!);

            double valortotal;

            //lógica simples:menos de 12 custa 0.30,12 pu custa 0.25
            if (quantidade < 12)
            {
                valortotal = quantidade * 0.30;
            }
            {
                valortotal = quantidade * 0.25;
            }
            Console.Write("o valor total de compra é:R$" + valortotal);
            {
            }
        }
    }
}