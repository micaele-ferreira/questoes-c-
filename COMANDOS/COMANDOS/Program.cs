using System;
using System.Globalization;

namespace COMANDOS
{
    class Program
    {
        static void Main(string[] args)
        {

            char genero = 'M';
            int idade = 32;
            double saldo = 10.0221313;
            string nome = "Maria";

               
            Console.Write("Bom dia");
            Console.WriteLine("boa tarde");

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F3"));
            Console.WriteLine(saldo.ToString("F3", CultureInfo.InvariantCulture));



        }
    }
}
