namespace FizzBuzzApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my FIZZ BUZZ App");

            string choice;
            do
            {
                Console.Write("Enter an integer please: ");
                int entry = int.Parse(Console.ReadLine());
                if(entry % 3 == 0) 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("FIZZ");
                }
                else if(entry % 5 == 0) 
                { 
                    Console.ForegroundColor= ConsoleColor.Blue;
                    Console.WriteLine("BUZZ!");
                }
                else if (entry % 5 == 0 && entry % 3 == 0)
                {
                    Console.WriteLine("FIZZBUZZ!");
                }
                else
                {
                    Console.WriteLine("Not fizz or buzz.");
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Would you like to go again? (y/n): ");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
