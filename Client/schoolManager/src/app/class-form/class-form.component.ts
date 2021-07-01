import { ClassModel } from './../models/classModel';
import { Router } from '@angular/router';
import { ClassService } from './../services/class.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-class-form',
  templateUrl: './class-form.component.html',
  styleUrls: ['./class-form.component.scss']
})
export class ClassFormComponent implements OnInit {

  name: string;
  studentQuantity: number;

  constructor(private service: ClassService, private router: Router) {
    this.name = "";
    this.studentQuantity = 0

  }

  ngOnInit(): void {
  }

  save() {
    console.log(this.name);
    this.service.Create(
      this.createNewClassModel()
    ).subscribe(s => {
      alert('turma criada');
      this.router.navigateByUrl("/classes");

    })
  }

  createNewClassModel(): ClassModel {
    return { id: 0, name: this.name, studentQuantity: 0, schoolId: 0 };

  }

}


