using System;
using Figgle;

namespace MDC
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2;
            int divisor, dividendo, resto;
            string op;

            do
            {
                Console.Write("Digite o 1ºValor(a): ");
                valor1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o 2ºValor(b): ");
                valor2 = int.Parse(Console.ReadLine());

                if (valor1 == 0 || valor2 == 0)
                {
                Console.Clear();
                Console.WriteLine("Não Pode Conter Valores Que São Igual a Zero");
                Console.WriteLine("Pressione ENTER Para Sair! e Execute o Programa Novamente!");
                Console.ReadKey();
                Environment.Exit(-1);
                }

                if (valor1 > valor2)
                {
                dividendo = valor1;
                divisor = valor2;
                }

                else
                {
                dividendo = valor2;
                divisor = valor1;
                }
                while (dividendo % divisor != 0)
                {
                resto = dividendo % divisor;
                dividendo = divisor;
                divisor = resto;
                }

                Console.WriteLine();
                Console.WriteLine("MDC(a, b) = " + divisor);

                Console.WriteLine("Deseja Sair? S/N");
                op = Console.ReadLine().ToUpper();
            }
            while (op == "N" || op == "NAO"); 
            {
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(FiggleFonts.Big.Render("Maximo Divisor!"));
                Console.ResetColor();
                Environment.Exit(-1);
            }    
        }
    }
}
