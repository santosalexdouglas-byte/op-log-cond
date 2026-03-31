/*Para doar sangue é necessário ter entre 18 e 67 anos e possuir mais de 60 kg. 
Faça um aplicativo que pergunte a idade de uma pessoa e seu peso e diga se ela pode 
doar sangue ou não; caso não possa, diga o(s) motivo(s).
Nome:
*/

public static class Atv7
{
  public static void Executar()
  {
    double idade;
    double kg;

    Console.WriteLine("Digite a idade");
    idade = double.Parse(Console.ReadLine()!);

    Console.WriteLine();

    Console.WriteLine("Digite o seu peso");
    kg = double.Parse(Console.ReadLine()!);

    if (idade >= 18 && idade <= 67)
    {
      if (kg >= 60)
      {
        Console.WriteLine("pode tirar sangue");
      }
      else
      {
        Console.WriteLine("não pode tirar sangue pois,o seu peso não esta nas normas ");
      }
    }
    else
    {
      Console.WriteLine("não pode tirar sangue pois,a sua idade não esta nas normas para ");
    }
  }
}