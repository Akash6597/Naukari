import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {ReactiveFormsModule} from '@angular/forms'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {ListBookComponent} from './listbook.component';
import {EditBookComponent} from "./editbook.component";
import {AddBookComponent} from './addbook.component';
import { from } from 'rxjs';
@NgModule({
  declarations: [
    AppComponent,EditBookComponent,ListBookComponent,AddBookComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
