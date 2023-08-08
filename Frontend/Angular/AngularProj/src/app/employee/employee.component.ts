import { Component } from '@angular/core';
interface IemployeeDetails {
  FirstName: string;
  LastName: string;
  DateofBirth: string;
  Age: number;
  JoiningDate: string;
  Country: string;
}


@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.sass']
})
export class EmployeeComponent {
public empdetails:Array<IemployeeDetails> = [
  {
    FirstName: "Harikrishnan",
    LastName: "PM",
    DateofBirth: '01/04/2000',
    Age: 23,
    JoiningDate: '03/06/2023',
    Country: "India"
  },{
    FirstName: "Jubiya",
    LastName: "Joseph",
    DateofBirth: '03/05/2000',
    Age: 23,
    JoiningDate: '03/06/2023',
    Country: "India"
  },{
    FirstName: "Ruby",
    LastName: "Susan",
    DateofBirth: '03/05/2000',
    Age: 23,
    JoiningDate: '03/06/2023',
    Country: "India"
  }
  
]

}
