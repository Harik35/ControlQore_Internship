import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { FormControl, FormGroup} from '@angular/forms';



@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.sass']
})



export class HomeComponent {

 
  constructor(private router: Router) {
 }
 @Output() searchElement = new EventEmitter<string>();

searchFormCtrl = new FormControl('');

  GoToEmployee(){
    this.router.navigate(['./employee']);
  }

  GoToDepartment(){
    this.router.navigate(['./dept'])
  }
  
  onSubmission(){
  //   this.myGroup = new FormGroup({
  //     searchFormCtrl: new FormControl()
  // });
    console.log(this.searchFormCtrl);
  }
  

}
