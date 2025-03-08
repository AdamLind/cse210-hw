using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guessNum = -1;

        while (guessNum != number) {
            Console.Write("What do you think my number is? ");
            string guess = Console.ReadLine();
            guessNum = int.Parse(guess);

            if (guessNum > number) {
                Console.WriteLine("Lower");
            }
            else if (guessNum < number) {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } 
    }
}