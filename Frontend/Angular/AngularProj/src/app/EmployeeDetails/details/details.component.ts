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
export class DetailsComponent{
 
  @Output() newItemEvent2 = new EventEmitter<boolean>();
  
  
  
    
  
  boolPass()
  {
    
    this.newItemEvent2.emit(false);
  }



}
