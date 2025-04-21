namespace StringExamples;

class Program
{
    static void Main(string[] args)
    {
        /***************************************************************************************************
         * Strings in C# are a special data type - they don't work like you think they should
         *
         * String literals are enclosed in " "
         *
         * A literal is something that says what it is:  1 1.24 "Bob"
         *
         * string variables sometimes require special processing
         *        you can't use < > to compare strings
         *        Beware: Early versions of C# do not allow use of == with strings
         * 
         * a method()is a program that process data in an object /variable
         * 
         * C# provides several methods to operate on strings:
         *
         *    .Equals(srting) - compare the string to left of the . to string inside () for equals
         *     .CompareTo(string) - return a number indicating how the first string relates to the second
         *                          return a negative number if first string is less than the second
         *                          return a zero if first string is equal the second
         *                          return a positive number if first string is greater than the second
         ***************************************************************************************************/
        // if (condition) {
        //    What to do if condition is true
        // }
        // else {
        //    What to do if condition is false
        // }
        string string1 = "a";
        string string2 = "b";
        
        Console.WriteLine("string1 is: " + string1);
        Console.WriteLine("string2 is: " + string2);
        
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
        if (string1.CompareTo(string2) == 0) // if the first string is equal second string
        {
            Console.WriteLine("string1 is equal string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT equal string2");
        }
        // Some methods that process strings 
        // to see a list of all methods avaliable to an object - just type the objectName. 
        //.Length returns the number of characters in a string '
        //.Contains(string) returns true if the string given is inside the string
        // .Substring(start-index,length)- extract characters from the string starting at the start index
        //                                  for the numbers characters indicated by the length
        //                                  start-index starts at 0 NOT A
        //                                  whenever you see the word index- starts counting at 0
        //                                  whenever you see the word position - starts count at 1
        // .StartsWith(string) - return true if the string starts with the specified characters (case senstive)
        // .EndsWith(string) - return true if the string ends with the specified characters (case senstive)
        // .Trim() - remove any leading or trailing spaces
        //Ex: string1. (   
        string sentence = "       My name is Frank and I attempt to teach C#       ";
        Console.WriteLine("There are " + sentence.Length + " characters in the sentence");
        
        bool containsFrank = sentence. Contains("Frank"); // true if sentence contaisns Franks 
        Console.WriteLine("Does the sentence contain Frank " + containsFrank);
        
        Console.WriteLine("Does the sentence contain Marquise " + sentence.Contains("Marquise"));

        string namInSentence = sentence.Substring(15, 5);   //extract the 5 charcters at position 12
        Console.WriteLine("Name is: " + namInSentence);
        
        Console.WriteLine("Does the sentence start with My? " + sentence.StartsWith("My"));
        Console.WriteLine("Does the sentence start with my? " + sentence.StartsWith("my"));
        Console.WriteLine("Does the sentence end with C#? " + sentence.EndsWith("C#"));

        Console.WriteLine("Results when sentence.Trim() is used to remove leading and trailing spaces");
        Console.WriteLine("Does the sentence start with My? " + sentence.Trim().StartsWith("My"));
        Console.WriteLine("Does the sentence start with my? " + sentence.Trim().StartsWith("my"));
        Console.WriteLine("Does the sentence end with C#? " + sentence.Trim().EndsWith("C#"));
        
        // When C # sees a staement with chained operations (operations seperated by dots)
        //
        // C# sharp processes  the staement form left to right, one operation at a time
        // Uses the result of the operation in the next one 
        // sentence.Trim().EndsWith(C#)
        //
        // 1.sentence.Trim() - return a string with the leading and trailing spaces removed 
        // 2.result-from-step 1.EndsWith() - return true or false depending on if the string ends with character 
        
        
        
    } // End of Main()
}  // End of class Program