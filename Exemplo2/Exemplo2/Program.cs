﻿using System;
using System.Globalization;

namespace Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            String nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto.");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu ultimo nome idade e altura");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimo = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
            
            Console.WriteLine("Você escreveu:");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(ultimo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
               

        }
    }
}
