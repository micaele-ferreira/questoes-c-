using System;
using System.Globalization;

namespace entrada2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            char genero = char.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
            
            Console.WriteLine("voce escreveu");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(d);
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(genero);
            Console.WriteLine(altura.ToString ("F2", CultureInfo.InvariantCulture));

        }
    }
}
