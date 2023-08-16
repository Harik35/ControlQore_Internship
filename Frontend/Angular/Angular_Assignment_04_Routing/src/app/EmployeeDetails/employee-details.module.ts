import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeeComponent } from './employee/employee.component';
import { DetailsComponent } from './details/details.component';


@NgModule({
  declarations: [
    EmployeeComponent,
    DetailsComponent,

  ],
  imports: [
    CommonModule
  ],
  exports:[
    EmployeeComponent,
    DetailsComponent
  ]
})
export class EmployeeDetailsModule { }
