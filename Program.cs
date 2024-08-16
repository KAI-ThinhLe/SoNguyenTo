using System;

class Program
{
    static void Main()
    {
        int number;
        Console.Write("Enter a positive integer: ");
        number = int.Parse(Console.ReadLine());

        if (number <= 1)
        {
            Console.WriteLine("The number is not a prime number.");
            return;
        }

        bool isPrime = true;
        int i = 2;
        while (i * i <= number)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
            i++;
        }

        if (isPrime)
        {
            Console.WriteLine("The number is a prime number.");
        }
        else
        {
            Console.WriteLine("The number is not a prime number.");
        }
    }
}
