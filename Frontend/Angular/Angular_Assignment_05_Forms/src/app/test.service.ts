import { Injectable } from '@angular/core';
import { IemployeeDetails } from './iemployee-details';
import { IdeptDetails } from './idept-details';


@Injectable({
  providedIn: 'root'
})
export class TestService {

  empdetails:Array<IemployeeDetails> = [
    {
      Id: 1,
      FirstName: "Harikrishnan",
      LastName: "PM",
      DateofBirth: '01/04/2000',
      Age: 23,
      JoiningDate: '03/06/2023',
      Country: "India"
    },{
      Id: 2,
      FirstName: "Jubiya",
      LastName: "Joseph",
      DateofBirth: '03/05/2000',
      Age: 23,
      JoiningDate: '03/06/2023',
      Country: "India"
    },{
      Id: 3,
      FirstName: "Ruby",
      LastName: "Susan",
      DateofBirth: '02/12/2000',
      Age: 23,
      JoiningDate: '30/06/2023',
      Country: "India"
    },{
      Id: 4,
      FirstName: "Narayana",
      LastName: "Menon",
      DateofBirth: '31/09/2000',
      Age: 23,
      JoiningDate: '03/06/2023',
      Country: "India"
    },{
      Id: 5,
      FirstName: "Christina",
      LastName: "Susan",
      DateofBirth: '23/01/2000',
      Age: 23,
      JoiningDate: '03/06/2023',
      Country: "India"
    }
    
  ]
  depdetail: Array<IdeptDetails> = []

  constructor() { }
}
