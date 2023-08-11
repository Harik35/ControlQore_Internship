import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmployeeComponent } from './EmployeeDetails/employee/employee.component';
import { DetailsComponent } from './EmployeeDetails/details/details.component';
import { EmployeeDetailsModule } from './EmployeeDetails/employee-details.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    EmployeeDetailsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
