using System;
using System.Collections.Generic;  // Give me access to the systems generic collections stuff

namespace Day_2_Dictionary_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*********************************************************
             * Example use of a Dictionary with array/List value
             *********************************************************/
                
            // Ask the user for a name and a grade
            // Store them in a Dictionary
            
            // Dictionary to hold name (key) and grade (value)
            //         key     value
            //         type    type    name      = new Dictionary<key-type, value>();
            Dictionary<string, double> gradeBook = new Dictionary<string, double>();
            
            // Lets add 3 students - loop 3 times for-loop
            // Loop until the user satisfies a condition instead of a specific # of times
            // Replace the for loop (designing the solution to what we want to do)
            // For-loop (specfic amount of times
            //Do we want loop at least once? Yes - do while loo[; No - while loop
            // Is ok to loop 0x? Yes -while loop; No- do while do loop
            //
            // In this case we have to ask the user at least once to enter some date 
            //How do we want the user to let us know they are done?
            string userResponse = "";
            do
            {
                
                    // Ask the user for the student name and grade 
                // Ask the user for the student name and grade
                Console.Write("Enter student name: ");
                string studentName = Console.ReadLine(); // Get student name// Ask the user for the student name
                Console.Write("Enter grade: ");
                double grade = Double.Parse(Console.ReadLine()); // Get student grade

                // Add the data to our Dictionary
                // Dictionary[key}     = value;
                gradeBook[studentName] = grade; // gradeBook.Add(studentName, grade) // may cause an exception
                
                // We need to define grade outside any block so it can be used 
                double grade = 0;
                string userGrade = ""; 
                
                try // a staement inside this try block might cause an exception
                {
                    // Get the user input as a string in case we need it later 
                    userGrade = Console.ReadLine();
                    grade = Double.Parse(userGrade); // get student grade
                }
                catch (FormatException exceptionObject) // if it throws a FormatException...
                {
                    Console.WriteLine("The data you entered (" + grade + " ) is not valid");
                    Console.WriteLine("The data is ignored");
                    // Skip adding the student to dictionary
                    continue; // skip the rest off the loop processing
                }
                Console.WriteLine("Are you done? (y/n)");
                // Get a response from the user and convert to lowercase
                userResponse = Console.ReadLine().ToLower();
                // We are checking userResponse AFTER we get it from user 
                if (userResponse != "y" || userResponse != "n")
                {
                    Console.WriteLine("Sorry we only accept 'y' or 'n' ");
                }
                else
                {
                    Console.WriteLine("Are you done? (y/n) ");
                    // Get a response from the user and convert to lowercase
                    userResponse = Console.ReadLine().ToLower();
                }
            } while (userResponse != "y") ; // Loop while they are not done = "y"
            
            // Display the entrys in our Dictionary only if we have a valid grade
            // Use a KeyValuePair type to get an entry from teh Dictionary
            foreach (KeyValuePair<string, double> anEntry in gradeBook)
            {
                Console.WriteLine(gradeBook[anEntry.Key] + " has a grade of " + anEntry.Value);
            }
            
            Console.WriteLine("Please press enter to end program...");
            Console.Read();
        }
    }
}