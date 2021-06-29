import { schoolModel } from './../models/schoolModel';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class SchoolService {
  private url = "https://localhost:5001/school"  ;
  constructor(private httpClient : HttpClient ) { }

  Create(newSchoolName: string) : Observable<schoolModel> {
    var newSchool = this.newSchool(newSchoolName);
    this.GetAll();
    return this.httpClient.post<schoolModel>(this.url,newSchool);
  }

  private newSchool(newSchoolName: string): schoolModel{

      return { name : newSchoolName , totalClasses:0 };
  }

  GetAll() : Observable<schoolModel[]> {
    return this.httpClient.get<schoolModel[]>(this.url);
  }


}
