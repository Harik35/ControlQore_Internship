import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { FormControl, FormGroup} from '@angular/forms';
import { IemployeeDetails } from 'src/app/iemployee-details';
import { Istudent } from '../istudent';
import { TestService } from '../test.service';



@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.sass']
})



export class HomeComponent {

  
  constructor(private router: Router, private studService: TestService ) {
  }

  GoToEmployee(){
    this.router.navigate(['./employee']);
  }

  GoToDepartment(){
    this.router.navigate(['./dept']);
  }

  student?: Istudent;
  inputFormGrp = new FormGroup(
    { 
      inputFirstName: new FormControl(''),
      inputLastName: new FormControl(''),
      inputEmail: new FormControl(''),
      inputPhone: new FormControl(''),
      inputDep: new FormControl<number | null>(null)
  }
  );
  
  onSubmit(){
    // this.http.post(this.baseUrl);
    this.student = {
      FirstName: this.inputFormGrp.value.inputFirstName,
      LastName: this.inputFormGrp.value.inputLastName,
      PhoneNumber: this.inputFormGrp.value.inputPhone,
      Email: this.inputFormGrp.value.inputEmail,
      DepartmentId: this.inputFormGrp.value.inputDep
    }
    this.studService.addEmployee(this.student).subscribe((data)=>{
      console.log(data);
    })
  }

  getAllData(){
    this.studService.getEmployee().subscribe((data) =>{
      console.log(data);
    })
  }
  
  seacrhById = new FormGroup({
    searchFormId: new FormControl('')
  })
  getDataById(){
    
    
  }
  

}
