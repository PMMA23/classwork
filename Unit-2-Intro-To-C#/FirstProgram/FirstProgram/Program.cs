namespace FirstProgram;

// This program will ask for three numbers
//      add them together and display the total

// Programming Solution - Human thinking 
// Identify the detailed steps
// 
// Ask for the numbers one at a time 
// Write down each number as its given 
// Add the numbers together and create a sum or total
// Tell the requester the total (display)
//
// Now that we have the steps in our solution
// Identify any data you need for the steps
//
// 1. A place to write down each number - a variable in a program 
// 2. A place to hold the sum/total - a variable in a program 
// 3. A way to ask for the numbers - a method in a program (object.method())
// 4. A way to receive the numbers - a method in a program (object.method())
// A way to report the sum/total - a method in a program (object.method())
//
//Place the steps in the order and provide more detail if necessary
// 1. Ask for the numbers one at a time 
//    a. Tell whatever is giving us a number to give me the first number 
//    b. Receive the first number from sender 
//    c. Write down the first number 
//    d. Tell whatever is giving us a number to give me the first number 
//    e. Receive the second number from sender 
//    f. Write down the second number 
//    g. Tell whatever is giving us a number to give me the first number 
//    h. Receive the third number from sender 
//    i. Write down the third number 
//
//
//
// 2. Add the numbers together create a sum/total
//      a. Add the first number to a sum/total
//      b. Add the second number to a sum/total
//      c. Add the third number to a sum/total
//
// 3. Tell the requester the total (display)
//
class Program
{
    static void Main(string[] args)
    {
        /*************************************************************
         * Define my data the program needs at the top of the program
         *
         * Data maybe defined anywhere before its used, easier to
         * find at the top
         *
         * To define a variable: data-type name = initial -value;
         *
         * Commonly used data types in C#:
         *
         * int    - numeric data that is a whole number between +/- 2 billion
         * long   - A whole number that's greater than +/- 2 billion
         * double - numeric value w/ decimal places
         * char   - a single alpha-numeric character (one letter)
         * string - a series of alpha numeric characters (words or sentence)
         * bool   - store true or false value for conditions
         *
         * Ex: 10 if you have a value (int or long)
         *      1.0 numeric value w/ demical (double)
         *      'a' note thats enclosed in ' ' (char)
         *      "some words" - note enclosed (string)
         *
         * Variable names in C# are usually spelled in camelCase
         * (camelCase- 1st letter is lowercase and other words are
         *              uppercase letter)
         * It's always good to initial variable when defining them
         * know what is in them 
         **************************************************************/
        
        // Define the variable to hold the numbers we need to add
        int number1 = 0;
        int number2 = 0;
        int number3 = 0;
        
        //Define a variable to hold the sum of the numbers 
        int sum = 0;
        
        Console.WriteLine("--- Starting program ---");
        
        // Ask for the numbers one at a time using the C# Console object
        // which represents the keyboard and screen 
        // Console.ReadLine() returns a string -cannot store int
        Console.WriteLine("Please enter a number: ");       // Asking for the number 
            string aLine;                                   // String to hold the line of input from the keyboard 
        aLine = Console.ReadLine();                       // Get a line from the keyboard
        // We need an int value to store our number
        // Console.ReadLine() only return a string 
        // So we need to converet the string from Console.ReadLine() to an int
        // int.Parse(string) will convert a string to an int 
        number1 = int.Parse(aLine);
        
        
        Console.WriteLine("--- Ending program ---");
    }
}