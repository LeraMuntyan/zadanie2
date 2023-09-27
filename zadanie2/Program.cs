using System;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {



            Random rand = new Random();
            int n = 20;
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 20);
                Console.Write("{0,2} ", i);
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
                Console.Write("{0,2} ", arr[i]);
            Console.WriteLine();
            bool k = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < i)
                {
                    Console.Write("{0,2} ", arr[i]);
                    k = false;
                }
                else
                    Console.Write("   ");
            }
            if (k)
                Console.WriteLine("Znachenii, menshih svoih indeksov net");
            Console.WriteLine();

            {
                Console.WriteLine("Esli hotite povtorit vvod, vvedite 1, inache lubuyu dr cifru");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1) Main();
                return;
            }
            Console.ReadLine();
        }
    }
}
