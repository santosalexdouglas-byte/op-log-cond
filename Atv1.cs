/*Ref (5 pontos)
1 - Faça um programa que calcule e apresente o valor do volume de uma lata, 
sabendo que PI é um valor constante de 3.14159, o programa deve pedir os valores 
de RAIO e ALTURA, utilize a fórmula VOLUME = PI * RAIO² * ALTURA.
Nome:
*/

using System.IO.Pipes;
using System.Runtime.CompilerServices;

public static class Atv1
{
  public static void Executar()
  {

    double pi = 3.14159;
    double raio = 10;
    double altura = 5;

    Console.WriteLine();

    Console.WriteLine("digite o valor de raio");
    raio = double.Parse(Console.ReadLine()!);
    Console.WriteLine();

    Console.WriteLine("digite o valor da altura");
    altura = double.Parse(Console.ReadLine()!);

    double total = pi * (raio * raio) * altura;
    Console.WriteLine(total);

  }

}