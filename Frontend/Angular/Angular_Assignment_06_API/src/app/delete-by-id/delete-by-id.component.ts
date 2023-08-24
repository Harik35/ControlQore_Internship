import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { TestService } from '../test.service';

@Component({
  selector: 'app-delete-by-id',
  templateUrl: './delete-by-id.component.html',
  styleUrls: ['./delete-by-id.component.sass']
})
export class DeleteByIdComponent {
  
  constructor(private empService: TestService){}
  
  seacrhById = new FormGroup({
    searchFormId: new FormControl('')
  })
  passingId: number = 0;

  deleteById(){
    this.passingId = Number(this.seacrhById.value.searchFormId);
    this.empService.deleteById(this.passingId).subscribe(()=>{});
    console.log(this.passingId);
  }


}
