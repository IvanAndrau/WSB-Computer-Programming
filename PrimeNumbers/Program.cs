using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    class Program
    {
        static void Sieve(int max, int count)
        {
            bool[] is_prime = new bool[max + 1];
            for(int i=0;i<max;i++)
            {
                is_prime[i] = true;
            }
            for (int i = 2; i <= max; i++)
                if (is_prime[i])
                    for (int j = 2 * i; j <= max; j += i)
                        is_prime[j] = false;


            for (int i = 2; i < max; i++)
            {
                if (is_prime[i])
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
        }

        static void Main()
        {
            int count = 0;
            int max;
            Console.Write("Enter max number: ");
            max = int.Parse(Console.ReadLine());
            Sieve(max, count);
            Console.ReadLine();
        }
    }
}