import { Component, Input } from '@angular/core';
import{Output, EventEmitter} from '@angular/core';
import { IemployeeDetails } from '../employee/iemployee-details';
@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.sass']
})
export class DetailsComponent {
  @Input() employeeDetail?: IemployeeDetails;
  @Output() newItemEvent2 = new EventEmitter<boolean>();
  boolPass(){
    this.newItemEvent2.emit(false);
  }



}
