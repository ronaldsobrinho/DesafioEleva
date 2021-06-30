import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { SchoolListComponent } from './school-list/school-list.component';
import { SchoolFormComponent } from './school-form/school-form.component';
import { AppRoutingModule } from './app-routing/app-routing.module';
import {  RouterModule } from '@angular/router';


@NgModule({
  declarations: [
    AppComponent,
    SchoolListComponent,
    SchoolFormComponent
  ],
  imports: [
    BrowserModule,FormsModule,HttpClientModule,AppRoutingModule,RouterModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
