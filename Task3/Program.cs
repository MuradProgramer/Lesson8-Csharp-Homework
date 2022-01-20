using System;

namespace Azerbaijan
{
    public static class Baku
    {
        public readonly static int CountOfPopulation = 2_000_000;
    }
}

namespace Russia
{
    public static class Moscow
    {
        public readonly static int CountOfPopulation = 10_000_000;
    }
}

namespace Polsha
{
    public static class Varshawa
    {
        public readonly static int CountOfPopulation = 5_000_000;
    }
}

namespace Turkey
{
    public static class Ankara
    {
        public readonly static int CountOfPopulation = 12_000_000;
    }
}

namespace Georgia
{
    public static class Tbilisi
    {
        public readonly static int CountOfPopulation = 500_000;
    }
}

namespace Brazil
{
    public static class Brazil
    {
        public readonly static int CountOfPopulation = 7_000_000;
    }
}

namespace England
{
    public static class London
    {
        public readonly static int CountOfPopulation = 8_500_000;
    }
}

namespace Task3
{
    class Program
    {
        static int GetPopulation(int ind)
        {
            ind--;
            switch (ind)
            {
                case 0:
                    return Azerbaijan.Baku.CountOfPopulation;
                case 1:
                    return Russia.Moscow.CountOfPopulation;
                case 2:
                    return Polsha.Varshawa.CountOfPopulation;
                case 3:
                    return Turkey.Ankara.CountOfPopulation;
                case 4:
                    return Georgia.Tbilisi.CountOfPopulation;
                case 5:
                    return Brazil.Brazil.CountOfPopulation;
                case 6:
                    return England.London.CountOfPopulation;
                default:
                    throw new ArgumentOutOfRangeException("Index Must Be Between 1 and 7", nameof(ind));
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER 3 COUNTRY: ");
            Console.WriteLine("[1] - Azerbaijan");
            Console.WriteLine("[2] - Russia");
            Console.WriteLine("[3] - Polsha");
            Console.WriteLine("[4] - Turkey");
            Console.WriteLine("[5] - Georgia");
            Console.WriteLine("[6] - Brazil");
            Console.WriteLine("[7] - England");
            int a = GetPopulation(int.Parse(Console.ReadLine()));
            int b = GetPopulation(int.Parse(Console.ReadLine()));
            int c = GetPopulation(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Max Population: {Math.Max(a, Math.Max(b, c))}");
        }
    }
}