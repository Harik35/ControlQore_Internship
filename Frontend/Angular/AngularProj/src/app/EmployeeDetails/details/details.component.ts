import { Component, Input, OnInit } from '@angular/core';
import{Output, EventEmitter} from '@angular/core';
import { IemployeeDetails } from '../../iemployee-details';
import { ActivatedRoute, Router } from '@angular/router';
import { EmployeeComponent } from '../employee/employee.component';
import { TestService } from 'src/app/test.service';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.sass']
})
export class DetailsComponent implements OnInit{
  public employeeDetail?: IemployeeDetails;
  public empId: number = 0;
  public emplist: Array<IemployeeDetails> = [];
  @Output() newItemEvent2 = new EventEmitter<boolean>();
  
  
  constructor (private empService: TestService, private route: ActivatedRoute, private router: Router){
    this.emplist  = this.empService.empdetails
  }
    
  
  boolPass()
  {
    this.router.navigate(['./employee']);
    //this.newItemEvent2.emit(false);
  }



}
