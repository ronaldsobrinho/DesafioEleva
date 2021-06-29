import { schoolModel } from './../models/schoolModel';
import { Component, OnInit } from '@angular/core';
import { SchoolService } from '../services/school.service';

@Component({
  selector: 'app-school-list',
  templateUrl: './school-list.component.html',
  styleUrls: ['./school-list.component.scss']
})
export class SchoolListComponent implements OnInit {

  total : number;
  schools:schoolModel[];
  constructor(private service : SchoolService) {
    this.schools = [];
    this.total = this.schools.length;
  }

  ngOnInit(): void {
    this.service.GetAll().subscribe(s=> this.setSchools(s));
  }

  setSchools(schoolList:schoolModel[]):void{
      this.schools = schoolList;
      this.total = this.schools.length;
  }

}
