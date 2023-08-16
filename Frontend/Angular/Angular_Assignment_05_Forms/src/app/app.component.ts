import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { IemployeeDetails } from './iemployee-details';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.sass']
})
export class AppComponent {

  constructor(private router: Router){

  }
  
  tempvariable3 = false;
  tempvariable2?: IemployeeDetails;

  addItem (emp: IemployeeDetails){
    this.tempvariable2 = emp;
    this.tempvariable3 = true;
    console.log(emp);

  }
  addItem2 (value: boolean){
    
    this.tempvariable3 = value;

  }

  GoToEmployee(){
    this.router.navigate(['./employee'])
  }

  title = 'AngularProj';
}

