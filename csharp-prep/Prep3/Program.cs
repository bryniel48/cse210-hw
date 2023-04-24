using System;

namespace Learing03{
class Program
{
    static void Main(string[] args)
    {   int guess = 0;
        int counter = 0;
        Random randomGenerator = new Random();
        int randNumber = randomGenerator.Next(1, 99);
        Console.WriteLine("There is a random number between 1 - 99, try to guess it");
        do{
            Console.WriteLine("What is your guess?");
            String answer = Console.ReadLine();
            guess = Convert.ToInt32(answer);
            if (guess > randNumber){
                Console.WriteLine("Lower");
                }
            else if (guess < randNumber){
                Console.WriteLine("Higher");
                }
            
            counter ++;
        } while(guess != randNumber);
        Console.WriteLine($"Congrats! You guessed it right! It took you {counter} times to guess it");
    }
}
}