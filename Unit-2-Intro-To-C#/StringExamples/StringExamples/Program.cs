namespace StringExamples;

class Program
{
    static void Main(string[] args)
    {
        /*****************************************************************
         * Strings in C# are a special data type - they don't work like you think they should
         *
         * String literal are enclosed in " "
         * 
         * A literal is something that says what it is: 1, 1.24 "Bob"
         *
         * string variable sometimes require special processing
         *          Ex: you can't use < > to compare strings
         *          Beware early version of C# do not allow use of == with strings
         *
         * C# provides several methods to operate on strings:
         * 
         *      .Equals(string) - compare the string to the left of the . to the string inside the () for equuals 
         *      .CompareTo(string)- return a number indicating how the first string relates to the second
         *                          return a negative number if the first string is less than the second
         *                          return a zero if the first string is equal to the second
         *                          return a positive number if the first string is greater than the second 
         ************************************************************************************/
        //If some (condition) {
        //        What to odo if condition is true
        //}
        // else {
        //      What to do if condition is false 
        //}
        string string1 = "a";
        string string2 = "b";
        
        Console.WriteLine($"string1 is: {string1}");
        Console.WriteLine($"string2 is: {string2}");
        
        if (string1.CompareTo(string2) > 0) // if the first string is greater than second string 
        
        {
            Console.WriteLine("string1 is greater than string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT greater than string2");
        }
        if (string1.CompareTo(string2) < 0) // if the first string is greater than second string 
        
        {
            Console.WriteLine("string1 is less than string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT less than string2");
        }
        if (string1.CompareTo(string2) == 0) // if the first string is greater than second string 
        
        {
            Console.WriteLine("string1 is equal string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT equal string2");
        }
        Console.WriteLine("Hello, World!");
    } // End of Main()
} // End of program 