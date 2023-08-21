import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { FormControl, FormGroup} from '@angular/forms';
import { IemployeeDetails } from 'src/app/iemployee-details';
import { TestService } from 'src/app/test.service';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.sass']
})



export class HomeComponent {

  newEmp!: IemployeeDetails

  public empForm2: Array<IemployeeDetails> = [];
  searchFormGrp = new FormGroup(
    { 
      searchFormFirstName: new FormControl(''),
      searchFormId: new FormControl<number>(0),
      searchFormLastName: new FormControl(''),
      searchFormDOB: new FormControl(''),
      searchFormAge: new FormControl<number>(0),
      searchFormJOD: new FormControl(''),
      searchFormCountry: new FormControl('')
  }
  );

  constructor(private empService: TestService, private router: Router) {
  this.empForm2  = empService.empdetails;

 }
 @Output() searchElement = new EventEmitter<string>();



  GoToEmployee(){
    this.router.navigate(['./employee']);
  }

  GoToDepartment(){
    this.router.navigate(['./dept']);
  }
  
  onSubmit(){
  //   this.myGroup = new FormGroup({
  //     searchFormCtrl: new FormControl()
  // });
  this.newEmp = {
    Id: this.searchFormGrp.value.searchFormId,
    FirstName: this.searchFormGrp.value.searchFormFirstName,
    LastName: this.searchFormGrp.value.searchFormLastName,
    Age: this.searchFormGrp.value.searchFormAge,
    DateofBirth: this.searchFormGrp.value.searchFormDOB,
    JoiningDate: this.searchFormGrp.value.searchFormJOD,
    Country: this.searchFormGrp.value.searchFormCountry
  } 
  this.empForm2.push(this.newEmp);
  console.log(this.searchFormGrp.value.searchFormFirstName);
  }
  

}
