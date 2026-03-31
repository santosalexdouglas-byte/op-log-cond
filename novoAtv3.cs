





public static class novoAtv3
{
    public static void Executar()
    {
        int numeroUm;
        int numeroDois;
        int numeroTres;
        int auxiliar;

        Console.Write("Digite o primeiro numero: ");
        numeroUm = int.Parse(Console.ReadLine()!);

        Console.Write("Digite o segundo numero: ");
        numeroDois = int.Parse(Console.ReadLine()!);

        Console.Write("Digite o terceiro numero: ");
        numeroTres = int.Parse(Console.ReadLine()!);

        if (numeroUm > numeroDois)
        {
            auxiliar = numeroUm;
            numeroUm = numeroDois;
            numeroDois = auxiliar;
        }

        if (numeroUm > numeroTres)
        {
            auxiliar = numeroUm;
            numeroUm = numeroTres;
            numeroTres = auxiliar;
        }

        if (numeroDois > numeroTres)
        {
            auxiliar = numeroDois;
            numeroDois = numeroTres;
            numeroTres = auxiliar;
        }

        Console.WriteLine($"Ordem crescente: {numeroUm}, {numeroDois}, {numeroTres}");

    }
}