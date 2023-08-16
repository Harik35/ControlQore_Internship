import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmployeeComponent } from './EmployeeDetails/employee/employee.component';
import { DetailsComponent } from './EmployeeDetails/details/details.component';

const routes: Routes = [{
  path: 'EmployeeDetails/employee', component: EmployeeComponent
},{
  path: 'EmployeeDetails/details', component: DetailsComponent
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
