//2 – Faça um programa que verifique se uma letra digitada é vogal ou consoante//

public static class Atv2
{
    public static void Executar()
    {

        string letra;

        Console.Write("digite uma letra: ");
        letra = Console.ReadLine()!.ToLower();

        if ((letra == "a") || (letra == "A") || (letra == "e") || (letra == "E") || (letra == "i") || (letra == "I") || (letra == "o") || (letra == "O") || (letra == "u") || (letra == "U"))
        {
            Console.WriteLine("A letra digitada é uma vogal.");
        }
        else
        {
            Console.WriteLine("A letra digitada não é uma vogal.");
        }
    }
}