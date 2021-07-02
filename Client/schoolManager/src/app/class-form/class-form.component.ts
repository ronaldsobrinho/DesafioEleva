import { ClassModel } from './../models/classModel';
import { ActivatedRoute } from '@angular/router';
import { ClassService } from './../services/class.service';
import { Component, EventEmitter, OnInit, Output } from '@angular/core';



@Component({
  selector: 'app-class-form',
  templateUrl: './class-form.component.html',
  styleUrls: ['./class-form.component.scss']
})


export class ClassFormComponent implements OnInit {

  @Output() onSave = new EventEmitter<number>();
  schoolId: number = 0;
  name: string = "";
  studentQuantity: number = 0;

  constructor(private service: ClassService, private activatedRoute: ActivatedRoute) {
  }
  ngOnInit(): void {
    this.activatedRoute.queryParamMap
      .subscribe((params) => {
        console.log(params);
        this.setParams(params);
      });
  }

  setParams(params: any) {
    let param = params.get("schoolId");
    //todo retornar um erro amigável se não conseguir ler este parâmetro;
    param = param != undefined ? parseInt(param) : 0;
    this.schoolId = param;
  }

  save() {
    let model = this.serialize();
    this.service.Create(model)
      .subscribe(s => {
        alert('Turma criada');
        this.onSave.emit(model.schoolId);
      }
        , error => {
          console.log(error);
          alert('Falha ao criar a turma');
        }
      )
  }

  serialize(): ClassModel {
    return { id: 0, name: this.name, studentQuantity: this.studentQuantity, schoolId: this.schoolId };
  }

}


