using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 3");
            Console.WriteLine("Exemplo 1");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            int diferenca = (A * B - C * D);
            Console.WriteLine("Diferença=" + diferenca);

            Console.WriteLine("Exemplo 1");
            int A1 = int.Parse(Console.ReadLine());
            int B1 = int.Parse(Console.ReadLine());
            int C1 = int.Parse(Console.ReadLine());
            int D1 = int.Parse(Console.ReadLine());
            int diferenca1 = (A1 * B1 - C1 * D1);
            Console.WriteLine("Diferença=" + diferenca1);

        }
    }
}
