import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { FormControl, FormGroup} from '@angular/forms';



@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.sass']
})



export class HomeComponent {

  searchFormGrp = new FormGroup({ searchFormCtrl: new FormControl('')});

  constructor(private router: Router) {
 }
 @Output() searchElement = new EventEmitter<string>();



  GoToEmployee(){
    this.router.navigate(['./employee']);
  }

  GoToDepartment(){
    this.router.navigate(['./dept']);
  }
  
  onSubmi(){
  //   this.myGroup = new FormGroup({
  //     searchFormCtrl: new FormControl()
  // });
  console.log(this.searchFormGrp.value);
  }
  

}
