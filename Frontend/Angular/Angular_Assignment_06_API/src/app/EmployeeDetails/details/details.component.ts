import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { TestService } from 'src/app/test.service';
import { Istudentreturn } from 'src/app/istudent-return';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.sass']
})
export class DetailsComponent implements OnInit{
  public empDetails?: Istudentreturn;
  public empId:number = 0;
  public emp: Array<Istudentreturn> = [];
  flag = false;

  constructor(private empService: TestService , private route: ActivatedRoute, private router:Router){
    
  }

  ngOnInit(): void {
    this.empService.getEmployee().subscribe((data) => {
      this.emp = data;
      const id: string = this.route.snapshot.params['id'];
      this.empId = Number(id);
      this.empDetails = this.emp.find((X) => X.id == this.empId);
    });
    
    console.log(this.empId);
    console.log(this.empDetails);
}



backButton(){
  
  this.router.navigate(['/']);}

}
