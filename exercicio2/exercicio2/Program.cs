using System;
using System.Globalization;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Raio do circulo");
            Console.WriteLine("exemplo 1");
            double raio1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159; 
            double area = pi * Math.Pow(raio1,2.0);
            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("exemplo 2");
            double raio2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area2 = pi * Math.Pow(raio2, 2.0);
            Console.WriteLine("A=" + area2.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("exemplo 3");
            double raio3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area3 = pi * Math.Pow(raio3, 2.0);
            Console.WriteLine("A=" + area3.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
