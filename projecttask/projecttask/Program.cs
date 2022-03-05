using System;

namespace projecttask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, count = 0;
            while (true)
            {
                Console.WriteLine("eded daxil et:");
                number = Convert.ToInt32(Console.ReadLine());
                {
                    while (number > 0)
                    {
                        number = number / 10;
                        count++;
                    }
                    Console.WriteLine("merteblerin  sayi:" + count);
                    Console.ReadLine(); 
                }
            }
        }
    }
}
