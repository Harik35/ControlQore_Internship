import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmployeeDetailsModule } from './EmployeeDetails/employee-details.module';
import { HomeComponent } from './home/home.component';
import { DeptListComponent } from './Department/dept-list/dept-list.component';
import { DeptDetailsComponent } from './Department/dept-details/dept-details.component';
import { ReactiveFormsModule } from '@angular/forms';
import {HttpClient, HttpClientModule} from '@angular/common/http';



@NgModule({
  declarations: [
    AppComponent,
    DeptListComponent,
    HomeComponent,
    DeptDetailsComponent],
  imports: [
    BrowserModule,
    AppRoutingModule,
    EmployeeDetailsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
