import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { TestService } from '../test.service';
import { Istudent } from '../istudent';

@Component({
  selector: 'app-updatebyid',
  templateUrl: './updatebyid.component.html',
  styleUrls: ['./updatebyid.component.sass']
})
export class UpdatebyidComponent {

  constructor(private empService: TestService){

  }

  student?:Istudent;
  Id?: number;

  updateFormGrp = new FormGroup(
    { 
      updateId: new FormControl(''),
      inputFirstName: new FormControl(''),
      inputLastName: new FormControl(''),
      inputEmail: new FormControl(''),
      inputPhone: new FormControl(''),
      inputDep: new FormControl<number | null>(null)
  }
  );
  

  onSubmit(){
    this.student = {
      FirstName: this.updateFormGrp.value.inputFirstName,
      LastName: this.updateFormGrp.value.inputLastName,
      PhoneNumber: this.updateFormGrp.value.inputPhone,
      Email: this.updateFormGrp.value.inputEmail,
      DepartmentId: this.updateFormGrp.value.inputDep
    }

    this.Id = Number(this.updateFormGrp.value.updateId)

    this.empService.updateById(this.student,this.Id).subscribe ((data)=>{
      console.log(data)
    })


    }

    

  }


