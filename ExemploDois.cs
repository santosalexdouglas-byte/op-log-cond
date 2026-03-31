










public static class ExemploDois
{
    public static void Executar()
    {
         double nota;
         double frequancia;

        Console.WriteLine("Digite a nota do aluno");
        nota = double.Parse(Console.ReadLine()!);
    
        Console.WriteLine();

        Console.WriteLine("Digite a frequancia do aluno");
        frequancia = double.Parse(Console.ReadLine()!);

        if (nota >= 7)
        {
            if (frequancia >= 75)
            {
                Console.WriteLine("Aluno aprovado!");
            }
            else
            {
                Console.WriteLine("Aluno reprovado por frequência.");
            }
        }

    }
}