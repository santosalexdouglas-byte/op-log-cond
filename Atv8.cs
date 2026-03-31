/*Ref. (10 pontos)8 - Crie um programa que faça
 5 perguntas para uma pessoa sobre um crime. As perguntas são: "Telefonou para a vítima?"
 "Esteve no local do crime?" "Mora perto da vítima?" "Devia para a vítima?" "Já trabalhou com a vítima?"
 O programa deve, no final, emitir uma classificação sobre a participação da pessoa no crime.
 Se a pessoa responder positivamente a 2 questões, ela deve ser classificada/exibida como "Suspeita",
 entre 3 e 4 como "Cúmplice" e 5 como "Assassino". Caso contrário, ela será classificada como "Inocente".Aluno:*/
public static class Atv8
{
    public static void Executar()
    {
        int pontos = 0;
        string resp;

        Console.WriteLine("responder apenas com sim ou não (letras minusculas):");

        //Pergunta 1
        Console.Write("telefonou para a vitima?");
        resp = Console.ReadLine();
        if (resp == "sim")
        {
            pontos = pontos + 1;
        }

        //pergunta 2
        Console.Write("Estava no local do crime?");
        resp = Console.ReadLine();
        if (resp == "sim")
        {
            pontos = pontos + 1;
        }

        //pergunta 3
        Console.Write("mora perto da vitima?");
        resp = Console.ReadLine();
        if (resp == "sim")
        {
            pontos = pontos + 1;
        }
        //pergunta 4
        Console.Write("devia para a vitima?");
        resp = Console.ReadLine();
        if (resp == "sim") ;
        {
            pontos = pontos + 1;
        }
        //pergunta 5
        Console.Write("já trabalhou com a vitima?");
        resp = Console.ReadLine();
        if (resp == "sim")
        {
            pontos = pontos + 1;
        }

        //resultado final
        Console.WriteLine();
        if (pontos == 3)
        {
            Console.WriteLine("Classificação:Assasino");
        }
        if (pontos == 3 || pontos == 4)
        {
            Console.WriteLine("Classificação:cumplice");
        }
        if (pontos == 2)
        {
            Console.WriteLine("Classificação:suspeito");
        }
        if (pontos == 1)
        {
            Console.WriteLine("Classificação:Inocente");
        }

    }
}