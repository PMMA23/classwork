namespace NumberAnalyzer;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number between 1 and 100");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        
        // Checking if out of range
        if (number < 1 || number > 100)
        {
            Console.WriteLine("That number is out of range");
        }
        // Odd and less than 60
        else if (number % 2 != 0 && number < 60)

        {
            Console.WriteLine("number + is Odd and less than 60.");
        }
        // Even and between 2 and 24
        
        else if (number % 2 == 0 && number >= 2 && number <= 24)
        {
            Console.WriteLine("number + is Even and less than 25.");
        }
        
        // Even and between 26 and 60
        else if (number % 2 == 0 && number >= 26 && number <= 60)
            Console.WriteLine("Even and between 26 and 60 inclusive.");
        
        // Even and greater than 60
        else if (number % 2 == 0 && number > 60)
        {
            Console.WriteLine(number + " is even and greater than 60.");
        }
        
        // Odd and greater than 60
            else if (number % 2 != 0 && number > 60)
            {
                Console.WriteLine(number + " is Odd and greater than 60.");
            }
    }
}