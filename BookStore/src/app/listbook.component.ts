import {Component,OnInit} from '@angular/core';
import {Book} from './book.model';
import { Router } from '@angular/router';
@Component({
    selector:'app-list',
    templateUrl:'./listbook.component.html'
})
export class ListBookComponent implements OnInit{
    books=Book;
    constructor(private router:Router){

    }
    ngOnInit(){

    }
    delete(id:number){
        for(let j=0;j<this.books.length;j++){
          if(this.books[j].id==id){
            this.books.splice(j,1)
          }
        }
      }
}