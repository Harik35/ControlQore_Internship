import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmployeeComponent } from './EmployeeDetails/employee/employee.component';
import { DetailsComponent } from './EmployeeDetails/details/details.component';

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
