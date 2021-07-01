import { ClassComponent } from './../class/class.component';
import { SchoolListComponent } from './../school-list/school-list.component';
import { SchoolFormComponent } from '../school-form/school-form.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClassFormComponent } from '../class-form/class-form.component';

export const routes: Routes = [
  { path: '', redirectTo: 'schools', pathMatch: 'full' },
  { path: 'schools', component: SchoolListComponent },
  { path: 'newSchool', component: SchoolFormComponent },
  { path: 'classes', component: ClassComponent },
  { path: 'newClass',   component: ClassFormComponent  }

];

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]
})
export class AppRoutingModule {


}
