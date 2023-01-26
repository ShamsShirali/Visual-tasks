using System;

namespace work1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loopCount = 0;
            int num = 11;

            bool isPrime=false;
            for(var i=2;i*i<num;i++)
            {
                loopCount++;
                if(num%i==0)
                    {
                    isPrime = true;
                    break;
                    }
            }
            if (isPrime == true)
                Console.WriteLine("murekkebdir");
            else
                Console.WriteLine("Sadedir");
            Console.WriteLine(loopCount);

            int number = -2;
            if(number%2==0)
            {
                Console.WriteLine("musbet eded");
            }
            else if (number < 0)
            {
                Console.WriteLine("menfidir");

            }
            else
            {
                Console.WriteLine("sifirdir");
            }
        }
    }
}
