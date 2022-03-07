using System;

namespace hello_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;
            int total = ((int)meal_cost + tip_percent) * (1 + tax_percent);
            Console.WriteLine($"總共是{total}");
        }
    }
}
