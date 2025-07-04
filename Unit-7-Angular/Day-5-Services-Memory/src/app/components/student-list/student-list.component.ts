/******************************************************
 * 
 * This is service 
 * 
 * It was initally created using : ng generate service/ service/student
 * (ng generate automatically added the .service)
 * (the .memory was added by instructor)
 * 
 * A service is a set of processing to facilitate the retrival 
 * and storage of the data- typically in a persistent source (saved)
 * 
 * may do other processing as well
 * 
 * This service does not save 
 */


import { CommonModule }   from '@angular/common';
import { Component }      from '@angular/core';
import { StudentInfo }    from '../../interfaces/studentInfo';
import { StudentService } from '../../services/student.service.memory';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'student-list',
  standalone: true,
  imports: [CommonModule, RouterLink],
  templateUrl: './student-list.component.html',
  styleUrl: './student-list.component.css'
})
export class StudentListComponent {

  // this service does not save the dta to persistent source (like data base ort API)
  // the data from this service s just an array in memory 
  // a service must be dependency njectable by angular 
  //  injectable means Angular is allowed to instantiate it 
  // and pass it to a funtion 

  // To make a service Dependency injectable:

  // 1. import injectable from Angular jcore features 
  // 2. Include the @injectable object w/ the providedIn property set to "root"

// This will hold the data for the Student to be displayed
// the data will come from a call to a service
// it starts out as an empty array  
//     var-name   : data-type
public studentList : StudentInfo [] ; // This is an array of StudentInfo objects

// constructor is used to initialize data in the component
//
// This style of constructor will define the variable, create a StudentService object
//                                       and assign that object to the variable
//                                       using Dependency Injection
//
// Dependency Injection is the automatic creation of variables and objects required
//
// Dependency Injection decouples the service from the code
// (makes it much easier to change the service)
//   
// without Dependency Injection the code would look like this:
//
//     private studentService;   // define a variable to hold the service
//
//     constructor() {
//                    studentService = new StudentService();// create the service
//                   }                                      //    and assign it to the variable
//                              
constructor(private studentService  : StudentService ) {
  // Call the service method to send back the current list of Student from the data source
  this.studentList = studentService.getStudentList(); // Initialize our StudentList from service
  //  1. studentService.getStudentList() - go to the Studentervice and run the method getStudentList
  //  2. = - take with the method returns and assign it to (store it in)
} //  3. this.studentList is assigned the data from step 2

}  // End of export