using System;
using System.Linq;

namespace MaxValue
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Enter the amount of integers you will be providing:");
            int numAmount = Convert.ToInt32(Console.ReadLine());

            int []answer = new int[numAmount];
            for(int i = 0; i < numAmount; i++)
            {
                Console.WriteLine("Enter int {0}:", i);           
                answer[i] = Convert.ToInt32(Console.ReadLine());
            }

            int maxNum = answer.Max();
            Console.WriteLine("Max number is {0}!", maxNum);
            

        }
    }
}
