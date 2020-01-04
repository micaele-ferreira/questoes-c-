using System;

namespace convercao
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 2.5f;
            double b = a;
            Console.WriteLine(b);

            double c = 5.1;
            float d = (float) c;
            Console.WriteLine(d);

            double e = 5.5;
            int f = (int)e;
            Console.WriteLine(f);

            int g = 5;
            int h = 2;
            double i =(double) g / h;
            Console.WriteLine(i);
        }
    }
}
