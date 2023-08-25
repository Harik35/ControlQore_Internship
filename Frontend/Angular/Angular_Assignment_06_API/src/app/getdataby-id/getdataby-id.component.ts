import { Component, OnInit } from '@angular/core';
import { TestService } from '../test.service';
import { FormControl, FormGroup } from '@angular/forms';
import { Istudentreturn } from '../istudent-return';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-getdataby-id',
  templateUrl: './getdataby-id.component.html',
  styleUrls: ['./getdataby-id.component.sass']
})
export class GetdatabyIDComponent{
  public empDetails?: Istudentreturn;
  public tableVisible = false;

  constructor(private empService: TestService,private route: ActivatedRoute, private router:Router){}
  
  
  getDatByIdFormGrp = new FormGroup({
    getdataId: new FormControl('')
  })
  passingId: number = 0;

  getdataById(){
    this.passingId = Number(this.getDatByIdFormGrp.value.getdataId);
    this.empService.getDataById(this.passingId).subscribe((data)=>{
      this.empDetails = data;
    });
    console.log(this.passingId);
    this.tableVisible = true;
  }

  backButton(){
  
    this.router.navigate(['/']);}
  
  }


