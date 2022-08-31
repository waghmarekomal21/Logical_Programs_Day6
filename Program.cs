﻿namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programming");
            while (true)
            {
                Console.WriteLine("Select program\n 1. fibonacci series\n 2. perfect number\n 3. prime number\n 4. reverse number"); //5. temperature conversion
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries fibonacciSeries = new FibonacciSeries();
                        fibonacciSeries.Series();
                        break;
                    case 2:
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.Number();
                        break;
                    case 3:
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.PrimeNumCheck();
                        break;
                    case 4:
                        ReverseNumber reverseNumber = new ReverseNumber();
                        reverseNumber.Number();
                        break;
                    //case 5:
                    //    TemperatureConversion temperatureConversion = new TemperatureConversion();
                    //    temperatureConversion.Conversion();
                    //    break;
                    default:
                        Console.WriteLine("Select correct option");
                        break;
                }
            }

        }
    }
}