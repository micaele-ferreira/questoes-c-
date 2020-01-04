using System;
using System.Globalization;
namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 6");
            Console.WriteLine("Exemplo 1");
            double A1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;

            double triangulo1 = (A1 * C1) / 2;
            double circulo1 = pi * C1 * C1;
            double trapesio1 = ((A1 + B1) * C1) / 2;
            double quadrado1 = B1 * B1;
            double retangulo1 = A1 * B1;
            Console.WriteLine("Triangulo:" + triangulo1);
            Console.WriteLine("circulo:" + circulo1);
            Console.WriteLine("trapesio:" + trapesio1);
            Console.WriteLine("quadrado:" + quadrado1);
            Console.WriteLine("retangulo:" + retangulo1);


            Console.WriteLine("Exemplo 2");
            double A2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            double triangulo2 = (A2 * C2) / 2;
            double circulo2 = pi * C2 * C2;
            double trapesio2 = ((A2 + B2) * C2) / 2;
            double quadrado2 = B2 * B2;
            double retangulo2 = A2 * B2;
            Console.WriteLine("Triangulo:" + triangulo2);
            Console.WriteLine("circulo:" + circulo2);
            Console.WriteLine("trapesio:" + trapesio2);
            Console.WriteLine("quadrado:" + quadrado2);
            Console.WriteLine("retangulo:" + retangulo2);







        }
    }
}
