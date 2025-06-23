// typescript file goes here
console.log("Welcome to My First TypeScript Program")

//  this app will create, store and process a set of students 
// Each student will have a name, class, start date 

// to assure anyone wanting to reference a Student has the same
// propeties and types, we will define an interface for Student 
// Think of an interface a programmer defined type of data layout 

interface Student {
    studentName : string;
    className : string 
    startDate : number 

}

//Define a class that will hold and process all the students 
class Roster {
    // Array to hold all the student in a roster 
    studentList  : Student[]; // Array of Student objects 
    constructor() {
        this.studentList = []; //Initialiaze array to be empty 
    }

    // Class method to add a student to the roster 
    addStudent(newStudent : Student){
    this.studentList.push(newStudent)

    // Class method to return the entire Roster
    getAllTheStudents(){
        return this.studentList
    }


} // End of class roster 


let classRoster = new Roster(); //defining class roster 
classRoster.addStudent({studentName : "Preshous", className : "Angular", startDate : 20250623})
classRoster.addStudent({studentName : "Cheese", className : "Angular", startDate : 20250623})
classRoster.addStudent({studentName : "Spongebob", className : "Angular", startDate : 20250623})
classRoster.addStudent({studentName : "Boss", className : "of own", startDate : 20250630})
classRoster.addStudent({studentName : "Jay", className : "of own", startDate : 20250630})

let aStudent = {studentName: "Jay Jay", className : "Advanced", startDate : 20250723
    classRoster.addStudent(aStudent)

    // dISPLAY ALL THE STUDENT IN ROSTER 
    // loOP THROUGH THE ROSTER AND DISPLAY STUDENTS ONE AT A TIME 

    classRoster.getAllTheStudents().array.forEach(aStudent => {console.log(aStudent);

    })
    
}
