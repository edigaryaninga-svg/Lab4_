using System;

namespace Lab4
{
    class Program
    {
        public static void A(in int x)
        {
            Console.WriteLine($"Method A (in): {x}");
        }

        public static void B(out int x)
        {
            x = 20;
            Console.WriteLine($"Method B (out): {x}");
        }

        public static void C(ref int x)
        {
            x += 10;
            Console.WriteLine($"Method C (ref): {x}");
        }

        public static int SumValues(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int valA = 5;
            A(in valA);

            int valB;
            B(out valB);
            Console.WriteLine($"After Method B: {valB}");

            int valC = 15;
            C(ref valC);
            Console.WriteLine($"After Method C: {valC}");

            int totalSum = SumValues(1, 2, 3, 4, 5, 10);
            Console.WriteLine($"SumValues result: {totalSum}");

            Console.ReadKey();
        }
    }
}