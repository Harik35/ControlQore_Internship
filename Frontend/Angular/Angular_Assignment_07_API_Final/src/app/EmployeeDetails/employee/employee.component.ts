import { Component } from '@angular/core';
import{Output, EventEmitter} from '@angular/core';
import { IemployeeDetails } from 'src/app/iemployee-details';
import { TestService } from 'src/app/test.service';
import { ActivatedRoute, Router } from '@angular/router';


@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.sass']
})
export class EmployeeComponent {
  @Output() newItemEvent = new EventEmitter<IemployeeDetails>();
  empvariable = true;

  public emp: Array<IemployeeDetails> = [];
  public empForm: Array<IemployeeDetails> = [];
  


  constructor(private empService: TestService, private router: Router) {
    this.emp = empService.empdetails;
    
  }

  passEmpToDetails(emp: IemployeeDetails){
    
    console.log(emp);
    this.router.navigate([`${emp.Id}/details`]);
    
    //this.empvariable = false;
    //this.newItemEvent.emit(emp);
  }

 
 




}
