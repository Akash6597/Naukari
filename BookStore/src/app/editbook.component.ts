import {Component,OnInit} from '@angular/core';
import {Book} from "./book.model";
import { Router, ActivatedRoute,ParamMap } from '@angular/router';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
@Component({
    selector:'app-edit',
    templateUrl:"./editbook.component.html"
})
export class EditBookComponent implements OnInit{
editBookFormGroup:FormGroup;
    book=Book;
    id;
    index;
    constructor(private router:Router,private activatedRoute:ActivatedRoute,private formBuilder:FormBuilder){}

    ngOnInit(){
        this.id=this.activatedRoute.snapshot.paramMap.get("id");
        this.index=this.id-1;
        this.editBookFormGroup=this.formBuilder.group({
            id : [this.id,Validators.required],
            genre : [this.book[this.index].genre,Validators.required],
            author : [this.book[this.index].author,Validators.required],
            title : [this.book[this.index].title,Validators.required],
            price : [this.book[this.index].price,Validators.required],
            publisher : [this.book[this.index].publisher,Validators.required],
            quantity : [this.book[this.index].quantity,Validators.required]   
        });
        
    }
    editSubmit(){
        console.log(this.editBookFormGroup)
        let item = Book.filter(t => t.id == this.id)[0];
        this.book[this.index].genre = this.editBookFormGroup.controls.genre.value;
        this.book[this.index].author = this.editBookFormGroup.controls.author.value;
        this.book[this.index].title = this.editBookFormGroup.controls.title.value;
        this.book[this.index].price=this.editBookFormGroup.controls.price.value;
        this.book[this.index].publisher = this.editBookFormGroup.controls.publisher.value;
        this.book[this.index].quantity = this.editBookFormGroup.controls.quantity.value;

    
        this.router.navigateByUrl("/");
    }
}