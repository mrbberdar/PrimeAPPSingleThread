using System;
using System.Collections.Generic;
using System.Threading;
using System.Collections.Concurrent;
using System.Diagnostics;



namespace PrimeAPPSingleThread
{
    class Program
    {
        public static List<long> data = new List<long>();

        public static void addPrime(long start, long x)
        {
            int inc = 0;
            for (long i = start; i <= x; i++)
            {
                if (i == 2)
                {
                    data.Add(i);
                }
                else
                {

                    for (int j = 2; j <= i - 1; j++)
                    {
                        if (i % j != 0)
                        {
                            inc++;
                        }
                    }
                    if (inc == i - 2)
                    {
                        data.Add(i);
                    }
                    inc = 0;
                }
            }
        }



        public static void readData(List<long> l)
        {
            foreach (long v in l)
            {
                Console.Write(v + " ");
            }
        }






        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Please add, up to what number do you want to see the prime numbers!");
            addPrime(2, Int64.Parse(Console.ReadLine().ToString()));
            readData(data);
            stopwatch.Stop();

            Console.WriteLine("\n\nTime Elapsed: " + stopwatch.Elapsed);



        }


    }

}

