import { SchoolService } from './../services/school.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-school-form',
  templateUrl: './school-form.component.html',
  styleUrls: ['./school-form.component.scss']
})
export class SchoolFormComponent implements OnInit {

   name? : string;

  constructor(private service : SchoolService , private router : Router) {
  }

  ngOnInit(): void {
  }

  Save():void{

    if (this.name != undefined) {
      this.service.Create(this.name).subscribe(c=> {
        alert('Escola criada');
        this.router.navigateByUrl("schools");
      }
      );
    }
  }

}
