using System;

namespace CalculoMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo à Calculadora de Média");
            Console.WriteLine();

            
            double nota1, nota2, nota3, nota4;
            string frase = "Digite a {0}ª nota.";
            
            Console.WriteLine(frase, 1);
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(frase, 2);
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(frase, 3);
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(frase, 4);
            nota4 = Convert.ToDouble(Console.ReadLine());

            double total =  nota1 + nota2 + nota3 + nota4;
            double media = total / 4;

            if(media < 4)
            {
                Console.WriteLine("Sua média é: " + media + ".");
                Console.WriteLine("Você está de recuperação.");
            }

                else if(media < 7)
                {
                    Console.WriteLine("Sua média é: " + media + ".");
                    Console.WriteLine("Você está de exame.");

                }
            else
            {
                Console.WriteLine("Sua média é: " + media + ".");
                Console.WriteLine("Você Foi aprovado.");
                Console.WriteLine("Parabéns!");
            }
            
        }
    }
}
