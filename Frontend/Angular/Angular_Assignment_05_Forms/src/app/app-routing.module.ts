
import { EmployeeComponent } from './EmployeeDetails/employee/employee.component';
import { DetailsComponent } from './EmployeeDetails/details/details.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router'
 
const routes: Routes = [{
  path: 'employee', component: EmployeeComponent
},{
  path: ':id/details', component: DetailsComponent
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
