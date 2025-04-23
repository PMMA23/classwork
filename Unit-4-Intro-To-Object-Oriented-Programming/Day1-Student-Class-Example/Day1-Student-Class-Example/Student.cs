namespace Day1_Student_Class_Example;

// internal attribute so we can use the class anywhere
//public - anyone can use this class
// class - this is the defintiopm of a C# CLASS
// Student - name of the class - Classname are in PascalCase

// A class is a description of an object used in object oriented programming 
// A class contains data (class data) and methods (class methods)
// A class is a programmer defined data type ( much like int, string, double, List<>
// Because it is a PROGRAMMER defines data type, the prorammer is responsible for:
//
//      the data in the class
//      the methods that manipulate the class data 
//
// class can do whatever a programmer decides it should or shouldn't do 

public class Student
{
    // Define the data for our class 
    // private indicates only me,mbers of the class can access the data 
    // private implements the Object-Oriented principle of Encapsulation
    // Ecapsulation - class should protect the data from outside 
    //                only methods in the class can access the data
    //
    //                Users of the class access the data using methods
    //                defined in the class 
    // Note the data is efined without an inital value 
    //                Class data should be initialized in constructors 
    private string studentName;
    private List<int> testScores;
    
    // Define methods for the class 
    
    // One special methods for a class is called a constructor
    // A constructor is responsible for initalizing data in a class
    // data should never be utilialized - starting value needs to be known
    
    // a constructor method is special because
    //
    // 1. it has a return type; not even void
    // 2. it has the same name as the Class
    // 3. it may or may not recieve parameters 
    //      a constructor with no oarameters is called a defaul 
    // 4. usually public 
    
    // Define a constructor to intilizale our dat with values 
    //      specified by user 

    public Student(string name, List<int> scores)
    {
        studentName = name; // SET THE CLASS TO THE DATA PASSED IN FROM THE USER 
        testScores = scores;// sET THE CLASS TO THE DATA PASSED IN FROM THE USER  
    }
}