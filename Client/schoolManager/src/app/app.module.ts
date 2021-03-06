import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { SchoolListComponent } from './school-list/school-list.component';
import { SchoolFormComponent } from './school-form/school-form.component';
import { AppRoutingModule } from './app-routing/app-routing.module';
import {  RouterModule } from '@angular/router';
import { ClassComponent } from './class/class.component';
import { ClassFormComponent } from './class-form/class-form.component';
import { CommonModule } from '@angular/common';

@NgModule({
  declarations: [
    AppComponent,
    SchoolListComponent,
    SchoolFormComponent,
    ClassComponent,
    ClassFormComponent
  ],
  imports: [
    BrowserModule,FormsModule,HttpClientModule,AppRoutingModule,RouterModule
    ,CommonModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
