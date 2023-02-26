import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { ComentsService } from '../../services/coments.service';
import { HomeComponent } from '../home/home.component';

@Component({
  selector: 'app-coments',
  templateUrl: './coments.component.html',
  styleUrls: ['./coments.component.css']
  
})
export class ComentsComponent implements OnInit{

  coments: any;
  comentsForm: any;
  postForm: any;
  resp2: any [] = [];
  resp3: any [] = [];
  
  @Input() posts : any;

  constructor(
    private comentsService: ComentsService,
    private homeComponent: HomeComponent,
    private fb: FormBuilder,
    ) { }

  ngOnInit(): void { 
    this.comentsForm = this.fb.group({
      author: "",
      content: "",
      createdAt: "",
      id:   "",
      status: "",
      title: "",
   });
   this.comentsForm.author = this.posts.author;
    this.comentsForm.content = this.posts.content;
    this.comentsForm.createdAt = this.posts.createdAt;
    this.comentsForm.id = this.posts.id;
    this.comentsForm.status = this.posts.status;
    this.comentsForm.title = this.posts.title;


   this.getComents();
  
  };

  public async getComents(){
    (await this.comentsService.getComents()).subscribe((resp: any) => {
      this.coments = resp;

      this.comentsForm = this.posts

      //console.log(this.comentsForm[0].id);
      //console.log(this.comentsForm);
      

     for (let i = 0; i < this.comentsForm.length; i++) {
      for(let j = 0; j < this.coments.length; j++)
      if(this.comentsForm[i].id === this.coments[j].id   ){

        this.resp2.push(this.coments[j]);
       }
     }

     this.coments = this.resp2;
     //console.log(this.resp2);

     for(let i = 0; i < this.resp2.length -1; i++) {
      if(this.resp2[i].id !== this.coments[i + 1].id   )
      this.resp3.push(this.coments[i]);
     }
     //console.log(this.resp3);


      //console.log(resp);
      
     });
    }

    
    
}
