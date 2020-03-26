import { Component, OnInit } from '@angular/core';
import { NodeWithI18n } from '@angular/compiler';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  timeLeft:number=7200;
  clicked=false;
  interval;
 startDate:Date;
  display=false;
  code=false;
  document=false;
  stime;
  etime;
  sdtime;
  edtime;
 time:Date=new Date(); 
 endtime;
  ngOnInit(){

  }

  start(){
    this.clicked=true
    let endtime:Date=new Date(this.time.setHours(+3))
    console.log(endtime)
    this.display=true;

    this.interval=setInterval(() =>{
      if(this.timeLeft >0){
        this.timeLeft--;
      }
      else{
        this.end()
      }
    },1000) 
  }
  coding(){

    this.code=true
    this.document=false

      this.stime=this.timeLeft    
    
  }
  documentation(){
    
      this.sdtime=this.timeLeft
     
    
    
    this.document=true
    this.code=false

  }
startActivity(){
  


}
endActivity(name:string){
 if(name=="code"){
  this.etime=this.timeLeft
}
else{
  this.edtime=this.timeLeft
}
  console.log(this.timeLeft)
}
  end(){
    clearInterval(this.interval);
    this.display=false
    this.code=false
    this.document=false
    console.log(this.timeLeft)
  }
  reset(){
    location.reload();
  }
}
