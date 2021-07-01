import { ClassService } from './../services/class.service';
import { ClassModel } from './../models/classModel';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-class',
  templateUrl: './class.component.html',
  styleUrls: ['./class.component.scss']
})
export class ClassComponent implements OnInit {

  schoolName : string;
  classes : ClassModel[]
  total: number;
  //todo : receber de outro componente
  constructor(private service : ClassService) {
      this.schoolName = "TEste";
      this.classes = [];
      this.total = 0;
  }

  ngOnInit(): void {
      this.service.GetAll(0).subscribe(obj=>
          this.setClasses(obj));
      };

 setClasses(classList:ClassModel[]):void{
          this.classes = classList;
          this.total = this.classes.length;
}


}


