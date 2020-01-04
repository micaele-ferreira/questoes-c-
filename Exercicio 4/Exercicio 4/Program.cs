using System;
using System.Globalization;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 4");
            Console.WriteLine("Exemplo 1");
            double numero = double.Parse(Console.ReadLine());
            double horasTrabalhadas = double.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = horasTrabalhadas * valorHora;
            Console.WriteLine("Numero=" + numero);
            Console.WriteLine("Salario=" + salario);

            Console.WriteLine("Exemplo 2");
            double numero1 = double.Parse(Console.ReadLine());
            double horasTrabalhadas1 = double.Parse(Console.ReadLine());
            double valorHora1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario1 = horasTrabalhadas1 * valorHora1;
            Console.WriteLine("Numero=" + numero1);
            Console.WriteLine("Salario=" + salario1);

            Console.WriteLine("Exemplo 3");
            double numero2 = double.Parse(Console.ReadLine());
            double horasTrabalhadas2 = double.Parse(Console.ReadLine());
            double valorHora2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario2 = horasTrabalhadas2 * valorHora2;
            Console.WriteLine("Numero=" + numero2);
            Console.WriteLine("Salario=" + salario2);






        }
    }
}
