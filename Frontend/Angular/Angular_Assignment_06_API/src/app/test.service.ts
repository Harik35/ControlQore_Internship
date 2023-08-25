import { Injectable } from '@angular/core';
import { IemployeeDetails } from './iemployee-details';
import { IdeptDetails } from './idept-details';
import { Istudent } from './istudent';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Istudentreturn } from './istudent-return';






@Injectable({
  providedIn: 'root'
})
export class TestService {

  constructor(private http: HttpClient) { }

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

  baseUrl: string = 'https://localhost:7104';

  addEmployee(stud: Istudent){
    return this.http.post(`${this.baseUrl}/api/Employee/AddEmployee`, stud);
  }
 
  getEmployee():Observable<Array<Istudentreturn>>{
    return this.http.get<Array<Istudentreturn>>(`${this.baseUrl}/api/Employee/Getalldata`);
  }

  deleteById(Id: number): Observable<any>{
    return this.http.delete(`${this.baseUrl}/api/Employee/deleteById?id=${Id}`)
   
  }
  getDataById(Id: Number):Observable<Istudentreturn> {
    return this.http.get<Istudentreturn>(`${this.baseUrl}/api/Employee/GetdatabyId?id=${Id}`)
  }

}
