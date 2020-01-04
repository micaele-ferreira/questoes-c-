using System;
using System.Globalization;

namespace curso2
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 53;
            double saldo = 10.09765;
            string nome = "marcos";

            Console.WriteLine("placehouders");
            Console.WriteLine("{0} tem {1} anos e possui {2} reais na conta", nome, idade, saldo);
            Console.WriteLine("{0} tem {1} anos e possui {2:F2} reais na conta", nome, idade, saldo);
            Console.WriteLine("interpolacao");
            Console.WriteLine($"{nome} tem {idade} anos e possui {saldo} reais na conta");
            Console.WriteLine($"{nome} tem {idade} anos e possui {saldo:F2} reais na conta");
            Console.WriteLine("concatenacao");
            Console.WriteLine(nome + " tem " + idade + " anos e possui " + saldo + "reais na conta");
            Console.WriteLine(nome + " tem " + idade + " anos e possui " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais na conta ");




        }
    }
}

