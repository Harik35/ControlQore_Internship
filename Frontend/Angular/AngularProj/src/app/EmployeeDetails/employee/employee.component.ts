import { Component } from '@angular/core';
import{Output, EventEmitter} from '@angular/core';
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
  @Output() newItemEvent = new EventEmitter<IemployeeDetails>();
  empvariable = true;

  BoolFunc(emp: IemployeeDetails){
    this.empvariable = false;
    this.newItemEvent.emit(emp);
  }
 

empdetails:Array<IemployeeDetails> = [
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
    DateofBirth: '02/12/2000',
    Age: 23,
    JoiningDate: '30/06/2023',
    Country: "India"
  },{
    FirstName: "Narayana",
    LastName: "Menon",
    DateofBirth: '31/09/2000',
    Age: 23,
    JoiningDate: '03/06/2023',
    Country: "India"
  },{
    FirstName: "Christina",
    LastName: "Susan",
    DateofBirth: '23/01/2000',
    Age: 23,
    JoiningDate: '03/06/2023',
    Country: "India"
  }
  
]


}
