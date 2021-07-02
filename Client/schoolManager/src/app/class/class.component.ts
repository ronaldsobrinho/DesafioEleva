import { ClassService } from './../services/class.service';
import { ClassModel } from './../models/classModel';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-class',
  templateUrl: './class.component.html',
  styleUrls: ['./class.component.scss']
})
export class ClassComponent implements OnInit {

  schoolId: number;
  schoolName: string;
  classes: ClassModel[]
  total: number;

  constructor(private service: ClassService, private router: ActivatedRoute) {
    this.schoolId = 0;
    this.schoolName = "";
    this.classes = [];
    this.total = 0;
  }

  ngOnInit(): void {

    this.router.queryParamMap
      .subscribe((params) => {
        console.log(params);
        this.setParams(params);
      });

    this.service.GetAll(this.schoolId).subscribe(obj =>
      this.setClasses(obj));
  };

  setParams(params: any) {
    //console.log(params);
    this.schoolId = params.get('schoolId');
    this.schoolName = params.get('schoolName');
  }

  setClasses(classList: ClassModel[]): void {
    this.classes = classList;
    this.total = this.classes.length;
  }

  listClasses(schoolId: number): void {
    this.service.GetAll(this.schoolId).subscribe(obj =>
      this.setClasses(obj));
  }
}







