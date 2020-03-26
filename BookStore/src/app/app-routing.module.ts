import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {EditBookComponent} from './editbook.component';
import { ListBookComponent } from './listbook.component';
import { AddBookComponent } from './addbook.component';

const routes: Routes = [{
  path:'',component:ListBookComponent
},{
  path:'edit/:id',component:EditBookComponent
},{
    path:'add',component:AddBookComponent
}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
