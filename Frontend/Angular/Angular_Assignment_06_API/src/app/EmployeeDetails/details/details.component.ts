import { Component, Input, OnInit } from '@angular/core';
import { IemployeeDetails } from '../../iemployee-details';
import { ActivatedRoute, Router } from '@angular/router';
import { TestService } from 'src/app/test.service';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.sass']
})
export class DetailsComponent implements OnInit{
  public empDetails?: IemployeeDetails;
  public empId:number = 0;
  public empList: Array<IemployeeDetails> = [];

  constructor(private empService: TestService, private route: ActivatedRoute, private router:Router){
    this.empList = this.empService.empdetails;
  }

  ngOnInit(): void {
    const id: string = this.route.snapshot.params['id'];
    this.empId = Number(id);
    this.empDetails = this.empList.find((X) => X.Id == this.empId);
    console.log(this.empId);
    console.log(this.empDetails);
}

backButton(){
  
  this.router.navigate(['/']);}

}
