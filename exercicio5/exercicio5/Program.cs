using System;
using System.Globalization;
namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 5");
            Console.WriteLine("Exemplo 1");
            double peca1 = double.Parse(Console.ReadLine());
            double numeroPecas1 = double.Parse(Console.ReadLine());
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorTotal1 = numeroPecas1 * valor1;
            double peca2 = double.Parse(Console.ReadLine());
            double numeroPecas2 = double.Parse(Console.ReadLine());
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorTotal2 = numeroPecas2 * valor2;
            double pagar1 = valorTotal1 + valorTotal2;

            Console.WriteLine("Valor a pagar =" + pagar1);

            Console.WriteLine("Exemplo 2");
            double peca3 = double.Parse(Console.ReadLine());
            double numeroPecas3 = double.Parse(Console.ReadLine());
            double valor3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorTotal3 = numeroPecas3 * valor3;
            double peca4 = double.Parse(Console.ReadLine());
            double numeroPecas4 = double.Parse(Console.ReadLine());
            double valor4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorTotal4 = numeroPecas4 * valor4;
            double pagar2 = valorTotal3 + valorTotal4;

            Console.WriteLine("Valor a pagar =" + pagar2);

            Console.WriteLine("Exemplo 3");
            double peca5 = double.Parse(Console.ReadLine());
            double numeroPecas5 = double.Parse(Console.ReadLine());
            double valor5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorTotal5 = numeroPecas5 * valor5;
            double peca6 = double.Parse(Console.ReadLine());
            double numeroPecas6 = double.Parse(Console.ReadLine());
            double valor6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorTotal6 = numeroPecas6 * valor6;
            double pagar3 = valorTotal5 + valorTotal6;

            Console.WriteLine("Valor a pagar =" + pagar3);


        }
    }
}
