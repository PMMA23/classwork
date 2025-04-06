namespace MethodsExamples;

class Program
{
    //********************************************************************
    //* Demonstrate the use of programmer-defined methods 
    //* A method is a block of code that processes data and usually returns a value.
    //*
    //* A method starts with a method signature: 
    //*      return-type Name(data-it-will-accept)
    //*
    //* return-type - the type of data returned from the method 
    //*               use void if the method does not return data 
    //*
    //* Name() - the name of the method. Method names use PascalCase
    //*          PascalCase means the first letter of every word is capitalized
    //*
    //* (parameters) - the type and name of any input values for the method
    //*
    //* A parameter is a piece of data passed to a method for processing 
    //********************************************************************************
    
    // Every application has one and only one method called Main()
    //
    // Main() method signature:
    //      return type: void (returns nothing)
    //      name: Main
    //      parameter: string[] args

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int mySum = Addem(4, 5); // Call the Addem method with 4 and 5
                                // Addem() will be executed with the number 4 and 5 
                                // it will return the sum 
                                // which will be stored in the variable mySum

                                int yoda = 97;
                                int obiWon = 420;
        Console.WriteLine("The sum of 3 and 4 is:" + mySum); // Display the result
        Console.WriteLine("The sum of 3 and 4 is: " + Addem(3,4));
        Console.WriteLine("The sum of yoda and obiWon is: " + Addem(yoda,obiWon)); // Call Addem w/ two ints
                                                                                    // run the Addem that takes two ints 
        Console.WriteLine("The sum of 3.1 and 4 is: " + Addem(3.1,4.5)); // calling two doubles
                                                                        // Run the addem  that takes two doubles 
         Console.WriteLine("The sum of 67 and 9.9 is: " + Addem(67, 9.9)); // Calling Addem with an int and a double 
                                                                        // We dint have an Addem that takes an int 
                                                                        // It ran the Addem that take two doubles 
                                                                        // C# coverts the int to a double 
                                                                        // so now it can run the Addem that takes doubles 
    }

    // Define a method to receive two numbers and return the sum
    //
    // If a method is used by a static method, it must be static itself
    // Any method used by Main() must be static because Main() is static 
    // return
    // type name (parameters)
    //
    
    // Addem is a method that recieves two ints its calling num1 and num2
    //                      and return the sum of the ints as an int 
    static int Addem(int num1, int num2)
    {
        //Console.WriteLine("Addem was called with " + num1 + " " + num2);
        return num1 + num2; // Add the two parameters and return the sum
    }
    // return a double 
    static double Addem(double num1, double num2)
    {
        //Console.WriteLine("Addem (double, double) called with " + num1 + " " + num2);
        return num1 + num2; // Add the two parameters and return the sum
        // double + double = result is a double 
        // return type must be a double 
    }
}