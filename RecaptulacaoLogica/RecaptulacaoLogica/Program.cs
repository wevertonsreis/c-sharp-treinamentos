﻿namespace RecaptulacaoLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            ExibindoValoresVariaveis();
            ExibindoMaximoMinimo();
        }

        public static void ExibindoValoresVariaveis()
        {
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';

            byte n1 = 128;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;

            string nome = "Maria";

            object obj1 = "Alex";
            object obj2 = 4.5f;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
        }

        public static void ExibindoMaximoMinimo()
        {
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
        }
    }
}