import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmployeeComponent } from './EmployeeDetails/employee/employee.component';
import { DetailsComponent } from './EmployeeDetails/details/details.component';
import { EmployeeDetailsModule } from './EmployeeDetails/employee-details.module';
import { HomeComponent } from './home/home.component';
import { DeptListComponent } from './Department/dept-list/dept-list.component';
import { DeptDetailsComponent } from './Department/dept-details/dept-details.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    DeptListComponent,
    DeptDetailsComponent],
  imports: [
    BrowserModule,
    AppRoutingModule,
    EmployeeDetailsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
