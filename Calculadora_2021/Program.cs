using System;

namespace Calculadora_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, soma, c, d, subtracao, e, f, multiplicacao, g, h, divisao, sobra;

            Console.WriteLine("Digite somente o numeral da soma!");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            soma = a + b;

            Console.WriteLine("Digite somente o numeral da subtração!");
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            subtracao = c - d;

            Console.WriteLine("Digite somente o numeral da multiplicação!");

            e = int.Parse(Console.ReadLine());
            f = int.Parse(Console.ReadLine());

            multiplicacao = e * f;

            Console.WriteLine("Digite somente o numeral da divisão!");

            g = int.Parse(Console.ReadLine());
            h = int.Parse(Console.ReadLine());

            divisao = g / h;
            sobra = g % h;
            
            Console.WriteLine("O resultado da sua soma é: " + soma);
            Console.WriteLine("O resultado da sua subtração é: " + subtracao);
            Console.WriteLine("O resultado da sua multiplicação é: " + multiplicacao);
            Console.WriteLine("O resultado da sua divisão é: " + divisao);
            Console.WriteLine("O resultado da sobra da divisão é: " + sobra);

            Console.ReadLine();




        }
    }
}
