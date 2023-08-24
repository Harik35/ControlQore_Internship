import { Component } from '@angular/core';
import{Output, EventEmitter} from '@angular/core';
import { IemployeeDetails } from 'src/app/iemployee-details';
import { TestService } from 'src/app/test.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Istudentreturn } from 'src/app/istudent-return';


@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.sass']
})
export class EmployeeComponent {
  @Output() newItemEvent = new EventEmitter<IemployeeDetails>();
  empvariable = false;

  public emp: Array<Istudentreturn> = [];
  public empForm: Array<IemployeeDetails> = [];
  constructor(private empService: TestService, private router: Router) {}

  passEmpToDetails(emp: Istudentreturn){
    
    console.log(emp);
    this.router.navigate([`${emp.Id}/details`]);
    
    //this.empvariable = false;
    //this.newItemEvent.emit(emp);
  }

  getAllData(){
    this.empService.getEmployee().subscribe((data) =>this.emp = data)
    this.empvariable = true;
    console.log(this.emp);
  }

 
 




}
