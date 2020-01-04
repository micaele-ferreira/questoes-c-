using System;
using System.Globalization;

namespace Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "computador";
            string produto2 = "Mesa de escritorio";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cuja o preço é $ {preco1}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2}");

            Console.WriteLine($" Registro: {idade} anos de idade, codigo {codigo} e gênero: {genero}");

            Console.WriteLine($" Medida: {medida}");
            Console.WriteLine($" Medida: {medida:F2}");
            Console.WriteLine(" Medida "+ medida.ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}
