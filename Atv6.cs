/*Ref. (10 pontos)
6 - Um programa deve ler três ângulos e verificar qual é o tipo de triângulo formado. 
Primeiro, é necessário conferir se a soma dos três ângulos é igual a 180°, 
pois só assim eles formam um triângulo. Depois, se um dos ângulos for igual a 90°, 
o triângulo é retângulo. Se um dos ângulos for maior que 90°, ele é obtusângulo. 
Caso contrário, se os três forem menores que 90°, o triângulo é acutângulo.
Nome:
*/

public static class Atv6
{
    public static void Executar()
    {
        Console.Write("Digite o 1 angulo:");
        int A1 = int.Parse(Console.ReadLine()!);

        Console.Write("Digite o 2 angulo:");
        int A2 = int.Parse(Console.ReadLine()!);

        Console.Write("Digite o 3 angulo:");
        int A3 = int.Parse(Console.ReadLine()!);

        //Soma basica para validar o triangulo
        int soma = A1 + A2 + A3;

        if (soma == 180)
        {
            //Classificação por angulos
            if (A1 == 90 || A2 == 90 || A3 == 90)
            {
                Console.Write("retangulo retangulo");
            }
            if (A1 > 90 || A2 > 90 || A3 > 90)
            {
                Console.Write("retangulo obtusangulo");
            }
        }
        {
            Console.Write("não forma um triangulo soma diferente de 180°)");
        }
    }
}