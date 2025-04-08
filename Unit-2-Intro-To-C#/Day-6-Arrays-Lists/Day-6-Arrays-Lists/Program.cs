namespace Day_6_Arrays_Lists;

// This program will ask for three numbers
//      add them together and display the total

class Program
{
    static void Main(string[] args)
    {
        // Define the variables to hold the numbers we need to add
        int[] numbers = new int [3]; // numbers.Length = 3; 2 is the largest allowable index 
        
        // Define a variable to hold the sum of the numbers
        int sum = 0;

        Console.WriteLine("--- Starting program ---");
        
        // Normally we process an array from beginning to end
        // (from the 1st element to last element, one at a time)
        //
        //a for-lop will loop through a process counting as it does o 
        // a for-loop is an excellent tool for processing an array from start to end
        //
        // STANDARD SYNTAX: FOR (I=0, I < arrayName. Length; i++
        //
        // arrayName.Length represents the number 
        
        // Index        loop as     
        // start        loop as the index       increment index
        // 0            is not outside array    index for each loop 
        for (int i=0; i< numbers.Length; i++)   // i=0,1,2, INSIDE LOOP AND 3 WHEN EXIT LOOP
        {
            Console.WriteLine("Please enter a number: "); // ask for the number 
            numbers[i] = int.Parse(Console.ReadLine());   // get a string from the keyboard 
                                                          // convert to int
                                                          // store it in numbers[i]
        }
        
        // Verify the array recieved the numbers correctly 
        // Go through the array one elment at a time and display the element 
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Element #" + i + ": " + numbers[i]);
            sum = sum + numbers[i]; // add the current number in the array to sum 
        }
       
        // Tell the requester the sum/total (display)
        Console.WriteLine("The sum is: " + sum);
        
        // Tell the requester the average of the numbers
        // divides the sum by the number of elements
        
        Console.WriteLine("The average of the numbers is: " + (double) sum / numbers.Length);
        
        // sum / numbers.Length 
        // int / int ---> integer arithmetic - divide gives two parts quotient and remainder 
        // int                                 7/3 - quotient = 2 remainder 1
        
        // (double) sum / numbers.Length
        //convert sum
        // to double / int ---> floating point arithetic
        //          / convert int to double (C# does this automatically)
        // double   / double ---> floating point arth
        // double (2.333333)

        Console.WriteLine("--- Ending program ---");
    }
}