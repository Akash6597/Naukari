import {Component, OnInit} from '@angular/core';
import {FormGroup, FormBuilder, Validators} from '@angular/forms';
import {Book} from './book.model';
import { Router } from '@angular/router';
@Component({
    selector:'app-addbook',
    templateUrl:"./addbook.component.html"
})
export class AddBookComponent implements OnInit{
    book=Book;
    bookFormGroup:FormGroup;
    constructor(private formBuilder:FormBuilder,private router:Router){}
ngOnInit(){
    this.bookFormGroup=this.formBuilder.group({
        id : ['',Validators.required],
        genre : ['',Validators.required],
        author : ['',Validators.required],
        title : ['',Validators.required],
        price : ['',Validators.required],
        publisher : ['',Validators.required],
        quantity : ['',Validators.required]   
    })
}
add(){
    this.book.push(this.bookFormGroup.value);
    this.router.navigateByUrl('/');
}
}