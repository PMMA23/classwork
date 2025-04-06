namespace VariablesExcercise;

class Program
{
    static void Main(string[] args)
    {
        // === Exercise 1.1 === 
        Console.WriteLine("Enter some text: "); // input text
        string userEnter = Console.ReadLine();  // input from user
        Console.WriteLine(userEnter);           //prints out exact input 
        
        // === Exercise 1.2 ===
        Console.WriteLine("Please enter a number: ");   // Ask for a number 
        string userResponse = Console.ReadLine();       // user input text
        int number = int.Parse(userResponse);           // turns into a number  
        int result = number + 1;                        // add 1 
        Console.WriteLine(result);                     // print number 
        
        // === Exercise 1.3 ===
        Console.WriteLine(" Please enter a decimal number ");    // Ask for decimal
        string input = Console.ReadLine();                       // get the text
        double decimalNumber = double.Parse(input);              // convert to double 
        double decimalResult = decimalNumber + 0.5;              // add 0.5
        Console.WriteLine(decimalResult);                        // print decimal
        
        // === Exercise 1.4 ===
        Console.WriteLine("Please enter a number : ");          //Ask for a number 
        string input1 = Console.ReadLine();                     // read 1st number
        double number1 = double.Parse(input1);                  // convert 1st number to double
        
        Console.WriteLine("Please enter another number : ");    //Ask for 2nd number
        string input2 = Console.ReadLine();                     // read 2nd number 
        double number2 = double.Parse(input2);                  // convert 2nd number to double 
        
        double sum = number1 + number2;                         // add the two numbers 
        Console.WriteLine("The sum is" + sum);                  // print sum
        
        // === Exercise 1.5 ===
        Console.WriteLine("Please enter a decimal number : "); // ask for number 
        string input3 = Console.ReadLine();                    // read 1st number 
        double number3 = double.Parse(input3);                 // convert to double 
        
        Console.WriteLine("Please enter another decimal number : "); // ask for 2nd number 
        string input4 = Console.ReadLine();                          // read 2nd number 
        double number4 = double.Parse(input4);                      // convert to double 
        
        double product = number3 * number4;                         // multiply both numbers 
        Console.WriteLine("The product is" + product);              // print sum
        
        // === Exercise 1.6 ===
        Console.WriteLine("Please enter a whole number : ");    // ask for first whole number 
        string input5 = Console.ReadLine();                     // read 1st number 
        int number5 = int.Parse(input5);                        // convert to int 
        
        Console.WriteLine("Please enter another whole number : ");  // ask for 2nd number 
        string input6 = Console.ReadLine();                         // read 2nd number 
        int number6 = int.Parse(input6);                            // convert to int 
        
        int divisionResult = number5 / number6;                     // divide the two numbers 
        Console.WriteLine("The result is " + divisionResult);       // print sum
        
        // === Exercise 1.7 ===
        Console.WriteLine("Please enter true or false ");       // asking for boolean input
        string answer = Console.ReadLine();                     // read text
        bool userBool = bool.Parse(answer);                     // convert to true/false
        
        Console.WriteLine("You entered:" + userBool);           // print what user typed
        Console.WriteLine("The opposite is:" + !userBool);      // show opposite 
        
        
    }
}