
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ClassModel } from '../models/classModel';


@Injectable({
  providedIn: 'root'
})
export class ClassService {
  private url = "https://localhost:5001/class"  ;
  constructor(private httpClient : HttpClient ) { }

  Create(newClass: ClassModel) : Observable<ClassModel> {
    console.log(newClass);
    return this.httpClient.post<ClassModel>(this.url,newClass);
  }

  GetAll(schoolId : number): Observable<ClassModel[]> {
    return this.httpClient.get<ClassModel[]>(this.url + '/'+schoolId,);
  }
}
